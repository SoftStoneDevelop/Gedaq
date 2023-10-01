using Gedaq.Base.Model;
using Gedaq.MySqlConnector.Model;
using System.Text;

namespace Gedaq.MySqlConnector.Helpers
{
    internal static class MySqlConnectorGeneratorHelper
    {
        public static void CreateParametr(BaseParametr baseParametr, StringBuilder builder)
        {
            var parametr = (MySqlConnectorParametr)baseParametr;

            builder.Append($@"
            var parametr = command.CreateParameter();
");

            if (parametr.HaveMySqlDbType)
            {
                builder.Append($@"
                parametr.MySqlDbType = (MySqlConnector.MySqlDbType)({parametr.MySqlDbType});
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

            builder.Append($@"
                command.Parameters.Add(parametr);
");
        }
    }
}