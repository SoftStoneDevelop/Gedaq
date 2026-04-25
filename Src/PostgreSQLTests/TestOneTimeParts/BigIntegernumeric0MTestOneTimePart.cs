

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
    internal partial class BigIntegerSingleTypenumeric
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.bigintegernumeric0mi
(
    id integer NOT NULL,
    value numeric NOT NULL,
    nullablevalue numeric,
    CONSTRAINT bigintegernumeric0mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_bigintegernumeric0mi
(
    id integer NOT NULL,
    value numeric NOT NULL,
    nullablevalue numeric,
    CONSTRAINT binary_bigintegernumeric0mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.bigintegernumeric0mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_bigintegernumeric0mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.bigintegernumeric0m
(
    id integer NOT NULL,
    value numeric NOT NULL,
    nullablevalue numeric,
    bigintegernumeric0mi_id integer,
    CONSTRAINT bigintegernumeric0m_pkey PRIMARY KEY (id),
    CONSTRAINT bigintegernumeric0m_bigintegernumeric0mi_fk FOREIGN KEY (bigintegernumeric0mi_id)
        REFERENCES public.bigintegernumeric0mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_bigintegernumeric0m
(
    id integer NOT NULL,
    value numeric NOT NULL,
    nullablevalue numeric,
    bigintegernumeric0mi_id integer,
    CONSTRAINT binary_bigintegernumeric0m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_bigintegernumeric0m_binary_bigintegernumeric0mi_fk FOREIGN KEY (bigintegernumeric0mi_id)
        REFERENCES public.binary_bigintegernumeric0mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.bigintegernumeric0m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_bigintegernumeric0m;
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

