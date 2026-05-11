

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
    internal partial class DateOnlyListdateListD1
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.dateonlydatelistd12mi
(
    id integer NOT NULL,
    value date[] NOT NULL,
    nullablevalue date[],
    CONSTRAINT dateonlydatelistd12mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_dateonlydatelistd12mi
(
    id integer NOT NULL,
    value date[] NOT NULL,
    nullablevalue date[],
    CONSTRAINT binary_dateonlydatelistd12mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.dateonlydatelistd12mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_dateonlydatelistd12mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.dateonlydatelistd1e2m
(
    id integer NOT NULL,
    value date[] NOT NULL,
    nullablevalue date[],
    dateonlydatelistd12mi_id integer,
    CONSTRAINT dateonlydatelistd1e2m_pkey PRIMARY KEY (id),
    CONSTRAINT dateonlydatelistd1e2m_dateonlydatelistd12mi_fk FOREIGN KEY (dateonlydatelistd12mi_id)
        REFERENCES public.dateonlydatelistd12mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_dateonlydatelistd1e2m
(
    id integer NOT NULL,
    value date[] NOT NULL,
    nullablevalue date[],
    dateonlydatelistd12mi_id integer,
    CONSTRAINT binary_dateonlydatelistd1e2m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_dateonlydatelistd1e2m_binary_dateonlydatelistd12mi_fk FOREIGN KEY (dateonlydatelistd12mi_id)
        REFERENCES public.binary_dateonlydatelistd12mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.dateonlydatelistd1e2m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_dateonlydatelistd1e2m;
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

