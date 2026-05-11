

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
    internal partial class DecimalMArraymoneyMArrayD1
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.decimalmoneymarrayd11mi
(
    id integer NOT NULL,
    value money[] NOT NULL,
    nullablevalue money[],
    CONSTRAINT decimalmoneymarrayd11mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_decimalmoneymarrayd11mi
(
    id integer NOT NULL,
    value money[] NOT NULL,
    nullablevalue money[],
    CONSTRAINT binary_decimalmoneymarrayd11mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.decimalmoneymarrayd11mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_decimalmoneymarrayd11mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.decimalmoneymarrayd1e1m
(
    id integer NOT NULL,
    value money[] NOT NULL,
    nullablevalue money[],
    decimalmoneymarrayd11mi_id integer,
    CONSTRAINT decimalmoneymarrayd1e1m_pkey PRIMARY KEY (id),
    CONSTRAINT decimalmoneymarrayd1e1m_decimalmoneymarrayd11mi_fk FOREIGN KEY (decimalmoneymarrayd11mi_id)
        REFERENCES public.decimalmoneymarrayd11mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_decimalmoneymarrayd1e1m
(
    id integer NOT NULL,
    value money[] NOT NULL,
    nullablevalue money[],
    decimalmoneymarrayd11mi_id integer,
    CONSTRAINT binary_decimalmoneymarrayd1e1m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_decimalmoneymarrayd1e1m_binary_decimalmoneymarrayd11mi_fk FOREIGN KEY (decimalmoneymarrayd11mi_id)
        REFERENCES public.binary_decimalmoneymarrayd11mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.decimalmoneymarrayd1e1m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_decimalmoneymarrayd1e1m;
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

