using Gedaq.Enums;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System.Text;

namespace Gedaq.Base.Model
{
    internal abstract class QueryBase : BaseGenerateItem
    {
        public QueryType QueryType { get; protected set; }

        public ReturnType ReturnType { get; protected set; }

        public override bool IsCollectionDelegateMap => MapTypeInfos?.Length > 1;

        public override string MapDelegateParametrName => "mapDelegate";

        public override string MapDelegateParametrType()
        {
            var builder = new StringBuilder("Action<");
            for (int i = 0; i < MapTypeInfos.Length; i++)
            {
                var mapTypeInfo = MapTypeInfos[i];
                if (i != 0)
                {
                    builder.Append(",");
                }

                builder.Append(mapTypeInfo.ItemTypeName);
            }
            builder.Append(">");

            return builder.ToString();
        }

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
    }
}