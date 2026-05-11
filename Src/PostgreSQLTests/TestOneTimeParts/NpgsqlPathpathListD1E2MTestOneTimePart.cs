

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
    internal partial class NpgsqlPathListpathListD1
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqlpathpathlistd1e2mi
(
    id integer NOT NULL,
    value path[] NOT NULL,
    nullablevalue path[],
    CONSTRAINT npgsqlpathpathlistd1e2mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlpathpathlistd1e2mi
(
    id integer NOT NULL,
    value path[] NOT NULL,
    nullablevalue path[],
    CONSTRAINT binary_npgsqlpathpathlistd1e2mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlpathpathlistd1e2mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlpathpathlistd1e2mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqlpathpathlistd1e2m
(
    id integer NOT NULL,
    value path[] NOT NULL,
    nullablevalue path[],
    npgsqlpathpathlistd1e2mi_id integer,
    CONSTRAINT npgsqlpathpathlistd1e2m_pkey PRIMARY KEY (id),
    CONSTRAINT npgsqlpathpathlistd1e2m_npgsqlpathpathlistd1e2mi_fk FOREIGN KEY (npgsqlpathpathlistd1e2mi_id)
        REFERENCES public.npgsqlpathpathlistd1e2mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlpathpathlistd1e2m
(
    id integer NOT NULL,
    value path[] NOT NULL,
    nullablevalue path[],
    npgsqlpathpathlistd1e2mi_id integer,
    CONSTRAINT binary_npgsqlpathpathlistd1e2m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_npgsqlpathpathlistd1e2m_binary_npgsqlpathpathlistd1e2mi_fk FOREIGN KEY (npgsqlpathpathlistd1e2mi_id)
        REFERENCES public.binary_npgsqlpathpathlistd1e2mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlpathpathlistd1e2m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlpathpathlistd1e2m;
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

