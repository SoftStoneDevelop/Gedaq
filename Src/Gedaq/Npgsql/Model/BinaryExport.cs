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
    internal class BinaryExport : BaseGenerateItem
    {
        public NpgsqlSourceType SourceType { get; private set; }
        public string Query;
        public Aliases Aliases { get; protected set; }

        private int[] NpgSqlDbTypes;

        public bool HaveNpgSqlDbTypes => NpgSqlDbTypes != null && NpgSqlDbTypes.Length != 0;

        private BinaryExport()
        {
        }

        internal static bool CreateNew(ImmutableArray<TypedConstant> namedArguments, INamedTypeSymbol containsType, out BinaryExport method)
        {
            method = null;
            if (namedArguments.Length != 9)
            {
                return false;
            }

            var methodSource = new BinaryExport();
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
                    methodName: namedArguments[1],
                    methodType: namedArguments[4],
                    accessModifier: namedArguments[6],
                    asyncResultType: namedArguments[7],
                    containsType
                    );

            if (methodSource.MapTypeName == null)
            {
                throw new Exception("The mapping type must be specified");
            }

            methodSource.ContainTypeName = containsType;
            method = methodSource;
            if (!methodSource.SetPartInterfaceType(namedArguments[8]))
            {
                return false;
            }

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

            if (argument.IsNull)
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

        public void SetAliases(Aliases aliases)
        {
            if (NpgSqlDbTypes == null)
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
    }
}