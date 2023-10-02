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
            if(parametr.HaveNameInCommand && parametr.HaveNpgSqlDbType)
            {
                builder.Append($@"
                var parametr = new NpgsqlParameter(""{parametr.NameInCommand}"", ({NpgsqlMapTypeHelper.NpgsqlDbTypeName})({parametr.NpgSqlDbType}));
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
                var parametr = new NpgsqlParameter();
");
            SetParametrs(
                parametr,
                builder,
                parametr.HaveNpgSqlDbType,
                parametr.HaveNameInCommand,
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
            if (parametr.HaveNameInCommand && parametr.HaveNpgSqlDbType)
            {
                builder.Append($@"
                var parametr = new NpgsqlParameter<{parametr.Type.GetFullTypeName()}>(""{parametr.NameInCommand}"", ({NpgsqlMapTypeHelper.NpgsqlDbTypeName}){parametr.NpgSqlDbType});
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
                var parametr = new NpgsqlParameter<{parametr.Type.GetFullTypeName()}>();
");
            SetParametrs(
                parametr,
                builder,
                parametr.HaveNpgSqlDbType,
                parametr.HaveNameInCommand,
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
            bool setSourceColumn,
            bool setSourceColumnNullMapping,
            bool setSourceVersion,
            bool setScale,
            bool setPrecision
            )
        {
            if (setNpgSqlDbType)
            {
                builder.Append($@"
                parametr.NpgsqlDbType = ({NpgsqlMapTypeHelper.NpgsqlDbTypeName})({parametr.NpgSqlDbType});
");
            }

            if (setHaveName)
            {
                builder.Append($@"
                parametr.ParameterName = ""{parametr.NameInCommand}"";
");
            }

            if (setHaveSize)
            {
                builder.Append($@"
                parametr.Size = {parametr.Size};
");
            }

            if (setNullable)
            {
                builder.Append($@"
                parametr.IsNullable = true;
");
            }

            if (setDirection)
            {
                builder.Append($@"
                parametr.Direction = System.Data.ParameterDirection.{parametr.Direction.ToString()};
");
            }

            if (setSourceColumn)
            {
                builder.Append($@"
                parametr.SourceColumn = ""{parametr.SourceColumn}"";
");
            }

            if (setSourceColumnNullMapping)
            {
                builder.Append($@"
                parametr.SourceColumnNullMapping = true;
");
            }

            if (setSourceVersion)
            {
                builder.Append($@"
                parametr.SourceVersion = System.Data.DataRowVersion.{parametr.SourceVersion.ToString()};
");
            }

            if (setScale)
            {
                builder.Append($@"
                parametr.Scale = {parametr.Scale};
");
            }

            if (setPrecision)
            {
                builder.Append($@"
                parametr.Precision = {parametr.Precision};
");
            }
        }

        public static void CreateParametr(BaseParametr baseParametr, StringBuilder builder)
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
                command.Parameters.Add(parametr);
");
        }
    }
}