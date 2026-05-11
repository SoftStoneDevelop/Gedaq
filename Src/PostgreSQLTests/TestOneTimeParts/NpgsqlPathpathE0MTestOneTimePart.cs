

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
    internal partial class NpgsqlPathSingleTypepath
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqlpathpathe0mi
(
    id integer NOT NULL,
    value path NOT NULL,
    nullablevalue path,
    CONSTRAINT npgsqlpathpathe0mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlpathpathe0mi
(
    id integer NOT NULL,
    value path NOT NULL,
    nullablevalue path,
    CONSTRAINT binary_npgsqlpathpathe0mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlpathpathe0mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlpathpathe0mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqlpathpathe0m
(
    id integer NOT NULL,
    value path NOT NULL,
    nullablevalue path,
    npgsqlpathpathe0mi_id integer,
    CONSTRAINT npgsqlpathpathe0m_pkey PRIMARY KEY (id),
    CONSTRAINT npgsqlpathpathe0m_npgsqlpathpathe0mi_fk FOREIGN KEY (npgsqlpathpathe0mi_id)
        REFERENCES public.npgsqlpathpathe0mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlpathpathe0m
(
    id integer NOT NULL,
    value path NOT NULL,
    nullablevalue path,
    npgsqlpathpathe0mi_id integer,
    CONSTRAINT binary_npgsqlpathpathe0m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_npgsqlpathpathe0m_binary_npgsqlpathpathe0mi_fk FOREIGN KEY (npgsqlpathpathe0mi_id)
        REFERENCES public.binary_npgsqlpathpathe0mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlpathpathe0m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlpathpathe0m;
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

