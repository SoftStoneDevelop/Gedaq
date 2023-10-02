

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
    internal partial class NpgsqlLineListlineArray
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqllinelinearray2mi
(
    id integer NOT NULL,
    value line[] NOT NULL,
    nullablevalue line[],
    CONSTRAINT npgsqllinelinearray2mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqllinelinearray2mi
(
    id integer NOT NULL,
    value line[] NOT NULL,
    nullablevalue line[],
    CONSTRAINT binary_npgsqllinelinearray2mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqllinelinearray2mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqllinelinearray2mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqllinelinearray2m
(
    id integer NOT NULL,
    value line[] NOT NULL,
    nullablevalue line[],
    npgsqllinelinearray2mi_id integer,
    CONSTRAINT npgsqllinelinearray2m_pkey PRIMARY KEY (id),
    CONSTRAINT npgsqllinelinearray2m_npgsqllinelinearray2mi_fk FOREIGN KEY (npgsqllinelinearray2mi_id)
        REFERENCES public.npgsqllinelinearray2mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqllinelinearray2m
(
    id integer NOT NULL,
    value line[] NOT NULL,
    nullablevalue line[],
    npgsqllinelinearray2mi_id integer,
    CONSTRAINT binary_npgsqllinelinearray2m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_npgsqllinelinearray2m_binary_npgsqllinelinearray2mi_fk FOREIGN KEY (npgsqllinelinearray2mi_id)
        REFERENCES public.binary_npgsqllinelinearray2mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqllinelinearray2m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqllinelinearray2m;
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

