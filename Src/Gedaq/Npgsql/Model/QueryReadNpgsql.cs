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

        public bool HaveParametrTypes()
        {
            return ParametrTypes != null;
        }

        public bool HaveParametrNames()
        {
            return ParametrNames != null;
        }

        public bool HaveParametrDbTypes()
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

            if (!FillParametrNames(namedArguments[5], methodSource))
            {
                return false;
            }

            if(!FillParametrTypes(namedArguments[6], methodSource))
            {
                return false;
            }

            if (methodSource.HaveParametrNames() &&
                methodSource.HaveParametrTypes() &&
                methodSource.ParametrNames.Length != methodSource.ParametrTypes.Length
                )
            {
                throw new Exception("The number of parameter names and their types do not match");
            }

            if (!FillParapetrDbTypes(namedArguments[7], methodSource))
            {
                return false;
            }

            if(methodSource.HaveParametrTypes() &&
               methodSource.HaveParametrDbTypes() &&
               methodSource.ParametrDbTypes.Length != methodSource.ParametrTypes.Length
               )
            {
                throw new Exception("The number of parameter DbTypes and their types do not match");
            }

            methodSource.ContainTypeName = containsType;

            method = methodSource;
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
                !namedTypeSymbol3.IsAssignableFrom("Gedaq.Provider.Enums", "MethodType")
                )
            {
                return false;
            }

            methodSource.MethodType = (MethodType)argument.Value;
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

        private static bool FillParametrNames(TypedConstant argument, QueryReadNpgsql methodSource)
        {
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

            methodSource.ParametrNames = new string[argument.Values.Length];
            for (int i = 0; i < methodSource.ParametrNames.Length; i++)
            {
                var item = argument.Values[i];
                var parametrName = (string)item.Value;
                methodSource.ParametrNames[i] = parametrName;
            }

            return true;
        }

        private static bool FillParametrTypes(TypedConstant argument, QueryReadNpgsql methodSource)
        {
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

            methodSource.ParametrTypes = new ITypeSymbol[argument.Values.Length];
            for (int i = 0; i < methodSource.ParametrTypes.Length; i++)
            {
                var item = argument.Values[i].Value;
                if (item is ITypeSymbol typeSymbol)
                {
                    methodSource.ParametrTypes[i] = typeSymbol;
                }
                else
                {
                    throw new Exception("Unknown type in queryTypeMap array");
                }
            }

            return true;
        }

        private static bool FillParapetrDbTypes(TypedConstant argument, QueryReadNpgsql methodSource)
        {
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

            methodSource.ParametrDbTypes = new int[argument.Values.Length];
            for (int i = 0; i < methodSource.ParametrDbTypes.Length; i++)
            {
                methodSource.ParametrDbTypes[i] = (int)argument.Values[i].Value;
            }

            return true;
        }
    }
}
