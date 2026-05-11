

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
    internal partial class StringMArraytextMArrayD1
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.stringtextmarrayd11mi
(
    id integer NOT NULL,
    value text[] NOT NULL,
    nullablevalue text[],
    CONSTRAINT stringtextmarrayd11mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_stringtextmarrayd11mi
(
    id integer NOT NULL,
    value text[] NOT NULL,
    nullablevalue text[],
    CONSTRAINT binary_stringtextmarrayd11mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.stringtextmarrayd11mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_stringtextmarrayd11mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.stringtextmarrayd1e1m
(
    id integer NOT NULL,
    value text[] NOT NULL,
    nullablevalue text[],
    stringtextmarrayd11mi_id integer,
    CONSTRAINT stringtextmarrayd1e1m_pkey PRIMARY KEY (id),
    CONSTRAINT stringtextmarrayd1e1m_stringtextmarrayd11mi_fk FOREIGN KEY (stringtextmarrayd11mi_id)
        REFERENCES public.stringtextmarrayd11mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_stringtextmarrayd1e1m
(
    id integer NOT NULL,
    value text[] NOT NULL,
    nullablevalue text[],
    stringtextmarrayd11mi_id integer,
    CONSTRAINT binary_stringtextmarrayd1e1m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_stringtextmarrayd1e1m_binary_stringtextmarrayd11mi_fk FOREIGN KEY (stringtextmarrayd11mi_id)
        REFERENCES public.binary_stringtextmarrayd11mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.stringtextmarrayd1e1m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_stringtextmarrayd1e1m;
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

