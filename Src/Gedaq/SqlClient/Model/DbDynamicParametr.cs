using Gedaq.Base.Model;
using Microsoft.CodeAnalysis;
using System.Collections.Immutable;

namespace Gedaq.SqlClient.Model
{
    internal class SqlClientDynamicParametr : BaseDynamicParametr
    {
        internal static bool CreateNew(
            ImmutableArray<TypedConstant> namedArguments,
            INamedTypeSymbol containsType,
            out SqlClientDynamicParametr parametr)
        {
            parametr = new SqlClientDynamicParametr();

            return true;
        }
    }
}
