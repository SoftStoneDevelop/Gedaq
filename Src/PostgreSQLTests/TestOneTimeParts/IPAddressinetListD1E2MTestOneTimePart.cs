

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
    internal partial class IPAddressListinetListD1
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.ipaddressinetlistd12mi
(
    id integer NOT NULL,
    value inet[] NOT NULL,
    nullablevalue inet[],
    CONSTRAINT ipaddressinetlistd12mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_ipaddressinetlistd12mi
(
    id integer NOT NULL,
    value inet[] NOT NULL,
    nullablevalue inet[],
    CONSTRAINT binary_ipaddressinetlistd12mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.ipaddressinetlistd12mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_ipaddressinetlistd12mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.ipaddressinetlistd1e2m
(
    id integer NOT NULL,
    value inet[] NOT NULL,
    nullablevalue inet[],
    ipaddressinetlistd12mi_id integer,
    CONSTRAINT ipaddressinetlistd1e2m_pkey PRIMARY KEY (id),
    CONSTRAINT ipaddressinetlistd1e2m_ipaddressinetlistd12mi_fk FOREIGN KEY (ipaddressinetlistd12mi_id)
        REFERENCES public.ipaddressinetlistd12mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_ipaddressinetlistd1e2m
(
    id integer NOT NULL,
    value inet[] NOT NULL,
    nullablevalue inet[],
    ipaddressinetlistd12mi_id integer,
    CONSTRAINT binary_ipaddressinetlistd1e2m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_ipaddressinetlistd1e2m_binary_ipaddressinetlistd12mi_fk FOREIGN KEY (ipaddressinetlistd12mi_id)
        REFERENCES public.binary_ipaddressinetlistd12mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.ipaddressinetlistd1e2m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_ipaddressinetlistd1e2m;
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

