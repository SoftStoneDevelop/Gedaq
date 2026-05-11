

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
    internal partial class BigIntegerMArraynumericMArrayD1
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.bigintegernumericmarrayd11mi
(
    id integer NOT NULL,
    value numeric[] NOT NULL,
    nullablevalue numeric[],
    CONSTRAINT bigintegernumericmarrayd11mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_bigintegernumericmarrayd11mi
(
    id integer NOT NULL,
    value numeric[] NOT NULL,
    nullablevalue numeric[],
    CONSTRAINT binary_bigintegernumericmarrayd11mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.bigintegernumericmarrayd11mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_bigintegernumericmarrayd11mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.bigintegernumericmarrayd1e1m
(
    id integer NOT NULL,
    value numeric[] NOT NULL,
    nullablevalue numeric[],
    bigintegernumericmarrayd11mi_id integer,
    CONSTRAINT bigintegernumericmarrayd1e1m_pkey PRIMARY KEY (id),
    CONSTRAINT bigintegernumericmarrayd1e1m_bigintegernumericmarrayd11mi_fk FOREIGN KEY (bigintegernumericmarrayd11mi_id)
        REFERENCES public.bigintegernumericmarrayd11mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_bigintegernumericmarrayd1e1m
(
    id integer NOT NULL,
    value numeric[] NOT NULL,
    nullablevalue numeric[],
    bigintegernumericmarrayd11mi_id integer,
    CONSTRAINT binary_bigintegernumericmarrayd1e1m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_bigintegernumericmarrayd1e1m_binary_bigintegernumericmarrayd11mi_fk FOREIGN KEY (bigintegernumericmarrayd11mi_id)
        REFERENCES public.binary_bigintegernumericmarrayd11mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.bigintegernumericmarrayd1e1m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_bigintegernumericmarrayd1e1m;
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

