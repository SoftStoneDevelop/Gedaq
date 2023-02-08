using Gedaq.Npgsql;
using Gedaq.Npgsql.Attributes;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
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
                var persons = sc.Method1Manual(connection).ToList();
                for (int i = 0; i < persons.Count; i++)
                {
                    Console.WriteLine(@$"
{nameof(Person.FirstName)}: {persons[i].FirstName}
{nameof(Person.MiddleName)}: {persons[i].MiddleName}
{nameof(Person.LastName)}: {persons[i].LastName}
");
                }
            }
        }
    }

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
            typeof(Person)
        },
            Gedaq.Provider.Enums.MethodType.Sync,
            Gedaq.Npgsql.Enums.SourceType.Connection
            )]
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
            typeof(Person)
        },
            Gedaq.Provider.Enums.MethodType.Sync,
            Gedaq.Npgsql.Enums.SourceType.Connection
            )]
        public void Config()
        {
            
        }

        public IEnumerable<Person> Method1Manual(NpgsqlConnection connection)
        {
            using var command = connection.CreateCommand();
            command.CommandText = @$"
SELECT 
    p1.id,
    p1.firstname,
    p1.middlename,
    p1.lastname
FROM person p1
";

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
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
}