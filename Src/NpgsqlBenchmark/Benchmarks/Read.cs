using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.IO;
using NpgsqlBenchmark.Model;
using Dapper;
using System.Linq;
using Gedaq.Provider.Enums;
using Gedaq.Npgsql.Enums;

namespace NpgsqlBenchmark.Benchmarks
{
    [Gedaq.Npgsql.Attributes.QueryRead(
            @"
SELECT 
    p.id,
    p.firstname,
    p.middlename,
    p.lastname
FROM person p
",
            typeof(Person),
            MethodType.Sync,
            SourceType.Connection,
            "Read"
            )]
    [MemoryDiagnoser]
    [SimpleJob(RuntimeMoniker.Net70)]
    [HideColumns("Error", "StdDev", "Median", "RatioSD")]
    public class Read
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
                var persons = _connection.Read().ToList();
            }
        }

        [Benchmark(Baseline = true, Description = "Dapper.Query<Person>")]
        public void Dapper()
        {
            for (int i = 0; i < Size; i++)
            {
                var persons = _connection.Query<Person>(@"
SELECT 
    p.id,
    p.firstname,
    p.middlename,
    p.lastname
FROM person p
", buffered: false)
                    .ToList();
            }
        }
    }
}
