

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
    internal partial class NpgsqlLineListlineListD1
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqllinelinelistd12mi
(
    id integer NOT NULL,
    value line[] NOT NULL,
    nullablevalue line[],
    CONSTRAINT npgsqllinelinelistd12mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqllinelinelistd12mi
(
    id integer NOT NULL,
    value line[] NOT NULL,
    nullablevalue line[],
    CONSTRAINT binary_npgsqllinelinelistd12mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqllinelinelistd12mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqllinelinelistd12mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqllinelinelistd1e2m
(
    id integer NOT NULL,
    value line[] NOT NULL,
    nullablevalue line[],
    npgsqllinelinelistd12mi_id integer,
    CONSTRAINT npgsqllinelinelistd1e2m_pkey PRIMARY KEY (id),
    CONSTRAINT npgsqllinelinelistd1e2m_npgsqllinelinelistd12mi_fk FOREIGN KEY (npgsqllinelinelistd12mi_id)
        REFERENCES public.npgsqllinelinelistd12mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqllinelinelistd1e2m
(
    id integer NOT NULL,
    value line[] NOT NULL,
    nullablevalue line[],
    npgsqllinelinelistd12mi_id integer,
    CONSTRAINT binary_npgsqllinelinelistd1e2m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_npgsqllinelinelistd1e2m_binary_npgsqllinelinelistd12mi_fk FOREIGN KEY (npgsqllinelinelistd12mi_id)
        REFERENCES public.binary_npgsqllinelinelistd12mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqllinelinelistd1e2m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqllinelinelistd1e2m;
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

