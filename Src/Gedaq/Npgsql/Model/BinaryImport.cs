using Gedaq.Base.Model;
using Gedaq.Constants;
using Gedaq.Helpers;
using Gedaq.Npgsql.Enums;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Immutable;

namespace Gedaq.Npgsql.Model
{
    internal class BinaryImport : BaseGenerateItem
    {
        public NpgsqlSourceType SourceType { get; private set; }
        public string Query;
        public Aliases Aliases { get; protected set; }

        public override bool IsCollectionDelegateMap => MapTypeInfos?.Length > 1;

        private int[] NpgSqlDbTypes;

        private BinaryImport()
        {
        }

        public override string MapDelegateParametrName => throw new NotImplementedException();

        public override string MapDelegateParametrType()
        {
            throw new NotImplementedException();
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

        internal static bool CreateNew(
            SourceProductionContext context,
            ImmutableArray<TypedConstant> namedArguments,
            INamedTypeSymbol containsType,
            out BinaryImport method)
        {
            method = null;
            if (namedArguments.Length != 9)
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametrsCount,
                    DiagnosticConstants.IncorrectAttributeParametrsCountDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "BinaryImport", "9", namedArguments.Length.ToString() });

                return false;
            }

            var methodSource = new BinaryImport();
            if (!methodSource.FillQuery(namedArguments[0]))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "1", nameof(Query) });

                return false;
            }

            if (!methodSource.FillNpgsqlDbTypes(namedArguments[3]))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "4", nameof(NpgSqlDbTypes) });

                return false;
            }

            if (!methodSource.FillMapTypesFromSingle(namedArguments[2]))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "3", nameof(MapTypeInfos) });

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
                    methodName: namedArguments[1],
                    methodType: namedArguments[4],
                    accessModifier: namedArguments[6],
                    asyncResultType: namedArguments[7],
                    containsType: containsType);

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
                !namedTypeSymbol4.IsAssignableFrom("Gedaq.Npgsql.Enums", "SourceType"))
            {
                return false;
            }

            SourceType = (NpgsqlSourceType)argument.Value;
            return true;
        }
    }
}