using Gedaq.Npgsql;
using Gedaq.Npgsql.Attributes;
using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using TestApp.Model;

namespace TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sc = new SomeClass();
            using (var connection = new NpgsqlConnection(""))
            {
                connection.Open();
                Console.WriteLine("Manual start:");
                var persons = SomeClass.Method1Manual(connection).ToList();
                for (int i = 0; i < persons.Count; i++)
                {
                    Console.WriteLine(@$"
{nameof(Person.FirstName)}: {persons[i].FirstName}
{nameof(Person.MiddleName)}: {persons[i].MiddleName}
{nameof(Person.LastName)}: {persons[i].LastName}
");
                }
                Console.WriteLine("Manual end.");

                Console.WriteLine("Genarated start:");
                var personsG = connection.MethodGenerated1().ToList();
                for (int i = 0; i < personsG.Count; i++)
                {
                    Console.WriteLine(@$"
{nameof(Person.FirstName)}: {personsG[i][0]}
{nameof(Person.MiddleName)}: {personsG[i][1]}
{nameof(Person.LastName)}: {personsG[i][2]}
");
                }
                Console.WriteLine("Genarated end.");
            }

            Console.ReadLine();
        }
    }

    public class SomeClass
    {
        [Gedaq.Npgsql.Attributes.QueryRead(
            new string[]
            {
                @"
SELECT 
    p1.id,
    p1.firstname,
    p1.middlename,
    p1.lastname
FROM person p1
"
            },
            new Type[]
            {
                typeof(object[])
            },
            Gedaq.Provider.Enums.MethodType.Sync,
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

        public async IAsyncEnumerable<Person> Method1ManualAsync(NpgsqlConnection connection)
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
    }
};