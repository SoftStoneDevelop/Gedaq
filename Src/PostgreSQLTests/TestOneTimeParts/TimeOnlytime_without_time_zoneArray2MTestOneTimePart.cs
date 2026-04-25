

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
    internal partial class TimeOnlyListtime_without_time_zoneArray
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.timeonlytime_without_time_zonearray2mi
(
    id integer NOT NULL,
    value time without time zone[] NOT NULL,
    nullablevalue time without time zone[],
    CONSTRAINT timeonlytime_without_time_zonearray2mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_timeonlytime_without_time_zonearray2mi
(
    id integer NOT NULL,
    value time without time zone[] NOT NULL,
    nullablevalue time without time zone[],
    CONSTRAINT binary_timeonlytime_without_time_zonearray2mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.timeonlytime_without_time_zonearray2mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_timeonlytime_without_time_zonearray2mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.timeonlytime_without_time_zonearray2m
(
    id integer NOT NULL,
    value time without time zone[] NOT NULL,
    nullablevalue time without time zone[],
    timeonlytime_without_time_zonearray2mi_id integer,
    CONSTRAINT timeonlytime_without_time_zonearray2m_pkey PRIMARY KEY (id),
    CONSTRAINT timeonlytime_without_time_zonearray2m_timeonlytime_without_time_zonearray2mi_fk FOREIGN KEY (timeonlytime_without_time_zonearray2mi_id)
        REFERENCES public.timeonlytime_without_time_zonearray2mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_timeonlytime_without_time_zonearray2m
(
    id integer NOT NULL,
    value time without time zone[] NOT NULL,
    nullablevalue time without time zone[],
    timeonlytime_without_time_zonearray2mi_id integer,
    CONSTRAINT binary_timeonlytime_without_time_zonearray2m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_timeonlytime_without_time_zonearray2m_binary_timeonlytime_without_time_zonearray2mi_fk FOREIGN KEY (timeonlytime_without_time_zonearray2mi_id)
        REFERENCES public.binary_timeonlytime_without_time_zonearray2mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.timeonlytime_without_time_zonearray2m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_timeonlytime_without_time_zonearray2m;
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

