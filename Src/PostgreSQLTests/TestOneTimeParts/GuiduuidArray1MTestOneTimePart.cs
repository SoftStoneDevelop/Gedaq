

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
    internal partial class GuidArrayuuidArray
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.guiduuidarray1mi
(
    id integer NOT NULL,
    value uuid[] NOT NULL,
    nullablevalue uuid[],
    CONSTRAINT guiduuidarray1mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_guiduuidarray1mi
(
    id integer NOT NULL,
    value uuid[] NOT NULL,
    nullablevalue uuid[],
    CONSTRAINT binary_guiduuidarray1mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.guiduuidarray1mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_guiduuidarray1mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.guiduuidarray1m
(
    id integer NOT NULL,
    value uuid[] NOT NULL,
    nullablevalue uuid[],
    guiduuidarray1mi_id integer,
    CONSTRAINT guiduuidarray1m_pkey PRIMARY KEY (id),
    CONSTRAINT guiduuidarray1m_guiduuidarray1mi_fk FOREIGN KEY (guiduuidarray1mi_id)
        REFERENCES public.guiduuidarray1mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_guiduuidarray1m
(
    id integer NOT NULL,
    value uuid[] NOT NULL,
    nullablevalue uuid[],
    guiduuidarray1mi_id integer,
    CONSTRAINT binary_guiduuidarray1m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_guiduuidarray1m_binary_guiduuidarray1mi_fk FOREIGN KEY (guiduuidarray1mi_id)
        REFERENCES public.binary_guiduuidarray1mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.guiduuidarray1m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_guiduuidarray1m;
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

