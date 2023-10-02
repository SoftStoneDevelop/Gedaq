

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
    internal partial class DateTimeListtimestamp_without_time_zoneArray
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.datetimetimestamp_without_time_zonearray2mi
(
    id integer NOT NULL,
    value timestamp without time zone[] NOT NULL,
    nullablevalue timestamp without time zone[],
    CONSTRAINT datetimetimestamp_without_time_zonearray2mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_datetimetimestamp_without_time_zonearray2mi
(
    id integer NOT NULL,
    value timestamp without time zone[] NOT NULL,
    nullablevalue timestamp without time zone[],
    CONSTRAINT binary_datetimetimestamp_without_time_zonearray2mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.datetimetimestamp_without_time_zonearray2mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_datetimetimestamp_without_time_zonearray2mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.datetimetimestamp_without_time_zonearray2m
(
    id integer NOT NULL,
    value timestamp without time zone[] NOT NULL,
    nullablevalue timestamp without time zone[],
    datetimetimestamp_without_time_zonearray2mi_id integer,
    CONSTRAINT datetimetimestamp_without_time_zonearray2m_pkey PRIMARY KEY (id),
    CONSTRAINT datetimetimestamp_without_time_zonearray2m_datetimetimestamp_without_time_zonearray2mi_fk FOREIGN KEY (datetimetimestamp_without_time_zonearray2mi_id)
        REFERENCES public.datetimetimestamp_without_time_zonearray2mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_datetimetimestamp_without_time_zonearray2m
(
    id integer NOT NULL,
    value timestamp without time zone[] NOT NULL,
    nullablevalue timestamp without time zone[],
    datetimetimestamp_without_time_zonearray2mi_id integer,
    CONSTRAINT binary_datetimetimestamp_without_time_zonearray2m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_datetimetimestamp_without_time_zonearray2m_binary_datetimetimestamp_without_time_zonearray2mi_fk FOREIGN KEY (datetimetimestamp_without_time_zonearray2mi_id)
        REFERENCES public.binary_datetimetimestamp_without_time_zonearray2mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.datetimetimestamp_without_time_zonearray2m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_datetimetimestamp_without_time_zonearray2m;
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

