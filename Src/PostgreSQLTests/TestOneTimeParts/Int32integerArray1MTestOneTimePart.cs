

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
    internal partial class Int32ArrayintegerArray
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.int32integerarray1mi
(
    id integer NOT NULL,
    value integer[] NOT NULL,
    nullablevalue integer[],
    CONSTRAINT int32integerarray1mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_int32integerarray1mi
(
    id integer NOT NULL,
    value integer[] NOT NULL,
    nullablevalue integer[],
    CONSTRAINT binary_int32integerarray1mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.int32integerarray1mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_int32integerarray1mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.int32integerarray1m
(
    id integer NOT NULL,
    value integer[] NOT NULL,
    nullablevalue integer[],
    int32integerarray1mi_id integer,
    CONSTRAINT int32integerarray1m_pkey PRIMARY KEY (id),
    CONSTRAINT int32integerarray1m_int32integerarray1mi_fk FOREIGN KEY (int32integerarray1mi_id)
        REFERENCES public.int32integerarray1mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_int32integerarray1m
(
    id integer NOT NULL,
    value integer[] NOT NULL,
    nullablevalue integer[],
    int32integerarray1mi_id integer,
    CONSTRAINT binary_int32integerarray1m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_int32integerarray1m_binary_int32integerarray1mi_fk FOREIGN KEY (int32integerarray1mi_id)
        REFERENCES public.binary_int32integerarray1mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.int32integerarray1m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_int32integerarray1m;
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

