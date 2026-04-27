using Gedaq.Base.Model;
using Gedaq.Constants;
using Gedaq.Helpers;
using Gedaq.Npgsql.Enums;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Immutable;

namespace Gedaq.Npgsql.Model
{
    internal class BinaryExport : BaseGenerateItem
    {
        public NpgsqlSourceType SourceType { get; private set; }
        public string Query;

        private int[] _npgSqlDbTypes;

        public override bool IsCollectionDelegateMap => MapTypeInfos?.Length > 1;

        public bool HaveNpgSqlDbTypes => _npgSqlDbTypes?.Length > 0;

        private BinaryExport()
        {
        }

        public override string MapDelegateParametrName => throw new NotImplementedException();

        public override string MapDelegateParametrType()
        {
            throw new NotImplementedException();
        }

        internal static bool CreateNew(
            SourceProductionContext context,
            ImmutableArray<TypedConstant> namedArguments,
            INamedTypeSymbol containsType,
            out BinaryExport method)
        {
            method = null;
            if (namedArguments.Length != 9)
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametrsCount,
                    DiagnosticConstants.IncorrectAttributeParametrsCountDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "BinaryExport", "9", namedArguments.Length.ToString() });

                return false;
            }

            var methodSource = new BinaryExport();
            if (!methodSource.FillQuery(namedArguments[2]))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "3", nameof(Query) });

                return false;
            }

            if (!methodSource.FillMapTypes(namedArguments[1]))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "2", nameof(MapTypeInfos) });

                return false;
            }

            if (!methodSource.FillNpgsqlDbTypes(namedArguments[3]))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "4", nameof(_npgSqlDbTypes) });

                return false;
            }

            if (!methodSource.FillSourceType(namedArguments[5]))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "6", nameof(SourceType) });

                return false;
            }

            methodSource.MethodInfo =
                new BaseMethodInfo(
                    methodName: namedArguments[0],
                    methodType: namedArguments[4],
                    accessModifier: namedArguments[6],
                    asyncResultType: namedArguments[7],
                    containsType);

            if (!methodSource.HaveMapTypes)
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.UnknownMapTypes,
                    DiagnosticConstants.UnknownMapTypesDescr,
                    DiagnosticSeverity.Error);
            }

            methodSource.ContainTypeName = containsType;
            method = methodSource;
            if (!methodSource.SetPartInterfaceType(namedArguments[8]))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "9", nameof(PartInterfaceType) });

                return false;
            }

            return true;
        }

        protected bool FillQuery(TypedConstant argument)
        {
            if (!(argument.Type is INamedTypeSymbol strParam) ||
                strParam.Name != nameof(String))
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
                !namedTypeSymbol4.IsAssignableFrom("Gedaq.Npgsql.Enums", "SourceType"))
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
                !elementType.IsAssignableFrom("NpgsqlTypes", "NpgsqlDbType"))
            {
                return false;
            }

            if (argument.IsNull)
            {
                return true;
            }

            _npgSqlDbTypes = new int[argument.Values.Length];
            for (int i = 0; i < argument.Values.Length; i++)
            {
                _npgSqlDbTypes[i] = (int)argument.Values[i].Value;
            }

            return true;
        }

        public void SetAliases(MapTypeInfo mapTypeInfo, Aliases aliases)
        {
            if (_npgSqlDbTypes == null)
            {
                mapTypeInfo.Aliases = aliases;
                return;
            }

            var fields = aliases.AllFieldsOrderByPosition();
            if (_npgSqlDbTypes?.Length != fields.Count)
            {
                throw new Exception("The number of NpgSqlDbTypes and columns in the query does not match.");
            }

            for (int i = 0; i < fields.Count; i++)
            {
                Field field = fields[i];
                field.AdditionalInfo = new NpgsqlFieldInfo(_npgSqlDbTypes[i]);
            }

            mapTypeInfo.Aliases = aliases;
        }
    }
}