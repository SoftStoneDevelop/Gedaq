

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
    internal partial class NpgsqlBoxMArrayboxMArrayD1
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqlboxboxmarrayd11mi
(
    id integer NOT NULL,
    value box[] NOT NULL,
    nullablevalue box[],
    CONSTRAINT npgsqlboxboxmarrayd11mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlboxboxmarrayd11mi
(
    id integer NOT NULL,
    value box[] NOT NULL,
    nullablevalue box[],
    CONSTRAINT binary_npgsqlboxboxmarrayd11mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlboxboxmarrayd11mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlboxboxmarrayd11mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqlboxboxmarrayd1e1m
(
    id integer NOT NULL,
    value box[] NOT NULL,
    nullablevalue box[],
    npgsqlboxboxmarrayd11mi_id integer,
    CONSTRAINT npgsqlboxboxmarrayd1e1m_pkey PRIMARY KEY (id),
    CONSTRAINT npgsqlboxboxmarrayd1e1m_npgsqlboxboxmarrayd11mi_fk FOREIGN KEY (npgsqlboxboxmarrayd11mi_id)
        REFERENCES public.npgsqlboxboxmarrayd11mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlboxboxmarrayd1e1m
(
    id integer NOT NULL,
    value box[] NOT NULL,
    nullablevalue box[],
    npgsqlboxboxmarrayd11mi_id integer,
    CONSTRAINT binary_npgsqlboxboxmarrayd1e1m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_npgsqlboxboxmarrayd1e1m_binary_npgsqlboxboxmarrayd11mi_fk FOREIGN KEY (npgsqlboxboxmarrayd11mi_id)
        REFERENCES public.binary_npgsqlboxboxmarrayd11mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlboxboxmarrayd1e1m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlboxboxmarrayd1e1m;
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

