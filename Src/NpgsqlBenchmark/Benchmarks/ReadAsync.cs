using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.IO;
using NpgsqlBenchmark.Model;
using Dapper;
using System.Linq;
using System.Threading.Tasks;
using Gedaq.Provider.Enums;
using Gedaq.Npgsql.Enums;

namespace NpgsqlBenchmark.Benchmarks
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
            MethodType.Async,
            SourceType.Connection,
            "ReadAsync"
            )]
    [MemoryDiagnoser]
    [SimpleJob(RuntimeMoniker.Net70)]
    [HideColumns("Error", "StdDev", "Median", "RatioSD")]
    public class ReadAsync
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
                var persons = await _connection.ReadAsyncAsync().ToListAsync();
            }
        }

        [Benchmark(Baseline = true, Description = "Dapper.QueryAsync<Person>")]
        public async Task Dapper()
        {
            for (int i = 0; i < Size; i++)
            {
                //async in QueryAsync always buffered
                var persons = await _connection.QueryAsync<Person>(@"
SELECT 
    p1.id,
    p1.firstname,
    p1.middlename,
    p1.lastname
FROM person p1
");
            }
        }
    }
}
