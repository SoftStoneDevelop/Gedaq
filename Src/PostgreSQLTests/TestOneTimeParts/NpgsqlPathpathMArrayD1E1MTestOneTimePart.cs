

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
    internal partial class NpgsqlPathMArraypathMArrayD1
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqlpathpathmarrayd11mi
(
    id integer NOT NULL,
    value path[] NOT NULL,
    nullablevalue path[],
    CONSTRAINT npgsqlpathpathmarrayd11mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlpathpathmarrayd11mi
(
    id integer NOT NULL,
    value path[] NOT NULL,
    nullablevalue path[],
    CONSTRAINT binary_npgsqlpathpathmarrayd11mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlpathpathmarrayd11mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlpathpathmarrayd11mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqlpathpathmarrayd1e1m
(
    id integer NOT NULL,
    value path[] NOT NULL,
    nullablevalue path[],
    npgsqlpathpathmarrayd11mi_id integer,
    CONSTRAINT npgsqlpathpathmarrayd1e1m_pkey PRIMARY KEY (id),
    CONSTRAINT npgsqlpathpathmarrayd1e1m_npgsqlpathpathmarrayd11mi_fk FOREIGN KEY (npgsqlpathpathmarrayd11mi_id)
        REFERENCES public.npgsqlpathpathmarrayd11mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlpathpathmarrayd1e1m
(
    id integer NOT NULL,
    value path[] NOT NULL,
    nullablevalue path[],
    npgsqlpathpathmarrayd11mi_id integer,
    CONSTRAINT binary_npgsqlpathpathmarrayd1e1m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_npgsqlpathpathmarrayd1e1m_binary_npgsqlpathpathmarrayd11mi_fk FOREIGN KEY (npgsqlpathpathmarrayd11mi_id)
        REFERENCES public.binary_npgsqlpathpathmarrayd11mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlpathpathmarrayd1e1m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlpathpathmarrayd1e1m;
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

