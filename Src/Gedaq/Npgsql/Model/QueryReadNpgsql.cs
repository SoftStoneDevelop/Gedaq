using Gedaq.Enums;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace Gedaq.Npgsql.Model
{
    internal class QueryReadNpgsql : BaseNpgsql
    {
        public string Query;
        public ITypeSymbol MapTypeName;
        public Aliases Aliases;

        public QueryReadNpgsql()
        {
        }

        public QueryReadNpgsql(QueryReadBatchNpgsql queryReadBatchNpgsql)
        {
            Query = queryReadBatchNpgsql.Queries[0].Query;
            MapTypeName = queryReadBatchNpgsql.Queries[0].MapTypeName;
            Aliases = queryReadBatchNpgsql.Queries[0].Aliases;
            MethodType = queryReadBatchNpgsql.MethodType;
            SourceType= queryReadBatchNpgsql.SourceType;
            ContainTypeName= queryReadBatchNpgsql.ContainTypeName;
            MethodName= queryReadBatchNpgsql.MethodName;
        }

        public static bool IsHisConstructor(ImmutableArray<TypedConstant> namedArguments, INamedTypeSymbol containsType, out QueryReadNpgsql method)
        {
            method = null;
            if (namedArguments.Length != 5)
            {
                return false;
            }

            var firstArgument = namedArguments[0];//string query
            if (!(firstArgument.Type is INamedTypeSymbol strParam) ||
                strParam.Name != nameof(String)
                )
            {
                return false;
            }

            var methodSource = new QueryReadNpgsql();
            methodSource.Query = (string)firstArgument.Value;

            var secondArgument = namedArguments[1];//Type typeMap
            if (!(secondArgument.Value is ITypeSymbol typeParam))
            {
                return false;
            }

            methodSource.MapTypeName = typeParam;

            var thirtArgument = namedArguments[2];//MethodType
            if (thirtArgument.Kind != TypedConstantKind.Enum ||
                !(thirtArgument.Type is INamedTypeSymbol namedTypeSymbol3) ||
                !namedTypeSymbol3.IsAssignableFrom("Gedaq.Provider.Enums", "MethodType")
                )
            {
                return false;
            }

            methodSource.MethodType = (MethodType)thirtArgument.Value;

            var fourthArgument = namedArguments[3];//SourceType
            if (fourthArgument.Kind != TypedConstantKind.Enum ||
                !(fourthArgument.Type is INamedTypeSymbol namedTypeSymbol4) ||
                !namedTypeSymbol4.IsAssignableFrom("Gedaq.Npgsql.Enums", "SourceType")
                )
            {
                return false;
            }

            methodSource.SourceType = (NpgsqlSourceType)fourthArgument.Value;

            var fifthArgument = namedArguments[4];//string
            if (!(fifthArgument.Type is INamedTypeSymbol namedTypeSymbol5) ||
                namedTypeSymbol5.Name != nameof(String)
                )
            {
                return false;
            }

            methodSource.MethodName = (string)fifthArgument.Value;
            methodSource.ContainTypeName = containsType;

            method = methodSource;
            return true;
        }
    }
}
