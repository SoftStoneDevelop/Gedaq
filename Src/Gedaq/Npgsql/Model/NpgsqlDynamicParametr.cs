using Gedaq.Base.Model;
using Microsoft.CodeAnalysis;
using System.Collections.Immutable;

namespace Gedaq.Npgsql.Model
{
    internal class NpgsqlDynamicParametr : BaseDynamicParametr
    {
        internal static bool CreateNew(
            ImmutableArray<TypedConstant> namedArguments,
            INamedTypeSymbol containsType,
            out NpgsqlDynamicParametr parametr)
        {
            parametr = new NpgsqlDynamicParametr();

            return true;
        }
    }
}
