﻿using Gedaq.Base.Model;
using Gedaq.MySqlConnector.Model;
using System.Text;

namespace Gedaq.MySqlConnector.Helpers
{
    internal static class MySqlConnectorGeneratorHelper
    {
        public static void CreateParametr(BaseParametr baseParametr, int index, StringBuilder builder)
        {
            var parametr = (MySqlConnectorParametr)baseParametr;

            builder.Append($@"
            var parametr{index} = command.CreateParameter();
");

            if (parametr.HaveMySqlDbType)
            {
                builder.Append($@"
                parametr{index}.NpgsqlDbType = (MySqlConnector.MySqlDbType){parametr.MySqlDbType};
");
            }

            if (parametr.HaveName)
            {
                builder.Append($@"
                parametr{index}.ParameterName = ""{parametr.Name}"";
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

            builder.Append($@"
                command.Parameters.Add(parametr{index});
");
        }
    }
}