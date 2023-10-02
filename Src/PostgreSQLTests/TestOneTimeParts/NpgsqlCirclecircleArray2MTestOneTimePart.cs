

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
    internal partial class NpgsqlCircleListcircleArray
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqlcirclecirclearray2mi
(
    id integer NOT NULL,
    value circle[] NOT NULL,
    nullablevalue circle[],
    CONSTRAINT npgsqlcirclecirclearray2mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlcirclecirclearray2mi
(
    id integer NOT NULL,
    value circle[] NOT NULL,
    nullablevalue circle[],
    CONSTRAINT binary_npgsqlcirclecirclearray2mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlcirclecirclearray2mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlcirclecirclearray2mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqlcirclecirclearray2m
(
    id integer NOT NULL,
    value circle[] NOT NULL,
    nullablevalue circle[],
    npgsqlcirclecirclearray2mi_id integer,
    CONSTRAINT npgsqlcirclecirclearray2m_pkey PRIMARY KEY (id),
    CONSTRAINT npgsqlcirclecirclearray2m_npgsqlcirclecirclearray2mi_fk FOREIGN KEY (npgsqlcirclecirclearray2mi_id)
        REFERENCES public.npgsqlcirclecirclearray2mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlcirclecirclearray2m
(
    id integer NOT NULL,
    value circle[] NOT NULL,
    nullablevalue circle[],
    npgsqlcirclecirclearray2mi_id integer,
    CONSTRAINT binary_npgsqlcirclecirclearray2m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_npgsqlcirclecirclearray2m_binary_npgsqlcirclecirclearray2mi_fk FOREIGN KEY (npgsqlcirclecirclearray2mi_id)
        REFERENCES public.binary_npgsqlcirclecirclearray2mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlcirclecirclearray2m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlcirclecirclearray2m;
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

