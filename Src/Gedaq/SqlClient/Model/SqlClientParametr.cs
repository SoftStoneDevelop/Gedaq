using Gedaq.Base.Model;
using Gedaq.Constants;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Immutable;
using System.Data;
using System.Data.SqlTypes;

namespace Gedaq.SqlClient.Model
{
    internal class SqlClientParametr : BaseParametr
    {
        public System.Data.SqlTypes.SqlCompareOptions CompareInfo;
        public bool HaveCompareInfo => CompareInfo != System.Data.SqlTypes.SqlCompareOptions.None;

        public bool ForceColumnEncryption;
        public bool HaveForceColumnEncryption => ForceColumnEncryption;

        public int LocaleId;
        public bool HaveLocaleId => LocaleId != 0;

        public int Offset;
        public bool HaveOffset => Offset != 0;

        public SqlDbType SqlDbType;
        public bool HaveSqlDbType => SqlDbType != SqlDbType.NVarChar;

        public string TypeName;
        public bool HaveTypeName => TypeName != "";

        public string UdtTypeName;
        public bool HaveUdtTypeName => UdtTypeName != "";

        public string XmlSchemaCollectionDatabase;
        public bool HaveXmlSchemaCollectionDatabase => XmlSchemaCollectionDatabase != "";

        public string XmlSchemaCollectionName;
        public bool HaveXmlSchemaCollectionName => XmlSchemaCollectionName != "";

        public string XmlSchemaCollectionOwningSchema;
        public bool HaveXmlSchemaCollectionOwningSchema => XmlSchemaCollectionOwningSchema != "";



        public override string VariableName(string postfix = default)
        {
            if (HaveNameInMethod)
            {
                return $"{NameInMethod}{postfix}";
            }

            return $"{NameInCommand}{postfix}";
        }

        internal static bool CreateNew(
            SourceProductionContext context,
            ImmutableArray<TypedConstant> namedArguments,
            out SqlClientParametr parametr)
        {
            parametr = null;

            if (namedArguments.Length != 21)
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametrsCount,
                    DiagnosticConstants.IncorrectAttributeParametrsCountDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "Parametr", "21", namedArguments.Length.ToString() });

                return false;
            }

            var result = new SqlClientParametr();
            if (!SetType(namedArguments[0], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "1", nameof(Type) });

                return false;
            }

            if (!SetNameInCommand(namedArguments[1], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "2", nameof(NameInCommand) });

                return false;
            }

            if (!SetCompareInfo(namedArguments[2], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "3", nameof(CompareInfo) });

                return false;
            }

            if (!SetForceColumnEncryption(namedArguments[3], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "4", nameof(ForceColumnEncryption) });

                return false;
            }

            if (!SetLocaleId(namedArguments[4], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "5", nameof(LocaleId) });

                return false;
            }

            if (!SetOffset(namedArguments[5], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "6", nameof(Offset) });

                return false;
            }

            if (!SetSqlDbType(namedArguments[6], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "7", nameof(SqlDbType) });

                return false;
            }

            if (!SetTypeName(namedArguments[7], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "8", nameof(TypeName) });

                return false;
            }

            if (!SetUdtTypeName(namedArguments[8], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "9", nameof(UdtTypeName) });

                return false;
            }

            if (!SetXmlSchemaCollectionDatabase(namedArguments[9], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "10", nameof(XmlSchemaCollectionDatabase) });

                return false;
            }

            if (!SetXmlSchemaCollectionName(namedArguments[10], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "11", nameof(XmlSchemaCollectionName) });

                return false;
            }

            if (!SetXmlSchemaCollectionOwningSchema(namedArguments[11], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "12", nameof(XmlSchemaCollectionOwningSchema) });

                return false;
            }

            if (!SetSize(namedArguments[12], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "13", nameof(Size) });

                return false;
            }

            if (!SetNullable(namedArguments[13], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "14", nameof(Nullable) });

                return false;
            }

            if (!SetDirection(namedArguments[14], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "15", nameof(Direction) });

                return false;
            }

            if (!SetSourceColumn(namedArguments[15], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "16", nameof(SourceColumn) });

                return false;
            }

            if (!SetSourceColumnNullMapping(namedArguments[16], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "17", nameof(SourceColumnNullMapping) });

                return false;
            }

            if (!SetSourceVersion(namedArguments[17], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "18", nameof(SourceVersion) });

                return false;
            }

            if (!SetScale(namedArguments[18], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "19", nameof(Scale) });

                return false;
            }

            if (!SetPrecision(namedArguments[19], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "20", nameof(Precision) });

                return false;
            }

            if (!SetNameInMethod(namedArguments[20], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "21", nameof(NameInMethod) });

                return false;
            }

            if (!result.HaveNameInCommand)
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.UnnamedQueryParametr,
                    DiagnosticConstants.UnnamedQueryParametrDescr,
                    DiagnosticSeverity.Error);

                return false;
            }

            parametr = result;
            return true;
        }

        private static bool SetCompareInfo(TypedConstant argument, SqlClientParametr parametr)
        {
            if (argument.Kind != TypedConstantKind.Enum ||
                !(argument.Type is INamedTypeSymbol dbType) ||
                !dbType.IsAssignableFrom("System.Data.SqlTypes", "SqlCompareOptions"))
            {
                return false;
            }

            parametr.CompareInfo = (SqlCompareOptions)argument.Value;
            return true;
        }

        private static bool SetForceColumnEncryption(TypedConstant argument, SqlClientParametr parametr)
        {
            if (!(argument.Type is INamedTypeSymbol nullableParam) ||
                nullableParam.Name != nameof(Boolean))
            {
                return false;
            }

            parametr.ForceColumnEncryption = (bool)argument.Value;
            return true;
        }

        private static bool SetLocaleId(TypedConstant argument, SqlClientParametr parametr)
        {
            if (!(argument.Type is INamedTypeSymbol sizeParam) ||
                sizeParam.Name != nameof(Int32))
            {
                return false;
            }

            parametr.LocaleId = (int)argument.Value;
            return true;
        }

        private static bool SetOffset(TypedConstant argument, SqlClientParametr parametr)
        {
            if (!(argument.Type is INamedTypeSymbol sizeParam) ||
                sizeParam.Name != nameof(Int32))
            {
                return false;
            }

            parametr.Offset = (int)argument.Value;
            return true;
        }

        private static bool SetSqlDbType(TypedConstant argument, SqlClientParametr parametr)
        {
            if (argument.Kind != TypedConstantKind.Enum ||
                !(argument.Type is INamedTypeSymbol dbType) ||
                !dbType.IsAssignableFrom("System.Data", "SqlDbType"))
            {
                return false;
            }

            parametr.SqlDbType = (SqlDbType)argument.Value;
            return true;
        }

        private static bool SetTypeName(TypedConstant argument, SqlClientParametr parametr)
        {
            if (!(argument.Type is INamedTypeSymbol paramName) ||
                paramName.Name != nameof(String))
            {
                return false;
            }

            parametr.TypeName = (string)argument.Value;
            return true;
        }

        private static bool SetUdtTypeName(TypedConstant argument, SqlClientParametr parametr)
        {
            if (!(argument.Type is INamedTypeSymbol paramName) ||
                paramName.Name != nameof(String))
            {
                return false;
            }

            parametr.UdtTypeName = (string)argument.Value;
            return true;
        }

        private static bool SetXmlSchemaCollectionDatabase(TypedConstant argument, SqlClientParametr parametr)
        {
            if (!(argument.Type is INamedTypeSymbol paramName) ||
                paramName.Name != nameof(String))
            {
                return false;
            }

            parametr.XmlSchemaCollectionDatabase = (string)argument.Value;
            return true;
        }

        private static bool SetXmlSchemaCollectionName(TypedConstant argument, SqlClientParametr parametr)
        {
            if (!(argument.Type is INamedTypeSymbol paramName) ||
                paramName.Name != nameof(String))
            {
                return false;
            }

            parametr.XmlSchemaCollectionName = (string)argument.Value;
            return true;
        }

        private static bool SetXmlSchemaCollectionOwningSchema(TypedConstant argument, SqlClientParametr parametr)
        {
            if (!(argument.Type is INamedTypeSymbol paramName) ||
                paramName.Name != nameof(String))
            {
                return false;
            }

            parametr.XmlSchemaCollectionOwningSchema = (string)argument.Value;
            return true;
        }
    }
}