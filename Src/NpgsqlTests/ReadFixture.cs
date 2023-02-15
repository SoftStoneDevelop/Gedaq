using Microsoft.Extensions.Configuration;
using Npgsql;
using NpgsqlTests.Helpers;
using NUnit.Framework;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace NpgsqlTests
{
    public class ReadFixtureModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public ReadFixtureIdentificationModel Identification { get; set; }
    }

    public class ReadFixtureIdentificationModel
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public ReadFixtureCountryModel Country { get; set; }
    }

    public class ReadFixtureCountryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    [TestFixture]
    internal class ReadFixture : BaseFixture
    {
        #region Init and destroy

        protected NpgsqlDataSource _dataSource;

        [SetUp]
        public void Init()
        {
            var dataSourceBuilder = new NpgsqlDataSourceBuilder(Settings.GetConnectionString("SqlConnection"));
            _dataSource = dataSourceBuilder.Build();
            var conn = _dataSource.OpenConnection();
            conn.DropTable("readfixtureperson");
            conn.DropTable("readfixtureidentification");
            conn.DropTable("readfixturecountry");

            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
CREATE TABLE IF NOT EXISTS public.readfixturecountry
(
    id integer NOT NULL,
    name text COLLATE pg_catalog.""default"" NOT NULL,
    CONSTRAINT readfixturecountry_pkey PRIMARY KEY (id)
);

CREATE TABLE IF NOT EXISTS public.readfixtureidentification
(
    id integer NOT NULL,
    typename text COLLATE pg_catalog.""default"" NOT NULL,
    readfixturecountry_id integer,
    CONSTRAINT readfixtureidentification_pkey PRIMARY KEY (id),
    CONSTRAINT readfixturecountry_fk FOREIGN KEY (readfixturecountry_id)
        REFERENCES public.readfixturecountry (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);

CREATE TABLE IF NOT EXISTS public.readfixtureperson
(
    id integer NOT NULL,
    firstname text COLLATE pg_catalog.""default"" NOT NULL,
    middlename text COLLATE pg_catalog.""default"",
    lastname text COLLATE pg_catalog.""default"",
    readfixtureidentification_id integer,
    CONSTRAINT readfixtureperson_pkey PRIMARY KEY (id),
    CONSTRAINT readfixtureidentification_fk FOREIGN KEY (readfixtureidentification_id)
        REFERENCES public.readfixtureidentification (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            cmd.ExecuteNonQuery();
            FillСountries(cmd);
            FillIdentification(cmd);
            FillPerson(cmd);
        }

        private void FillPerson(NpgsqlCommand cmd)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = @"
INSERT INTO public.readfixtureperson(
	id, firstname, middlename, lastname, readfixtureidentification_id)
	VALUES (
    $1, $2, $3, $4, $5
);
";
            var id = new NpgsqlParameter<int>();
            id.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
            cmd.Parameters.Add(id);

            var firstname = new NpgsqlParameter<string>();
            firstname.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;
            cmd.Parameters.Add(firstname);

            var middlename = new NpgsqlParameter<string>();
            middlename.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;
            cmd.Parameters.Add(middlename);

            var lastname = new NpgsqlParameter<string>();
            lastname.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;
            cmd.Parameters.Add(lastname);

            var identificationId = new NpgsqlParameter();
            identificationId.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
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

        private void FillСountries(NpgsqlCommand cmd)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = @"
INSERT INTO public.readfixturecountry(
	id, name)
	VALUES (
    $1, $2
);
";
            var id = new NpgsqlParameter<int>();
            id.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
            cmd.Parameters.Add(id);

            var typename = new NpgsqlParameter<string>();
            typename.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;
            cmd.Parameters.Add(typename);
            cmd.Prepare();

            id.TypedValue = 1;
            typename.TypedValue = "Russia";
            cmd.ExecuteNonQuery();

            id.TypedValue = 2;
            typename.TypedValue = "China";
            cmd.ExecuteNonQuery();

            id.TypedValue = 3;
            typename.TypedValue = "Serbia";
            cmd.ExecuteNonQuery();

            id.TypedValue = 4;
            typename.TypedValue = "Belarus";
            cmd.ExecuteNonQuery();

            id.TypedValue = 5;
            typename.TypedValue = "Martian colony";
            cmd.ExecuteNonQuery();
        }

        private void FillIdentification(NpgsqlCommand cmd)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = @"
INSERT INTO public.readfixtureidentification(
	id, typename, readfixturecountry_id)
	VALUES (
    $1, $2, $3
);
";
            var id = new NpgsqlParameter<int>();
            id.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
            cmd.Parameters.Add(id);

            var typename = new NpgsqlParameter<string>();
            typename.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;
            cmd.Parameters.Add(typename);

            var countryId = new NpgsqlParameter();
            countryId.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
            countryId.IsNullable = true;
            cmd.Parameters.Add(countryId);
            cmd.Prepare();

            id.TypedValue = 1;
            typename.TypedValue = "sailor's passport";
            countryId.Value = 1;
            cmd.ExecuteNonQuery();

            id.TypedValue = 2;
            typename.TypedValue = "officer's certificate";
            countryId.Value = 2;
            cmd.ExecuteNonQuery();

            id.TypedValue = 3;
            typename.TypedValue = "driver license";
            countryId.Value = 3;
            cmd.ExecuteNonQuery();

            id.TypedValue = 4;
            typename.TypedValue = "citizen's passport";
            countryId.Value = DBNull.Value;
            cmd.ExecuteNonQuery();

            id.TypedValue = 5;
            typename.TypedValue = "party card";
            countryId.Value = 5;
            cmd.ExecuteNonQuery();
        }

        [TearDown]
        public void Cleanup()
        {
            _dataSource.OpenConnection().DropTable("readfixtureperson");
            _dataSource.OpenConnection().DropTable("readfixtureidentification");
            _dataSource.OpenConnection().DropTable("readfixturecountry");
            _dataSource?.Dispose();
        }

        #endregion

        #region Sync

        [Test]
        [Gedaq.Npgsql.Attributes.QueryRead(
            @"
SELECT 
    r.id,
    r.firstname,
~StartInner::Identification:id~
    i.id,
~StartInner::Country:id~
    c.id,
    c.name,
~EndInner::Country~
    i.typename,
~EndInner::Identification~
    r.middlename,
    r.lastname
FROM readfixtureperson r
LEFT JOIN readfixtureidentification i ON i.id = r.readfixtureidentification_id
LEFT JOIN readfixturecountry c ON c.id = i.readfixturecountry_id
",
            typeof(ReadFixtureModel),
            Gedaq.Provider.Enums.MethodType.Async | Gedaq.Provider.Enums.MethodType.Sync,
            Gedaq.Npgsql.Enums.SourceType.Connection,
            "ToClass"
            )]
        public void ReadToClassConnection()
        {
            var list = _dataSource.OpenConnection().ToClass().ToList();

            Assert.That(list, Has.Count.EqualTo(10));

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
                Assert.That(list[5].Id, Is.EqualTo(5));
                Assert.That(list[5].FirstName, Is.EqualTo("John5"));
                Assert.That(list[5].MiddleName, Is.EqualTo("Сurly5"));
                Assert.That(list[5].LastName, Is.EqualTo("Doe5"));

                Assert.That(list[5].Identification.Id, Is.EqualTo(5));
                Assert.That(list[5].Identification.TypeName, Is.EqualTo("party card"));
            });
        }

        [Test]
        [Gedaq.Npgsql.Attributes.QueryRead(
            @"
SELECT 
    r.id,
    r.firstname,
~StartInner::Identification:id~
    i.id,
    i.typename,
~EndInner::Identification~
    r.middlename,
    r.lastname
FROM readfixtureperson r
LEFT JOIN readfixtureidentification i ON i.id = r.readfixtureidentification_id
",
            typeof(object[]),
            Gedaq.Provider.Enums.MethodType.Async | Gedaq.Provider.Enums.MethodType.Sync,
            Gedaq.Npgsql.Enums.SourceType.Connection,
            "ToObjArr"
            )]
        public void ReadToObjArrConnection()
        {
            var list = _dataSource.OpenConnection().ToObjArr().ToList();

            Assert.That(list, Has.Count.EqualTo(10));

            Assert.Multiple(() =>
            {
                Assert.That((int)list[0][0], Is.EqualTo(0));
                Assert.That((string)list[0][1], Is.EqualTo("John0"));
                Assert.That((DBNull)list[0][2], Is.EqualTo(DBNull.Value));
                Assert.That((DBNull)list[0][3], Is.EqualTo(DBNull.Value));
                Assert.That((string)list[0][4], Is.EqualTo("Сurly0"));
                Assert.That((string)list[0][5], Is.EqualTo("Doe0"));
            });

            Assert.Multiple(() =>
            {
                Assert.That((int)list[5][0], Is.EqualTo(5));
                Assert.That((string)list[5][1], Is.EqualTo("John5"));
                Assert.That((int)list[5][2], Is.EqualTo(5));
                Assert.That((string)list[5][3], Is.EqualTo("party card"));
                Assert.That((string)list[5][4], Is.EqualTo("Сurly5"));
                Assert.That((string)list[5][5], Is.EqualTo("Doe5"));
            });
        }

        [Test]
        [Gedaq.Npgsql.Attributes.QueryRead(
            @"
SELECT 
    (r.id,
    r.firstname,
    i.id,
    i.typename,
    r.middlename,
    r.lastname) row
FROM readfixtureperson r
LEFT JOIN readfixtureidentification i ON i.id = r.readfixtureidentification_id
",
            typeof(object),
            Gedaq.Provider.Enums.MethodType.Async | Gedaq.Provider.Enums.MethodType.Sync,
            Gedaq.Npgsql.Enums.SourceType.Connection,
            "ToObj"
            )]
        public void ReadToObjConnection()
        {
            var list = _dataSource.OpenConnection().ToObj().ToList();

            Assert.That(list, Has.Count.EqualTo(10));

            Assert.Multiple(() =>
            {
                Assert.That((int)((object[])list[0])[0], Is.EqualTo(0));
                Assert.That((string)((object[])list[0])[1], Is.EqualTo("John0"));
                Assert.That((int?)((object[])list[0])[2], Is.EqualTo(null));
                Assert.That((string)((object[])list[0])[3], Is.EqualTo(null));
                Assert.That((string)((object[])list[0])[4], Is.EqualTo("Сurly0"));
                Assert.That((string)((object[])list[0])[5], Is.EqualTo("Doe0"));
            });

            Assert.Multiple(() =>
            {
                Assert.That((int)((object[])list[5])[0], Is.EqualTo(5));
                Assert.That((string)((object[])list[5])[1], Is.EqualTo("John5"));
                Assert.That((int?)((object[])list[5])[2], Is.EqualTo(5));
                Assert.That((string)((object[])list[5])[3], Is.EqualTo("party card"));
                Assert.That((string)((object[])list[5])[4], Is.EqualTo("Сurly5"));
                Assert.That((string)((object[])list[5])[5], Is.EqualTo("Doe5"));
            });
        }

        #endregion

        #region Async

        [Test]
        public async Task ReadToClassConnectionAsync()
        {
            var list = await _dataSource.OpenConnection().ToClassAsync().ToListAsync();

            Assert.That(list, Has.Count.EqualTo(10));

            Assert.Multiple(() =>
            {
                Assert.That(list[0].Id, Is.EqualTo(0));
                Assert.That(list[0].FirstName, Is.EqualTo("John0"));
                Assert.That(list[0].MiddleName, Is.EqualTo("Сurly0"));
                Assert.That(list[0].LastName, Is.EqualTo("Doe0"));
            });

            Assert.Multiple(() =>
            {
                Assert.That(list[6].Id, Is.EqualTo(6));
                Assert.That(list[6].FirstName, Is.EqualTo("John6"));
                Assert.That(list[6].MiddleName, Is.EqualTo("Сurly6"));
                Assert.That(list[6].LastName, Is.EqualTo("Doe6"));
            });
        }

        [Test]
        public async Task ReadToObjArrConnectionAsync()
        {
            var list = await _dataSource.OpenConnection().ToObjArrAsync().ToListAsync();

            Assert.That(list, Has.Count.EqualTo(10));

            Assert.Multiple(() =>
            {
                Assert.That((int)list[0][0], Is.EqualTo(0));
                Assert.That((string)list[0][1], Is.EqualTo("John0"));
                Assert.That((DBNull)list[0][2], Is.EqualTo(DBNull.Value));
                Assert.That((DBNull)list[0][3], Is.EqualTo(DBNull.Value));
                Assert.That((string)list[0][4], Is.EqualTo("Сurly0"));
                Assert.That((string)list[0][5], Is.EqualTo("Doe0"));
            });

            Assert.Multiple(() =>
            {
                Assert.That((int)list[5][0], Is.EqualTo(5));
                Assert.That((string)list[5][1], Is.EqualTo("John5"));
                Assert.That((int)list[5][2], Is.EqualTo(5));
                Assert.That((string)list[5][3], Is.EqualTo("party card"));
                Assert.That((string)list[5][4], Is.EqualTo("Сurly5"));
                Assert.That((string)list[5][5], Is.EqualTo("Doe5"));
            });
        }

        [Test]
        public async Task ReadToObjConnectionAsync()
        {
            var list = await _dataSource.OpenConnection().ToObjAsync().ToListAsync();

            Assert.That(list, Has.Count.EqualTo(10));

            Assert.Multiple(() =>
            {
                Assert.That((int)((object[])list[0])[0], Is.EqualTo(0));
                Assert.That((string)((object[])list[0])[1], Is.EqualTo("John0"));
                Assert.That((int?)((object[])list[0])[2], Is.EqualTo(null));
                Assert.That((string)((object[])list[0])[3], Is.EqualTo(null));
                Assert.That((string)((object[])list[0])[4], Is.EqualTo("Сurly0"));
                Assert.That((string)((object[])list[0])[5], Is.EqualTo("Doe0"));
            });

            Assert.Multiple(() =>
            {
                Assert.That((int)((object[])list[5])[0], Is.EqualTo(5));
                Assert.That((string)((object[])list[5])[1], Is.EqualTo("John5"));
                Assert.That((int?)((object[])list[5])[2], Is.EqualTo(5));
                Assert.That((string)((object[])list[5])[3], Is.EqualTo("party card"));
                Assert.That((string)((object[])list[5])[4], Is.EqualTo("Сurly5"));
                Assert.That((string)((object[])list[5])[5], Is.EqualTo("Doe5"));
            });
        }

        #endregion
    }
}