

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
    internal partial class NpgsqlLineSingleTypeline
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqllinelinee0mi
(
    id integer NOT NULL,
    value line NOT NULL,
    nullablevalue line,
    CONSTRAINT npgsqllinelinee0mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqllinelinee0mi
(
    id integer NOT NULL,
    value line NOT NULL,
    nullablevalue line,
    CONSTRAINT binary_npgsqllinelinee0mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqllinelinee0mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqllinelinee0mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqllinelinee0m
(
    id integer NOT NULL,
    value line NOT NULL,
    nullablevalue line,
    npgsqllinelinee0mi_id integer,
    CONSTRAINT npgsqllinelinee0m_pkey PRIMARY KEY (id),
    CONSTRAINT npgsqllinelinee0m_npgsqllinelinee0mi_fk FOREIGN KEY (npgsqllinelinee0mi_id)
        REFERENCES public.npgsqllinelinee0mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqllinelinee0m
(
    id integer NOT NULL,
    value line NOT NULL,
    nullablevalue line,
    npgsqllinelinee0mi_id integer,
    CONSTRAINT binary_npgsqllinelinee0m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_npgsqllinelinee0m_binary_npgsqllinelinee0mi_fk FOREIGN KEY (npgsqllinelinee0mi_id)
        REFERENCES public.binary_npgsqllinelinee0mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqllinelinee0m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqllinelinee0m;
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

