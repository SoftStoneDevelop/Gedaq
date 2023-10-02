

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
    internal partial class NpgsqlIntervalListintervalArray
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqlintervalintervalarray2mi
(
    id integer NOT NULL,
    value interval[] NOT NULL,
    nullablevalue interval[],
    CONSTRAINT npgsqlintervalintervalarray2mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlintervalintervalarray2mi
(
    id integer NOT NULL,
    value interval[] NOT NULL,
    nullablevalue interval[],
    CONSTRAINT binary_npgsqlintervalintervalarray2mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlintervalintervalarray2mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlintervalintervalarray2mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqlintervalintervalarray2m
(
    id integer NOT NULL,
    value interval[] NOT NULL,
    nullablevalue interval[],
    npgsqlintervalintervalarray2mi_id integer,
    CONSTRAINT npgsqlintervalintervalarray2m_pkey PRIMARY KEY (id),
    CONSTRAINT npgsqlintervalintervalarray2m_npgsqlintervalintervalarray2mi_fk FOREIGN KEY (npgsqlintervalintervalarray2mi_id)
        REFERENCES public.npgsqlintervalintervalarray2mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlintervalintervalarray2m
(
    id integer NOT NULL,
    value interval[] NOT NULL,
    nullablevalue interval[],
    npgsqlintervalintervalarray2mi_id integer,
    CONSTRAINT binary_npgsqlintervalintervalarray2m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_npgsqlintervalintervalarray2m_binary_npgsqlintervalintervalarray2mi_fk FOREIGN KEY (npgsqlintervalintervalarray2mi_id)
        REFERENCES public.binary_npgsqlintervalintervalarray2mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlintervalintervalarray2m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlintervalintervalarray2m;
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

