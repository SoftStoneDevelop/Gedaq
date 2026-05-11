

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
    internal partial class SByteMArraysmallintMArrayD1
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.sbytesmallintmarrayd11mi
(
    id integer NOT NULL,
    value smallint[] NOT NULL,
    nullablevalue smallint[],
    CONSTRAINT sbytesmallintmarrayd11mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_sbytesmallintmarrayd11mi
(
    id integer NOT NULL,
    value smallint[] NOT NULL,
    nullablevalue smallint[],
    CONSTRAINT binary_sbytesmallintmarrayd11mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.sbytesmallintmarrayd11mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_sbytesmallintmarrayd11mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.sbytesmallintmarrayd1e1m
(
    id integer NOT NULL,
    value smallint[] NOT NULL,
    nullablevalue smallint[],
    sbytesmallintmarrayd11mi_id integer,
    CONSTRAINT sbytesmallintmarrayd1e1m_pkey PRIMARY KEY (id),
    CONSTRAINT sbytesmallintmarrayd1e1m_sbytesmallintmarrayd11mi_fk FOREIGN KEY (sbytesmallintmarrayd11mi_id)
        REFERENCES public.sbytesmallintmarrayd11mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_sbytesmallintmarrayd1e1m
(
    id integer NOT NULL,
    value smallint[] NOT NULL,
    nullablevalue smallint[],
    sbytesmallintmarrayd11mi_id integer,
    CONSTRAINT binary_sbytesmallintmarrayd1e1m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_sbytesmallintmarrayd1e1m_binary_sbytesmallintmarrayd11mi_fk FOREIGN KEY (sbytesmallintmarrayd11mi_id)
        REFERENCES public.binary_sbytesmallintmarrayd11mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.sbytesmallintmarrayd1e1m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_sbytesmallintmarrayd1e1m;
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

