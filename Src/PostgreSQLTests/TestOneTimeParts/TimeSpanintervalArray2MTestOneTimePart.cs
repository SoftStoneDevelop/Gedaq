

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
    internal partial class TimeSpanListintervalArray
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.timespanintervalarray2mi
(
    id integer NOT NULL,
    value interval[] NOT NULL,
    nullablevalue interval[],
    CONSTRAINT timespanintervalarray2mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_timespanintervalarray2mi
(
    id integer NOT NULL,
    value interval[] NOT NULL,
    nullablevalue interval[],
    CONSTRAINT binary_timespanintervalarray2mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.timespanintervalarray2mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_timespanintervalarray2mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.timespanintervalarray2m
(
    id integer NOT NULL,
    value interval[] NOT NULL,
    nullablevalue interval[],
    timespanintervalarray2mi_id integer,
    CONSTRAINT timespanintervalarray2m_pkey PRIMARY KEY (id),
    CONSTRAINT timespanintervalarray2m_timespanintervalarray2mi_fk FOREIGN KEY (timespanintervalarray2mi_id)
        REFERENCES public.timespanintervalarray2mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_timespanintervalarray2m
(
    id integer NOT NULL,
    value interval[] NOT NULL,
    nullablevalue interval[],
    timespanintervalarray2mi_id integer,
    CONSTRAINT binary_timespanintervalarray2m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_timespanintervalarray2m_binary_timespanintervalarray2mi_fk FOREIGN KEY (timespanintervalarray2mi_id)
        REFERENCES public.binary_timespanintervalarray2mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.timespanintervalarray2m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_timespanintervalarray2m;
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

