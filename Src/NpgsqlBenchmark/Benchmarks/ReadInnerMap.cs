using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Dapper;
using Gedaq.Npgsql.Attributes;
using Gedaq.Npgsql.Enums;
using Gedaq.Common.Enums;
using Microsoft.Extensions.Configuration;
using Npgsql;
using NpgsqlBenchmark.Model;
using System.IO;
using System.Linq;

namespace NpgsqlBenchmark.Benchmarks
{
    [Query(
            @"
SELECT 
    p.id,
    p.firstname,
~StartInner::Identification:id~
    i.id,
    i.typename,
~EndInner::Identification~
    p.middlename,
    p.lastname
FROM person p
LEFT JOIN identification i ON i.id = p.identification_id
WHERE p.id > $1
",
        typeof(Person),
        MethodType.Sync,
        SourceType.Connection,
        "ReadInnerMap"
        )]
    [Parametr("ReadInnerMap", parametrType: typeof(int), position: 1)]
    [MemoryDiagnoser]
    [SimpleJob(RuntimeMoniker.Net70)]
    [HideColumns("Error", "StdDev", "Median", "RatioSD")]
    public class ReadInnerMap
    {
        [Params(10, 20, 30)]
        public int Size;

        private NpgsqlConnection _connection;

        [GlobalSetup]
        public void Setup()
        {
            var root = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("settings.json", optional: false)
                .Build()
                ;

            _connection = new NpgsqlConnection(root.GetConnectionString("SqlConnection"));
            _connection.Open();
        }

        [GlobalCleanup]
        public void Cleanup()
        {
            _connection?.Dispose();
        }

        [Benchmark(Description = $"Gedaq")]
        public void Gedaq()
        {
            for (int i = 0; i < Size; i++)
            {
                var persons = _connection.ReadInnerMap(49999).ToList();
            }
        }

        [Benchmark(Baseline = true, Description = "Dapper.Query<Person, Identification, Person>")]
        public void Dapper()
        {
            for (int i = 0; i < Size; i++)
            {
                var parametrs = new { id = 49999 };
                var persons = _connection.Query<Person, Identification, Person>(@"
SELECT 
    p.id,
    p.firstname,
    p.middlename,
    p.lastname,
    i.id,
    i.typename
FROM person p
LEFT JOIN identification i ON i.id = p.identification_id
WHERE p.id > @id
",
(person, identification) => 
{
    person.Identification = identification;
    return person;
}, parametrs, buffered: false)
                    .ToList();
            }
        }
    }
}
