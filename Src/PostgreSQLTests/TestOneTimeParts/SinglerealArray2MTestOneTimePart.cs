

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
    internal partial class SingleListrealArray
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.singlerealarray2mi
(
    id integer NOT NULL,
    value real[] NOT NULL,
    nullablevalue real[],
    CONSTRAINT singlerealarray2mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_singlerealarray2mi
(
    id integer NOT NULL,
    value real[] NOT NULL,
    nullablevalue real[],
    CONSTRAINT binary_singlerealarray2mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.singlerealarray2mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_singlerealarray2mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.singlerealarray2m
(
    id integer NOT NULL,
    value real[] NOT NULL,
    nullablevalue real[],
    singlerealarray2mi_id integer,
    CONSTRAINT singlerealarray2m_pkey PRIMARY KEY (id),
    CONSTRAINT singlerealarray2m_singlerealarray2mi_fk FOREIGN KEY (singlerealarray2mi_id)
        REFERENCES public.singlerealarray2mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_singlerealarray2m
(
    id integer NOT NULL,
    value real[] NOT NULL,
    nullablevalue real[],
    singlerealarray2mi_id integer,
    CONSTRAINT binary_singlerealarray2m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_singlerealarray2m_binary_singlerealarray2mi_fk FOREIGN KEY (singlerealarray2mi_id)
        REFERENCES public.binary_singlerealarray2mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.singlerealarray2m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_singlerealarray2m;
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

