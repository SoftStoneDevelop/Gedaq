using DbConnectionTests.Helpers;
using DbConnectionTests.Model;
using Gedaq.DbConnection.Attributes;
using Microsoft.Data.SqlClient;
using NUnit.Framework;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DbConnectionTests
{
    [TestFixture]
    internal class MsSqlQueryFixture : BaseFixture
    {
        #region Init and destroy

        [SetUp]
        public void Init()
        {
            using var connection = OpenConnection();
            connection.DropTable("readfixtureperson");
            connection.DropTable("readfixtureidentification");
            connection.DropTable("readfixturecountry");

            using var cmd = connection.CreateCommand();
            cmd.CommandText = @"
CREATE TABLE [dbo].[readfixturecountry](
	[id] [int] NOT NULL,
	[name] [text] NOT NULL,
 CONSTRAINT [PK_readfixturecountry] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
;

CREATE TABLE [dbo].[readfixtureidentification](
	[id] [int] NOT NULL,
	[typename] [text] NOT NULL,
	[readfixturecountry_id] [int] NULL,
 CONSTRAINT [PK_readfixtureidentification] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
;

ALTER TABLE [dbo].[readfixtureidentification]  WITH CHECK ADD  CONSTRAINT [readfixturecountry_fk] FOREIGN KEY([readfixturecountry_id])
REFERENCES [dbo].[readfixturecountry] ([id])
;

ALTER TABLE [dbo].[readfixtureidentification] CHECK CONSTRAINT [readfixturecountry_fk]
;

CREATE TABLE [dbo].[readfixtureperson](
	[id] [int] NOT NULL,
	[firstname] [text] NOT NULL,
	[middlename] [text] NULL,
	[lastname] [text] NULL,
	[readfixtureidentification_id] [int] NULL,
 CONSTRAINT [PK_readfixtureperson] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
;

ALTER TABLE [dbo].[readfixtureperson]  WITH CHECK ADD  CONSTRAINT [readfixtureidentification_fk] FOREIGN KEY([readfixtureidentification_id])
REFERENCES [dbo].[readfixtureidentification] ([id])
;

ALTER TABLE [dbo].[readfixtureperson] CHECK CONSTRAINT [readfixtureidentification_fk]
;
";
            cmd.ExecuteNonQuery();
            FillСountries(cmd);
            FillIdentification(cmd);
            FillPerson(cmd);
        }

        private SqlConnection OpenConnection()
        {
            var conn = Microsoft.Data.SqlClient.SqlClientFactory.Instance.CreateConnection();
            conn.ConnectionString = GetMsSqlConnectionString();
            conn.Open();
            return (SqlConnection)conn;
        }

        private void FillPerson(SqlCommand cmd)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = @"
INSERT INTO readfixtureperson(
	id, firstname, middlename, lastname, readfixtureidentification_id)
	VALUES (
    @id, @firstname, @middlename, @lastname, @readfixtureidentification_id
);
";
            var id = new SqlParameter();
            id.SqlDbType = System.Data.SqlDbType.Int;
            id.ParameterName = "id";
            cmd.Parameters.Add(id);

            var firstname = new SqlParameter();
            firstname.SqlDbType = System.Data.SqlDbType.Text;
            firstname.Size = 4000;
            firstname.ParameterName = "firstname";
            cmd.Parameters.Add(firstname);

            var middlename = new SqlParameter();
            middlename.SqlDbType = System.Data.SqlDbType.Text;
            middlename.Size = 4000;
            middlename.ParameterName = "middlename";
            cmd.Parameters.Add(middlename);

            var lastname = new SqlParameter();
            lastname.SqlDbType = System.Data.SqlDbType.Text;
            lastname.Size = 4000;
            lastname.ParameterName = "lastname";
            cmd.Parameters.Add(lastname);

            var identificationId = new SqlParameter();
            identificationId.SqlDbType = System.Data.SqlDbType.Int;
            identificationId.ParameterName = "readfixtureidentification_id";
            identificationId.IsNullable = true;
            cmd.Parameters.Add(identificationId);
            cmd.Prepare();

            for (int i = 0; i < 10; i++)
            {
                id.Value = i;
                firstname.Value = $"John{i}";
                middlename.Value = $"Сurly{i}";
                lastname.Value = $"Doe{i}";
                if (i > 0 && i < 6)
                {
                    identificationId.Value = i;
                }
                else
                {
                    identificationId.Value = DBNull.Value;
                }

                cmd.ExecuteNonQuery();
            }
        }

        private void FillСountries(SqlCommand cmd)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = @"
INSERT INTO readfixturecountry(
	id, name)
	VALUES (
    @id, @name
);
";
            var id = new SqlParameter();
            id.SqlDbType = System.Data.SqlDbType.Int;
            id.ParameterName = "id";
            cmd.Parameters.Add(id);

            var name = new SqlParameter();
            name.SqlDbType = System.Data.SqlDbType.Text;
            name.ParameterName = "name";
            name.Size = 4000;
            cmd.Parameters.Add(name);
            cmd.Prepare();

            id.Value = 1;
            name.Value = "Russia";
            cmd.ExecuteNonQuery();

            id.Value = 2;
            name.Value = "China";
            cmd.ExecuteNonQuery();

            id.Value = 3;
            name.Value = "Serbia";
            cmd.ExecuteNonQuery();

            id.Value = 4;
            name.Value = "Belarus";
            cmd.ExecuteNonQuery();

            id.Value = 5;
            name.Value = "Martian colony";
            cmd.ExecuteNonQuery();
        }

        private void FillIdentification(SqlCommand cmd)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = @"
INSERT INTO readfixtureidentification(
	id, typename, readfixturecountry_id)
	VALUES (
    @id, @typename, @readfixturecountry_id
);
";
            var id = new SqlParameter();
            id.SqlDbType = System.Data.SqlDbType.Int;
            id.ParameterName = "id";
            cmd.Parameters.Add(id);

            var typename = new SqlParameter();
            typename.SqlDbType = System.Data.SqlDbType.Text;
            typename.Size = 4000;
            typename.ParameterName = "typename";
            cmd.Parameters.Add(typename);

            var countryId = new SqlParameter();
            countryId.SqlDbType = System.Data.SqlDbType.Int;
            countryId.ParameterName = "readfixturecountry_id";
            countryId.IsNullable = true;
            cmd.Parameters.Add(countryId);
            cmd.Prepare();

            id.Value = 1;
            typename.Value = "sailor's passport";
            countryId.Value = 1;
            cmd.ExecuteNonQuery();

            id.Value = 2;
            typename.Value = "officer's certificate";
            countryId.Value = 2;
            cmd.ExecuteNonQuery();

            id.Value = 3;
            typename.Value = "driver license";
            countryId.Value = 3;
            cmd.ExecuteNonQuery();

            id.Value = 4;
            typename.Value = "citizen's passport";
            countryId.Value = DBNull.Value;
            cmd.ExecuteNonQuery();

            id.Value = 5;
            typename.Value = "party card";
            countryId.Value = 5;
            cmd.ExecuteNonQuery();
        }

        [TearDown]
        public void Cleanup()
        {
            using var connection = OpenConnection();
            connection?.DropTable("readfixtureperson");
            connection?.DropTable("readfixtureidentification");
            connection?.DropTable("readfixturecountry");
        }

        #endregion

        [Test]
        [Query(
            @"
SELECT 
    p.id,
    p.firstname,
~StartInner::Identification:id~
    i.id,
~StartInner::Country:id~
    c.id,
    c.name,
~EndInner::Country~
    i.typename,
~EndInner::Identification~
    p.middlename,
    p.lastname
FROM readfixtureperson p
LEFT JOIN readfixtureidentification i ON i.id = p.readfixtureidentification_id
LEFT JOIN readfixturecountry c ON c.id = i.readfixturecountry_id
WHERE p.id != @id
ORDER BY p.id ASC
",
            typeof(ReadFixtureModel),
            Gedaq.Common.Enums.MethodType.Async | Gedaq.Common.Enums.MethodType.Sync,
            "MsSqlToClass1"
            )]
        [Parametr("MsSqlToClass1", parametrType: typeof(int), parametrName: "id", dbType: System.Data.DbType.Int32)]
        public void ReadToClass()
        {
            using var connection = OpenConnection();
            var list = connection.MsSqlToClass1(3).ToList();

            Assert.That(list, Has.Count.EqualTo(9));

            Assert.Multiple(() =>
            {
                Assert.That(list[0].Id, Is.EqualTo(0));
                Assert.That(list[0].FirstName, Is.EqualTo("John0"));
                Assert.That(list[0].MiddleName, Is.EqualTo("Сurly0"));
                Assert.That(list[0].LastName, Is.EqualTo("Doe0"));

                Assert.That(list[0].Identification, Is.EqualTo(null));
            });

            Assert.Multiple(() =>
            {
                Assert.That(list[3].Id, Is.EqualTo(4));
                Assert.That(list[3].FirstName, Is.EqualTo("John4"));
                Assert.That(list[3].MiddleName, Is.EqualTo("Сurly4"));
                Assert.That(list[3].LastName, Is.EqualTo("Doe4"));

                Assert.That(list[3].Identification, Is.Not.EqualTo(null));
            });

            var identification = list[3].Identification;
            Assert.Multiple(() =>
            {
                Assert.That(identification.Id, Is.EqualTo(4));
                Assert.That(identification.TypeName, Is.EqualTo("citizen's passport"));

                Assert.That(identification.Country, Is.EqualTo(null));
            });

            Assert.Multiple(() =>
            {
                Assert.That(list[4].Id, Is.EqualTo(5));
                Assert.That(list[4].FirstName, Is.EqualTo("John5"));
                Assert.That(list[4].MiddleName, Is.EqualTo("Сurly5"));
                Assert.That(list[4].LastName, Is.EqualTo("Doe5"));

                Assert.That(list[4].Identification, Is.Not.EqualTo(null));
            });

            identification = list[4].Identification;
            Assert.Multiple(() =>
            {
                Assert.That(identification.Id, Is.EqualTo(5));
                Assert.That(identification.TypeName, Is.EqualTo("party card"));

                Assert.That(identification.Country, Is.Not.EqualTo(null));
            });

            var country = list[4].Identification.Country;
            Assert.Multiple(() =>
            {
                Assert.That(country.Id, Is.EqualTo(5));
                Assert.That(country.Name, Is.EqualTo("Martian colony"));
            });
        }

        [Test]
        [Query(
            @"
SELECT 
    p.id,
    p.firstname,
~StartInner::Identification:id~
    i.id,
~StartInner::Country:id~
    c.id,
    c.name,
~EndInner::Country~
    i.typename,
~EndInner::Identification~
    p.middlename,
    p.lastname
FROM readfixtureperson p
LEFT JOIN readfixtureidentification i ON i.id = p.readfixtureidentification_id
LEFT JOIN readfixturecountry c ON c.id = i.readfixturecountry_id
WHERE p.id != @id AND p.id != @id2
ORDER BY p.id ASC
",
            typeof(ReadFixtureModel),
            Gedaq.Common.Enums.MethodType.Async | Gedaq.Common.Enums.MethodType.Sync,
            "MsSqlToClass2"
            )]
        [Parametr("MsSqlToClass2", parametrType: typeof(int), parametrName: "id")]
        [Parametr("MsSqlToClass2", parametrType: typeof(int), parametrName: "id2")]
        public async Task ReadToClassAsync()
        {
            using var connection = OpenConnection();
            var list = await connection.MsSqlToClass2Async(3, 6).ToListAsync();

            Assert.That(list, Has.Count.EqualTo(8));

            Assert.Multiple(() =>
            {
                Assert.That(list[0].Id, Is.EqualTo(0));
                Assert.That(list[0].FirstName, Is.EqualTo("John0"));
                Assert.That(list[0].MiddleName, Is.EqualTo("Сurly0"));
                Assert.That(list[0].LastName, Is.EqualTo("Doe0"));

                Assert.That(list[0].Identification, Is.EqualTo(null));
            });

            Assert.Multiple(() =>
            {
                Assert.That(list[3].Id, Is.EqualTo(4));
                Assert.That(list[3].FirstName, Is.EqualTo("John4"));
                Assert.That(list[3].MiddleName, Is.EqualTo("Сurly4"));
                Assert.That(list[3].LastName, Is.EqualTo("Doe4"));

                Assert.That(list[3].Identification, Is.Not.EqualTo(null));
            });

            var identification = list[3].Identification;
            Assert.Multiple(() =>
            {
                Assert.That(identification.Id, Is.EqualTo(4));
                Assert.That(identification.TypeName, Is.EqualTo("citizen's passport"));

                Assert.That(identification.Country, Is.EqualTo(null));
            });

            Assert.Multiple(() =>
            {
                Assert.That(list[4].Id, Is.EqualTo(5));
                Assert.That(list[4].FirstName, Is.EqualTo("John5"));
                Assert.That(list[4].MiddleName, Is.EqualTo("Сurly5"));
                Assert.That(list[4].LastName, Is.EqualTo("Doe5"));

                Assert.That(list[4].Identification, Is.Not.EqualTo(null));
            });

            identification = list[4].Identification;
            Assert.Multiple(() =>
            {
                Assert.That(identification.Id, Is.EqualTo(5));
                Assert.That(identification.TypeName, Is.EqualTo("party card"));

                Assert.That(identification.Country, Is.Not.EqualTo(null));
            });

            var country = list[4].Identification.Country;
            Assert.Multiple(() =>
            {
                Assert.That(country.Id, Is.EqualTo(5));
                Assert.That(country.Name, Is.EqualTo("Martian colony"));
            });
        }

        [Test]
        public void CreateCommand()
        {
            using var connection = OpenConnection();
            using var command = connection.CreateMsSqlToClass1Command(false, 10);
            Assert.That(command.CommandTimeout, Is.EqualTo(10));

            using var command2 = connection.CreateMsSqlToClass1Command(true);
            Assert.That(command2.CommandTimeout, Is.EqualTo(30));
        }

        [Test]
        public async Task CreateCommandAsync()
        {
            using var connection = OpenConnection();
            await using var command = await connection.CreateMsSqlToClass1CommandAsync(false, timeout: 10);
            Assert.That(command.CommandTimeout, Is.EqualTo(10));

            await using var command2 = await connection.CreateMsSqlToClass1CommandAsync(true);
            Assert.That(command2.CommandTimeout, Is.EqualTo(30));
        }

        [Test]
        [Query(
            @"
SELECT 
    P.id,
    p.firstname,
~StartInner::Identification:id~
    i.id,
~StartInner::Country:id~
    c.id,
    c.name,
~EndInner::Country~
    i.typename,
~EndInner::Identification~
    p.middlename,
    p.lastname
FROM readfixtureperson p
LEFT JOIN readfixtureidentification i ON i.id = p.readfixtureidentification_id
LEFT JOIN readfixturecountry c ON c.id = i.readfixturecountry_id
WHERE p.id != @id
ORDER BY p.id ASC
",
            typeof(object[]),
            Gedaq.Common.Enums.MethodType.Async | Gedaq.Common.Enums.MethodType.Sync,
            "MsSqlToObjArr"
            )]
        [Parametr("MsSqlToObjArr", parametrType: typeof(int), parametrName: "id")]
        public void ReadToObjArr()
        {
            using var connection = OpenConnection();
            var list = connection.MsSqlToObjArr(3).ToList();

            Assert.That(list, Has.Count.EqualTo(9));

            Assert.Multiple(() =>
            {
                Assert.That((int)list[0][0], Is.EqualTo(0));
                Assert.That((string)list[0][1], Is.EqualTo("John0"));
                Assert.That((DBNull)list[0][2], Is.EqualTo(DBNull.Value));
                Assert.That((DBNull)list[0][3], Is.EqualTo(DBNull.Value));
                Assert.That((DBNull)list[0][4], Is.EqualTo(DBNull.Value));
                Assert.That((DBNull)list[0][5], Is.EqualTo(DBNull.Value));
                Assert.That((string)list[0][6], Is.EqualTo("Сurly0"));
                Assert.That((string)list[0][7], Is.EqualTo("Doe0"));
            });

            Assert.Multiple(() =>
            {
                Assert.That((int)list[4][0], Is.EqualTo(5));
                Assert.That((string)list[4][1], Is.EqualTo("John5"));
                Assert.That((int)list[4][2], Is.EqualTo(5));
                Assert.That((int)list[4][3], Is.EqualTo(5));
                Assert.That((string)list[4][4], Is.EqualTo("Martian colony"));
                Assert.That((string)list[4][5], Is.EqualTo("party card"));
                Assert.That((string)list[4][6], Is.EqualTo("Сurly5"));
                Assert.That((string)list[4][7], Is.EqualTo("Doe5"));
            });
        }

        [Test]
        public async Task ReadToObjArrAsync()
        {
            using var connection = OpenConnection();
            var list = await connection.MsSqlToObjArrAsync(3).ToListAsync();

            Assert.That(list, Has.Count.EqualTo(9));

            Assert.Multiple(() =>
            {
                Assert.That((int)list[0][0], Is.EqualTo(0));
                Assert.That((string)list[0][1], Is.EqualTo("John0"));
                Assert.That((DBNull)list[0][2], Is.EqualTo(DBNull.Value));
                Assert.That((DBNull)list[0][3], Is.EqualTo(DBNull.Value));
                Assert.That((DBNull)list[0][4], Is.EqualTo(DBNull.Value));
                Assert.That((DBNull)list[0][5], Is.EqualTo(DBNull.Value));
                Assert.That((string)list[0][6], Is.EqualTo("Сurly0"));
                Assert.That((string)list[0][7], Is.EqualTo("Doe0"));
            });

            Assert.Multiple(() =>
            {
                Assert.That((int)list[4][0], Is.EqualTo(5));
                Assert.That((string)list[4][1], Is.EqualTo("John5"));
                Assert.That((int)list[4][2], Is.EqualTo(5));
                Assert.That((int)list[4][3], Is.EqualTo(5));
                Assert.That((string)list[4][4], Is.EqualTo("Martian colony"));
                Assert.That((string)list[4][5], Is.EqualTo("party card"));
                Assert.That((string)list[4][6], Is.EqualTo("Сurly5"));
                Assert.That((string)list[4][7], Is.EqualTo("Doe5"));
            });
        }
    }
}