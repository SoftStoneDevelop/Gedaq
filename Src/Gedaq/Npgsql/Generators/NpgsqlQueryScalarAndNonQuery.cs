﻿using Gedaq.Base;
using Gedaq.Base.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Enums;
using Gedaq.Npgsql.Helpers;
using Gedaq.Npgsql.Model;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.Npgsql.Generators
{
    internal class NpgsqlQueryScalarAndNonQuery : QueryScalarNonQueryBase
    {
        private readonly NpgsqlQueryCommon _queryCommon = new NpgsqlQueryCommon();
        protected override QueryCommonBase QueryCommon => _queryCommon;

        protected override void NonQueryMethod(QueryBase source, StringBuilder builder)
        {
            var npgsqlQuery = (QueryReadNpgsql)source;
            if (npgsqlQuery.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                StartNonQueryMethod(source, MethodType.Sync, builder);
                QueryMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(), Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), builder);
                EndMethodParametrs(builder);
                MethodBody(source, true, Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), MethodType.Sync, QueryType.NonQuery, builder);
                EndMethod(builder);
            }

            if (npgsqlQuery.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                StartNonQueryMethod(source, MethodType.Sync, builder);
                QueryMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(), Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), builder);
                EndMethodParametrs(builder);
                MethodBody(source, false, Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), MethodType.Sync, QueryType.NonQuery, builder);
                EndMethod(builder);
            }
        }

        protected override void NonQueryMethodAsync(QueryBase source, StringBuilder builder)
        {
            var npgsqlQuery = (QueryReadNpgsql)source;
            if (npgsqlQuery.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                StartNonQueryMethod(source, MethodType.Async, builder);
                QueryMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(), Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), builder);
                AsyncEndMethodParametrs(builder);
                MethodBody(source, true, Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), MethodType.Async, QueryType.NonQuery, builder);
                EndMethod(builder);
            }

            if (npgsqlQuery.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                StartNonQueryMethod(source, MethodType.Async, builder);
                QueryMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(), Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), builder);
                AsyncEndMethodParametrs(builder);
                MethodBody(source, false, Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), MethodType.Async, QueryType.NonQuery, builder);
                EndMethod(builder);
            }
        }

        protected override void ScalarMethod(QueryBase source, StringBuilder builder)
        {
            var npgsqlQuery = (QueryReadNpgsql)source;
            if (npgsqlQuery.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                StartScalarMethod(source, MethodType.Sync, builder);
                QueryMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(), Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), builder);
                EndMethodParametrs(builder);
                MethodBody(source, true, Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), MethodType.Sync, QueryType.Scalar, builder);
                EndMethod(builder);
            }

            if (npgsqlQuery.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                StartScalarMethod(source, MethodType.Sync, builder);
                QueryMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(), Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), builder);
                EndMethodParametrs(builder);
                MethodBody(source, false, Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), MethodType.Sync, QueryType.Scalar, builder);
                EndMethod(builder);
            }
        }

        protected override void ScalarMethodAsync(QueryBase source, StringBuilder builder)
        {
            var npgsqlQuery = (QueryReadNpgsql)source;
            if (npgsqlQuery.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                StartScalarMethod(source, MethodType.Async, builder);
                QueryMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(), Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), builder);
                AsyncEndMethodParametrs(builder);
                MethodBody(source, true, Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), MethodType.Async, QueryType.Scalar, builder);
                EndMethod(builder);
            }

            if (npgsqlQuery.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                StartScalarMethod(source, MethodType.Async, builder);
                QueryMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(), Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), builder);
                AsyncEndMethodParametrs(builder);
                MethodBody(source, false, Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), MethodType.Async, QueryType.Scalar, builder);
                EndMethod(builder);
            }
        }
    }
}