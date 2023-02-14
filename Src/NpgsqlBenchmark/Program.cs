using BenchmarkDotNet.Running;
using Gedaq.Npgsql.Enums;
using Gedaq.Provider.Enums;
using Microsoft.Diagnostics.Tracing.Parsers.AspNet;
using Microsoft.Extensions.Configuration;
using Npgsql;
using NpgsqlBenchmark.Benchmarks;
using NpgsqlBenchmark.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace NpgsqlBenchmark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestQuery();
            BenchmarkRunner.Run<Read>();
            BenchmarkRunner.Run<ReadAsync>();

            BenchmarkRunner.Run<ReadInnerMap>();
            BenchmarkRunner.Run<ReadInnerMapAsync>();
        }

        private static void TestQuery()
        {
            var root = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("settings.json", optional: false)
                .Build()
            ;

            using var connection = new NpgsqlConnection(root.GetConnectionString("SqlConnection"));
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
SELECT 
    p.id,
    p.firstname,
    p.middlename,
    p.lastname
FROM person p
WHERE p.id > $1
ORDER BY p.id ASC
";
            var parametr = new NpgsqlParameter<int>();
            parametr.TypedValue= 13;
            cmd.Parameters.Add(parametr);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var id = reader.GetFieldValue<int>(0);
                var firstname = reader.GetFieldValue<string>(1);
                var middlename = reader.GetFieldValue<string>(2);
                var lastname = reader.GetFieldValue<string>(3);
            }
        }

        [Gedaq.Npgsql.Attributes.QueryRead(
            @"
SELECT 
    p.id,
    p.firstname,
    p.middlename,
    p.lastname
FROM person p1
WHERE p.id > $1
ORDER BY p.id ASC
",
            typeof(Person),
            MethodType.Sync | MethodType.Async,
            SourceType.Connection,
            "GetData",
            parametrTypes: new Type[] { typeof(int) }
            )]
        private static async Task GetData()
        {
            var root = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("settings.json", optional: false)
                .Build()
            ;

            using var connection = new NpgsqlConnection(root.GetConnectionString("SqlConnection"));
            var data = await connection.GetDataAsync(13).ToListAsync();
        }

        private static void FillTestDatabase()
        {
            var root = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("settings.json", optional: false)
                .Build()
                ;

            using (var connection = new NpgsqlConnection(root.GetConnectionString("SqlConnection")))
            {
                connection.Open();
                using var cmd = connection.CreateCommand();
                {
                    cmd.CommandText = @"
CREATE TABLE IF NOT EXISTS public.identification
(
    id integer NOT NULL,
    typename text COLLATE pg_catalog.""default"" NOT NULL,
    CONSTRAINT identification_pkey PRIMARY KEY (id)
)
";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"
INSERT INTO public.identification(
	id, typename)
	VALUES (
    @id, @typename
);
";
                    var id = cmd.CreateParameter();
                    id.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
                    id.ParameterName = "id";
                    cmd.Parameters.Add(id);
                    
                    var typename = cmd.CreateParameter();
                    typename.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;
                    typename.ParameterName = "typename";
                    cmd.Parameters.Add(typename);
                    cmd.Prepare();

                    id.Value = 1;
                    typename.Value = "sailor's passport";
                    cmd.ExecuteNonQuery();

                    id.Value = 2;
                    typename.Value = "officer's certificate";
                    cmd.ExecuteNonQuery();

                    id.Value = 3;
                    typename.Value = "driver license";
                    cmd.ExecuteNonQuery();

                    id.Value = 4;
                    typename.Value = "citizen's passport";
                    cmd.ExecuteNonQuery();

                    id.Value = 5;
                    typename.Value = "party card";
                    cmd.ExecuteNonQuery();
                }

                //fill person
                {
                    cmd.CommandText = @"
CREATE TABLE IF NOT EXISTS public.person
(
    id integer NOT NULL,
    firstname text COLLATE pg_catalog.""default"" NOT NULL,
    middlename text COLLATE pg_catalog.""default"",
    lastname text COLLATE pg_catalog.""default"",
    identification_id integer,
    CONSTRAINT person_pkey PRIMARY KEY (id),
    CONSTRAINT identification_fk FOREIGN KEY (identification_id)
        REFERENCES public.identification (id)
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID
)
";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"
INSERT INTO public.person(
	id, firstname, middlename, lastname, identification_id)
	VALUES (
    @id, @firstname, @middlename, @lastname, @identification_id
);
";
                    cmd.Parameters.Clear();
                    var id = cmd.CreateParameter();
                    id.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
                    id.ParameterName = "id";
                    cmd.Parameters.Add(id);

                    var firstname = cmd.CreateParameter();
                    firstname.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;
                    firstname.ParameterName = "firstname";
                    cmd.Parameters.Add(firstname);

                    var middlename = cmd.CreateParameter();
                    middlename.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;
                    middlename.ParameterName = "middlename";
                    cmd.Parameters.Add(middlename);

                    var lastname = cmd.CreateParameter();
                    lastname.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;
                    lastname.ParameterName = "lastname";
                    cmd.Parameters.Add(lastname);

                    var identificationId = cmd.CreateParameter();
                    identificationId.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
                    identificationId.ParameterName = "identification_id";
                    identificationId.IsNullable = true;
                    cmd.Parameters.Add(identificationId);
                    cmd.Prepare();

                    var refId = 0;
                    for (int i = 0; i < 100000; i++)
                    {
                        id.Value = i;
                        firstname.Value = $"John{i}";
                        middlename.Value = $"Сurly{i}";
                        lastname.Value = $"Doe{i}";

                        if (++refId > 5)
                        {
                            refId = 1;
                        }

                        if (i % 2 == 0)
                        {
                            identificationId.Value = refId;
                        }
                        else
                        {
                            identificationId.Value = DBNull.Value;
                        }

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}