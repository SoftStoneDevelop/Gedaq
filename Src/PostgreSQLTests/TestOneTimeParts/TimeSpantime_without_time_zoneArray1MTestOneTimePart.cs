

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
    internal partial class TimeSpanArraytime_without_time_zoneArray
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.timespantime_without_time_zonearray1mi
(
    id integer NOT NULL,
    value time without time zone[] NOT NULL,
    nullablevalue time without time zone[],
    CONSTRAINT timespantime_without_time_zonearray1mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_timespantime_without_time_zonearray1mi
(
    id integer NOT NULL,
    value time without time zone[] NOT NULL,
    nullablevalue time without time zone[],
    CONSTRAINT binary_timespantime_without_time_zonearray1mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.timespantime_without_time_zonearray1mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_timespantime_without_time_zonearray1mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.timespantime_without_time_zonearray1m
(
    id integer NOT NULL,
    value time without time zone[] NOT NULL,
    nullablevalue time without time zone[],
    timespantime_without_time_zonearray1mi_id integer,
    CONSTRAINT timespantime_without_time_zonearray1m_pkey PRIMARY KEY (id),
    CONSTRAINT timespantime_without_time_zonearray1m_timespantime_without_time_zonearray1mi_fk FOREIGN KEY (timespantime_without_time_zonearray1mi_id)
        REFERENCES public.timespantime_without_time_zonearray1mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_timespantime_without_time_zonearray1m
(
    id integer NOT NULL,
    value time without time zone[] NOT NULL,
    nullablevalue time without time zone[],
    timespantime_without_time_zonearray1mi_id integer,
    CONSTRAINT binary_timespantime_without_time_zonearray1m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_timespantime_without_time_zonearray1m_binary_timespantime_without_time_zonearray1mi_fk FOREIGN KEY (timespantime_without_time_zonearray1mi_id)
        REFERENCES public.binary_timespantime_without_time_zonearray1mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.timespantime_without_time_zonearray1m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_timespantime_without_time_zonearray1m;
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

