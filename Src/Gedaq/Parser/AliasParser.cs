using Gedaq.Base.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gedaq.Parser
{
    internal ref struct AliasParser
    {
        internal static readonly char[] EmptyOrCarret = new char[] { ' ', '\r', '\n' };
        private static readonly string _from = "from";
        private static readonly string _as = "as";
        private static readonly string _startInner = "~startinner::";
        private static readonly string _endInner = "~endinner::";

        private static readonly string _reinterpret = "~reinterpret::";
        private StringBuilder _reinterpretName;

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
            _reinterpretName = new StringBuilder();
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
                if (Skip(in EmptyOrCarret))
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
                    Skip(in EmptyOrCarret);
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
                    if (IsReinterpret())
                    {
                        _lastPartIndex = _currentIndex;
                        continue;
                    }

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

                if (_reinterpretName.Length != 0)
                {
                    fieldName = _reinterpretName.ToString();
                    _reinterpretName.Clear();
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
            var isNullCheck = false;
            name = null;
            for (; _currentIndex < _query.Length; _currentIndex++)
            {
                if (char.IsLetterOrDigit(_query[_currentIndex]))
                {
                    if (notAllowedcolon && isNullCheck)
                    {
                        throw new Exception("After '?' can be only '~'");
                    }

                    _field.Append(_query[_currentIndex]);
                    continue;
                }
                else if (_query[_currentIndex] == '?')
                {
                    isNullCheck = true;
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
                throw new Exception("The inner name cannot be empty");
            }

            if (!nameClosed)
            {
                throw new Exception("Inner name must end on '~'");
            }

            if (!isNullCheck)
            {
                if (_field.Length == 0)
                {
                    throw new Exception("LinkKey not found");
                }

                linkKey = _field.ToString();
                _field.Clear();
            }
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

        private bool IsReinterpret()
        {
            var index = 0;
            if (_reinterpretName.Length != 0)
            {
                throw new Exception(@"Double reinterpret");
            }

            for (int i = _currentIndex; i < _query.Length; i++)
            {
                if (index < _reinterpret.Length)
                {
                    if (char.ToLowerInvariant(_query[i]) != _reinterpret[index])
                    {
                        return false;
                    }

                    index++;
                    continue;
                }

                if (!char.IsLetterOrDigit(_query[i]))
                {
                    if (_query[i] == '~')
                    {
                        if (_reinterpretName.Length == 0)
                        {
                            throw new Exception(@"Reinterpret name cannot be empty or contain not letter or digital");
                        }

                        _currentIndex += index + 1;
                        return true;
                    }

                    throw new NotSupportedException("Reinterpret name support only letter/digital characters");
                }
                else
                {
                    _reinterpretName.Append(_query[i]);
                }

                index++;
            }

            return true;
        }

        private string GetNameAlias(bool allowedDot = true)
        {
            var notAllowedAs = false;
            var dotPass = false;

            if (IsAsOrAlias())
            {
                Skip(in EmptyOrCarret);
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
                    if (Skip(in EmptyOrCarret))
                    {
                        break;
                    }

                    if (_query[_currentIndex] == '~')
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
                        Skip(in EmptyOrCarret);
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
                        Skip(in EmptyOrCarret);
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

                if (EmptyOrCarret.Contains(_query[i]))
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

                if (EmptyOrCarret.Contains(_query[i]))
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