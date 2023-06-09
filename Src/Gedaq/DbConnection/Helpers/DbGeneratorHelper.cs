using Gedaq.Base.Model;
using Gedaq.DbConnection.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.DbConnection.Helpers
{
    internal static class DbGeneratorHelper
    {
        public static void CreateParametr(BaseParametr baseParametr, int index, StringBuilder builder, bool isBatch = false)
        {
            var parametr = (DbParametr)baseParametr;

            if(isBatch)
            {
                builder.Append($@"
                var parametr{index} = fakeCommand.CreateParameter();
            ");
            }
            else
            {
                builder.Append($@"
            var parametr{index} = command.CreateParameter();
");
            }

            if (parametr.HaveDbType)
            {
                builder.Append($@"
                parametr{index}.DbType = (System.Data.DbType){parametr.DbType};
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

            if (parametr.Nullable)
            {
                builder.Append($@"
                parametr{index}.IsNullable = true;
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

            builder.Append($@"
                command.Parameters.Add(parametr{index});
");
        }
    }
}
