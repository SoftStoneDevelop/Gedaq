using Microsoft.CodeAnalysis;
using System;
using System.Data;

namespace Gedaq.DbConnection.Model
{
    internal abstract class BaseParametr
    {
        public string Name;
        public ITypeSymbol Type;
        public int Size;
        public int NumberInBatch;
        public bool Nullable;
        public ParameterDirection Direction;

        public bool HaveName => Name != null;
        public bool HaveSize => Size != -1;

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
    }
}