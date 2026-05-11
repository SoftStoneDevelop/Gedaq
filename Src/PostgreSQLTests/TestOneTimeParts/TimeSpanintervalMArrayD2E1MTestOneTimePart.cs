

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
    internal partial class TimeSpanMArrayintervalMArrayD2
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.timespanintervalmarrayd21mi
(
    id integer NOT NULL,
    value interval[][] NOT NULL,
    nullablevalue interval[][],
    CONSTRAINT timespanintervalmarrayd21mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_timespanintervalmarrayd21mi
(
    id integer NOT NULL,
    value interval[][] NOT NULL,
    nullablevalue interval[][],
    CONSTRAINT binary_timespanintervalmarrayd21mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.timespanintervalmarrayd21mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_timespanintervalmarrayd21mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.timespanintervalmarrayd2e1m
(
    id integer NOT NULL,
    value interval[][] NOT NULL,
    nullablevalue interval[][],
    timespanintervalmarrayd21mi_id integer,
    CONSTRAINT timespanintervalmarrayd2e1m_pkey PRIMARY KEY (id),
    CONSTRAINT timespanintervalmarrayd2e1m_timespanintervalmarrayd21mi_fk FOREIGN KEY (timespanintervalmarrayd21mi_id)
        REFERENCES public.timespanintervalmarrayd21mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_timespanintervalmarrayd2e1m
(
    id integer NOT NULL,
    value interval[][] NOT NULL,
    nullablevalue interval[][],
    timespanintervalmarrayd21mi_id integer,
    CONSTRAINT binary_timespanintervalmarrayd2e1m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_timespanintervalmarrayd2e1m_binary_timespanintervalmarrayd21mi_fk FOREIGN KEY (timespanintervalmarrayd21mi_id)
        REFERENCES public.binary_timespanintervalmarrayd21mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.timespanintervalmarrayd2e1m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_timespanintervalmarrayd2e1m;
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

