namespace NpgsqlBenchmark.Model
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
            Gedaq.Provider.Enums.MethodType.Sync,
            Gedaq.Npgsql.Enums.SourceType.Connection,
            "GetAllPerson"
            )]
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
            Gedaq.Provider.Enums.MethodType.Async,
            Gedaq.Npgsql.Enums.SourceType.Connection,
            "GetAllPerson"
            )]
    public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public Identification Identification { get; set; }
    }
}