

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
    internal partial class DateOnlyMArraydateMArrayD1
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.dateonlydatemarrayd11mi
(
    id integer NOT NULL,
    value date[] NOT NULL,
    nullablevalue date[],
    CONSTRAINT dateonlydatemarrayd11mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_dateonlydatemarrayd11mi
(
    id integer NOT NULL,
    value date[] NOT NULL,
    nullablevalue date[],
    CONSTRAINT binary_dateonlydatemarrayd11mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.dateonlydatemarrayd11mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_dateonlydatemarrayd11mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.dateonlydatemarrayd1e1m
(
    id integer NOT NULL,
    value date[] NOT NULL,
    nullablevalue date[],
    dateonlydatemarrayd11mi_id integer,
    CONSTRAINT dateonlydatemarrayd1e1m_pkey PRIMARY KEY (id),
    CONSTRAINT dateonlydatemarrayd1e1m_dateonlydatemarrayd11mi_fk FOREIGN KEY (dateonlydatemarrayd11mi_id)
        REFERENCES public.dateonlydatemarrayd11mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_dateonlydatemarrayd1e1m
(
    id integer NOT NULL,
    value date[] NOT NULL,
    nullablevalue date[],
    dateonlydatemarrayd11mi_id integer,
    CONSTRAINT binary_dateonlydatemarrayd1e1m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_dateonlydatemarrayd1e1m_binary_dateonlydatemarrayd11mi_fk FOREIGN KEY (dateonlydatemarrayd11mi_id)
        REFERENCES public.binary_dateonlydatemarrayd11mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.dateonlydatemarrayd1e1m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_dateonlydatemarrayd1e1m;
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

