using Gedaq.Npgsql;
using Gedaq.Provider.Attributes;
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
                //var command = sc.Method1CommandManual(in connection);
                //var persons = sc.Method1Manual(in command, true);

                var persons = sc.Method1Manual(in connection);
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

    [UseProvider]
    public class SomeClass
    {
        private readonly PostgresRequest request;

        [UseProvider]
        public List<Person> Method1()
        {
            request
                
                
                
                ?





                .Query
                
                
                <
                    
                    
                                              Person
                    
                    
                    
                    >
                
                
                (
                    
                    
                    "M1"
                    
                    
                    )
                .
                
                
                
                Where(wh => wh.Id == 15)



                .ToList
                
                
                (
                    
                    
                    
                    )
                
                
                ;

            return this.request?.Query<Person>("M1").ToList();
            //return GedaqSomeClass.M1();
        }

        public NpgsqlCommand Method1CommandManual(in NpgsqlConnection connection)
        {
            var command = connection.CreateCommand();
            command.CommandText = @$"
SELECT 
    p1.id,
    p1.firstname,
    p1.middlename,
    p1.lastname
FROM person p1
";
            return command;
        }

        public List<Person> Method1ExecuteManual(in NpgsqlCommand command)
        {
            using (var reader = command.ExecuteReader())
            {
                var persons = new List<Person>();
                while (reader.Read())
                {
                    var item = new Person
                    {
                        Id = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        MiddleName = reader.GetString(2),
                        LastName = reader.GetString(3)
                    };
                    persons.Add(item);
                }

                return persons;
            }
        }

        public List<Person> Method1Manual(in NpgsqlConnection connection)
        {
            using (var command = Method1CommandManual(in connection))
            {
                return Method1ExecuteManual(in command);
            }
        }

        public List<Person> Method1Manual(
            in NpgsqlCommand command,
            in bool prepareCommand
            )
        {
            if(prepareCommand && !command.IsPrepared)
            {
                command.Prepare();
            }

            return Method1ExecuteManual(in command);
        }
    }

    //[UseProvider]
    //public partial class SomeClass2
    //{
    //    private readonly PostgresRequest request;

    //    [UseProvider]
    //    public List<Person> Method1()
    //    {
    //        return request?.Query<Person>("M1").ToList();
    //        //return M1();
    //    }
    //}
}