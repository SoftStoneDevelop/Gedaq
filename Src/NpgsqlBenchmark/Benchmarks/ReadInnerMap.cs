﻿using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.IO;
using NpgsqlBenchmark.Model;
using Dapper;
using System.Linq;
using Gedaq.Npgsql.Enums;
using Gedaq.Provider.Enums;

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
            MethodType.Sync,
            SourceType.Connection,
            "GetAllPersonInner"
            )]
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
                var persons = _connection.GetAllPersonInner().ToList();
            }
        }

        [Benchmark(Baseline = true, Description = "Dapper.Query<Person, Identification, Person>")]
        public void Dapper()
        {
            for (int i = 0; i < Size; i++)
            {
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
",
(person, identification) => 
{
    person.Identification = identification;
    return person;
}, buffered: false)
                    .ToList();
            }
        }
    }
}
