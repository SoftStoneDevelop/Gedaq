

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
    internal partial class IPAddressSingleTypeinet
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.ipaddressinete0mi
(
    id integer NOT NULL,
    value inet NOT NULL,
    nullablevalue inet,
    CONSTRAINT ipaddressinete0mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_ipaddressinete0mi
(
    id integer NOT NULL,
    value inet NOT NULL,
    nullablevalue inet,
    CONSTRAINT binary_ipaddressinete0mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.ipaddressinete0mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_ipaddressinete0mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.ipaddressinete0m
(
    id integer NOT NULL,
    value inet NOT NULL,
    nullablevalue inet,
    ipaddressinete0mi_id integer,
    CONSTRAINT ipaddressinete0m_pkey PRIMARY KEY (id),
    CONSTRAINT ipaddressinete0m_ipaddressinete0mi_fk FOREIGN KEY (ipaddressinete0mi_id)
        REFERENCES public.ipaddressinete0mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_ipaddressinete0m
(
    id integer NOT NULL,
    value inet NOT NULL,
    nullablevalue inet,
    ipaddressinete0mi_id integer,
    CONSTRAINT binary_ipaddressinete0m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_ipaddressinete0m_binary_ipaddressinete0mi_fk FOREIGN KEY (ipaddressinete0mi_id)
        REFERENCES public.binary_ipaddressinete0mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.ipaddressinete0m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_ipaddressinete0m;
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

