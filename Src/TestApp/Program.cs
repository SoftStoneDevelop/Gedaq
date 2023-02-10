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

            //Connection(builder.GetConnectionString("SqlConnection"));
            //Source(builder.GetConnectionString("SqlConnection"));

            await ConnectionAsync(builder.GetConnectionString("SqlConnection"));
            //await SourceAsync(builder.GetConnectionString("SqlConnection"));

            Console.ReadLine();
        }

        public static void Connection(string connectionString)
        {
            var sc = new SomeClass();
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var personsG = connection.MethodGenerated1().ToList();
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

        public static async Task ConnectionAsync(string connectionString)
        {
            var sc = new SomeClass();
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var personsG = await connection.MethodGenerated1Async().ToListAsync();
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

        public static void Source(string connectionString)
        {
            var sc = new SomeClass();
            var dataSourceBuilder = new NpgsqlDataSourceBuilder(connectionString);
            using var dataSource = dataSourceBuilder.Build();

            var personsG = dataSource.MethodGenerated1().ToList();
            for (int i = 0; i < personsG.Count; i++)
            {
                Console.WriteLine(@$"
{nameof(Person.FirstName)}: {personsG[i].FirstName}
{nameof(Person.MiddleName)}: {personsG[i].MiddleName}
{nameof(Person.LastName)}: {personsG[i].LastName}
");
            }
        }

        public static async Task SourceAsync(string connectionString)
        {
            var sc = new SomeClass();
            var dataSourceBuilder = new NpgsqlDataSourceBuilder(connectionString);
            using var dataSource = dataSourceBuilder.Build();

            Console.WriteLine("Genarated start:");
            var personsG = await dataSource.MethodGenerated1Async().ToListAsync();
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

    public class SomeClass
    {
        [Gedaq.Npgsql.Attributes.QueryRead(
            @"
SELECT 
    p1.id,
    p1.firstname,
    p1.middlename,
    p1.lastname
FROM person p1
",
            typeof(Person),
            Gedaq.Provider.Enums.MethodType.Sync,
            Gedaq.Npgsql.Enums.SourceType.NpgsqlDataSource,
            "MethodGenerated1"
            )]
        [Gedaq.Npgsql.Attributes.QueryRead(
            @"
SELECT 
    p1.id,
    p1.firstname,
    p1.middlename,
    p1.lastname
FROM person p1
",
            typeof(Person),
            Gedaq.Provider.Enums.MethodType.Async,
            Gedaq.Npgsql.Enums.SourceType.NpgsqlDataSource,
            "MethodGenerated1"
            )]
        [Gedaq.Npgsql.Attributes.QueryRead(
            @"
SELECT 
    p1.id,
    p1.firstname,
    p1.middlename,
    p1.lastname
FROM person p1
",
            typeof(Person),
            Gedaq.Provider.Enums.MethodType.Sync,
            Gedaq.Npgsql.Enums.SourceType.Connection,
            "MethodGenerated1"
            )]
        [Gedaq.Npgsql.Attributes.QueryRead(
            @"
SELECT 
    p1.id,
    p1.firstname,
    p1.middlename,
    p1.lastname
FROM person p1
",
            typeof(Person),
            Gedaq.Provider.Enums.MethodType.Async,
            Gedaq.Npgsql.Enums.SourceType.Connection,
            "MethodGenerated1"
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