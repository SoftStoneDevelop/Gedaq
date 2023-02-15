using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Enums;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection.Metadata;
using System.Text;

namespace Gedaq.Npgsql.Model
{
    internal class Parametr
    {
        public int Position;
        public string Name;
        public ITypeSymbol Type;
        public int DbType = -1;

        public bool HaveName => Name != null;
        public bool HaveDbType => DbType >= 0;

        public string VariableName()
        {
            return HaveName ?
                    Name.ToLowerInvariant() :
                    $"mParametr{Position}"
                ;
        }
    }

    internal class QueryReadNpgsql : BaseNpgsql
    {
        public string Query;
        public ITypeSymbol MapTypeName;
        public Aliases Aliases;
        public Parametr[] Parametrs;

        public QueryReadNpgsql()
        {
        }

        public bool HaveParametrs()
        {
            return Parametrs != null;
        }

        private static void FillParametrs(QueryReadNpgsql source, string[] parametrNames, ITypeSymbol[] parametrTypes, int[] parametrDbTypes)
        {
            if(parametrTypes == null)
            {
                return;
            }

            if (parametrNames != null &&
                parametrNames.Length != parametrTypes.Length
                )
            {
                throw new Exception("The number of parameter names and their types do not match");
            }

            if (parametrDbTypes != null &&
                parametrTypes.Length != parametrDbTypes.Length
               )
            {
                throw new Exception("The number of parameter DbTypes and their types do not match");
            }

            source.Parametrs = new Parametr[parametrTypes.Length];
            for (int i = 0; i < parametrTypes.Length; i++)
            {
                var parametr = new Parametr();
                parametr.Type= parametrTypes[i];
                parametr.Position = i + 1;

                if (parametrNames != null)
                {
                    parametr.Name = parametrNames[i];
                }

                if(parametrDbTypes != null)
                {
                    parametr.DbType = parametrDbTypes[i];
                }

                source.Parametrs[i] = parametr;
            }
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

            if (!FillParametrNames(namedArguments[5], methodSource, out var parametrNames))
            {
                return false;
            }

            if(!FillParametrTypes(namedArguments[6], methodSource, out var parametrTypes))
            {
                return false;
            }

            if (!FillParapetrDbTypes(namedArguments[7], methodSource, out var parametrDbTypes))
            {
                return false;
            }

            methodSource.ContainTypeName = containsType;
            FillParametrs(methodSource, parametrNames, parametrTypes, parametrDbTypes);
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
