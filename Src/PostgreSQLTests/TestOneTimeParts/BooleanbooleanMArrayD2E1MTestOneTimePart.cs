

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
    internal partial class BooleanMArraybooleanMArrayD2
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.booleanbooleanmarrayd21mi
(
    id integer NOT NULL,
    value boolean[][] NOT NULL,
    nullablevalue boolean[][],
    CONSTRAINT booleanbooleanmarrayd21mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_booleanbooleanmarrayd21mi
(
    id integer NOT NULL,
    value boolean[][] NOT NULL,
    nullablevalue boolean[][],
    CONSTRAINT binary_booleanbooleanmarrayd21mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.booleanbooleanmarrayd21mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_booleanbooleanmarrayd21mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.booleanbooleanmarrayd2e1m
(
    id integer NOT NULL,
    value boolean[][] NOT NULL,
    nullablevalue boolean[][],
    booleanbooleanmarrayd21mi_id integer,
    CONSTRAINT booleanbooleanmarrayd2e1m_pkey PRIMARY KEY (id),
    CONSTRAINT booleanbooleanmarrayd2e1m_booleanbooleanmarrayd21mi_fk FOREIGN KEY (booleanbooleanmarrayd21mi_id)
        REFERENCES public.booleanbooleanmarrayd21mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_booleanbooleanmarrayd2e1m
(
    id integer NOT NULL,
    value boolean[][] NOT NULL,
    nullablevalue boolean[][],
    booleanbooleanmarrayd21mi_id integer,
    CONSTRAINT binary_booleanbooleanmarrayd2e1m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_booleanbooleanmarrayd2e1m_binary_booleanbooleanmarrayd21mi_fk FOREIGN KEY (booleanbooleanmarrayd21mi_id)
        REFERENCES public.binary_booleanbooleanmarrayd21mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.booleanbooleanmarrayd2e1m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_booleanbooleanmarrayd2e1m;
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

