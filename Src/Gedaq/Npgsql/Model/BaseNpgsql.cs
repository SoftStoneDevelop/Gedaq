using Gedaq.Enums;
using Gedaq.Npgsql.Enums;
using Microsoft.CodeAnalysis;

namespace Gedaq.Npgsql.Model
{
    internal class BaseNpgsql
    {
        public string MethodName;
        public NpgsqlSourceType SourceType;
        public MethodType MethodType;
        public QueryType QueryType;
        public INamedTypeSymbol ContainTypeName;
        public int? Timeout;
    }
}