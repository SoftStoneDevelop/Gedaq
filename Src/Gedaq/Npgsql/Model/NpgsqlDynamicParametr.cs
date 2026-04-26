using Gedaq.Base.Model;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

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
