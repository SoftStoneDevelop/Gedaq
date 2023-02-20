using Gedaq.Enums;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Gedaq.Base.Model
{
    internal abstract class QueryBase : BaseGenerateItem
    {
        public string Query;
        public ITypeSymbol MapTypeName { get; private set; }
        public Aliases Aliases;

        public bool NeedGenerate;

        public abstract bool HaveParametrs();

        public abstract IEnumerable<BaseParametr> BaseParametrs();

        protected bool FillMethodName(TypedConstant argument)
        {
            if (!(argument.Type is INamedTypeSymbol namedTypeSymbol) ||
                namedTypeSymbol.Name != nameof(String)
                )
            {
                return false;
            }

            MethodName = (string)argument.Value;
            return true;
        }

        protected bool FillGenerate(TypedConstant argument)
        {
            if (!(argument.Type is INamedTypeSymbol namedTypeSymbol) ||
                namedTypeSymbol.Name != nameof(Boolean)
                )
            {
                return false;
            }

            NeedGenerate = (bool)argument.Value;
            return true;
        }

        protected bool FillQuery(TypedConstant argument)
        {
            if (!(argument.Type is INamedTypeSymbol strParam) ||
                strParam.Name != nameof(String)
                )
            {
                return false;
            }

            Query = (string)argument.Value;
            return true;
        }

        protected bool FillMapType(TypedConstant argument)
        {
            if (argument.IsNull)
            {
                return true;
            }

            if (!(argument.Value is ITypeSymbol typeParam))
            {
                return false;
            }

            MapTypeName = typeParam;
            return true;
        }

        protected bool FillMethodType(TypedConstant argument)
        {
            if (argument.Kind != TypedConstantKind.Enum ||
                !(argument.Type is INamedTypeSymbol namedTypeSymbol3) ||
                !namedTypeSymbol3.IsAssignableFrom("Gedaq.Common.Enums", "MethodType")
                )
            {
                return false;
            }

            MethodType = (MethodType)argument.Value;
            return true;
        }

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