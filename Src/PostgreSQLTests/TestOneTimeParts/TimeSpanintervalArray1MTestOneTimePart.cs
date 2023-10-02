

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
    internal partial class TimeSpanArrayintervalArray
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.timespanintervalarray1mi
(
    id integer NOT NULL,
    value interval[] NOT NULL,
    nullablevalue interval[],
    CONSTRAINT timespanintervalarray1mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_timespanintervalarray1mi
(
    id integer NOT NULL,
    value interval[] NOT NULL,
    nullablevalue interval[],
    CONSTRAINT binary_timespanintervalarray1mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.timespanintervalarray1mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_timespanintervalarray1mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.timespanintervalarray1m
(
    id integer NOT NULL,
    value interval[] NOT NULL,
    nullablevalue interval[],
    timespanintervalarray1mi_id integer,
    CONSTRAINT timespanintervalarray1m_pkey PRIMARY KEY (id),
    CONSTRAINT timespanintervalarray1m_timespanintervalarray1mi_fk FOREIGN KEY (timespanintervalarray1mi_id)
        REFERENCES public.timespanintervalarray1mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_timespanintervalarray1m
(
    id integer NOT NULL,
    value interval[] NOT NULL,
    nullablevalue interval[],
    timespanintervalarray1mi_id integer,
    CONSTRAINT binary_timespanintervalarray1m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_timespanintervalarray1m_binary_timespanintervalarray1mi_fk FOREIGN KEY (timespanintervalarray1mi_id)
        REFERENCES public.binary_timespanintervalarray1mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.timespanintervalarray1m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_timespanintervalarray1m;
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

