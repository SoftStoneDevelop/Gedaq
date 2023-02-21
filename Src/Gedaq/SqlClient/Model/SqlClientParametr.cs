using Gedaq.Base.Model;
using Gedaq.DbConnection.Model;
using Gedaq.Helpers;
using Gedaq.Npgsql.Model;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data;
using System.Data.SqlTypes;
using System.Reflection;
using System.Text;

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
            return $"{Name.ToLowerInvariant()}{postfix}";
        }

        internal static bool CreateNew(
            ImmutableArray<TypedConstant> namedArguments,
            INamedTypeSymbol containsType,
            out SqlClientParametr parametr,
            out string methodName
            )
        {
            parametr = null;
            methodName = null;

            if (namedArguments.Length != 21)
            {
                return false;
            }

            if(!SetMethodName(namedArguments[0], ref methodName))
            {
                return false;
            }

            var result = new SqlClientParametr();
            if (!SetType(namedArguments[1], result))
            {
                return false;
            }

            if (!SetName(namedArguments[2], result))
            {
                return false;
            }

            if (!SetCompareInfo(namedArguments[3], result))
            {
                return false;
            }

            if (!SetForceColumnEncryption(namedArguments[4], result))
            {
                return false;
            }

            if (!SetLocaleId(namedArguments[5], result))
            {
                return false;
            }

            if (!SetOffset(namedArguments[6], result))
            {
                return false;
            }

            if (!SetSqlDbType(namedArguments[7], result))
            {
                return false;
            }

            if (!SetTypeName(namedArguments[8], result))
            {
                return false;
            }

            if (!SetUdtTypeName(namedArguments[9], result))
            {
                return false;
            }

            if (!SetXmlSchemaCollectionDatabase(namedArguments[10], result))
            {
                return false;
            }

            if (!SetXmlSchemaCollectionName(namedArguments[11], result))
            {
                return false;
            }

            if (!SetXmlSchemaCollectionOwningSchema(namedArguments[12], result))
            {
                return false;
            }

            if (!SetSize(namedArguments[13], result))
            {
                return false;
            }

            if (!SetNullable(namedArguments[14], result))
            {
                return false;
            }

            if (!SetDirection(namedArguments[15], result))
            {
                return false;
            }

            if (!SetSourceColumn(namedArguments[16], result))
            {
                return false;
            }

            if (!SetSourceColumnNullMapping(namedArguments[17], result))
            {
                return false;
            }

            if (!SetSourceVersion(namedArguments[18], result))
            {
                return false;
            }

            if (!SetScale(namedArguments[19], result))
            {
                return false;
            }

            if (!SetPrecision(namedArguments[20], result))
            {
                return false;
            }

            if (!result.HaveName)
            {
                throw new Exception("Parameter not have name");
            }

            parametr = result;
            return true;
        }

        private static bool SetCompareInfo(TypedConstant argument, SqlClientParametr parametr)
        {
            if (argument.Kind != TypedConstantKind.Enum ||
                !(argument.Type is INamedTypeSymbol dbType) ||
                !dbType.IsAssignableFrom("System.Data.SqlTypes", "SqlCompareOptions")
                )
            {
                return false;
            }

            parametr.CompareInfo = (SqlCompareOptions)argument.Value;
            return true;
        }

        private static bool SetForceColumnEncryption(TypedConstant argument, SqlClientParametr parametr)
        {
            if (!(argument.Type is INamedTypeSymbol nullableParam) ||
                nullableParam.Name != nameof(Boolean)
                )
            {
                return false;
            }

            parametr.ForceColumnEncryption = (bool)argument.Value;
            return true;
        }

        private static bool SetLocaleId(TypedConstant argument, SqlClientParametr parametr)
        {
            if (!(argument.Type is INamedTypeSymbol sizeParam) ||
                sizeParam.Name != nameof(Int32)
                )
            {
                return false;
            }

            parametr.LocaleId = (int)argument.Value;
            return true;
        }

        private static bool SetOffset(TypedConstant argument, SqlClientParametr parametr)
        {
            if (!(argument.Type is INamedTypeSymbol sizeParam) ||
                sizeParam.Name != nameof(Int32)
                )
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
                !dbType.IsAssignableFrom("System.Data", "SqlDbType")
                )
            {
                return false;
            }

            parametr.SqlDbType = (SqlDbType)argument.Value;
            return true;
        }

        private static bool SetTypeName(TypedConstant argument, SqlClientParametr parametr)
        {
            if (!(argument.Type is INamedTypeSymbol paramName) ||
                paramName.Name != nameof(String)
                )
            {
                return false;
            }

            parametr.TypeName = (string)argument.Value;
            return true;
        }

        private static bool SetUdtTypeName(TypedConstant argument, SqlClientParametr parametr)
        {
            if (!(argument.Type is INamedTypeSymbol paramName) ||
                paramName.Name != nameof(String)
                )
            {
                return false;
            }

            parametr.UdtTypeName = (string)argument.Value;
            return true;
        }

        private static bool SetXmlSchemaCollectionDatabase(TypedConstant argument, SqlClientParametr parametr)
        {
            if (!(argument.Type is INamedTypeSymbol paramName) ||
                paramName.Name != nameof(String)
                )
            {
                return false;
            }

            parametr.XmlSchemaCollectionDatabase = (string)argument.Value;
            return true;
        }

        private static bool SetXmlSchemaCollectionName(TypedConstant argument, SqlClientParametr parametr)
        {
            if (!(argument.Type is INamedTypeSymbol paramName) ||
                paramName.Name != nameof(String)
                )
            {
                return false;
            }

            parametr.XmlSchemaCollectionName = (string)argument.Value;
            return true;
        }

        private static bool SetXmlSchemaCollectionOwningSchema(TypedConstant argument, SqlClientParametr parametr)
        {
            if (!(argument.Type is INamedTypeSymbol paramName) ||
                paramName.Name != nameof(String)
                )
            {
                return false;
            }

            parametr.XmlSchemaCollectionOwningSchema = (string)argument.Value;
            return true;
        }
    }
}