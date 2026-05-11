

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
    internal partial class BooleanListbooleanListD1
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.booleanbooleanlistd1e2mi
(
    id integer NOT NULL,
    value boolean[] NOT NULL,
    nullablevalue boolean[],
    CONSTRAINT booleanbooleanlistd1e2mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_booleanbooleanlistd1e2mi
(
    id integer NOT NULL,
    value boolean[] NOT NULL,
    nullablevalue boolean[],
    CONSTRAINT binary_booleanbooleanlistd1e2mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.booleanbooleanlistd1e2mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_booleanbooleanlistd1e2mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.booleanbooleanlistd1e2m
(
    id integer NOT NULL,
    value boolean[] NOT NULL,
    nullablevalue boolean[],
    booleanbooleanlistd1e2mi_id integer,
    CONSTRAINT booleanbooleanlistd1e2m_pkey PRIMARY KEY (id),
    CONSTRAINT booleanbooleanlistd1e2m_booleanbooleanlistd1e2mi_fk FOREIGN KEY (booleanbooleanlistd1e2mi_id)
        REFERENCES public.booleanbooleanlistd1e2mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_booleanbooleanlistd1e2m
(
    id integer NOT NULL,
    value boolean[] NOT NULL,
    nullablevalue boolean[],
    booleanbooleanlistd1e2mi_id integer,
    CONSTRAINT binary_booleanbooleanlistd1e2m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_booleanbooleanlistd1e2m_binary_booleanbooleanlistd1e2mi_fk FOREIGN KEY (booleanbooleanlistd1e2mi_id)
        REFERENCES public.binary_booleanbooleanlistd1e2mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.booleanbooleanlistd1e2m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_booleanbooleanlistd1e2m;
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

