using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Model;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Gedaq.Base.Model
{
    internal abstract class QueryBase : BaseGenerateItem
    {
        public QueryType QueryType { get; protected set; }

        protected bool FillQueryType(TypedConstant argument)
        {
            if (argument.Kind != TypedConstantKind.Enum ||
                !(argument.Type is INamedTypeSymbol namedTypeSymbol) ||
                !namedTypeSymbol.IsAssignableFrom("Gedaq.Common.Enums", "QueryType")
                )
            {
                return false;
            }

            QueryType = (QueryType)argument.Value;
            return true;
        }
    }
}