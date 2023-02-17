using Gedaq.Enums;
using Gedaq.Npgsql.Enums;
using Microsoft.CodeAnalysis;

namespace Gedaq.DbConnection.Model
{
    internal class BaseGenerateItem
    {
        public string MethodName;
        public MethodType MethodType;
        public QueryType QueryType;
        public INamedTypeSymbol ContainTypeName;
        public int? Timeout;
    }
}