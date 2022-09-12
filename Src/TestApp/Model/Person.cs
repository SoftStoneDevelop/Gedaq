using Gedaq.Npgsql.Attributes;
using Gedaq.Provider.Attributes.Constraints;
using ColumnAttribute = Gedaq.Npgsql.Attributes.ColumnAttribute;

namespace TestApp.Model
{
    [NpgsqlTable("person")]
    public class Person
    {
        [PK("id_pk_constrain")]
        [Column("id", NpgsqlTypes.NpgsqlDbType.Integer)]
        public int Id { get; set; }

        [NotNull("firstname_not_null_constrain")]
        [Column("firstname", NpgsqlTypes.NpgsqlDbType.Text)]
        public string FirstName { get; set; }

        [Column("middlename", NpgsqlTypes.NpgsqlDbType.Text)]
        public string MiddleName { get; set; }

        [Column("lastname", NpgsqlTypes.NpgsqlDbType.Text)]
        public string LastName { get; set; }
    }
}