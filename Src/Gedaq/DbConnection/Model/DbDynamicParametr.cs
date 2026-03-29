using Gedaq.Base.Model;
using Microsoft.CodeAnalysis;
using System.Collections.Immutable;

namespace Gedaq.DbConnection.Model
{
    internal class DbDynamicParametr : BaseDynamicParametr
    {
        internal static bool CreateNew(
            ImmutableArray<TypedConstant> namedArguments,
            INamedTypeSymbol containsType,
            out DbDynamicParametr parametr)
        {
            parametr = new DbDynamicParametr();

            return true;
        }
    }
}
