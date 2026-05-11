

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
    internal partial class NpgsqlPointMArraypointMArrayD2
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqlpointpointmarrayd21mi
(
    id integer NOT NULL,
    value point[][] NOT NULL,
    nullablevalue point[][],
    CONSTRAINT npgsqlpointpointmarrayd21mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlpointpointmarrayd21mi
(
    id integer NOT NULL,
    value point[][] NOT NULL,
    nullablevalue point[][],
    CONSTRAINT binary_npgsqlpointpointmarrayd21mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlpointpointmarrayd21mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlpointpointmarrayd21mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqlpointpointmarrayd2e1m
(
    id integer NOT NULL,
    value point[][] NOT NULL,
    nullablevalue point[][],
    npgsqlpointpointmarrayd21mi_id integer,
    CONSTRAINT npgsqlpointpointmarrayd2e1m_pkey PRIMARY KEY (id),
    CONSTRAINT npgsqlpointpointmarrayd2e1m_npgsqlpointpointmarrayd21mi_fk FOREIGN KEY (npgsqlpointpointmarrayd21mi_id)
        REFERENCES public.npgsqlpointpointmarrayd21mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlpointpointmarrayd2e1m
(
    id integer NOT NULL,
    value point[][] NOT NULL,
    nullablevalue point[][],
    npgsqlpointpointmarrayd21mi_id integer,
    CONSTRAINT binary_npgsqlpointpointmarrayd2e1m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_npgsqlpointpointmarrayd2e1m_binary_npgsqlpointpointmarrayd21mi_fk FOREIGN KEY (npgsqlpointpointmarrayd21mi_id)
        REFERENCES public.binary_npgsqlpointpointmarrayd21mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlpointpointmarrayd2e1m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlpointpointmarrayd2e1m;
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

