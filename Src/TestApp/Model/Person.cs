using Gedaq.Provider.Attributes;

namespace TestApp.Model
{
    [Table("person")]
    public class Person
    {
        [PK()]
        [Column("id")]
        public int Id { get; set; }

        [Column("firstname")]
        public string FirstName { get; set; }

        [Column("middlename")]
        public string MiddleName { get; set; }

        [Column("lastname")]
        public string LastName { get; set; }
    }
}