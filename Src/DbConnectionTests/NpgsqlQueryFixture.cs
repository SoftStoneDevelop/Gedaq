using DbConnectionTests.Helpers;
using DbConnectionTests.Model;
using Gedaq.Common.Attributes;
using Gedaq.DbConnection.Attributes;
using Npgsql;
using NUnit.Framework;
using System;
using System.Data;
using System.Linq;

namespace DbConnectionTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    internal partial class NpgsqlQueryFixture : BaseFixture
    {
        #region Init and destroy

        protected NpgsqlDataSource _dataSource;

        [SetUp]
        public void Init()
        {
            var dataSourceBuilder = new NpgsqlDataSourceBuilder(GetNpgsqlSqlConnectionString());
            _dataSource = dataSourceBuilder.Build();
            using var conn = _dataSource.OpenConnection();
            NpgsqlDatabaseHelper.DropTable(conn, "dbconnectionperson");
            NpgsqlDatabaseHelper.DropTable(conn, "dbconnectionidentification");
            NpgsqlDatabaseHelper.DropTable(conn, "dbconnectioncountry");

            using var cmd = conn.CreateCommand();
            DropFunction(cmd);

            CreateCountryTable(cmd);
            FillСountries(cmd);

            CreateIdentificationTable(cmd);
            FillIdentification(cmd);

            CreatePersonTable(cmd);
            FillPerson(cmd);

            CreateFunction(cmd);
        }

        private void CreateCountryTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE IF NOT EXISTS public.dbconnectioncountry
(
    id integer NOT NULL,
    name text COLLATE pg_catalog.""default"" NOT NULL,
    CONSTRAINT dbconnectioncountry_pkey PRIMARY KEY (id)
);
";
            cmd.ExecuteNonQuery();
        }

        private void CreateIdentificationTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE IF NOT EXISTS public.dbconnectionidentification
(
    id integer NOT NULL,
    typename text COLLATE pg_catalog.""default"" NOT NULL,
    country_id integer,
    CONSTRAINT dbconnectionidentification_pkey PRIMARY KEY (id),
    CONSTRAINT dbconnectioncountry_fk FOREIGN KEY (country_id)
        REFERENCES public.dbconnectioncountry (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            cmd.ExecuteNonQuery();
        }

        private void CreatePersonTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE IF NOT EXISTS public.dbconnectionperson
(
    id integer NOT NULL,
    firstname text COLLATE pg_catalog.""default"" NOT NULL,
    middlename text COLLATE pg_catalog.""default"",
    lastname text COLLATE pg_catalog.""default"",
    identification_id integer,
    CONSTRAINT dbconnectionperson_pkey PRIMARY KEY (id),
    CONSTRAINT dbconnectionidentification_fk FOREIGN KEY (identification_id)
        REFERENCES public.dbconnectionidentification (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            cmd.ExecuteNonQuery();
        }

        private void FillPerson(NpgsqlCommand cmd)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = @"
INSERT INTO public.dbconnectionperson(
	id, firstname, middlename, lastname, identification_id)
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
INSERT INTO public.dbconnectioncountry(
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
INSERT INTO public.dbconnectionidentification(
	id, typename, country_id)
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

        private void CreateFunction(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE FUNCTION dbconnectionfunc(in int, out out1 int, out out2 text)
    AS $$ SELECT $1, CAST($1 AS text) || ' is text' $$
    LANGUAGE SQL;
";
            cmd.ExecuteNonQuery();
        }

        private void DropFunction(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP FUNCTION IF EXISTS dbconnectionfunc(in INT, out int, out text);
";
            cmd.ExecuteNonQuery();
        }
        [TearDown]
        public void Cleanup()
        {
            using (var connection = _dataSource.OpenConnection())
            {
                using var cmd = connection.CreateCommand();
                DropFunction(cmd);

                connection.DropTable("dbconnectionperson");
                connection.DropTable("dbconnectionidentification");
                connection.DropTable("dbconnectioncountry");
            }
            _dataSource?.Dispose();
        }

        #endregion

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
FROM dbconnectionperson p
LEFT JOIN dbconnectionidentification i ON i.id = p.identification_id
LEFT JOIN dbconnectioncountry c ON c.id = i.country_id
WHERE p.id != @id
ORDER BY p.id ASC
",
            "NpgsqlToClass1",
            typeof(Person),
            Gedaq.Common.Enums.MethodType.Async | Gedaq.Common.Enums.MethodType.Sync
            ),
            Parametr(parametrType: typeof(int), parametrName: "id", dbType: System.Data.DbType.Int32)
            ]
        public void NpgsqlToClass1()
        {
        }

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
FROM dbconnectionperson p
LEFT JOIN dbconnectionidentification i ON i.id = p.identification_id
LEFT JOIN dbconnectioncountry c ON c.id = i.country_id
WHERE p.id != {1} AND p.id != {0}
ORDER BY p.id ASC
",
            "NpgsqlToClass2",
            typeof(Person),
            Gedaq.Common.Enums.MethodType.Async | Gedaq.Common.Enums.MethodType.Sync
            ),
            QueryFormat(1, "condition"),
            QueryFormat(0)
            ]
        public void NpgsqlToClass2()
        {
        }

        [Test]
        [QueryBatch("NpgsqlBatchReadToClass", Gedaq.Common.Enums.QueryType.Read | Gedaq.Common.Enums.QueryType.Scalar, Gedaq.Common.Enums.MethodType.Sync),
            BatchPart("NpgsqlToClass2", 1),
            BatchPart("NpgsqlToClass1", 2)
            ]
        public void BatchReadToClass()
        {
            using var connection = _dataSource.OpenConnection();
            var batchList = NpgsqlBatchReadToClass(connection, 6.ToString(), 3.ToString(), 3).Select(sel => sel.ToList()).ToList();

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
        public void BatchScalarToClass()
        {
            using var connection = _dataSource.OpenConnection();
            var id = ScalarNpgsqlBatchReadToClass(connection, 0.ToString(), 1.ToString(), 0);
            Assert.That(id, Is.EqualTo(2));
        }

        [Test]
        [Query(
            @"
select * from dbconnectionfunc(@inParam);
",
            "FuncOut",
            queryType: Gedaq.Common.Enums.QueryType.NonQuery
            ),
            Parametr(parametrType: typeof(int), parametrName: "inParam", direction: ParameterDirection.Input),
            Parametr(parametrType: typeof(int), parametrName: "out1", direction: ParameterDirection.Output),
            Parametr(parametrType: typeof(string), parametrName: "out2", direction: ParameterDirection.Output)
            ]
        public void TestFuncOut()
        {
            using var connection = _dataSource.OpenConnection();
            var result = NonQueryFuncOut(connection, 46, out var out1, out var out2);
            Assert.Multiple(() =>
            {
                Assert.That(out1, Is.EqualTo(46));
                Assert.That(out2, Is.EqualTo("46 is text"));
            });
        }

        [Test]
        [Query(
            @"
select out1, out2 from dbconnectionfunc(@inParam);
",
            "ReadFunc",
            typeof(ReadFunc),
            queryType: Gedaq.Common.Enums.QueryType.Read
            ),
            Parametr(parametrType: typeof(int), parametrName: "inParam", direction: ParameterDirection.Input)
            ]
        public void TestReadFunc()
        {
            using var connection = _dataSource.OpenConnection();
            var result = ReadFunc(connection, 24).First();
            Assert.Multiple(() =>
            {
                Assert.That(result.Out1, Is.EqualTo(24));
                Assert.That(result.Out2, Is.EqualTo("24 is text"));
            });
        }

        [Test]
        [Query(
            @"
SELECT 
~StartInner::Person:id~
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
    p.lastname,
~EndInner::Person~
	func.out1,
	func.out2
FROM dbconnectionperson p
LEFT JOIN dbconnectionidentification i ON i.id = p.identification_id
LEFT JOIN dbconnectioncountry c ON c.id = i.country_id
LEFT JOIN LATERAL dbconnectionfunc(@inParam) AS func ON true
WHERE p.id = @personId
ORDER BY p.id ASC
",
            "ReadFuncPerson",
            typeof(ReadFunc),
             queryType: Gedaq.Common.Enums.QueryType.Read
            ),
            Parametr(parametrType: typeof(int), parametrName: "inParam", direction: ParameterDirection.Input),
            Parametr(parametrType: typeof(int), parametrName: "personId", direction: ParameterDirection.Input)
            ]
        public void TestReadFuncAndPerson()
        {
            using var connection = _dataSource.OpenConnection();
            var result = ReadFuncPerson(connection, 13, 1).First();
            Assert.Multiple(() =>
            {
                Assert.That(result.Out1, Is.EqualTo(13));
                Assert.That(result.Out2, Is.EqualTo("13 is text"));
                Assert.That(result.Person.Id, Is.EqualTo(1));
                Assert.That(result.Person.Identification.Id, Is.EqualTo(1));
                Assert.That(result.Person.Identification.Country.Id, Is.EqualTo(1));
            });
        }
    }
}