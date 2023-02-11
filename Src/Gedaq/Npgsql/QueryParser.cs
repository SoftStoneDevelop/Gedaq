using Gedaq.Enums;
using Gedaq.Npgsql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

[assembly:InternalsVisibleTo("NpgsqlTests")]
namespace Gedaq.Npgsql
{
    internal class QueryParser
    {
        static readonly string[] _knownCommands = new string[] { "select", "insert", "delete" };

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

            return FillAliases(lastCommand.Substring(index));
        }

        private Aliases FillAliases(string query)
        {
            var root = new Aliases();
            var stateMachine = new FindAliasStateMachine(query);
            while(stateMachine.CanMoveNext())
            {
                var action = stateMachine.MoveNext();
                switch (action)
                {
                    case ActionAfterStep.None:
                    {
                        break;
                    }

                    case ActionAfterStep.AddField:
                    {
                        root.Fields.Add(new Field() { Name = stateMachine.GetAlias() });
                        break;
                    }

                    case ActionAfterStep.EndSearch:
                    {
                        return root;
                    }

                    case ActionAfterStep.EndSearchAndAddField:
                    {
                        root.Fields.Add(new Field() { Name = stateMachine.GetAlias() });
                        return root;
                    }
                }
            }

            return root;
        }

        //wrong expression
        public static Regex FindInstructionRegex = 
            new Regex(
                @"(?<=(^|\s))(select|delete|insert)(?=(.*|\s*)*;)",
                RegexOptions.IgnoreCase | RegexOptions.Compiled
                );

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

                    if (_knownCommands[currentPossibleCommand][indexInstruction] == char.ToLowerInvariant(command[indexInCommand]))
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

        private struct FindAliasStateMachine
        {
            private static readonly char[] _emptyOrCarret = new char[] { ' ', '\r', '\n' };
            private static readonly string _from = "from";

            private StringBuilder _field;
            private bool _getField;

            private string _query;
            private int currentIndex;

            private int _leftBrackets;

            /// <summary>
            /// -1 - start state
            /// -2 - end state
            /// 0 - skip until not letter
            /// 1 - skip until not right brackets
            /// 2 - expect start of alias
            /// 3 - expect end of alias
            /// 4 - expect: comma or FROM or END or Start of Alias
            /// </summary>
            private int _state;

            public FindAliasStateMachine(
                string query
                )
            {
                _field = new StringBuilder();
                _getField = false;
                currentIndex = -1;
                _leftBrackets = 0;
                _state = -1;
                _query = query;
            }

            public string GetAlias()
            {
                var result = _field.ToString();
                _getField = false;
                _field.Clear();

                return result;
            }

            public bool CanMoveNext()
            {
                if (_state == -2)
                {
                    return false;
                }

                return true;
            }


            public ActionAfterStep MoveNext()
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

                if (currentIndex == _query.Length - 1 && _state != 3)
                {
                    throw new Exception("Unexpected end of state machine");
                }

                switch (_state)
                {
                    case 0:
                    {
                        return SkipUntilNotLetter();
                    }

                    case 1:
                    {
                        return SkipUntilNotRightBrackets();
                    }

                    case 2:
                    {
                        return ExpectStartAlias();
                    }

                    case 3:
                    {
                        return ExpectEndAlias();
                    }

                    case 4:
                    {
                        return ExpectCommaOrFromOrEnd();
                    }

                    default:
                    {
                        throw new Exception("Unexpected state of state machine");
                    }
                }
            }

            private ActionAfterStep SkipUntilNotLetter()//0
            {
                if (char.IsLetter(_query[currentIndex]))
                {
                    _state = 3;
                    _field.Append(_query[currentIndex]);
                    return ActionAfterStep.None;
                }
                else if (_query[currentIndex] == '(')
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

            private ActionAfterStep SkipUntilNotRightBrackets()//1
            {
                if (_query[currentIndex] == ')')
                {
                    if (--_leftBrackets == 0)
                    {
                        _state = 2;
                    }

                    return ActionAfterStep.None;
                }

                return ActionAfterStep.None;
            }

            private ActionAfterStep ExpectStartAlias()//2
            {
                if (char.IsLetter(_query[currentIndex]))
                {
                    _state = 3;
                    _field.Append(_query[currentIndex]);

                    return ActionAfterStep.None;
                }

                if (_emptyOrCarret.Contains(_query[currentIndex]))
                {
                    return ActionAfterStep.None;
                }

                throw new Exception("Expect start of alias");
            }

            private ActionAfterStep ExpectEndAlias()//3
            {
                if (currentIndex == _query.Length - 1)
                {
                    _state = -2;
                    return ActionAfterStep.EndSearchAndAddField;
                }

                if (_query[currentIndex] == '.')
                {
                    _field.Clear();
                    return ActionAfterStep.None;
                }

                if (char.IsLetter(_query[currentIndex]) || (_field.Length > 0 && char.IsDigit(_query[currentIndex])))
                {
                    _field.Append(_query[currentIndex]);
                    return ActionAfterStep.None;
                }

                if (_field.Length == 2 && _query[currentIndex] == char.ToLowerInvariant(' ') && _field.ToString().ToLowerInvariant() == "as".ToLowerInvariant())
                {
                    _state = 2;
                    _field.Clear();

                    return ActionAfterStep.None;
                }

                if (_emptyOrCarret.Contains(_query[currentIndex]))
                {
                    _state = 4;
                    if (_field.Length == 4 && _field.ToString().ToLowerInvariant() == "FROM".ToLowerInvariant())
                    {
                        throw new Exception("'FROM' can't be alias");
                    }

                    _getField = true;

                    return ActionAfterStep.AddField;
                }

                if (_query[currentIndex] == ',')
                {
                    _state = 0;
                    _getField = true;

                    return ActionAfterStep.AddField;
                }

                throw new Exception("Expect start of alias: unknown behavior");
            }

            private ActionAfterStep ExpectCommaOrFromOrEnd()//4
            {
                if (currentIndex == _query.Length - 1)
                {
                    _state = -2;
                    return ActionAfterStep.EndSearch;
                }

                if (_field.Length == 0)
                {
                    if (_emptyOrCarret.Contains(_query[currentIndex]))
                    {
                        return ActionAfterStep.None;
                    }
                    else
                    if (_query[currentIndex] == ',')
                    {
                        _state = 0;
                        return ActionAfterStep.None;
                    }
                }

                if (_field.Length < 4 && _emptyOrCarret.Contains(_query[currentIndex]))
                {
                    throw new Exception($"Expect {nameof(ExpectCommaOrFromOrEnd)} but field equal '{_field.ToString()}'");
                }

                if (_field.Length < 4)
                {
                    _field.Append(_query[currentIndex]);
                    return ActionAfterStep.None;
                }

                if (_field.Length == 4 && _emptyOrCarret.Contains(_query[currentIndex]) && _field.ToString().ToLowerInvariant() == "FROM".ToLowerInvariant())
                {
                    _state = -2;
                    return ActionAfterStep.EndSearch;
                }

                throw new Exception($"Expect {nameof(ExpectCommaOrFromOrEnd)}");
            }
        }
    }
}
