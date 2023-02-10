using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.IO;
using NpgsqlBenchmark.Model;
using Dapper;
using System.Linq;
using System.Threading.Tasks;

namespace NpgsqlBenchmark.Benchmarks
{
    [MemoryDiagnoser]
    [SimpleJob(RuntimeMoniker.Net70)]
    [HideColumns("Error", "StdDev", "Median", "RatioSD")]
    public class ReadAsync
    {
        [Params(10, 20, 30, 40)]
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
                var persons = await _connection.GetAllPersonAsync().ToListAsync();
            }
        }

        [Benchmark(Baseline = true, Description = "Dapper.QueryAsync<T>")]
        public async Task Dapper()
        {
            for (int i = 0; i < Size; i++)
            {
                var persons = await _connection.QueryAsync<Person>(@"
SELECT 
    p1.id,
    p1.firstname,
    p1.middlename,
    p1.lastname
FROM person p1
");
                var list = persons.ToList();
            }
        }
    }
}
