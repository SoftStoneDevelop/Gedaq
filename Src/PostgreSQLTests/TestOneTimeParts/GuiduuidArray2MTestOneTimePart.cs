

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
    internal partial class GuidListuuidArray
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.guiduuidarray2mi
(
    id integer NOT NULL,
    value uuid[] NOT NULL,
    nullablevalue uuid[],
    CONSTRAINT guiduuidarray2mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_guiduuidarray2mi
(
    id integer NOT NULL,
    value uuid[] NOT NULL,
    nullablevalue uuid[],
    CONSTRAINT binary_guiduuidarray2mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.guiduuidarray2mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_guiduuidarray2mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.guiduuidarray2m
(
    id integer NOT NULL,
    value uuid[] NOT NULL,
    nullablevalue uuid[],
    guiduuidarray2mi_id integer,
    CONSTRAINT guiduuidarray2m_pkey PRIMARY KEY (id),
    CONSTRAINT guiduuidarray2m_guiduuidarray2mi_fk FOREIGN KEY (guiduuidarray2mi_id)
        REFERENCES public.guiduuidarray2mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_guiduuidarray2m
(
    id integer NOT NULL,
    value uuid[] NOT NULL,
    nullablevalue uuid[],
    guiduuidarray2mi_id integer,
    CONSTRAINT binary_guiduuidarray2m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_guiduuidarray2m_binary_guiduuidarray2mi_fk FOREIGN KEY (guiduuidarray2mi_id)
        REFERENCES public.binary_guiduuidarray2mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.guiduuidarray2m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_guiduuidarray2m;
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

