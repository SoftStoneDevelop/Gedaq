

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
    internal partial class SingleMArrayrealMArrayD2
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.singlerealmarrayd21mi
(
    id integer NOT NULL,
    value real[][] NOT NULL,
    nullablevalue real[][],
    CONSTRAINT singlerealmarrayd21mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_singlerealmarrayd21mi
(
    id integer NOT NULL,
    value real[][] NOT NULL,
    nullablevalue real[][],
    CONSTRAINT binary_singlerealmarrayd21mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.singlerealmarrayd21mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_singlerealmarrayd21mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.singlerealmarrayd2e1m
(
    id integer NOT NULL,
    value real[][] NOT NULL,
    nullablevalue real[][],
    singlerealmarrayd21mi_id integer,
    CONSTRAINT singlerealmarrayd2e1m_pkey PRIMARY KEY (id),
    CONSTRAINT singlerealmarrayd2e1m_singlerealmarrayd21mi_fk FOREIGN KEY (singlerealmarrayd21mi_id)
        REFERENCES public.singlerealmarrayd21mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_singlerealmarrayd2e1m
(
    id integer NOT NULL,
    value real[][] NOT NULL,
    nullablevalue real[][],
    singlerealmarrayd21mi_id integer,
    CONSTRAINT binary_singlerealmarrayd2e1m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_singlerealmarrayd2e1m_binary_singlerealmarrayd21mi_fk FOREIGN KEY (singlerealmarrayd21mi_id)
        REFERENCES public.binary_singlerealmarrayd21mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.singlerealmarrayd2e1m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_singlerealmarrayd2e1m;
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

