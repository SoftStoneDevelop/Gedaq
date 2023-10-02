

using Npgsql;
using NpgsqlTypes;
using Gedaq.Common.Enums;
using Gedaq.Npgsql.Attributes;
using Gedaq.Npgsql.Enums;
using System;


using NUnit.Framework;
using System.Data.Common;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    internal partial class Int64ArraybigintArray
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.int64bigintarray1mi
(
    id integer NOT NULL,
    value bigint[] NOT NULL,
    nullablevalue bigint[],
    CONSTRAINT int64bigintarray1mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_int64bigintarray1mi
(
    id integer NOT NULL,
    value bigint[] NOT NULL,
    nullablevalue bigint[],
    CONSTRAINT binary_int64bigintarray1mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.int64bigintarray1mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_int64bigintarray1mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.int64bigintarray1m
(
    id integer NOT NULL,
    value bigint[] NOT NULL,
    nullablevalue bigint[],
    int64bigintarray1mi_id integer,
    CONSTRAINT int64bigintarray1m_pkey PRIMARY KEY (id),
    CONSTRAINT int64bigintarray1m_int64bigintarray1mi_fk FOREIGN KEY (int64bigintarray1mi_id)
        REFERENCES public.int64bigintarray1mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_int64bigintarray1m
(
    id integer NOT NULL,
    value bigint[] NOT NULL,
    nullablevalue bigint[],
    int64bigintarray1mi_id integer,
    CONSTRAINT binary_int64bigintarray1m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_int64bigintarray1m_binary_int64bigintarray1mi_fk FOREIGN KEY (int64bigintarray1mi_id)
        REFERENCES public.binary_int64bigintarray1mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.int64bigintarray1m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_int64bigintarray1m;
";
            await cmd.ExecuteNonQueryAsync();
        }


        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                await using var cmd = connection.CreateCommand();
                await CreateModelInnerTable(cmd);
                await CreateModelTable(cmd);
            }
        }


        [OneTimeTearDown]
        public async Task OneTimeTearDown()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                await using var cmd = connection.CreateCommand();
                await DropModelTable(cmd);
                await DropModelInnerTable(cmd);
            }
        }


    }
}

