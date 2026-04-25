

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
    internal partial class BooleanArraybooleanArray
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.booleanbooleanarray1mi
(
    id integer NOT NULL,
    value boolean[] NOT NULL,
    nullablevalue boolean[],
    CONSTRAINT booleanbooleanarray1mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_booleanbooleanarray1mi
(
    id integer NOT NULL,
    value boolean[] NOT NULL,
    nullablevalue boolean[],
    CONSTRAINT binary_booleanbooleanarray1mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.booleanbooleanarray1mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_booleanbooleanarray1mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.booleanbooleanarray1m
(
    id integer NOT NULL,
    value boolean[] NOT NULL,
    nullablevalue boolean[],
    booleanbooleanarray1mi_id integer,
    CONSTRAINT booleanbooleanarray1m_pkey PRIMARY KEY (id),
    CONSTRAINT booleanbooleanarray1m_booleanbooleanarray1mi_fk FOREIGN KEY (booleanbooleanarray1mi_id)
        REFERENCES public.booleanbooleanarray1mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_booleanbooleanarray1m
(
    id integer NOT NULL,
    value boolean[] NOT NULL,
    nullablevalue boolean[],
    booleanbooleanarray1mi_id integer,
    CONSTRAINT binary_booleanbooleanarray1m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_booleanbooleanarray1m_binary_booleanbooleanarray1mi_fk FOREIGN KEY (booleanbooleanarray1mi_id)
        REFERENCES public.binary_booleanbooleanarray1mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.booleanbooleanarray1m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_booleanbooleanarray1m;
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

