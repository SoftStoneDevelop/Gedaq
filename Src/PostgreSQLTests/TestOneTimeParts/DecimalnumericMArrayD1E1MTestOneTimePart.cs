

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
    internal partial class DecimalMArraynumericMArrayD1
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.decimalnumericmarrayd11mi
(
    id integer NOT NULL,
    value numeric[] NOT NULL,
    nullablevalue numeric[],
    CONSTRAINT decimalnumericmarrayd11mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_decimalnumericmarrayd11mi
(
    id integer NOT NULL,
    value numeric[] NOT NULL,
    nullablevalue numeric[],
    CONSTRAINT binary_decimalnumericmarrayd11mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.decimalnumericmarrayd11mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_decimalnumericmarrayd11mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.decimalnumericmarrayd1e1m
(
    id integer NOT NULL,
    value numeric[] NOT NULL,
    nullablevalue numeric[],
    decimalnumericmarrayd11mi_id integer,
    CONSTRAINT decimalnumericmarrayd1e1m_pkey PRIMARY KEY (id),
    CONSTRAINT decimalnumericmarrayd1e1m_decimalnumericmarrayd11mi_fk FOREIGN KEY (decimalnumericmarrayd11mi_id)
        REFERENCES public.decimalnumericmarrayd11mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_decimalnumericmarrayd1e1m
(
    id integer NOT NULL,
    value numeric[] NOT NULL,
    nullablevalue numeric[],
    decimalnumericmarrayd11mi_id integer,
    CONSTRAINT binary_decimalnumericmarrayd1e1m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_decimalnumericmarrayd1e1m_binary_decimalnumericmarrayd11mi_fk FOREIGN KEY (decimalnumericmarrayd11mi_id)
        REFERENCES public.binary_decimalnumericmarrayd11mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.decimalnumericmarrayd1e1m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_decimalnumericmarrayd1e1m;
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

