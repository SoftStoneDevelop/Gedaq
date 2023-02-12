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

            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
CREATE TABLE IF NOT EXISTS public.readfixtureidentification
(
    id integer NOT NULL,
    typename text COLLATE pg_catalog.""default"" NOT NULL,
    CONSTRAINT readfixtureidentification_pkey PRIMARY KEY (id)
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
    @id, @firstname, @middlename, @lastname, @readfixtureidentification_id
);
";
            var id = cmd.CreateParameter();
            id.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
            id.ParameterName = "id";
            cmd.Parameters.Add(id);

            var firstname = cmd.CreateParameter();
            firstname.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;
            firstname.ParameterName = "firstname";
            cmd.Parameters.Add(firstname);

            var middlename = cmd.CreateParameter();
            middlename.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;
            middlename.ParameterName = "middlename";
            cmd.Parameters.Add(middlename);

            var lastname = cmd.CreateParameter();
            lastname.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;
            lastname.ParameterName = "lastname";
            cmd.Parameters.Add(lastname);

            var identificationId = cmd.CreateParameter();
            identificationId.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
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

        private void FillIdentification(NpgsqlCommand cmd)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = @"
INSERT INTO public.readfixtureidentification(
	id, typename)
	VALUES (
    @id, @typename
);
";
            var id = cmd.CreateParameter();
            id.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
            id.ParameterName = "id";
            cmd.Parameters.Add(id);

            var typename = cmd.CreateParameter();
            typename.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;
            typename.ParameterName = "typename";
            cmd.Parameters.Add(typename);
            cmd.Prepare();

            id.Value = 1;
            typename.Value = "sailor's passport";
            cmd.ExecuteNonQuery();

            id.Value = 2;
            typename.Value = "officer's certificate";
            cmd.ExecuteNonQuery();

            id.Value = 3;
            typename.Value = "driver license";
            cmd.ExecuteNonQuery();

            id.Value = 4;
            typename.Value = "citizen's passport";
            cmd.ExecuteNonQuery();

            id.Value = 5;
            typename.Value = "party card";
            cmd.ExecuteNonQuery();
        }

        [TearDown]
        public void Cleanup()
        {
            _dataSource.OpenConnection().DropTable("readfixtureperson");
            _dataSource.OpenConnection().DropTable("readfixtureidentification");
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
    i.typename,
~EndInner::Identification~
    r.middlename,
    r.lastname
FROM readfixtureperson r
LEFT JOIN readfixtureidentification i ON i.id = r.readfixtureidentification_id
",
            typeof(ReadFixtureModel),
            Gedaq.Provider.Enums.MethodType.Sync,
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
            Gedaq.Provider.Enums.MethodType.Sync,
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
            Gedaq.Provider.Enums.MethodType.Sync,
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
            typeof(ReadFixtureModel),
            Gedaq.Provider.Enums.MethodType.Async,
            Gedaq.Npgsql.Enums.SourceType.Connection,
            "ToClass"
            )]
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
            Gedaq.Provider.Enums.MethodType.Async,
            Gedaq.Npgsql.Enums.SourceType.Connection,
            "ToObjArr"
            )]
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
            Gedaq.Provider.Enums.MethodType.Async,
            Gedaq.Npgsql.Enums.SourceType.Connection,
            "ToObj"
            )]
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