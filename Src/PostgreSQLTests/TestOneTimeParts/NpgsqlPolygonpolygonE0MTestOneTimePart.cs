

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
CREATE TABLE public.npgsqlpolygonpolygon0mi
(
    id integer NOT NULL,
    value polygon NOT NULL,
    nullablevalue polygon,
    CONSTRAINT npgsqlpolygonpolygon0mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlpolygonpolygon0mi
(
    id integer NOT NULL,
    value polygon NOT NULL,
    nullablevalue polygon,
    CONSTRAINT binary_npgsqlpolygonpolygon0mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlpolygonpolygon0mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlpolygonpolygon0mi;
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
    npgsqlpolygonpolygon0mi_id integer,
    CONSTRAINT npgsqlpolygonpolygone0m_pkey PRIMARY KEY (id),
    CONSTRAINT npgsqlpolygonpolygone0m_npgsqlpolygonpolygon0mi_fk FOREIGN KEY (npgsqlpolygonpolygon0mi_id)
        REFERENCES public.npgsqlpolygonpolygon0mi (id) MATCH SIMPLE
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
    npgsqlpolygonpolygon0mi_id integer,
    CONSTRAINT binary_npgsqlpolygonpolygone0m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_npgsqlpolygonpolygone0m_binary_npgsqlpolygonpolygon0mi_fk FOREIGN KEY (npgsqlpolygonpolygon0mi_id)
        REFERENCES public.binary_npgsqlpolygonpolygon0mi (id) MATCH SIMPLE
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

