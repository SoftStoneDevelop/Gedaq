

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
    internal partial class NpgsqlCircleListcircleListD1
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqlcirclecirclelistd12mi
(
    id integer NOT NULL,
    value circle[] NOT NULL,
    nullablevalue circle[],
    CONSTRAINT npgsqlcirclecirclelistd12mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlcirclecirclelistd12mi
(
    id integer NOT NULL,
    value circle[] NOT NULL,
    nullablevalue circle[],
    CONSTRAINT binary_npgsqlcirclecirclelistd12mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlcirclecirclelistd12mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlcirclecirclelistd12mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqlcirclecirclelistd1e2m
(
    id integer NOT NULL,
    value circle[] NOT NULL,
    nullablevalue circle[],
    npgsqlcirclecirclelistd12mi_id integer,
    CONSTRAINT npgsqlcirclecirclelistd1e2m_pkey PRIMARY KEY (id),
    CONSTRAINT npgsqlcirclecirclelistd1e2m_npgsqlcirclecirclelistd12mi_fk FOREIGN KEY (npgsqlcirclecirclelistd12mi_id)
        REFERENCES public.npgsqlcirclecirclelistd12mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlcirclecirclelistd1e2m
(
    id integer NOT NULL,
    value circle[] NOT NULL,
    nullablevalue circle[],
    npgsqlcirclecirclelistd12mi_id integer,
    CONSTRAINT binary_npgsqlcirclecirclelistd1e2m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_npgsqlcirclecirclelistd1e2m_binary_npgsqlcirclecirclelistd12mi_fk FOREIGN KEY (npgsqlcirclecirclelistd12mi_id)
        REFERENCES public.binary_npgsqlcirclecirclelistd12mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlcirclecirclelistd1e2m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlcirclecirclelistd1e2m;
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

