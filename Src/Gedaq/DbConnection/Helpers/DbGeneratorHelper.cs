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

            if (parametr.Nullable)
            {
                builder.Append($@"
                parametr
                {index}.IsNullable = true;

                ");
            }

            if (parametr.Direction != System.Data.ParameterDirection.Input)
            {
                builder.Append($@"
                parametr{index}.Direction = System.Data.ParameterDirection.{parametr.Direction.ToString()};
");
            }

            builder.Append($@"
                command.Parameters.Add(parametr{index});
");
        }
    }
}
