using Gedaq.Base.Model;
using Gedaq.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

[assembly: InternalsVisibleTo("DbConnectionTests")]
namespace Gedaq.Base
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
            if (newQuery != null)
            {
                query = querySpan.Slice(0, lastCommandIndex + index).ToString() + newQuery;
            }

            return aliases;
        }

        public Aliases GetIntResultAlias()
        {
            return new Aliases(true);
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

            if (query[i] == splitter)
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
            if (parser.QueryIsNew())
            {
                newQuery = parser.GetNewQuery();
            }

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
            private static readonly string _startInner = "~startinner::";
            private static readonly string _endInner = "~endinner::";

            private Aliases _root;

            private StringBuilder _field;
            private int _fieldPosition;

            private ReadOnlySpan<char> _query;
            private int _currentIndex;
            private int _lastPartIndex;

            private bool _containInner;
            private StringBuilder _resultQuery;

            private int _leftBrackets;

            public AliasParser(
                ReadOnlySpan<char> query
                )
            {
                _field = new StringBuilder();
                _currentIndex = 0;
                _lastPartIndex = 0;
                _leftBrackets = 0;
                _fieldPosition = -1;
                _query = query;
                _root = null;
                _containInner = false;
                _resultQuery = new StringBuilder();
            }

            public Aliases GetAliases()
            {
                return _root;
            }

            public bool QueryIsNew()
            {
                return _resultQuery.Length != 0;
            }

            public string GetNewQuery()
            {
                return _resultQuery.ToString();
            }

            public void Parse()
            {
                if (_root != null)
                {
                    return;
                }

                _root = new Aliases();
                var innerStack = new Stack<Aliases>();
                innerStack.Push(_root);
                while (_currentIndex < _query.Length)
                {
                    if (Skip(in _emptyOrCarret))
                    {
                        break;
                    }

                    if (IsFrom() || _query[_currentIndex] == ';')
                    {
                        break;
                    }

                    if (_query[_currentIndex] == '(')
                    {
                        SkipBracketGroup();
                        Skip(in _emptyOrCarret);
                        var name = GetNameAlias(false);
                        if (string.IsNullOrWhiteSpace(name))
                        {
                            throw new Exception("After group must be AliasName");
                        }

                        var lastAlias = innerStack.Peek();
                        lastAlias.Fields.Add(new Field { Name = name, Position = _fieldPosition });
                        continue;
                    }

                    if (_query[_currentIndex] == '~')
                    {
                        _containInner |= true;
                        AppendPartQuery(_lastPartIndex, _currentIndex - _lastPartIndex);
                        if (IsStartInner())
                        {
                            GetStartInnerName(out var innerName, out var linkName);
                            _lastPartIndex = _currentIndex;
                            var innerAlias = new Aliases(innerName, linkName);
                            innerStack.Push(innerAlias);
                            continue;
                        }

                        if (IsEndInner())
                        {
                            var innerName = GetEndInnerName();
                            _lastPartIndex = _currentIndex;
                            if (innerStack.Count < 1 || innerStack.Peek() == _root)
                            {
                                throw new Exception("'EndInner' closing statement without opening statement.");
                            }

                            var endedAlias = innerStack.Pop();
                            if (endedAlias.EntityName != innerName)
                            {
                                throw new Exception("The names of the open and close operators do not match.");
                            }

                            var lastAlias = innerStack.Peek();
                            lastAlias.InnerEntities.Add(endedAlias);

                            continue;
                        }


                        throw new Exception("Unknown Inner operator");
                    }

                    var fieldName = GetNameAlias();
                    if (string.IsNullOrWhiteSpace(fieldName))
                    {
                        throw new Exception("Not found Alias");
                    }

                    var alias = innerStack.Peek();
                    alias.Fields.Add(new Field { Name = fieldName, Position = _fieldPosition });
                }

                if (innerStack.Count != 1 || innerStack.Peek() != _root)
                {
                    throw new Exception($"There are non-closed operators in the query: {StackToList(innerStack)}");
                }

                AppendPartQuery(_lastPartIndex, _query.Length - _lastPartIndex);
            }

            private void AppendPartQuery(int start, int length)
            {
                if (!_containInner)
                {
                    return;
                }

                if (_lastPartIndex >= _query.Length)
                {
                    return;
                }

                _resultQuery.Append(_query.Slice(start, length).ToString());
                var s = _resultQuery.ToString();
                _lastPartIndex = start + length;
            }

            private string StackToList(Stack<Aliases> stack)
            {
                var builder = new StringBuilder();
                while (stack.Count != 0)
                {
                    builder.Append("'");
                    var alias = stack.Pop();
                    if (alias.IsRoot)
                    {
                        builder.Append("Root");
                    }
                    else
                    {
                        builder.Append(alias.EntityName);
                    }
                    builder.Append("'");
                    if (stack.Count != 0)
                    {
                        builder.Append(',');
                    }
                }

                return builder.ToString();
            }

            private void GetStartInnerName(out string name, out string linkKey)
            {
                linkKey = null;
                var nameClosed = false;
                var notAllowedcolon = false;
                name = null;
                for (; _currentIndex < _query.Length; _currentIndex++)
                {
                    if (char.IsLetterOrDigit(_query[_currentIndex]))
                    {
                        _field.Append(_query[_currentIndex]);
                        continue;
                    }
                    else if (_query[_currentIndex] == ':')
                    {
                        if (notAllowedcolon)
                        {
                            throw new Exception("LinkKey separator repeated");
                        }

                        name = _field.ToString();
                        _field.Clear();
                        notAllowedcolon = true;
                    }
                    else
                    {
                        if (_query[_currentIndex] != '~')
                        {
                            throw new Exception("Inner name must end on '~'");
                        }

                        _currentIndex++;
                        nameClosed = true;
                        break;
                    }
                }

                if (name == null)
                {
                    throw new Exception("LinkKey not found");
                }

                if (!nameClosed)
                {
                    throw new Exception("Inner name must end on '~'");
                }

                if (_field.Length == 0)
                {
                    throw new Exception("The inner name cannot be empty.");
                }

                linkKey = _field.ToString();
                _field.Clear();
            }

            private string GetEndInnerName()
            {
                var nameClosed = false;
                for (; _currentIndex < _query.Length; _currentIndex++)
                {
                    if (char.IsLetterOrDigit(_query[_currentIndex]))
                    {
                        _field.Append(_query[_currentIndex]);
                        continue;
                    }
                    else
                    {
                        if (_query[_currentIndex] != '~')
                        {
                            throw new Exception("Inner name must end on '~'");
                        }

                        _currentIndex++;
                        nameClosed = true;
                        break;
                    }
                }

                if (!nameClosed)
                {
                    throw new Exception("Inner name must end on '~'");
                }

                if (_field.Length == 0)
                {
                    throw new Exception("The inner name cannot be empty.");
                }

                var name = _field.ToString();
                _field.Clear();
                return name;
            }

            private bool IsStartInner()
            {
                var index = 0;
                for (int i = _currentIndex; i < _query.Length; i++)
                {
                    if (index < _startInner.Length)
                    {
                        if (char.ToLowerInvariant(_query[i]) != _startInner[index])
                        {
                            return false;
                        }

                        index++;
                        continue;
                    }

                    if (!char.IsLetter(_query[i]))
                    {
                        throw new Exception(@"After '~StartInner::' must be letter");
                    }
                    else
                    {
                        _currentIndex += index;
                        return true;
                    }
                }

                return false;
            }

            private bool IsEndInner()
            {
                var index = 0;
                for (int i = _currentIndex; i < _query.Length; i++)
                {
                    if (index < _endInner.Length)
                    {
                        if (char.ToLowerInvariant(_query[i]) != _endInner[index])
                        {
                            return false;
                        }

                        index++;
                        continue;
                    }

                    if (!char.IsLetter(_query[i]))
                    {
                        throw new Exception(@"After '~EndInner::' must be letter");
                    }
                    else
                    {
                        _currentIndex += index;
                        return true;
                    }
                }

                return false;
            }

            private string GetNameAlias(bool allowedDot = true)
            {
                var notAllowedAs = false;
                var dotPass = false;

                if (IsAsOrAlias())
                {
                    Skip(in _emptyOrCarret);
                    notAllowedAs = true;
                }

                for (; _currentIndex < _query.Length; _currentIndex++)
                {
                    if (char.IsLetterOrDigit(_query[_currentIndex]))
                    {
                        _field.Append(_query[_currentIndex]);
                        continue;
                    }
                    else
                    {
                        if (Skip(in _emptyOrCarret))
                        {
                            break;
                        }

                        if (_query[_currentIndex] == '.')
                        {
                            if (dotPass)
                            {
                                throw new Exception("Double dot in Alias");
                            }

                            if (!allowedDot)
                            {
                                throw new Exception("Dot in name is not allowed");
                            }

                            dotPass = true;
                            _field.Clear();
                            Skip(in _emptyOrCarret);
                            continue;
                        }

                        if (_query[_currentIndex] == ',')
                        {
                            _currentIndex++;
                            break;
                        }

                        if (IsAsOrAlias())
                        {
                            if (notAllowedAs)
                            {
                                throw new Exception("Double 'AS' key");
                            }

                            _field.Clear();
                            Skip(in _emptyOrCarret);
                            _field.Append(_query[_currentIndex]);
                            notAllowedAs = true;
                            continue;
                        }

                        if (IsFrom())
                        {
                            break;
                        }
                    }
                }

                if (_field.Length > 0)
                {
                    _fieldPosition++;
                    var name = _field.ToString();
                    _field.Clear();

                    return name;
                }

                return null;
            }

            private bool IsAsOrAlias()
            {
                var index = 0;
                for (int i = _currentIndex; i < _query.Length; i++)
                {
                    if (index > 2)
                    {
                        break;
                    }

                    if (index < 2)
                    {
                        if (char.ToLowerInvariant(_query[i]) != _as[index])
                        {
                            return false;
                        }

                        index++;
                        continue;
                    }

                    if (_emptyOrCarret.Contains(_query[i]))
                    {
                        _currentIndex += 3;
                        return true;
                    }

                    index++;
                }

                if (!IsFrom() && _query[_currentIndex] != ',')
                {
                    return true;
                }

                return false;
            }

            private bool IsFrom()
            {
                var index = 0;
                for (int i = _currentIndex; i < _query.Length; i++)
                {
                    if (index > 4)
                    {
                        return false;
                    }

                    if (index < 4)
                    {
                        if (char.ToLowerInvariant(_query[i]) != _from[index])
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
                for (; _currentIndex < _query.Length; _currentIndex++)
                {
                    if (!chars.Contains(_query[_currentIndex]))
                    {
                        return false;
                    }
                }

                return true;
            }

            private void SkipBracketGroup()
            {
                for (; _currentIndex < _query.Length; _currentIndex++)
                {
                    if (_query[_currentIndex] == '(')
                    {
                        _leftBrackets++;
                        continue;
                    }

                    if (_query[_currentIndex] == ')')
                    {
                        _leftBrackets--;
                    }

                    if (_leftBrackets == 0)
                    {
                        _currentIndex++;
                        break;
                    }
                }
            }
        }
    }
}