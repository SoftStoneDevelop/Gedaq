

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
    internal partial class DecimalListmoneyArray
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.decimalmoneyarray2mi
(
    id integer NOT NULL,
    value money[] NOT NULL,
    nullablevalue money[],
    CONSTRAINT decimalmoneyarray2mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_decimalmoneyarray2mi
(
    id integer NOT NULL,
    value money[] NOT NULL,
    nullablevalue money[],
    CONSTRAINT binary_decimalmoneyarray2mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.decimalmoneyarray2mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_decimalmoneyarray2mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.decimalmoneyarray2m
(
    id integer NOT NULL,
    value money[] NOT NULL,
    nullablevalue money[],
    decimalmoneyarray2mi_id integer,
    CONSTRAINT decimalmoneyarray2m_pkey PRIMARY KEY (id),
    CONSTRAINT decimalmoneyarray2m_decimalmoneyarray2mi_fk FOREIGN KEY (decimalmoneyarray2mi_id)
        REFERENCES public.decimalmoneyarray2mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_decimalmoneyarray2m
(
    id integer NOT NULL,
    value money[] NOT NULL,
    nullablevalue money[],
    decimalmoneyarray2mi_id integer,
    CONSTRAINT binary_decimalmoneyarray2m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_decimalmoneyarray2m_binary_decimalmoneyarray2mi_fk FOREIGN KEY (decimalmoneyarray2mi_id)
        REFERENCES public.binary_decimalmoneyarray2mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.decimalmoneyarray2m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_decimalmoneyarray2m;
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

