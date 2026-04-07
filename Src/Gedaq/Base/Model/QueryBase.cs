using Gedaq.Enums;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;

namespace Gedaq.Base.Model
{
    internal abstract class QueryBase : BaseGenerateItem
    {
        public QueryType QueryType { get; protected set; }

        public ReturnType ReturnType { get; protected set; }

        protected bool FillQueryType(TypedConstant argument)
        {
            if (argument.Kind != TypedConstantKind.Enum ||
                !(argument.Type is INamedTypeSymbol namedTypeSymbol) ||
                !namedTypeSymbol.IsAssignableFrom("Gedaq.Common.Enums", "QueryType"))
            {
                return false;
            }

            QueryType = (QueryType)argument.Value;
            return true;
        }

        protected bool FillReturnType(TypedConstant argument)
        {
            if (argument.Kind != TypedConstantKind.Enum ||
                !(argument.Type is INamedTypeSymbol namedTypeSymbol) ||
                !namedTypeSymbol.IsAssignableFrom("Gedaq.Common.Enums", "ReturnType"))
            {
                return false;
            }

            ReturnType = (ReturnType)argument.Value;
            return true;
        }

        protected bool FillOverrideAliasPrefixs(TypedConstant argument)
        {
            if (argument.IsNull)
            {
                return true;
            }

            if (!(argument.Value is ITypeSymbol typeParam))
            {
                return false;
            }

            if (!typeParam.IsArrayType(out var elementType))
            {
                return false;
            }

            if (elementType.Name != nameof(String))
            {
                return false;
            }

            OverrideAliasPrefixs = argument.Values.CastArray<string>();
            return true;
        }
    }
}