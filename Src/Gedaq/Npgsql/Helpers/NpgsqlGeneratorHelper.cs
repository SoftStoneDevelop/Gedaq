using Gedaq.Base.Model;
using Gedaq.Helpers;
using Gedaq.Npgsql.Model;
using System.Reflection;
using System.Text;

namespace Gedaq.Npgsql.Helpers
{
    internal static class NpgsqlGeneratorHelper
    {
        private static void CreateNullableParametr(NpgsqlParametr parametr, StringBuilder builder)
        {
            if(parametr.HaveName && parametr.HaveNpgSqlDbType)
            {
                builder.Append($@"
                var parametr{parametr.Position} = new NpgsqlParameter(""{parametr.Name}"", ({NpgsqlMapTypeHelper.NpgsqlDbTypeName}){parametr.NpgSqlDbType});
");
                SetParametrs(
                    parametr,
                    builder,
                    false,
                    false,
                    parametr.HaveSize,
                    parametr.Nullable,
                    parametr.HaveDirection,
                    parametr.HaveSourceColumn,
                    parametr.HaveSourceColumnNullMapping,
                    parametr.HaveSourceVersion,
                    parametr.HaveScale,
                    parametr.HavePrecision
                    );
                return;
            }

            builder.Append($@"
                var parametr{parametr.Position} = new NpgsqlParameter();
");
            SetParametrs(
                parametr,
                builder,
                parametr.HaveName,
                parametr.HaveNpgSqlDbType,
                parametr.HaveSize,
                parametr.Nullable,
                parametr.HaveDirection,
                parametr.HaveSourceColumn,
                parametr.HaveSourceColumnNullMapping,
                parametr.HaveSourceVersion,
                parametr.HaveScale,
                parametr.HavePrecision
                );
        }

        private static void CreateValueParametr(NpgsqlParametr parametr, StringBuilder builder)
        {
            if (parametr.HaveName && parametr.HaveNpgSqlDbType)
            {
                builder.Append($@"
                var parametr{parametr.Position} = new NpgsqlParameter<{parametr.Type.GetFullTypeName()}>(""{parametr.Name}"", ({NpgsqlMapTypeHelper.NpgsqlDbTypeName}){parametr.NpgSqlDbType});
");
                SetParametrs(
                    parametr,
                    builder, 
                    false,
                    false,
                    parametr.HaveSize,
                    parametr.Nullable,
                    parametr.HaveDirection,
                    parametr.HaveSourceColumn,
                    parametr.HaveSourceColumnNullMapping,
                    parametr.HaveSourceVersion,
                    parametr.HaveScale,
                    parametr.HavePrecision
                    );
                return;
            }

            builder.Append($@"
                var parametr{parametr.Position} = new NpgsqlParameter<{parametr.Type.GetFullTypeName()}>();
");
            SetParametrs(
                parametr,
                builder,
                parametr.HaveName,
                parametr.HaveNpgSqlDbType,
                parametr.HaveSize,
                parametr.Nullable,
                parametr.HaveDirection,
                parametr.HaveSourceColumn,
                parametr.HaveSourceColumnNullMapping,
                parametr.HaveSourceVersion,
                parametr.HaveScale,
                parametr.HavePrecision
                );
        }

        private static void SetParametrs(
            NpgsqlParametr parametr,
            StringBuilder builder,
            bool setNpgSqlDbType,
            bool setHaveName,
            bool setHaveSize,
            bool setNullable,
            bool setDirection,
            bool haveSourceColumn,
            bool haveSourceColumnNullMapping,
            bool haveSourceVersion,
            bool haveScale,
            bool havePrecision
            )
        {
            if (setNpgSqlDbType)
            {
                builder.Append($@"
                parametr{parametr.Position}.NpgsqlDbType = ({NpgsqlMapTypeHelper.NpgsqlDbTypeName}){parametr.NpgSqlDbType};
");
            }

            if (setHaveName)
            {
                builder.Append($@"
                parametr{parametr.Position}.ParameterName = ""{parametr.Name}"";
");
            }

            if (setHaveSize)
            {
                builder.Append($@"
                parametr{parametr.Position}.Size = {parametr.Size};
");
            }

            if (setNullable)
            {
                builder.Append($@"
                parametr{parametr.Position}.IsNullable = true;
");
            }

            if (setDirection)
            {
                builder.Append($@"
                parametr{parametr.Position}.Direction = System.Data.ParameterDirection.{parametr.Direction.ToString()};
");
            }

            if (haveSourceColumn)
            {
                builder.Append($@"
                parametr{parametr.Position}.SourceColumn = ""{parametr.SourceColumn}"";
");
            }

            if (haveSourceColumnNullMapping)
            {
                builder.Append($@"
                parametr{parametr.Position}.SourceColumnNullMapping = true;
");
            }

            if (haveSourceVersion)
            {
                builder.Append($@"
                parametr{parametr.Position}.SourceVersion = System.Data.DataRowVersion.{parametr.SourceVersion.ToString()};
");
            }

            if (haveScale)
            {
                builder.Append($@"
                parametr{parametr.Position}.Scale = {parametr.Scale};
");
            }

            if (havePrecision)
            {
                builder.Append($@"
                parametr{parametr.Position}.Precision = {parametr.Precision};
");
            }
        }

        public static void CreateParametr(BaseParametr baseParametr, int index, StringBuilder builder)
        {
            var parametr = (NpgsqlParametr)baseParametr;
            if (parametr.Type.IsNullableType())
            {
                CreateNullableParametr(parametr, builder);
            }
            else
            {
                CreateValueParametr(parametr, builder);
            }

            builder.Append($@"
                command.Parameters.Add(parametr{parametr.Position});
");
        }
    }
}