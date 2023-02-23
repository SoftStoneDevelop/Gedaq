namespace NpgsqlTests.Model
{
    public class ReadFixtureModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public ReadFixtureIdentificationModel Identification { get; set; }
    }
}