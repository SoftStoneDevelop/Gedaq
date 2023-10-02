

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
    internal partial class BooleanListbooleanArray
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.booleanbooleanarray2mi
(
    id integer NOT NULL,
    value boolean[] NOT NULL,
    nullablevalue boolean[],
    CONSTRAINT booleanbooleanarray2mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_booleanbooleanarray2mi
(
    id integer NOT NULL,
    value boolean[] NOT NULL,
    nullablevalue boolean[],
    CONSTRAINT binary_booleanbooleanarray2mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.booleanbooleanarray2mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_booleanbooleanarray2mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.booleanbooleanarray2m
(
    id integer NOT NULL,
    value boolean[] NOT NULL,
    nullablevalue boolean[],
    booleanbooleanarray2mi_id integer,
    CONSTRAINT booleanbooleanarray2m_pkey PRIMARY KEY (id),
    CONSTRAINT booleanbooleanarray2m_booleanbooleanarray2mi_fk FOREIGN KEY (booleanbooleanarray2mi_id)
        REFERENCES public.booleanbooleanarray2mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_booleanbooleanarray2m
(
    id integer NOT NULL,
    value boolean[] NOT NULL,
    nullablevalue boolean[],
    booleanbooleanarray2mi_id integer,
    CONSTRAINT binary_booleanbooleanarray2m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_booleanbooleanarray2m_binary_booleanbooleanarray2mi_fk FOREIGN KEY (booleanbooleanarray2mi_id)
        REFERENCES public.binary_booleanbooleanarray2mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.booleanbooleanarray2m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_booleanbooleanarray2m;
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

