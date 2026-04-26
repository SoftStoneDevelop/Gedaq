

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
    internal partial class NpgsqlPolygonArraypolygonArray
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqlpolygonpolygonarray1mi
(
    id integer NOT NULL,
    value polygon[] NOT NULL,
    nullablevalue polygon[],
    CONSTRAINT npgsqlpolygonpolygonarray1mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlpolygonpolygonarray1mi
(
    id integer NOT NULL,
    value polygon[] NOT NULL,
    nullablevalue polygon[],
    CONSTRAINT binary_npgsqlpolygonpolygonarray1mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlpolygonpolygonarray1mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlpolygonpolygonarray1mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqlpolygonpolygonarray1m
(
    id integer NOT NULL,
    value polygon[] NOT NULL,
    nullablevalue polygon[],
    npgsqlpolygonpolygonarray1mi_id integer,
    CONSTRAINT npgsqlpolygonpolygonarray1m_pkey PRIMARY KEY (id),
    CONSTRAINT npgsqlpolygonpolygonarray1m_npgsqlpolygonpolygonarray1mi_fk FOREIGN KEY (npgsqlpolygonpolygonarray1mi_id)
        REFERENCES public.npgsqlpolygonpolygonarray1mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlpolygonpolygonarray1m
(
    id integer NOT NULL,
    value polygon[] NOT NULL,
    nullablevalue polygon[],
    npgsqlpolygonpolygonarray1mi_id integer,
    CONSTRAINT binary_npgsqlpolygonpolygonarray1m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_npgsqlpolygonpolygonarray1m_binary_npgsqlpolygonpolygonarray1mi_fk FOREIGN KEY (npgsqlpolygonpolygonarray1mi_id)
        REFERENCES public.binary_npgsqlpolygonpolygonarray1mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlpolygonpolygonarray1m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlpolygonpolygonarray1m;
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

