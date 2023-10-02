

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
    internal partial class NpgsqlIntervalSingleTypeinterval
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqlintervalinterval0mi
(
    id integer NOT NULL,
    value interval NOT NULL,
    nullablevalue interval,
    CONSTRAINT npgsqlintervalinterval0mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlintervalinterval0mi
(
    id integer NOT NULL,
    value interval NOT NULL,
    nullablevalue interval,
    CONSTRAINT binary_npgsqlintervalinterval0mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlintervalinterval0mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlintervalinterval0mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqlintervalinterval0m
(
    id integer NOT NULL,
    value interval NOT NULL,
    nullablevalue interval,
    npgsqlintervalinterval0mi_id integer,
    CONSTRAINT npgsqlintervalinterval0m_pkey PRIMARY KEY (id),
    CONSTRAINT npgsqlintervalinterval0m_npgsqlintervalinterval0mi_fk FOREIGN KEY (npgsqlintervalinterval0mi_id)
        REFERENCES public.npgsqlintervalinterval0mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlintervalinterval0m
(
    id integer NOT NULL,
    value interval NOT NULL,
    nullablevalue interval,
    npgsqlintervalinterval0mi_id integer,
    CONSTRAINT binary_npgsqlintervalinterval0m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_npgsqlintervalinterval0m_binary_npgsqlintervalinterval0mi_fk FOREIGN KEY (npgsqlintervalinterval0mi_id)
        REFERENCES public.binary_npgsqlintervalinterval0mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlintervalinterval0m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlintervalinterval0m;
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

