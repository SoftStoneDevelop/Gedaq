using Gedaq.Npgsql.Model;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.DbConnection.Model
{
    internal class QueryBase : BaseGenerateItem
    {
        public string Query;
        public ITypeSymbol MapTypeName;
        public Aliases Aliases;

        public bool NeedGenerate;
    }
}