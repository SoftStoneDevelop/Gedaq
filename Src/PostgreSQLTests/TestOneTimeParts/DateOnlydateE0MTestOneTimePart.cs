

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
    internal partial class DateOnlySingleTypedate
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.dateonlydatee0mi
(
    id integer NOT NULL,
    value date NOT NULL,
    nullablevalue date,
    CONSTRAINT dateonlydatee0mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_dateonlydatee0mi
(
    id integer NOT NULL,
    value date NOT NULL,
    nullablevalue date,
    CONSTRAINT binary_dateonlydatee0mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.dateonlydatee0mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_dateonlydatee0mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.dateonlydatee0m
(
    id integer NOT NULL,
    value date NOT NULL,
    nullablevalue date,
    dateonlydatee0mi_id integer,
    CONSTRAINT dateonlydatee0m_pkey PRIMARY KEY (id),
    CONSTRAINT dateonlydatee0m_dateonlydatee0mi_fk FOREIGN KEY (dateonlydatee0mi_id)
        REFERENCES public.dateonlydatee0mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_dateonlydatee0m
(
    id integer NOT NULL,
    value date NOT NULL,
    nullablevalue date,
    dateonlydatee0mi_id integer,
    CONSTRAINT binary_dateonlydatee0m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_dateonlydatee0m_binary_dateonlydatee0mi_fk FOREIGN KEY (dateonlydatee0mi_id)
        REFERENCES public.binary_dateonlydatee0mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.dateonlydatee0m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_dateonlydatee0m;
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

