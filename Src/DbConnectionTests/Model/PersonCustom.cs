namespace DbConnectionTests.Model
{
    public class PersonCustom
    {
        public int Id { get; set; }

        public Name Name { get; set; }

        public Identification Identification { get; set; }
    }

    public class Name
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }
    }
}