using Gedaq.Enums;
using Gedaq.Npgsql.Enums;
using Microsoft.CodeAnalysis;

namespace Gedaq.Base.Model
{
    internal class BaseGenerateItem
    {
        public string MethodName { get; protected set; }
        public MethodType MethodType { get; protected set; }
        public QueryType QueryType { get; protected set; }
        public INamedTypeSymbol ContainTypeName;
    }
}