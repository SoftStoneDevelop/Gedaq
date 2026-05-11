

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
    internal partial class NpgsqlPolygonSingleTypepolygon
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqlpolygonpolygone0mi
(
    id integer NOT NULL,
    value polygon NOT NULL,
    nullablevalue polygon,
    CONSTRAINT npgsqlpolygonpolygone0mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlpolygonpolygone0mi
(
    id integer NOT NULL,
    value polygon NOT NULL,
    nullablevalue polygon,
    CONSTRAINT binary_npgsqlpolygonpolygone0mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlpolygonpolygone0mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlpolygonpolygone0mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqlpolygonpolygone0m
(
    id integer NOT NULL,
    value polygon NOT NULL,
    nullablevalue polygon,
    npgsqlpolygonpolygone0mi_id integer,
    CONSTRAINT npgsqlpolygonpolygone0m_pkey PRIMARY KEY (id),
    CONSTRAINT npgsqlpolygonpolygone0m_npgsqlpolygonpolygone0mi_fk FOREIGN KEY (npgsqlpolygonpolygone0mi_id)
        REFERENCES public.npgsqlpolygonpolygone0mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlpolygonpolygone0m
(
    id integer NOT NULL,
    value polygon NOT NULL,
    nullablevalue polygon,
    npgsqlpolygonpolygone0mi_id integer,
    CONSTRAINT binary_npgsqlpolygonpolygone0m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_npgsqlpolygonpolygone0m_binary_npgsqlpolygonpolygone0mi_fk FOREIGN KEY (npgsqlpolygonpolygone0mi_id)
        REFERENCES public.binary_npgsqlpolygonpolygone0mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlpolygonpolygone0m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlpolygonpolygone0m;
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

