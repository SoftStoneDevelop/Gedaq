

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
    internal partial class DateOnlyArraydateArray
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.dateonlydatearray1mi
(
    id integer NOT NULL,
    value date[] NOT NULL,
    nullablevalue date[],
    CONSTRAINT dateonlydatearray1mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_dateonlydatearray1mi
(
    id integer NOT NULL,
    value date[] NOT NULL,
    nullablevalue date[],
    CONSTRAINT binary_dateonlydatearray1mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.dateonlydatearray1mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_dateonlydatearray1mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.dateonlydatearray1m
(
    id integer NOT NULL,
    value date[] NOT NULL,
    nullablevalue date[],
    dateonlydatearray1mi_id integer,
    CONSTRAINT dateonlydatearray1m_pkey PRIMARY KEY (id),
    CONSTRAINT dateonlydatearray1m_dateonlydatearray1mi_fk FOREIGN KEY (dateonlydatearray1mi_id)
        REFERENCES public.dateonlydatearray1mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_dateonlydatearray1m
(
    id integer NOT NULL,
    value date[] NOT NULL,
    nullablevalue date[],
    dateonlydatearray1mi_id integer,
    CONSTRAINT binary_dateonlydatearray1m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_dateonlydatearray1m_binary_dateonlydatearray1mi_fk FOREIGN KEY (dateonlydatearray1mi_id)
        REFERENCES public.binary_dateonlydatearray1mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.dateonlydatearray1m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_dateonlydatearray1m;
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

