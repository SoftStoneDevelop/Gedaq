using Gedaq.DbConnection.Generators;
using Gedaq.DbConnection.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Enums;
using Gedaq.Npgsql.Helpers;
using Gedaq.Npgsql.Model;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gedaq.Npgsql.Generators
{
    internal class NpgsqlQueryRead : QueryReadMethodBase
    {
        protected override string CommandType()
        {
            return "NpgsqlCommand";
        }

        protected override string ReaderType()
        {
            return "NpgsqlDataReader";
        }

        public override string GetParametrValue(BaseParametr parametr, int index, string source)
        {
            if (parametr.Type.IsNullableType())
            {
                return $"((NpgsqlParameter){source}.Parameters[{index}]).Value";
            }
            else
            {
                return $"((NpgsqlParameter<{parametr.Type.GetFullTypeName()}>){source}.Parameters[{index}]).TypedValue";
            }
        }

        protected override void ReadMethod(QueryBase source, StringBuilder builder)
        {
            QueryReadNpgsql npgsqlQuery = (QueryReadNpgsql)source;
            if (npgsqlQuery.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                StartReadMethod(source, MethodType.Sync, builder);
                QueryMethodParametrs(
                    source,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName()
                    );
                EndMethodParametrs(builder);
                ReadMethodBody(source, true, Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), MethodType.Sync, builder);
                EndMethod(builder);
            }

            if (npgsqlQuery.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                StartReadMethod(source, MethodType.Sync, builder);
                QueryMethodParametrs(
                    source,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName()
                    );
                EndMethodParametrs(builder);
                ReadMethodBody(source, false, Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), MethodType.Sync, builder);
                EndMethod(builder);
            }
        }

        protected override void ReadAsyncMethod(QueryBase source, StringBuilder builder)
        {
            QueryReadNpgsql npgsqlQuery = (QueryReadNpgsql)source;
            if (npgsqlQuery.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                StartReadMethod(source, MethodType.Async, builder);
                QueryMethodParametrs(
                    source,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName()
                    );
                AsyncEndMethodParametrs(builder, true);
                ReadMethodBody(source, true, Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), MethodType.Async, builder);
                EndMethod(builder);
            }

            if (npgsqlQuery.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                StartReadMethod(source, MethodType.Async, builder);
                QueryMethodParametrs(
                    source,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName()
                    );
                AsyncEndMethodParametrs(builder, true);
                ReadMethodBody(source, false, Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), MethodType.Async, builder);
                EndMethod(builder);
            }
        }

        public override bool IsKnownProviderType(ITypeSymbol type)
        {
            return MapTypeHelper.IsKnownProviderType(type);
        }
    }
}