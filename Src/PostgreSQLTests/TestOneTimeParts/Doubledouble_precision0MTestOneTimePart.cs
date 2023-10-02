

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
    internal partial class DoubleSingleTypedouble_precision
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.doubledouble_precision0mi
(
    id integer NOT NULL,
    value double precision NOT NULL,
    nullablevalue double precision,
    CONSTRAINT doubledouble_precision0mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_doubledouble_precision0mi
(
    id integer NOT NULL,
    value double precision NOT NULL,
    nullablevalue double precision,
    CONSTRAINT binary_doubledouble_precision0mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.doubledouble_precision0mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_doubledouble_precision0mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.doubledouble_precision0m
(
    id integer NOT NULL,
    value double precision NOT NULL,
    nullablevalue double precision,
    doubledouble_precision0mi_id integer,
    CONSTRAINT doubledouble_precision0m_pkey PRIMARY KEY (id),
    CONSTRAINT doubledouble_precision0m_doubledouble_precision0mi_fk FOREIGN KEY (doubledouble_precision0mi_id)
        REFERENCES public.doubledouble_precision0mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_doubledouble_precision0m
(
    id integer NOT NULL,
    value double precision NOT NULL,
    nullablevalue double precision,
    doubledouble_precision0mi_id integer,
    CONSTRAINT binary_doubledouble_precision0m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_doubledouble_precision0m_binary_doubledouble_precision0mi_fk FOREIGN KEY (doubledouble_precision0mi_id)
        REFERENCES public.binary_doubledouble_precision0mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.doubledouble_precision0m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_doubledouble_precision0m;
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

