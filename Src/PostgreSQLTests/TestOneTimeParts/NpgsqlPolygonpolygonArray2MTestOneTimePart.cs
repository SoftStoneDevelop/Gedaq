

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
    internal partial class NpgsqlPolygonListpolygonArray
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqlpolygonpolygonarray2mi
(
    id integer NOT NULL,
    value polygon[] NOT NULL,
    nullablevalue polygon[],
    CONSTRAINT npgsqlpolygonpolygonarray2mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlpolygonpolygonarray2mi
(
    id integer NOT NULL,
    value polygon[] NOT NULL,
    nullablevalue polygon[],
    CONSTRAINT binary_npgsqlpolygonpolygonarray2mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlpolygonpolygonarray2mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlpolygonpolygonarray2mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqlpolygonpolygonarray2m
(
    id integer NOT NULL,
    value polygon[] NOT NULL,
    nullablevalue polygon[],
    npgsqlpolygonpolygonarray2mi_id integer,
    CONSTRAINT npgsqlpolygonpolygonarray2m_pkey PRIMARY KEY (id),
    CONSTRAINT npgsqlpolygonpolygonarray2m_npgsqlpolygonpolygonarray2mi_fk FOREIGN KEY (npgsqlpolygonpolygonarray2mi_id)
        REFERENCES public.npgsqlpolygonpolygonarray2mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlpolygonpolygonarray2m
(
    id integer NOT NULL,
    value polygon[] NOT NULL,
    nullablevalue polygon[],
    npgsqlpolygonpolygonarray2mi_id integer,
    CONSTRAINT binary_npgsqlpolygonpolygonarray2m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_npgsqlpolygonpolygonarray2m_binary_npgsqlpolygonpolygonarray2mi_fk FOREIGN KEY (npgsqlpolygonpolygonarray2mi_id)
        REFERENCES public.binary_npgsqlpolygonpolygonarray2mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlpolygonpolygonarray2m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlpolygonpolygonarray2m;
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

