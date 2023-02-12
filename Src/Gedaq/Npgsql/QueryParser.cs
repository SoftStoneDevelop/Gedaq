using Gedaq.Enums;
using Gedaq.Npgsql.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

[assembly:InternalsVisibleTo("NpgsqlTests")]
namespace Gedaq.Npgsql
{
    internal class QueryParser
    {
        static readonly string[] _knownCommands = new string[] { "select", "insert", "delete" };

        public Aliases Parse(ref string query)
        {
            var querySpan = query.AsSpan();
            var lastCommandIndex = GetLastSplitedItem(querySpan, ';');
            var lastCommand = querySpan.Slice(lastCommandIndex);
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

            var aliases = FillAliases(lastCommand.Slice(index), out var newQuery);
            if(newQuery != null)
            {
                query = querySpan.Slice(0, lastCommandIndex + index + 1).ToString() + newQuery;
            }

            return aliases;
        }

        internal int GetLastSplitedItem(ReadOnlySpan<char> query, char splitter)
        {
            int i = query.Length - 1;
            for (; i >= 0; i--)
            {
                if (query[i] != '\r' && query[i] != '\n' && query[i] != ' ')
                {
                    break;
                }
            }

            if(query[i] == splitter)
            {
                i--;
            }

            for (; i >= 0; i--)
            {
                if (query[i] == splitter)
                {
                    return i + 1;
                }
            }

            return 0;
        }

        private Aliases FillAliases(ReadOnlySpan<char> query, out string newQuery)
        {
            newQuery = null;
            var parser = new AliasParser(query);
            parser.Parse();

            return
                parser.GetAliases();
        }

        private bool FindInstruction(ReadOnlySpan<char> command, out int indexAfterInstruction, out InstructionType instruction)
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

        private ref struct AliasParser
        {
            private static readonly char[] _emptyOrCarret = new char[] { ' ', '\r', '\n' };
            private static readonly string _from = "from";
            private static readonly string _as = "as";

            private StringBuilder _field;
            private int _fieldPosition;
            private ReadOnlySpan<char> _query;
            private int currentIndex;
            private Aliases _root;
            private int _leftBrackets;

            public AliasParser(
                ReadOnlySpan<char> query
                )
            {
                _field = new StringBuilder();
                currentIndex = 0;
                _leftBrackets = 0;
                _fieldPosition = -1;
                _query = query;
                _root = null;
            }

            public Aliases GetAliases()
            {
                return _root;
            }

            public void Parse()
            {
                if(_root != null)
                {
                    return;
                }

                _root = new Aliases();
                while (currentIndex < _query.Length)
                {
                    if (Skip(in _emptyOrCarret))
                    {
                        return;
                    }

                    if(IsFrom() || _query[currentIndex] == ';')
                    {
                        return;
                    }

                    if (_query[currentIndex] == '(')
                    {
                        SkipBracketGroup();
                        Skip(in _emptyOrCarret);
                        var name = GetNameAlias(false);
                        if(string.IsNullOrWhiteSpace(name))
                        {
                            throw new Exception("After group must be AliasName");
                        }

                        _root.Fields.Add(new Field { Name = name, Position = _fieldPosition });
                        continue;
                    }

                    var fieldName = GetNameAlias();
                    if (string.IsNullOrWhiteSpace(fieldName))
                    {
                        throw new Exception("Not found Alias");
                    }

                    _root.Fields.Add(new Field { Name = fieldName, Position = _fieldPosition });
                }
            }

            private string GetNameAlias(bool allowedDot = true)
            {
                var notAllowedAs = false;
                var dotPass = false;

                if (IsAs())
                {
                    Skip(in _emptyOrCarret);
                    notAllowedAs = true;
                }

                for (; currentIndex < _query.Length; currentIndex++)
                {
                    if (char.IsLetterOrDigit(_query[currentIndex]))
                    {
                        _field.Append(_query[currentIndex]);
                        continue;
                    }
                    else
                    {
                        if(Skip(in _emptyOrCarret))
                        {
                            break;
                        }

                        if(_query[currentIndex] == '.')
                        {
                            if(dotPass)
                            {
                                throw new Exception("Double dot in Alias");
                            }

                            if(!allowedDot)
                            {
                                throw new Exception("Dot in name is not allowed");
                            }

                            dotPass = true;
                            _field.Clear();
                            Skip(in _emptyOrCarret);
                            continue;
                        }

                        if(_query[currentIndex] == ',')
                        {
                            currentIndex++;
                            break;
                        }

                        if(IsAs())
                        {
                            if(notAllowedAs)
                            {
                                throw new Exception("Double 'AS' key");
                            }

                            _field.Clear();
                            Skip(in _emptyOrCarret);
                            notAllowedAs = true;
                            continue;
                        }

                        if(IsFrom())
                        {
                            break;
                        }
                    }
                }

                if(_field.Length > 0)
                {
                    _fieldPosition++;
                    var name = _field.ToString();
                    _field.Clear();

                    return name;
                }

                return null;
            }

            private bool IsAs()
            {
                var index = 0;
                for (int i = currentIndex; i < _query.Length; i++)
                {
                    if(index > 2)
                    {
                        return false;
                    }

                    if (index < 2)
                    {
                        if(char.ToLowerInvariant(_query[i]) != _as[index])
                        {
                            return false;
                        }

                        index++;
                        continue;
                    }

                    if (_emptyOrCarret.Contains(_query[i]))
                    {
                        currentIndex += 3;
                        return true;
                    }

                    index++;
                }

                return false;
            }

            private bool IsFrom()
            {
                var index = 0;
                for (int i = currentIndex; i < _query.Length; i++)
                {
                    if (index > 4)
                    {
                        return false;
                    }

                    if (index < 4)
                    {
                        if(char.ToLowerInvariant(_query[i]) != _from[index])
                        {
                            return false;
                        }

                        index++;
                        continue;
                    }

                    if (_emptyOrCarret.Contains(_query[i]))
                    {
                        return true;
                    }

                    index++;
                }

                return false;
            }

            private bool Skip(in char[] chars)
            {
                for (; currentIndex < _query.Length; currentIndex++)
                {
                    if(!chars.Contains(_query[currentIndex]))
                    {
                        return false;
                    }
                }

                return true;
            }

            private void SkipBracketGroup()
            {
                for (; currentIndex < _query.Length; currentIndex++)
                {
                    if (_query[currentIndex] == '(')
                    {
                        _leftBrackets++;
                        continue;
                    }

                    if(_query[currentIndex] == ')')
                    {
                        _leftBrackets--;
                    }

                    if(_leftBrackets == 0)
                    {
                        currentIndex++;
                        break;
                    }
                }
            }
        }
    }
}