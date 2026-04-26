

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
    internal partial class IPAddressListinetArray
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.ipaddressinetarray2mi
(
    id integer NOT NULL,
    value inet[] NOT NULL,
    nullablevalue inet[],
    CONSTRAINT ipaddressinetarray2mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_ipaddressinetarray2mi
(
    id integer NOT NULL,
    value inet[] NOT NULL,
    nullablevalue inet[],
    CONSTRAINT binary_ipaddressinetarray2mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.ipaddressinetarray2mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_ipaddressinetarray2mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.ipaddressinetarray2m
(
    id integer NOT NULL,
    value inet[] NOT NULL,
    nullablevalue inet[],
    ipaddressinetarray2mi_id integer,
    CONSTRAINT ipaddressinetarray2m_pkey PRIMARY KEY (id),
    CONSTRAINT ipaddressinetarray2m_ipaddressinetarray2mi_fk FOREIGN KEY (ipaddressinetarray2mi_id)
        REFERENCES public.ipaddressinetarray2mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_ipaddressinetarray2m
(
    id integer NOT NULL,
    value inet[] NOT NULL,
    nullablevalue inet[],
    ipaddressinetarray2mi_id integer,
    CONSTRAINT binary_ipaddressinetarray2m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_ipaddressinetarray2m_binary_ipaddressinetarray2mi_fk FOREIGN KEY (ipaddressinetarray2mi_id)
        REFERENCES public.binary_ipaddressinetarray2mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.ipaddressinetarray2m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_ipaddressinetarray2m;
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

