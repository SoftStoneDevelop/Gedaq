using Gedaq.Base.Model;
using Gedaq.DbConnection.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.DbConnection.Helpers
{
    internal static class DbGeneratorHelper
    {
        public static void CreateParametr(BaseParametr baseParametr, StringBuilder builder, bool isBatch = false)
        {
            var parametr = (DbParametr)baseParametr;

            if(isBatch)
            {
                builder.Append($@"
                var parametr = fakeCommand.CreateParameter();
            ");
            }
            else
            {
                builder.Append($@"
            var parametr = command.CreateParameter();
");
            }

            if (parametr.HaveDbType)
            {
                builder.Append($@"
                parametr.DbType = (System.Data.DbType)({parametr.DbType});
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
