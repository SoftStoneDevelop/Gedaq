using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Gedaq.DbConnection.Model
{
    internal class DbParametr
    {
        public int Position;
        public string Name;
        public ITypeSymbol Type;
        public int DbType;
        public int Size;
        public int NumberInBatch;
        public bool Nullable;
        public ParameterDirection Direction;

        public bool HaveName => Name != null;
        public bool HaveDbType => DbType != 40;
        public bool HaveSize => Size != -1;

        public bool HavePosition => Position != -1;

        public string VariableName()
        {
            return HaveName ?
                    Name.ToLowerInvariant() :
                    $"mParametr{Position}"
                ;
        }
    }
}