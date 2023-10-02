using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Data;

namespace Gedaq.Base.Model
{
    internal abstract class BaseParametr
    {
        public string NameInCommand;
        public bool HaveNameInCommand => NameInCommand != null;

        public string NameInMethod;
        public bool HaveNameInMethod => NameInMethod != null;

        public ITypeSymbol Type;

        public int Size;
        public bool HaveSize => Size != -1;

        public int Scale;
        public bool HaveScale => Scale != 0;

        public int Precision;
        public bool HavePrecision => Precision != 0;

        public bool Nullable;

        public ParameterDirection Direction;
        public bool HaveDirection => Direction != ParameterDirection.Input;

        public string SourceColumn;
        public bool HaveSourceColumn => SourceColumn != "";

        public bool SourceColumnNullMapping;
        public bool HaveSourceColumnNullMapping => SourceColumnNullMapping;

        public DataRowVersion SourceVersion;
        public bool HaveSourceVersion => SourceVersion != DataRowVersion.Current;

        public abstract string VariableName(string postfix = default);

        public static string VariablePostfix(ParameterDirection direction)
        {
            switch (direction)
            {
                case ParameterDirection.Input:
                    {
                        return string.Empty;
                    }

                case ParameterDirection.InputOutput:
                case ParameterDirection.Output:
                    {
                        return "Out";
                    }

                case ParameterDirection.ReturnValue:
                    {
                        return "Return";
                    }

                default:
                    {
                        throw new NotImplementedException();
                    }
            }
        }

        protected static bool SetType(TypedConstant argument, BaseParametr parametr)
        {
            if (!(argument.Value is ITypeSymbol typeParam))
            {
                return false;
            }

            parametr.Type = typeParam;
            return true;
        }

        protected static bool SetNameInCommand(TypedConstant argument, BaseParametr parametr)
        {
            if (!(argument.Type is INamedTypeSymbol paramName) ||
                paramName.Name != nameof(String)
                )
            {
                return false;
            }

            parametr.NameInCommand = (string)argument.Value;
            return true;
        }

        protected static bool SetNameInMethod(TypedConstant argument, BaseParametr parametr)
        {
            if (!(argument.Type is INamedTypeSymbol paramName) ||
                paramName.Name != nameof(String)
                )
            {
                return false;
            }

            parametr.NameInMethod = (string)argument.Value;
            return true;
        }

        protected static bool SetSize(TypedConstant argument, BaseParametr parametr)
        {
            if (!(argument.Type is INamedTypeSymbol sizeParam) ||
                sizeParam.Name != nameof(Int32)
                )
            {
                return false;
            }

            parametr.Size = (int)argument.Value;
            return true;
        }

        protected static bool SetNullable(TypedConstant argument, BaseParametr parametr)
        {
            if (!(argument.Type is INamedTypeSymbol nullableParam) ||
                nullableParam.Name != nameof(Boolean)
                )
            {
                return false;
            }

            parametr.Nullable = (bool)argument.Value;
            return true;
        }

        protected static bool SetDirection(TypedConstant argument, BaseParametr parametr)
        {
            if (argument.Kind != TypedConstantKind.Enum ||
                !(argument.Type is INamedTypeSymbol directionParam) ||
                !directionParam.IsAssignableFrom("System.Data", "ParameterDirection")
                )
            {
                return false;
            }

            parametr.Direction = (ParameterDirection)argument.Value;
            return true;
        }

        protected static bool SetSourceColumn(TypedConstant argument, BaseParametr parametr)
        {
            if (!(argument.Type is INamedTypeSymbol paramName) ||
                paramName.Name != nameof(String)
                )
            {
                return false;
            }

            parametr.SourceColumn = (string)argument.Value;
            return true;
        }

        protected static bool SetSourceColumnNullMapping(TypedConstant argument, BaseParametr parametr)
        {
            if (!(argument.Type is INamedTypeSymbol nullableParam) ||
                nullableParam.Name != nameof(Boolean)
                )
            {
                return false;
            }

            parametr.SourceColumnNullMapping = (bool)argument.Value;
            return true;
        }

        protected static bool SetSourceVersion(TypedConstant argument, BaseParametr parametr)
        {
            if (argument.Kind != TypedConstantKind.Enum ||
                !(argument.Type is INamedTypeSymbol directionParam) ||
                !directionParam.IsAssignableFrom("System.Data", "DataRowVersion")
                )
            {
                return false;
            }

            parametr.SourceVersion = (DataRowVersion)argument.Value;
            return true;
        }

        protected static bool SetScale(TypedConstant argument, BaseParametr parametr)
        {
            if (!(argument.Type is INamedTypeSymbol sizeParam) ||
                sizeParam.Name != nameof(Byte)
                )
            {
                return false;
            }

            parametr.Scale = (byte)argument.Value;
            return true;
        }

        protected static bool SetPrecision(TypedConstant argument, BaseParametr parametr)
        {
            if (!(argument.Type is INamedTypeSymbol sizeParam) ||
                sizeParam.Name != nameof(Byte)
                )
            {
                return false;
            }

            parametr.Precision = (byte)argument.Value;
            return true;
        }

        public int Index {  get; set; }
    }
}