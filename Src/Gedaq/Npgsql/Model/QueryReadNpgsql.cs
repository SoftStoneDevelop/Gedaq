using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Enums;
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

        public string[] ParametrNames;
        public ITypeSymbol[] ParametrTypes;
        public int[] ParametrDbTypes;

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

        public bool HaveParametrs()
        {
            return ParametrTypes != null && ParametrNames != null;
        }

        public bool HaveParametrTypes()
        {
            return ParametrDbTypes != null;
        }

        public static bool IsHisConstructor(ImmutableArray<TypedConstant> namedArguments, INamedTypeSymbol containsType, out QueryReadNpgsql method)
        {
            method = null;
            if (namedArguments.Length != 8)
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

            var sixArgument = namedArguments[5];//string[] parametrNames
            if (!(sixArgument.Type is IArrayTypeSymbol strArray) ||
                strArray.ElementType.Name != nameof(String) ||
                strArray.Rank != 1
                )
            {
                return false;
            }

            if(!sixArgument.IsNull)
            {
                methodSource.ParametrNames = new string[sixArgument.Values.Length];
                for (int i = 0; i < methodSource.ParametrNames.Length; i++)
                {
                    var item = sixArgument.Values[i];
                    var parametrName = (string)item.Value;
                    methodSource.ParametrNames[i] = parametrName;
                }
            }

            var sevenArgument = namedArguments[6];//Type[] parametrTypes
            if (!(sevenArgument.Type is IArrayTypeSymbol typeArray) ||
                typeArray.ElementType.Name != nameof(Type) ||
                typeArray.Rank != 1
                )
            {
                return false;
            }

            if (sixArgument.IsNull && !sevenArgument.IsNull || !sixArgument.IsNull && sevenArgument.IsNull)
            {
                throw new Exception("Parameters and parameter types are filled in pairs");
            }

            if (!sevenArgument.IsNull)
            {
                if (sixArgument.Values.Length != sevenArgument.Values.Length)
                {
                    throw new Exception("The number of parameters and their types do not match");
                }

                methodSource.ParametrTypes = new ITypeSymbol[sevenArgument.Values.Length];
                for (int i = 0; i < methodSource.ParametrTypes.Length; i++)
                {
                    var item = sevenArgument.Values[i].Value;
                    if (item is ITypeSymbol typeSymbol)
                    {
                        methodSource.ParametrTypes[i] = typeSymbol;
                    }
                    else
                    {
                        throw new Exception("Unknown type in queryTypeMap array");
                    }
                }
            }

            var eighthArgument = namedArguments[7];//NpgsqlDbType[] parametrDbTypes
            if (!(eighthArgument.Type is IArrayTypeSymbol dbTypeArray) ||
                dbTypeArray.ElementType.TypeKind != TypeKind.Enum ||
                dbTypeArray.Rank != 1 ||
                !(dbTypeArray.ElementType is INamedTypeSymbol dbType) ||
                !dbType.IsAssignableFrom("NpgsqlTypes", "NpgsqlDbType")
                )
            {
                return false;
            }

            if(!eighthArgument.IsNull && !sixArgument.IsNull)
            {
                methodSource.ParametrDbTypes = new int[eighthArgument.Values.Length];
                for (int i = 0; i < methodSource.ParametrDbTypes.Length; i++)
                {
                    methodSource.ParametrDbTypes[i] = (int)eighthArgument.Values[i].Value;
                }
            }

            methodSource.ContainTypeName = containsType;

            method = methodSource;
            return true;
        }
    }
}
