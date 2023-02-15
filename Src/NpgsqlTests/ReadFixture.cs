using Gedaq.Npgsql.Attributes;
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

        [Test]
        [QueryRead(
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
WHERE p.id != $1
ORDER BY p.id ASC
",
            typeof(ReadFixtureModel),
            Gedaq.Provider.Enums.MethodType.Async | Gedaq.Provider.Enums.MethodType.Sync,
            Gedaq.Npgsql.Enums.SourceType.Connection,
            "ToClass1",
            Gedaq.Common.Enums.GenerateType.Single | Gedaq.Common.Enums.GenerateType.Batch,
            "BatchReadToClass",
            2
            )]
        [Parametr("ToClass1", parametrType: typeof(int), position: 1)]
        public void ReadToClass()
        {
            var list = _dataSource.OpenConnection().ToClass1(3).ToList();

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
        [QueryRead(
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
WHERE p.id != $1 AND p.id != $2
ORDER BY p.id ASC
",
            typeof(ReadFixtureModel),
            Gedaq.Provider.Enums.MethodType.Async | Gedaq.Provider.Enums.MethodType.Sync,
            Gedaq.Npgsql.Enums.SourceType.Connection,
            "ToClass2",
            Gedaq.Common.Enums.GenerateType.Single | Gedaq.Common.Enums.GenerateType.Batch,
            "BatchReadToClass",
            1
            )]
        [Parametr("ToClass2", parametrType: typeof(int), position: 1)]
        [Parametr("ToClass2", parametrType: typeof(int), position: 2)]
        public async Task ReadToClassAsync()
        {
            var list = await _dataSource.OpenConnection().ToClass2Async(3, 6).ToListAsync();

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
        public void BatchReadToClass()
        {
            var batchList = _dataSource.OpenConnection().BatchReadToClass(3, 6, 3).Select(sel => sel.ToList()).ToList();

            var list = batchList[0];
            {
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

            list = batchList[1];
            {
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
        }

        [Test]
        public void CreateCommand()
        {
            using var command = _dataSource.OpenConnection().CreateToClass1Command(false, 10);
            Assert.That(command.IsPrepared, Is.EqualTo(false));
            Assert.That(command.CommandTimeout, Is.EqualTo(10));

            using var command2 = _dataSource.OpenConnection().CreateToClass1Command(true);
            Assert.That(command2.IsPrepared, Is.EqualTo(true));
            Assert.That(command2.CommandTimeout, Is.EqualTo(30));
        }

        [Test]
        public async Task CreateCommandAsync()
        {
            using var command = await _dataSource.OpenConnection().CreateToClass1CommandAsync(false, timeout: 10);
            Assert.That(command.IsPrepared, Is.EqualTo(false));
            Assert.That(command.CommandTimeout, Is.EqualTo(10));

            using var command2 = await _dataSource.OpenConnection().CreateToClass1CommandAsync(true);
            Assert.That(command2.IsPrepared, Is.EqualTo(true));
            Assert.That(command2.CommandTimeout, Is.EqualTo(30));
        }

        [Test]
        [Gedaq.Npgsql.Attributes.QueryRead(
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
WHERE p.id != $1
ORDER BY p.id ASC
",
            typeof(object[]),
            Gedaq.Provider.Enums.MethodType.Async | Gedaq.Provider.Enums.MethodType.Sync,
            Gedaq.Npgsql.Enums.SourceType.Connection,
            "ToObjArr"
            )]
        [Parametr("ToObjArr", parametrType: typeof(int), position: 1)]
        public void ReadToObjArr()
        {
            var list = _dataSource.OpenConnection().ToObjArr(3).ToList();

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
            var list = await _dataSource.OpenConnection().ToObjArrAsync(3).ToListAsync();

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
        [Gedaq.Npgsql.Attributes.QueryRead(
            @"
SELECT 
    (p.id,
    p.firstname,
    i.id,
    c.id,
    c.name,
    i.typename,
    p.middlename,
    p.lastname) row
FROM readfixtureperson p
LEFT JOIN readfixtureidentification i ON i.id = p.readfixtureidentification_id
LEFT JOIN readfixturecountry c ON c.id = i.readfixturecountry_id
WHERE p.id != $1
ORDER BY p.id ASC
",
            typeof(object),
            Gedaq.Provider.Enums.MethodType.Async | Gedaq.Provider.Enums.MethodType.Sync,
            Gedaq.Npgsql.Enums.SourceType.Connection,
            "ToObj"
            )]
        [Parametr("ToObj", parametrType: typeof(int), position: 1)]
        public void ReadToObj()
        {
            var list = _dataSource.OpenConnection().ToObj(3).ToList();

            Assert.That(list, Has.Count.EqualTo(9));

            Assert.Multiple(() =>
            {
                Assert.That((int)((object[])list[0])[0], Is.EqualTo(0));
                Assert.That((string)((object[])list[0])[1], Is.EqualTo("John0"));
                Assert.That((int?)((object[])list[0])[2], Is.EqualTo(null));
                Assert.That((string)((object[])list[0])[3], Is.EqualTo(null));
                Assert.That((int?)((object[])list[0])[4], Is.EqualTo(null));
                Assert.That((string)((object[])list[0])[5], Is.EqualTo(null));
                Assert.That((string)((object[])list[0])[6], Is.EqualTo("Сurly0"));
                Assert.That((string)((object[])list[0])[7], Is.EqualTo("Doe0"));
            });

            Assert.Multiple(() =>
            {
                Assert.That((int)((object[])list[4])[0], Is.EqualTo(5));
                Assert.That((string)((object[])list[4])[1], Is.EqualTo("John5"));
                Assert.That((int?)((object[])list[4])[2], Is.EqualTo(5));
                Assert.That((int?)((object[])list[4])[3], Is.EqualTo(5));
                Assert.That((string)((object[])list[4])[4], Is.EqualTo("Martian colony"));
                Assert.That((string)((object[])list[4])[5], Is.EqualTo("party card"));
                Assert.That((string)((object[])list[4])[6], Is.EqualTo("Сurly5"));
                Assert.That((string)((object[])list[4])[7], Is.EqualTo("Doe5"));
            });
        }

        [Test]
        public async Task ReadToObjAsync()
        {
            var list = await _dataSource.OpenConnection().ToObjAsync(3).ToListAsync();

            Assert.That(list, Has.Count.EqualTo(9));

            Assert.Multiple(() =>
            {
                Assert.That((int)((object[])list[0])[0], Is.EqualTo(0));
                Assert.That((string)((object[])list[0])[1], Is.EqualTo("John0"));
                Assert.That((int?)((object[])list[0])[2], Is.EqualTo(null));
                Assert.That((string)((object[])list[0])[3], Is.EqualTo(null));
                Assert.That((int?)((object[])list[0])[4], Is.EqualTo(null));
                Assert.That((string)((object[])list[0])[5], Is.EqualTo(null));
                Assert.That((string)((object[])list[0])[6], Is.EqualTo("Сurly0"));
                Assert.That((string)((object[])list[0])[7], Is.EqualTo("Doe0"));
            });

            Assert.Multiple(() =>
            {
                Assert.That((int)((object[])list[4])[0], Is.EqualTo(5));
                Assert.That((string)((object[])list[4])[1], Is.EqualTo("John5"));
                Assert.That((int?)((object[])list[4])[2], Is.EqualTo(5));
                Assert.That((int?)((object[])list[4])[3], Is.EqualTo(5));
                Assert.That((string)((object[])list[4])[4], Is.EqualTo("Martian colony"));
                Assert.That((string)((object[])list[4])[5], Is.EqualTo("party card"));
                Assert.That((string)((object[])list[4])[6], Is.EqualTo("Сurly5"));
                Assert.That((string)((object[])list[4])[7], Is.EqualTo("Doe5"));
            });
        }
    }
}