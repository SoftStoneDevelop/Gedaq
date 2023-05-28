using Gedaq.Base.Model;
using Gedaq.SqlClient.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.SqlClient.Helpers
{
    internal static class SqlClientGeneratorHelper
    {
        public static void CreateParametr(BaseParametr baseParametr, int index, StringBuilder builder)
        {
            var parametr = (SqlClientParametr)baseParametr;

            builder.Append($@"
            var parametr{index} = command.CreateParameter();
");

            if (parametr.HaveSqlDbType)
            {
                builder.Append($@"
                parametr{index}.SqlDbType = System.Data.SqlDbType.{parametr.SqlDbType.ToString()};
");
            }

            if (parametr.HaveNameInCommand)
            {
                builder.Append($@"
                parametr{index}.ParameterName = ""{parametr.NameInCommand}"";
");
            }

            if (parametr.HaveSize)
            {
                builder.Append($@"
                parametr{index}.Size = {parametr.Size};
");
            }

            if (parametr.HaveNullable)
            {
                builder.Append($@"
                parametr
                {index}.IsNullable = true;

                ");
            }

            if (parametr.HaveDirection)
            {
                builder.Append($@"
                parametr{index}.Direction = System.Data.ParameterDirection.{parametr.Direction.ToString()};
");
            }

            if (parametr.HaveSourceColumn)
            {
                builder.Append($@"
                parametr{index}.SourceColumn = ""{parametr.SourceColumn}"";
");
            }

            if (parametr.HaveSourceColumnNullMapping)
            {
                builder.Append($@"
                parametr{index}.SourceColumnNullMapping = true;
");
            }

            if (parametr.HaveSourceVersion)
            {
                builder.Append($@"
                parametr{index}.SourceVersion = System.Data.DataRowVersion.{parametr.SourceVersion.ToString()};
");
            }

            if (parametr.HaveScale)
            {
                builder.Append($@"
                parametr{index}.Scale = {parametr.Scale};
");
            }

            if (parametr.HavePrecision)
            {
                builder.Append($@"
                parametr{index}.Precision = {parametr.Precision};
");
            }

            if (parametr.HaveCompareInfo)
            {
                builder.Append($@"
                parametr{index}.CompareInfo = System.Data.SqlTypes.{parametr.CompareInfo.ToString()};
");
            }

            if (parametr.HaveForceColumnEncryption)
            {
                builder.Append($@"
                parametr{index}.ForceColumnEncryption = true;
");
            }

            if (parametr.HaveLocaleId)
            {
                builder.Append($@"
                parametr{index}.LocaleId = {parametr.LocaleId};
");
            }

            if (parametr.HaveOffset)
            {
                builder.Append($@"
                parametr{index}.Offset = {parametr.Offset};
");
            }

            if (parametr.HaveTypeName)
            {
                builder.Append($@"
                parametr{index}.TypeName = ""{parametr.TypeName}"";
");
            }

            if (parametr.HaveUdtTypeName)
            {
                builder.Append($@"
                parametr{index}.UdtTypeName = ""{parametr.TypeName}"";
");
            }

            if (parametr.HaveXmlSchemaCollectionDatabase)
            {
                builder.Append($@"
                parametr{index}.XmlSchemaCollectionDatabase = ""{parametr.XmlSchemaCollectionDatabase}"";
");
            }

            if (parametr.HaveXmlSchemaCollectionName)
            {
                builder.Append($@"
                parametr{index}.XmlSchemaCollectionName = ""{parametr.XmlSchemaCollectionName}"";
");
            }

            if (parametr.HaveXmlSchemaCollectionOwningSchema)
            {
                builder.Append($@"
                parametr{index}.XmlSchemaCollectionOwningSchema = ""{parametr.XmlSchemaCollectionOwningSchema}"";
");
            }

            builder.Append($@"
                command.Parameters.Add(parametr{index});
");
        }
    }
}
