using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.IO;
using NpgsqlBenchmark.Model;
using Dapper;
using System.Linq;
using Gedaq.Npgsql.Enums;
using Gedaq.Provider.Enums;
using System.Threading.Tasks;

namespace NpgsqlBenchmark.Benchmarks
{
    [Gedaq.Npgsql.Attributes.QueryRead(
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
",
            typeof(Person),
            MethodType.Async,
            SourceType.Connection,
            "GetAllPersonInner"
            )]
    [MemoryDiagnoser]
    [SimpleJob(RuntimeMoniker.Net70)]
    [HideColumns("Error", "StdDev", "Median", "RatioSD")]
    public class ReadInnerMapAsync
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

        [Benchmark(Description = $"GedaqAsync")]
        public async Task Gedaq()
        {
            for (int i = 0; i < Size; i++)
            {
                var persons = await _connection.GetAllPersonInnerAsync().ToListAsync();
            }
        }

        [Benchmark(Baseline = true, Description = "Dapper.QueryAsync<Person, Identification, Person>")]
        public async Task Dapper()
        {
            for (int i = 0; i < Size; i++)
            {
                //async in QueryAsync always buffered
                var persons = await _connection.QueryAsync<Person, Identification, Person>(@"
SELECT 
    p.id,
    p.firstname,
    p.middlename,
    p.lastname,
    i.id,
    i.typename
FROM person p
LEFT JOIN identification i ON i.id = p.identification_id
",
(person, identification) => 
{
    person.Identification = identification;
    return person;
});
                var list = persons.ToList();
            }
        }
    }
}
