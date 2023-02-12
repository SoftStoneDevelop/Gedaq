using Gedaq.Npgsql;
using Gedaq.Npgsql.Attributes;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using TestApp.Model;

namespace TestApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("settings.json", optional: false)
                .Build();
                ;

            //DropTablesTestDatabase(builder.GetConnectionString("SqlConnection"));
            //FillTestDatabase(builder.GetConnectionString("SqlConnection"));
            Connection(builder.GetConnectionString("SqlConnection"));
            await ConnectionAsync(builder.GetConnectionString("SqlConnection"));

            Console.ReadLine();
        }

        private static void DropTablesTestDatabase(string connStr)
        {
            using (var connection = new NpgsqlConnection(connStr))
            {
                connection.Open();
                using var cmd = connection.CreateCommand();
                {
                    cmd.CommandText = @"
DROP TABLE person;
DROP TABLE identification;
";
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private static void FillTestDatabase(string connStr)
        {
            using (var connection = new NpgsqlConnection(connStr))
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

        public static void Connection(string connectionString)
        {
            var sc = new SomeClass();
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var personsG = connection.GetAllPerson().ToList();
                for (int i = 0; i < personsG.Count; i++)
                {
                    Console.WriteLine(@$"
{nameof(Person.FirstName)}: {personsG[i].FirstName}
{nameof(Person.MiddleName)}: {personsG[i].MiddleName}
{nameof(Person.LastName)}: {personsG[i].LastName}
");
                }
            }
        }

        public static async Task ConnectionAsync(string connectionString)
        {
            var sc = new SomeClass();
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var personsG = await connection.GetAllPersonAsync().ToListAsync();
                for (int i = 0; i < personsG.Count; i++)
                {
                    Console.WriteLine(@$"
{nameof(Person.FirstName)}: {personsG[i].FirstName}
{nameof(Person.MiddleName)}: {personsG[i].MiddleName}
{nameof(Person.LastName)}: {personsG[i].LastName}
");
                }

                //foreach (var item in await SomeClass.Method12ManualAsync(connection).ToListAsync())
                //{
                //    var sd = 45;
                //}
            }
        }
    }

    public class SomeClass
    {
        [Gedaq.Npgsql.Attributes.QueryRead(
            @"
SELECT 
    p1.id,
    p1.firstname,
~StartInner::Identification:id~
    i.id,
    i.typename,
~EndInner::Identification~
    p1.middlename,
    p1.lastname
FROM person p1
LEFT JOIN identification i ON i.id = p1.identification_id
ORDER BY p1.id
",
            typeof(Person),
            Gedaq.Provider.Enums.MethodType.Sync,
            Gedaq.Npgsql.Enums.SourceType.Connection,
            "GetAllPerson"
            )]
        [Gedaq.Npgsql.Attributes.QueryRead(
            @"
SELECT 
    p1.id,
    p1.firstname,
~StartInner::Identification:id~
    i.id,
    i.typename,
~EndInner::Identification~
    p1.middlename,
    p1.lastname
FROM person p1
LEFT JOIN identification i ON i.id = p1.identification_id
ORDER BY p1.id
",
            typeof(Person),
            Gedaq.Provider.Enums.MethodType.Async,
            Gedaq.Npgsql.Enums.SourceType.Connection,
            "GetAllPerson"
            )]
        public void Config()
        {
            
        }

        public static IEnumerable<Person> Method1Manual(
            NpgsqlConnection connection)
        {
            bool needClose = connection.State == ConnectionState.Closed;
            if(needClose)
            {
                connection.Open();
            }

            NpgsqlCommand command = null;
            NpgsqlDataReader reader = null;
            try
            {
                command = connection.CreateCommand();
                command.CommandText = @$"
SELECT 
    p1.id,
    p1.firstname,
    p1.middlename,
    p1.lastname
FROM person p1
";

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var item = new Person
                    {
                        Id = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        MiddleName = reader.GetString(2),
                        LastName = reader.GetString(3),
                    };

                    yield return item;
                }
                
                while (reader.NextResult()) 
                {
                    //ignore
                }

                ((IDataReader)reader).Dispose();
                reader = null;
            }
            finally
            {
                if (reader != null)
                {
                    if (!reader.IsClosed)
                    {
                        try 
                        {
                            command.Cancel();
                        }
                        catch { /* ignore */ }
                    }

                    reader.Dispose();
                }

                if (needClose)
                {
                    connection.Close();
                }

                command?.Parameters.Clear();
                command?.Dispose();
            }
        }

        public static async IAsyncEnumerable<Person> Method1ManualAsync(NpgsqlConnection connection)
        {
            await using var command = connection.CreateCommand();
            command.CommandText = @$"
SELECT 
    p1.id,
    p1.firstname,
    p1.middlename,
    p1.lastname
FROM person p1
";
            await using(var reader = await command.ExecuteReaderAsync())
            {
                while (await reader.ReadAsync())
                {
                    var item = new Person
                    {
                        Id = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        MiddleName = reader.GetString(2),
                        LastName = reader.GetString(3)
                    };
                    
                    yield return item;
                }
            }
        }

        public static async IAsyncEnumerable<IAsyncEnumerable<Person>> Method12ManualAsync(NpgsqlConnection connection)
        {
            await using var batch = connection.CreateBatch();
            var command1 = new NpgsqlBatchCommand(@$"
SELECT 
    p1.id,
    p1.firstname,
    p1.middlename,
    p1.lastname
FROM person p1
");
            batch.BatchCommands.Add(command1);

            var command2 = new NpgsqlBatchCommand(@$"
SELECT 
    p1.id,
    p1.firstname,
    p1.middlename,
    p1.lastname
FROM person p1
");
            batch.BatchCommands.Add(command2);

            await using (var reader = await batch.ExecuteReaderAsync())
            {
                yield return Method11ManualAsync(reader);
                await reader.NextResultAsync();
                yield return Method13ManualAsync(reader);
                while(await reader.NextResultAsync())
                {
                    //ignore
                }
            }
        }

        public static async IAsyncEnumerable<Person> Method11ManualAsync(NpgsqlDataReader reader)
        {
            while (await reader.ReadAsync())
            {
                var item = new Person
                {
                    Id = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    MiddleName = reader.GetString(2),
                    LastName = reader.GetString(3)
                };

                yield return item;
            }
        }

        public static async IAsyncEnumerable<Person> Method13ManualAsync(NpgsqlDataReader reader)
        {
            while (await reader.ReadAsync())
            {
                var item = new Person
                {
                    Id = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    MiddleName = reader.GetString(2),
                    LastName = reader.GetString(3)
                };

                yield return item;
            }
        }
    }
};