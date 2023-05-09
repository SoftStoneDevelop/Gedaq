using Gedaq.Base.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Enums;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Gedaq.Npgsql.Model
{
    internal class BinaryImport : BaseGenerateItem
    {
        public NpgsqlSourceType SourceType { get; private set; }
        public string Query;
        public ITypeSymbol MapTypeName { get; private set; }
        public Aliases Aliases { get; protected set; }

        private int[] NpgSqlDbTypes;

        private BinaryImport()
        {
        }

        public void SetAliases(Aliases aliases)
        {
            if(NpgSqlDbTypes == null)
            {
                Aliases = aliases;
                return;
            }

            var fields = aliases.AllFieldsOrderByPosition();
            if (NpgSqlDbTypes?.Length != fields.Count)
            {
                throw new Exception("The number of NpgSqlDbTypes and columns in the query does not match.");
            }

            for (int i = 0; i < fields.Count; i++)
            {
                Field field = fields[i];
                field.AdditionalInfo = new NpgsqlFieldInfo(NpgSqlDbTypes[i]);
            }

            Aliases = aliases;
        }

        internal static bool CreateNew(ImmutableArray<TypedConstant> namedArguments, INamedTypeSymbol containsType, out BinaryImport method)
        {
            method = null;
            if (namedArguments.Length != 7)
            {
                return false;
            }

            var methodSource = new BinaryImport();
            if (!methodSource.FillQuery(namedArguments[0]))
            {
                return false;
            }

            if (!methodSource.FillMapType(namedArguments[2]))
            {
                return false;
            }

            if (!methodSource.FillNpgsqlDbTypes(namedArguments[3]))
            {
                return false;
            }

            if (!methodSource.FillSourceType(namedArguments[5]))
            {
                return false;
            }

            methodSource.MethodInfo =
                new BaseMethodInfo(
                    namedArguments[1],
                    namedArguments[4],
                    namedArguments[6],
                    containsType
                    );

            if (methodSource.MapTypeName == null)
            {
                throw new Exception("The mapping type must be specified");
            }

            methodSource.ContainTypeName = containsType;
            method = methodSource;
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

        protected bool FillNpgsqlDbTypes(TypedConstant argument)
        {
            if (!(argument.Type is IArrayTypeSymbol arrayTypeSymbol) ||
                arrayTypeSymbol.Rank != 1 ||
                arrayTypeSymbol.ElementType.TypeKind != TypeKind.Enum ||
                !(arrayTypeSymbol.ElementType is INamedTypeSymbol elementType) ||
                !elementType.IsAssignableFrom("NpgsqlTypes", "NpgsqlDbType")
                )
            {
                return false;
            }

            if(argument.IsNull)
            {
                return true;
            }

            NpgSqlDbTypes = new int[argument.Values.Length];
            for (int i = 0; i < argument.Values.Length; i++)
            {
                NpgSqlDbTypes[i] = (int)argument.Values[i].Value;
            }

            return true;
        }

        private bool FillSourceType(TypedConstant argument)
        {
            if (argument.Kind != TypedConstantKind.Enum ||
                !(argument.Type is INamedTypeSymbol namedTypeSymbol4) ||
                !namedTypeSymbol4.IsAssignableFrom("Gedaq.Npgsql.Enums", "SourceType")
                )
            {
                return false;
            }

            SourceType = (NpgsqlSourceType)argument.Value;
            return true;
        }
    }
}