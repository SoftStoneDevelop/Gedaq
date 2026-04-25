

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
    internal partial class TimeSpanSingleTypeinterval
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.timespaninterval0mi
(
    id integer NOT NULL,
    value interval NOT NULL,
    nullablevalue interval,
    CONSTRAINT timespaninterval0mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_timespaninterval0mi
(
    id integer NOT NULL,
    value interval NOT NULL,
    nullablevalue interval,
    CONSTRAINT binary_timespaninterval0mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.timespaninterval0mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_timespaninterval0mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.timespaninterval0m
(
    id integer NOT NULL,
    value interval NOT NULL,
    nullablevalue interval,
    timespaninterval0mi_id integer,
    CONSTRAINT timespaninterval0m_pkey PRIMARY KEY (id),
    CONSTRAINT timespaninterval0m_timespaninterval0mi_fk FOREIGN KEY (timespaninterval0mi_id)
        REFERENCES public.timespaninterval0mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_timespaninterval0m
(
    id integer NOT NULL,
    value interval NOT NULL,
    nullablevalue interval,
    timespaninterval0mi_id integer,
    CONSTRAINT binary_timespaninterval0m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_timespaninterval0m_binary_timespaninterval0mi_fk FOREIGN KEY (timespaninterval0mi_id)
        REFERENCES public.binary_timespaninterval0mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.timespaninterval0m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_timespaninterval0m;
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

