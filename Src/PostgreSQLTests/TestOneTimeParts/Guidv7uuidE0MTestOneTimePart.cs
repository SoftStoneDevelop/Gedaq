

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
    internal partial class Guidv7SingleTypeuuid
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.guidv7uuide0mi
(
    id integer NOT NULL,
    value uuid NOT NULL,
    nullablevalue uuid,
    CONSTRAINT guidv7uuide0mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_guidv7uuide0mi
(
    id integer NOT NULL,
    value uuid NOT NULL,
    nullablevalue uuid,
    CONSTRAINT binary_guidv7uuide0mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.guidv7uuide0mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_guidv7uuide0mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.guidv7uuide0m
(
    id integer NOT NULL,
    value uuid NOT NULL,
    nullablevalue uuid,
    guidv7uuide0mi_id integer,
    CONSTRAINT guidv7uuide0m_pkey PRIMARY KEY (id),
    CONSTRAINT guidv7uuide0m_guidv7uuide0mi_fk FOREIGN KEY (guidv7uuide0mi_id)
        REFERENCES public.guidv7uuide0mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_guidv7uuide0m
(
    id integer NOT NULL,
    value uuid NOT NULL,
    nullablevalue uuid,
    guidv7uuide0mi_id integer,
    CONSTRAINT binary_guidv7uuide0m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_guidv7uuide0m_binary_guidv7uuide0mi_fk FOREIGN KEY (guidv7uuide0mi_id)
        REFERENCES public.binary_guidv7uuide0mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.guidv7uuide0m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_guidv7uuide0m;
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

