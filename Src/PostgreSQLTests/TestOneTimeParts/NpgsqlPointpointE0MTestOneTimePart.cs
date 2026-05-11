

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
    internal partial class NpgsqlPointSingleTypepoint
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqlpointpointe0mi
(
    id integer NOT NULL,
    value point NOT NULL,
    nullablevalue point,
    CONSTRAINT npgsqlpointpointe0mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlpointpointe0mi
(
    id integer NOT NULL,
    value point NOT NULL,
    nullablevalue point,
    CONSTRAINT binary_npgsqlpointpointe0mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlpointpointe0mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlpointpointe0mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqlpointpointe0m
(
    id integer NOT NULL,
    value point NOT NULL,
    nullablevalue point,
    npgsqlpointpointe0mi_id integer,
    CONSTRAINT npgsqlpointpointe0m_pkey PRIMARY KEY (id),
    CONSTRAINT npgsqlpointpointe0m_npgsqlpointpointe0mi_fk FOREIGN KEY (npgsqlpointpointe0mi_id)
        REFERENCES public.npgsqlpointpointe0mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlpointpointe0m
(
    id integer NOT NULL,
    value point NOT NULL,
    nullablevalue point,
    npgsqlpointpointe0mi_id integer,
    CONSTRAINT binary_npgsqlpointpointe0m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_npgsqlpointpointe0m_binary_npgsqlpointpointe0mi_fk FOREIGN KEY (npgsqlpointpointe0mi_id)
        REFERENCES public.binary_npgsqlpointpointe0mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlpointpointe0m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlpointpointe0m;
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

