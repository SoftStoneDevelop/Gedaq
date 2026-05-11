

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
    internal partial class NpgsqlCircleMArraycircleMArrayD2
    {


        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqlcirclecirclemarrayd21mi
(
    id integer NOT NULL,
    value circle[][] NOT NULL,
    nullablevalue circle[][],
    CONSTRAINT npgsqlcirclecirclemarrayd21mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlcirclecirclemarrayd21mi
(
    id integer NOT NULL,
    value circle[][] NOT NULL,
    nullablevalue circle[][],
    CONSTRAINT binary_npgsqlcirclecirclemarrayd21mi_pkey PRIMARY KEY (id)
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlcirclecirclemarrayd21mi;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlcirclecirclemarrayd21mi;
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task CreateModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE public.npgsqlcirclecirclemarrayd2e1m
(
    id integer NOT NULL,
    value circle[][] NOT NULL,
    nullablevalue circle[][],
    npgsqlcirclecirclemarrayd21mi_id integer,
    CONSTRAINT npgsqlcirclecirclemarrayd2e1m_pkey PRIMARY KEY (id),
    CONSTRAINT npgsqlcirclecirclemarrayd2e1m_npgsqlcirclecirclemarrayd21mi_fk FOREIGN KEY (npgsqlcirclecirclemarrayd21mi_id)
        REFERENCES public.npgsqlcirclecirclemarrayd21mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
CREATE TABLE public.binary_npgsqlcirclecirclemarrayd2e1m
(
    id integer NOT NULL,
    value circle[][] NOT NULL,
    nullablevalue circle[][],
    npgsqlcirclecirclemarrayd21mi_id integer,
    CONSTRAINT binary_npgsqlcirclecirclemarrayd2e1m_pkey PRIMARY KEY (id),
    CONSTRAINT binary_npgsqlcirclecirclemarrayd2e1m_binary_npgsqlcirclecirclemarrayd21mi_fk FOREIGN KEY (npgsqlcirclecirclemarrayd21mi_id)
        REFERENCES public.binary_npgsqlcirclecirclemarrayd21mi (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            await cmd.ExecuteNonQueryAsync();
        }


        private async Task DropModelTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP TABLE public.npgsqlcirclecirclemarrayd2e1m;
";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @"
DROP TABLE public.binary_npgsqlcirclecirclemarrayd2e1m;
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

