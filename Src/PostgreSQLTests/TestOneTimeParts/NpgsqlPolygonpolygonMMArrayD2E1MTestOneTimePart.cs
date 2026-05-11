

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
    internal partial class NpgsqlPolygonMArraypolygonMMArrayD2
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqlpolygonpolygonmmarrayd2e1mi
(
    id integer NOT NULL,
    value polygon[][] NOT NULL,
    nullablevalue polygon[][],
    CONSTRAINT npgsqlpolygonpolygonmmarrayd2e1mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
    id integer NOT NULL,
    value polygon[][] NOT NULL,
    nullablevalue polygon[][],
    CONSTRAINT binary_npgsqlpolygonpolygonmmarrayd2e1mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlpolygonpolygonmmarrayd2e1mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlpolygonpolygonmmarrayd2e1mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqlpolygonpolygonmmarrayd2e1m
(
    id integer NOT NULL,
    value polygon[][] NOT NULL,
    nullablevalue polygon[][],
    npgsqlpolygonpolygonmmarrayd2e1mi_id integer,
    CONSTRAINT npgsqlpolygonpolygonmmarrayd2e1m_pkey PRIMARY KEY (id),
    CONSTRAINT npgsqlpolygonpolygonmmarrayd2e1m_npgsqlpolygonpolygonmmarrayd2e1mi_fk FOREIGN KEY (npgsqlpolygonpolygonmmarrayd2e1mi_id)
        REFERENCES public.npgsqlpolygonpolygonmmarrayd2e1mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlpolygonpolygonmmarrayd2e1m
(
    id integer NOT NULL,
    value polygon[][] NOT NULL,
    nullablevalue polygon[][],
    npgsqlpolygonpolygonmmarrayd2e1mi_id integer,
    CONSTRAINT binary_npgsqlpolygonpolygonmmarrayd2e1m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_npgsqlpolygonpolygonmmarrayd2e1m_binary_npgsqlpolygonpolygonmmarrayd2e1mi_fk FOREIGN KEY (npgsqlpolygonpolygonmmarrayd2e1mi_id)
        REFERENCES public.binary_npgsqlpolygonpolygonmmarrayd2e1mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlpolygonpolygonmmarrayd2e1m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlpolygonpolygonmmarrayd2e1m;
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

