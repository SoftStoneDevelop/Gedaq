

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
    internal partial class SingleMArrayrealMMArrayD3
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.singlerealmmarrayd3e1mi
(
    id integer NOT NULL,
    value real[][][] NOT NULL,
    nullablevalue real[][][],
    CONSTRAINT singlerealmmarrayd3e1mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_singlerealmmarrayd3e1mi
(
    id integer NOT NULL,
    value real[][][] NOT NULL,
    nullablevalue real[][][],
    CONSTRAINT binary_singlerealmmarrayd3e1mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.singlerealmmarrayd3e1mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_singlerealmmarrayd3e1mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.singlerealmmarrayd3e1m
(
    id integer NOT NULL,
    value real[][][] NOT NULL,
    nullablevalue real[][][],
    singlerealmmarrayd3e1mi_id integer,
    CONSTRAINT singlerealmmarrayd3e1m_pkey PRIMARY KEY (id),
    CONSTRAINT singlerealmmarrayd3e1m_singlerealmmarrayd3e1mi_fk FOREIGN KEY (singlerealmmarrayd3e1mi_id)
        REFERENCES public.singlerealmmarrayd3e1mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_singlerealmmarrayd3e1m
(
    id integer NOT NULL,
    value real[][][] NOT NULL,
    nullablevalue real[][][],
    singlerealmmarrayd3e1mi_id integer,
    CONSTRAINT binary_singlerealmmarrayd3e1m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_singlerealmmarrayd3e1m_binary_singlerealmmarrayd3e1mi_fk FOREIGN KEY (singlerealmmarrayd3e1mi_id)
        REFERENCES public.binary_singlerealmmarrayd3e1mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.singlerealmmarrayd3e1m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_singlerealmmarrayd3e1m;
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

