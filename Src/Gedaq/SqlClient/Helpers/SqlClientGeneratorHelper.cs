using Gedaq.Base.Model;
using Gedaq.SqlClient.Model;
using System.Text;

namespace Gedaq.SqlClient.Helpers
{
    internal static class SqlClientGeneratorHelper
    {
        public static void CreateParametr(BaseParametr baseParametr, StringBuilder builder)
        {
            var parametr = (SqlClientParametr)baseParametr;

            builder.Append($@"
            var parametr = command.CreateParameter();
");

            if (parametr.HaveSqlDbType)
            {
                builder.Append($@"
                parametr.SqlDbType = (System.Data.SqlDbType)({(int)parametr.SqlDbType});
");
            }

            if (parametr.HaveNameInCommand)
            {
                builder.Append($@"
                parametr.ParameterName = ""{parametr.NameInCommand}"";
");
            }

            if (parametr.HaveSize)
            {
                builder.Append($@"
                parametr.Size = {parametr.Size};
");
            }

            if (parametr.Nullable)
            {
                builder.Append($@"
                parametr.IsNullable = true;
                ");
            }

            if (parametr.HaveDirection)
            {
                builder.Append($@"
                parametr.Direction = System.Data.ParameterDirection.{parametr.Direction.ToString()};
");
            }

            if (parametr.HaveSourceColumn)
            {
                builder.Append($@"
                parametr.SourceColumn = ""{parametr.SourceColumn}"";
");
            }

            if (parametr.HaveSourceColumnNullMapping)
            {
                builder.Append($@"
                parametr.SourceColumnNullMapping = true;
");
            }

            if (parametr.HaveSourceVersion)
            {
                builder.Append($@"
                parametr.SourceVersion = System.Data.DataRowVersion.{parametr.SourceVersion.ToString()};
");
            }

            if (parametr.HaveScale)
            {
                builder.Append($@"
                parametr.Scale = {parametr.Scale};
");
            }

            if (parametr.HavePrecision)
            {
                builder.Append($@"
                parametr.Precision = {parametr.Precision};
");
            }

            if (parametr.HaveCompareInfo)
            {
                builder.Append($@"
                parametr.CompareInfo = System.Data.SqlTypes.{parametr.CompareInfo.ToString()};
");
            }

            if (parametr.HaveForceColumnEncryption)
            {
                builder.Append($@"
                parametr.ForceColumnEncryption = true;
");
            }

            if (parametr.HaveLocaleId)
            {
                builder.Append($@"
                parametr.LocaleId = {parametr.LocaleId};
");
            }

            if (parametr.HaveOffset)
            {
                builder.Append($@"
                parametr.Offset = {parametr.Offset};
");
            }

            if (parametr.HaveTypeName)
            {
                builder.Append($@"
                parametr.TypeName = ""{parametr.TypeName}"";
");
            }

            if (parametr.HaveUdtTypeName)
            {
                builder.Append($@"
                parametr.UdtTypeName = ""{parametr.TypeName}"";
");
            }

            if (parametr.HaveXmlSchemaCollectionDatabase)
            {
                builder.Append($@"
                parametr.XmlSchemaCollectionDatabase = ""{parametr.XmlSchemaCollectionDatabase}"";
");
            }

            if (parametr.HaveXmlSchemaCollectionName)
            {
                builder.Append($@"
                parametr.XmlSchemaCollectionName = ""{parametr.XmlSchemaCollectionName}"";
");
            }

            if (parametr.HaveXmlSchemaCollectionOwningSchema)
            {
                builder.Append($@"
                parametr.XmlSchemaCollectionOwningSchema = ""{parametr.XmlSchemaCollectionOwningSchema}"";
");
            }

            builder.Append($@"
                command.Parameters.Add(parametr);
");
        }
    }
}
