namespace NpgsqlBenchmark.Model
{
    public class Person
    {
        public int Id { get; set; }

        public char[] FirstName { get; set; }

        public char[] MiddleName { get; set; }

        public char[] LastName { get; set; }

        public Identification Identification { get; set; }
    }
}