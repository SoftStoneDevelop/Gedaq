using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Enums;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Immutable;

namespace Gedaq.Npgsql.Model
{
    internal class QueryReadNpgsql : BaseNpgsql
    {
        public ITypeSymbol MapTypeName;
        public Aliases Aliases;
        public Parametr[] Parametrs;
        public string Query;

        public bool NeedGenerate;

        public QueryReadNpgsql()
        {
        }

        public bool HaveParametrs()
        {
            return Parametrs != null;
        }

        internal static bool CreateNew(ImmutableArray<TypedConstant> namedArguments, INamedTypeSymbol containsType, out QueryReadNpgsql method)
        {
            method = null;
            if (namedArguments.Length != 7)
            {
                return false;
            }

            var methodSource = new QueryReadNpgsql();
            if (!FillQuery(namedArguments[0], methodSource))
            {
                return false;
            }
            
            if(!FillMapType(namedArguments[1], methodSource))
            {
                return false;
            }

            if (!FillMethodType(namedArguments[2], methodSource))
            {
                return false;
            }

            if (!FillSourceType(namedArguments[3], methodSource))
            {
                return false;
            }

            if (!FillMethodName(namedArguments[4], methodSource))
            {
                return false;
            }

            if (!FillQueryType(namedArguments[5], methodSource))
            {
                return false;
            }

            if (!FillGenerate(namedArguments[6], methodSource))
            {
                return false;
            }

            methodSource.ContainTypeName = containsType;
            method = methodSource;
            return true;
        }

        private static bool FillGenerate(TypedConstant argument, QueryReadNpgsql methodSource)
        {
            if (!(argument.Type is INamedTypeSymbol namedTypeSymbol) ||
                namedTypeSymbol.Name != nameof(Boolean)
                )
            {
                return false;
            }

            methodSource.NeedGenerate = (bool)argument.Value;
            return true;
        }

        private static bool FillQuery(TypedConstant argument, QueryReadNpgsql methodSource)
        {
            if (!(argument.Type is INamedTypeSymbol strParam) ||
                strParam.Name != nameof(String)
                )
            {
                return false;
            }

            methodSource.Query = (string)argument.Value;
            return true;
        }

        private static bool FillMapType(TypedConstant argument, QueryReadNpgsql methodSource)
        {
            if (!(argument.Value is ITypeSymbol typeParam))
            {
                return false;
            }

            methodSource.MapTypeName = typeParam;
            return true;
        }

        private static bool FillMethodType(TypedConstant argument, QueryReadNpgsql methodSource)
        {
            if (argument.Kind != TypedConstantKind.Enum ||
                !(argument.Type is INamedTypeSymbol namedTypeSymbol3) ||
                !namedTypeSymbol3.IsAssignableFrom("Gedaq.Common.Enums", "MethodType")
                )
            {
                return false;
            }

            methodSource.MethodType = (MethodType)argument.Value;
            return true;
        }

        private static bool FillQueryType(TypedConstant argument, QueryReadNpgsql methodSource)
        {
            if (argument.Kind != TypedConstantKind.Enum ||
                !(argument.Type is INamedTypeSymbol namedTypeSymbol) ||
                !namedTypeSymbol.IsAssignableFrom("Gedaq.Common.Enums", "QueryType")
                )
            {
                return false;
            }

            methodSource.QueryType = (QueryType)argument.Value;
            return true;
        }

        private static bool FillSourceType(TypedConstant argument, QueryReadNpgsql methodSource)
        {
            if (argument.Kind != TypedConstantKind.Enum ||
                !(argument.Type is INamedTypeSymbol namedTypeSymbol4) ||
                !namedTypeSymbol4.IsAssignableFrom("Gedaq.Npgsql.Enums", "SourceType")
                )
            {
                return false;
            }

            methodSource.SourceType = (NpgsqlSourceType)argument.Value;
            return true;
        }

        private static bool FillMethodName(TypedConstant argument, QueryReadNpgsql methodSource)
        {
            if (!(argument.Type is INamedTypeSymbol namedTypeSymbol5) ||
                namedTypeSymbol5.Name != nameof(String)
                )
            {
                return false;
            }

            methodSource.MethodName = (string)argument.Value;
            return true;
        }

        private static bool FillParametrNames(TypedConstant argument, QueryReadNpgsql methodSource, out string[]parametrNames)
        {
            parametrNames = null;
            if (!(argument.Type is IArrayTypeSymbol strArray) ||
                strArray.ElementType.Name != nameof(String) ||
                strArray.Rank != 1
                )
            {
                return false;
            }

            if (argument.IsNull)
            {
                return true;
            }

            parametrNames = new string[argument.Values.Length];
            for (int i = 0; i < parametrNames.Length; i++)
            {
                var item = argument.Values[i];
                var parametrName = (string)item.Value;
                parametrNames[i] = parametrName;
            }

            return true;
        }

        private static bool FillParametrTypes(TypedConstant argument, QueryReadNpgsql methodSource, out ITypeSymbol[] parametrTypes)
        {
            parametrTypes = null;
            if (!(argument.Type is IArrayTypeSymbol typeArray) ||
                typeArray.ElementType.Name != nameof(Type) ||
                typeArray.Rank != 1
                )
            {
                return false;
            }

            if (argument.IsNull)
            {
                return true;
            }

            parametrTypes = new ITypeSymbol[argument.Values.Length];
            for (int i = 0; i < parametrTypes.Length; i++)
            {
                var item = argument.Values[i].Value;
                if (item is ITypeSymbol typeSymbol)
                {
                    parametrTypes[i] = typeSymbol;
                }
                else
                {
                    throw new Exception("Unknown type in queryTypeMap array");
                }
            }

            return true;
        }

        private static bool FillParapetrDbTypes(TypedConstant argument, QueryReadNpgsql methodSource, out int[] parametrDbTypes)
        {
            parametrDbTypes = null;
            if (!(argument.Type is IArrayTypeSymbol dbTypeArray) ||
                dbTypeArray.ElementType.TypeKind != TypeKind.Enum ||
                dbTypeArray.Rank != 1 ||
                !(dbTypeArray.ElementType is INamedTypeSymbol dbType) ||
                !dbType.IsAssignableFrom("NpgsqlTypes", "NpgsqlDbType")
                )
            {
                return false;
            }

            if(argument.IsNull)
            {
                return true;
            }

            parametrDbTypes = new int[argument.Values.Length];
            for (int i = 0; i < parametrDbTypes.Length; i++)
            {
                parametrDbTypes[i] = (int)argument.Values[i].Value;
            }

            return true;
        }
    }
}
