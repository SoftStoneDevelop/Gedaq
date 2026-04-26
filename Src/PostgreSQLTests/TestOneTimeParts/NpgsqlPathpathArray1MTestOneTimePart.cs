

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
    internal partial class NpgsqlPathArraypathArray
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqlpathpatharray1mi
(
    id integer NOT NULL,
    value path[] NOT NULL,
    nullablevalue path[],
    CONSTRAINT npgsqlpathpatharray1mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlpathpatharray1mi
(
    id integer NOT NULL,
    value path[] NOT NULL,
    nullablevalue path[],
    CONSTRAINT binary_npgsqlpathpatharray1mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlpathpatharray1mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlpathpatharray1mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqlpathpatharray1m
(
    id integer NOT NULL,
    value path[] NOT NULL,
    nullablevalue path[],
    npgsqlpathpatharray1mi_id integer,
    CONSTRAINT npgsqlpathpatharray1m_pkey PRIMARY KEY (id),
    CONSTRAINT npgsqlpathpatharray1m_npgsqlpathpatharray1mi_fk FOREIGN KEY (npgsqlpathpatharray1mi_id)
        REFERENCES public.npgsqlpathpatharray1mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlpathpatharray1m
(
    id integer NOT NULL,
    value path[] NOT NULL,
    nullablevalue path[],
    npgsqlpathpatharray1mi_id integer,
    CONSTRAINT binary_npgsqlpathpatharray1m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_npgsqlpathpatharray1m_binary_npgsqlpathpatharray1mi_fk FOREIGN KEY (npgsqlpathpatharray1mi_id)
        REFERENCES public.binary_npgsqlpathpatharray1mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlpathpatharray1m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlpathpatharray1m;
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

