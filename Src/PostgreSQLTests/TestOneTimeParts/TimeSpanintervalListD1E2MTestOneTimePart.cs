

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
    internal partial class TimeSpanListintervalListD1
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.timespanintervallistd12mi
(
    id integer NOT NULL,
    value interval[] NOT NULL,
    nullablevalue interval[],
    CONSTRAINT timespanintervallistd12mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_timespanintervallistd12mi
(
    id integer NOT NULL,
    value interval[] NOT NULL,
    nullablevalue interval[],
    CONSTRAINT binary_timespanintervallistd12mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.timespanintervallistd12mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_timespanintervallistd12mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.timespanintervallistd1e2m
(
    id integer NOT NULL,
    value interval[] NOT NULL,
    nullablevalue interval[],
    timespanintervallistd12mi_id integer,
    CONSTRAINT timespanintervallistd1e2m_pkey PRIMARY KEY (id),
    CONSTRAINT timespanintervallistd1e2m_timespanintervallistd12mi_fk FOREIGN KEY (timespanintervallistd12mi_id)
        REFERENCES public.timespanintervallistd12mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_timespanintervallistd1e2m
(
    id integer NOT NULL,
    value interval[] NOT NULL,
    nullablevalue interval[],
    timespanintervallistd12mi_id integer,
    CONSTRAINT binary_timespanintervallistd1e2m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_timespanintervallistd1e2m_binary_timespanintervallistd12mi_fk FOREIGN KEY (timespanintervallistd12mi_id)
        REFERENCES public.binary_timespanintervallistd12mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.timespanintervallistd1e2m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_timespanintervallistd1e2m;
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

