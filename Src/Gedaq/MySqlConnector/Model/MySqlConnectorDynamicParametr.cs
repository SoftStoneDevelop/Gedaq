using Gedaq.Base.Model;
using Microsoft.CodeAnalysis;
using System.Collections.Immutable;

namespace Gedaq.MySqlConnector.Model
{
    internal class MySqlConnectorDynamicParametr : BaseDynamicParametr
    {
        internal static bool CreateNew(
            ImmutableArray<TypedConstant> namedArguments,
            INamedTypeSymbol containsType,
            out MySqlConnectorDynamicParametr parametr)
        {
            parametr = new MySqlConnectorDynamicParametr();

            return true;
        }
    }
}
