using Microsoft.CodeAnalysis;
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

        public abstract string VariableName();
    }
}