

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
    internal partial class GuidSingleTypeuuid
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.guiduuid0mi
(
    id integer NOT NULL,
    value uuid NOT NULL,
    nullablevalue uuid,
    CONSTRAINT guiduuid0mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_guiduuid0mi
(
    id integer NOT NULL,
    value uuid NOT NULL,
    nullablevalue uuid,
    CONSTRAINT binary_guiduuid0mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.guiduuid0mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_guiduuid0mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.guiduuid0m
(
    id integer NOT NULL,
    value uuid NOT NULL,
    nullablevalue uuid,
    guiduuid0mi_id integer,
    CONSTRAINT guiduuid0m_pkey PRIMARY KEY (id),
    CONSTRAINT guiduuid0m_guiduuid0mi_fk FOREIGN KEY (guiduuid0mi_id)
        REFERENCES public.guiduuid0mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_guiduuid0m
(
    id integer NOT NULL,
    value uuid NOT NULL,
    nullablevalue uuid,
    guiduuid0mi_id integer,
    CONSTRAINT binary_guiduuid0m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_guiduuid0m_binary_guiduuid0mi_fk FOREIGN KEY (guiduuid0mi_id)
        REFERENCES public.binary_guiduuid0mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.guiduuid0m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_guiduuid0m;
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

