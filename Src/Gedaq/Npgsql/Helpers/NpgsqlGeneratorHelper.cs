using Gedaq.Base.Model;
using Gedaq.Helpers;
using Gedaq.Npgsql.Model;
using System.Text;

namespace Gedaq.Npgsql.Helpers
{
    internal static class NpgsqlGeneratorHelper
    {
        public static void CreateParametr(BaseParametr baseParametr, int index, StringBuilder builder)
        {
            var parametr = (NpgsqlParametr)baseParametr;
            if (parametr.Type.IsNullableType())
            {
                builder.Append($@"
                var parametr{parametr.Position} = new NpgsqlParameter();
");
            }
            else
            {
                builder.Append($@"
                var parametr{parametr.Position} = new NpgsqlParameter<{parametr.Type.GetFullTypeName()}>();
");
            }

            if (parametr.HaveNpgSqlDbType)
            {
                builder.Append($@"
                parametr{parametr.Position}.NpgsqlDbType = ({NpgsqlMapTypeHelper.NpgsqlDbTypeName}){parametr.NpgSqlDbType};
");
            }

            if (parametr.HaveName)
            {
                builder.Append($@"
                parametr{parametr.Position}.ParameterName = ""{parametr.Name}"";
");
            }

            if (parametr.HaveSize)
            {
                builder.Append($@"
                parametr{parametr.Position}.Size = {parametr.Size};
");
            }

            if (parametr.Nullable)
            {
                builder.Append($@"
                parametr{parametr.Position}.IsNullable = true;
");
            }

            if (parametr.Direction != System.Data.ParameterDirection.Input)
            {
                builder.Append($@"
                parametr{parametr.Position}.Direction = System.Data.ParameterDirection.{parametr.Direction.ToString()};
");
            }

            builder.Append($@"
                command.Parameters.Add(parametr{parametr.Position});
");
        }
    }
}