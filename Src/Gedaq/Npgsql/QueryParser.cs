using Gedaq.Enums;
using Gedaq.Npgsql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gedaq.Npgsql
{
    internal class QueryParser
    {
        static readonly string[] _knownCommands = new string[] { "SELECT", "INSERT", "DELETE" };

        public Aliases Parse(string query)
        {
            var commands = query.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            if (commands.Length == 0)
            {
                throw new Exception("The query does not contain commands.");
            }

            var lastCommand = commands[commands.Length - 1];
            if (!FindInstruction(lastCommand, out var index, out var instructionType))
            {
                throw new Exception("Instruction in query not found");
            }

            if (index == lastCommand.Length)
            {
                throw new Exception("The instruction is followed by no parameters.");
            }

            if (instructionType == InstructionType.Delete || instructionType == InstructionType.Insert)
            {
                return new Aliases(true);
            }

            var result = new Aliases();
            FillAliases(result, lastCommand.Substring(index));
            result.FieldNames.TrimExcess();

            return result;
        }

        private void FillAliases(Aliases result, string query)
        {
            var stateMachine = new FindAliasStateMachine(query.Length);
            foreach (var character in query)
            {
                var action = stateMachine.MoveNext(in character);
                switch (action)
                {
                    case ActionAfterStep.None:
                    {
                        break;
                    }

                    case ActionAfterStep.AddField:
                    {
                        result.FieldNames.Add(stateMachine.GetAlias());
                        break;
                    }

                    case ActionAfterStep.EndSearch:
                    {
                        goto endSearch;
                    }

                    case ActionAfterStep.EndSearchAndAddField:
                    {
                        result.FieldNames.Add(stateMachine.GetAlias());
                        goto endSearch;
                    }
                }
            }

        endSearch:
            return;
        }

        private bool FindInstruction(string command, out int indexAfterInstruction, out InstructionType instruction)
        {
            indexAfterInstruction = -1;
            instruction = InstructionType.None;
            var currentPossibleCommand = 0;
            var indexInstruction = 0;
            var indexInCommand = 0;

            var emptySequence = true;
            for (; indexInCommand < command.Length; indexInCommand++)
            {
                if (emptySequence)
                {
                    if (command[indexInCommand] == '\r' || command[indexInCommand] == '\n' || command[indexInCommand] == ' ')
                    {
                        continue;
                    }

                    emptySequence = false;
                }

                var cChar = command[indexInCommand];

                if (command[indexInCommand] == '\r' || command[indexInCommand] == '\n' || command[indexInCommand] == ' ')
                {
                    if (currentPossibleCommand >= _knownCommands.Length)
                    {
                        return false;
                    }

                    break;
                }

                for (; currentPossibleCommand < _knownCommands.Length; currentPossibleCommand++)
                {
                    if (_knownCommands[currentPossibleCommand].Length <= indexInstruction)
                    {
                        continue;
                    }

                    if (char.ToLowerInvariant(_knownCommands[currentPossibleCommand][indexInstruction]) == char.ToLowerInvariant(command[indexInCommand]))
                    {
                        indexInstruction++;
                        break;
                    }
                }
            }

            if (_knownCommands[currentPossibleCommand].Length == indexInstruction)
            {
                indexAfterInstruction = indexInCommand;
                instruction = IndexToType(currentPossibleCommand);
                return true;
            }

            return false;
        }

        private InstructionType IndexToType(int index)
        {
            switch (index)
            {
                case 0:
                {
                    return InstructionType.Select;
                }

                case 1:
                {
                    return InstructionType.Insert;
                }

                case 2:
                {
                    return InstructionType.Delete;
                }

                default:
                {
                    return InstructionType.None;
                }
            }
        }

        private enum ActionAfterStep
        {
            None = 0,
            AddField = 1,
            EndSearch = 2,
            EndSearchAndAddField = 3
        }

        private class FindAliasStateMachine
        {
            private static readonly char[] _emptyOrCarret = new char[] { ' ', '\r', '\n' };
            private StringBuilder _field = new StringBuilder();
            private bool _getField = false;

            private int lastIndex;
            private int currentIndex = -1;
            private int _leftBrackets = 0;

            /// <summary>
            /// -1 - start state
            /// -2 - end state
            /// 0 - skip until not letter
            /// 1 - skip until not right brackets
            /// 2 - expect start of alias
            /// 3 - expect end of alias
            /// 4 - expect: comma or FROM or END or Start of Alias
            /// </summary>
            private int _state = -1;

            public FindAliasStateMachine(
                int queryLength
                )
            {
                lastIndex = queryLength - 1;
            }

            public string GetAlias()
            {
                var result = _field.ToString();
                _getField = false;
                _field.Clear();

                return result;
            }


            public ActionAfterStep MoveNext(in char character)
            {
                if (_getField)
                {
                    throw new Exception("Alias alias not added");
                }

                if (_state == -2)
                {
                    throw new Exception("State machine expired");
                }

                currentIndex++;

                if (_state == -1)
                {
                    _state = 0;
                }

                if (currentIndex == lastIndex && _state != 3)
                {
                    throw new Exception("Unexpected end of state machine");
                }

                switch (_state)
                {
                    case 0:
                    {
                        return SkipUntilNotLetter(in character);
                    }

                    case 1:
                    {
                        return SkipUntilNotRightBrackets(in character);
                    }

                    case 2:
                    {
                        return ExpectStartAlias(in character);
                    }

                    case 3:
                    {
                        return ExpectEndAlias(in character);
                    }

                    case 4:
                    {
                        return ExpectCommaOrFromOrEnd(in character);
                    }

                    default:
                    {
                        throw new Exception("Unexpected state of state machine");
                    }
                }
            }

            private ActionAfterStep SkipUntilNotLetter(in char character)//0
            {
                if (char.IsLetter(character))
                {
                    _state = 3;
                    _field.Append(character);
                    return ActionAfterStep.None;
                }
                else if (character == '(')
                {
                    _leftBrackets++;
                    _state = 1;
                    _field.Clear();
                    return ActionAfterStep.None;
                }
                else
                {
                    return ActionAfterStep.None;
                }
            }

            private ActionAfterStep SkipUntilNotRightBrackets(in char character)//1
            {
                if (character == ')')
                {
                    if (--_leftBrackets == 0)
                    {
                        _state = 2;
                    }

                    return ActionAfterStep.None;
                }

                return ActionAfterStep.None;
            }

            private ActionAfterStep ExpectStartAlias(in char character)//2
            {
                if (char.IsLetter(character))
                {
                    _state = 3;
                    _field.Append(character);

                    return ActionAfterStep.None;
                }

                if (_emptyOrCarret.Contains(character))
                {
                    return ActionAfterStep.None;
                }

                throw new Exception("Expect start of alias");
            }

            private ActionAfterStep ExpectEndAlias(in char character)//3
            {
                if (currentIndex == lastIndex)
                {
                    _state = -2;
                    return ActionAfterStep.EndSearchAndAddField;
                }

                if (character == '.')
                {
                    _field.Clear();
                    return ActionAfterStep.None;
                }

                if (char.IsLetter(character) || (_field.Length > 0 && char.IsDigit(character)))
                {
                    _field.Append(character);
                    return ActionAfterStep.None;
                }

                if (_field.Length == 2 && character == char.ToLowerInvariant(' ') && _field.ToString().ToLowerInvariant() == "as".ToLowerInvariant())
                {
                    _state = 2;
                    _field.Clear();

                    return ActionAfterStep.None;
                }

                if (_emptyOrCarret.Contains(character))
                {
                    _state = 4;
                    if (_field.Length == 4 && _field.ToString().ToLowerInvariant() == "FROM".ToLowerInvariant())
                    {
                        throw new Exception("'FROM' can't be alias");
                    }

                    _getField = true;

                    return ActionAfterStep.AddField;
                }

                if (character == ',')
                {
                    _state = 0;
                    _getField = true;

                    return ActionAfterStep.AddField;
                }

                throw new Exception("Expect start of alias: unknown behavior");
            }

            private ActionAfterStep ExpectCommaOrFromOrEnd(in char character)//4
            {
                if (currentIndex == lastIndex)
                {
                    _state = -2;
                    return ActionAfterStep.EndSearch;
                }

                if (_field.Length == 0)
                {
                    if (_emptyOrCarret.Contains(character))
                    {
                        return ActionAfterStep.None;
                    }
                    else
                    if (character == ',')
                    {
                        _state = 0;
                        return ActionAfterStep.None;
                    }
                }

                if (_field.Length < 4 && _emptyOrCarret.Contains(character))
                {
                    throw new Exception($"Expect {nameof(ExpectCommaOrFromOrEnd)} but field equal '{_field.ToString()}'");
                }

                if (_field.Length < 4)
                {
                    _field.Append(character);
                    return ActionAfterStep.None;
                }

                if (_field.Length == 4 && _emptyOrCarret.Contains(character) && _field.ToString().ToLowerInvariant() == "FROM".ToLowerInvariant())
                {
                    _state = -2;
                    return ActionAfterStep.EndSearch;
                }

                throw new Exception($"Expect {nameof(ExpectCommaOrFromOrEnd)}");
            }
        }
    }
}
