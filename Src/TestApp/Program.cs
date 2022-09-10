using Gedaq.Provider.Attributes;
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
            var persons = sc.Method1();
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

    [UseProvider]
    public class SomeClass
    {
        private readonly PostgresRequest request;

        [UseProvider]
        public List<Person> Method1()
        {
            return request?.Query<Person>("M1").ToList();
            //return GedaqSomeClass.M1();
        }
    }

    [UseProvider]
    public partial class SomeClass2
    {
        private readonly PostgresRequest request;

        [UseProvider]
        public List<Person> Method1()
        {
            return request?.Query<Person>("M1").ToList();
            //return M1();
        }
    }
}