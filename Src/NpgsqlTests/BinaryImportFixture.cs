using Gedaq.Npgsql.Attributes;
using Gedaq.Npgsql.Model;
using Microsoft.Extensions.Configuration;
using Npgsql;
using NpgsqlTests.Helpers;
using NpgsqlTests.Model;
using NpgsqlTypes;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NpgsqlTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    internal class BinaryImportFixture : BaseFixture
    {
        #region Init and destroy

        protected NpgsqlDataSource _dataSource;
        private List<ReadFixtureModel> _persons;

        [SetUp]
        public void Init()
        {
            var dataSourceBuilder = new NpgsqlDataSourceBuilder(Settings.GetConnectionString("SqlConnection"));
            _dataSource = dataSourceBuilder.Build();
            var conn = _dataSource.OpenConnection();
            conn.DropTable("binaryimportperson");
            conn.DropTable("binaryimportidentification");

            using var cmd = conn.CreateCommand();

            CreateIdentificationTable(cmd);
            FillIdentification(cmd);

            CreatePersonTable(cmd);
            SetPersons();
        }

        private void CreateIdentificationTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE IF NOT EXISTS public.binaryimportidentification
(
    id integer NOT NULL,
    typename text COLLATE pg_catalog.""default"" NOT NULL,
    CONSTRAINT binaryimportidentification_pkey PRIMARY KEY (id)
);
";
            cmd.ExecuteNonQuery();
        }

        private void CreatePersonTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE IF NOT EXISTS public.binaryimportperson
(
    id integer NOT NULL,
    firstname text COLLATE pg_catalog.""default"" NULL,
    middlename text COLLATE pg_catalog.""default"",
    lastname text COLLATE pg_catalog.""default"",
    binaryimportidentification_id integer,
    CONSTRAINT binaryimportperson_pkey PRIMARY KEY (id),
    CONSTRAINT binaryimportidentification_fk FOREIGN KEY (binaryimportidentification_id)
        REFERENCES public.binaryimportidentification (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            cmd.ExecuteNonQuery();
        }


        [BinaryExport(@"
COPY binaryimportperson 
(
id,
firstname,
~StartInner::Identification:id~
    ~Reinterpret::id~
binaryimportidentification_id,
~EndInner::Identification~
middlename,
lastname
) TO STDOUT (FORMAT BINARY)
",
            "ExportBinaryImportFixture",
            typeof(ReadFixtureModel),
            Gedaq.Common.Enums.MethodType.Sync | Gedaq.Common.Enums.MethodType.Async
            )]
        private void SetPersons()
        {
            _persons = new List<ReadFixtureModel>();
            for (int i = 0; i < 10; i++)
            {
                var item = new ReadFixtureModel();
                item.Id = i;
                if (i > 0 && i < 6)
                {
                    item.FirstName = $"John{i}";
                    item.MiddleName = $"Сurly{i}";
                    item.LastName = $"Doe{i}";
                    item.Identification = new ReadFixtureIdentificationModel() { Id = i };
                }

                _persons.Add(item);
            }
        }

        private void FillIdentification(NpgsqlCommand cmd)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = @"
INSERT INTO public.binaryimportidentification(
	id, typename)
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
            typename.TypedValue = "sailor's passport";
            cmd.ExecuteNonQuery();

            id.TypedValue = 2;
            typename.TypedValue = "officer's certificate";
            cmd.ExecuteNonQuery();

            id.TypedValue = 3;
            typename.TypedValue = "driver license";
            cmd.ExecuteNonQuery();

            id.TypedValue = 4;
            typename.TypedValue = "citizen's passport";
            cmd.ExecuteNonQuery();

            id.TypedValue = 5;
            typename.TypedValue = "party card";
            cmd.ExecuteNonQuery();
        }

        [TearDown]
        public void Cleanup()
        {
            using (var connection = _dataSource.OpenConnection())
            {
                using var cmd = connection.CreateCommand();

                connection.DropTable("binaryimportperson");
                connection.DropTable("binaryimportidentification");
            }
            _dataSource?.Dispose();
        }

        #endregion

        [Test]
        [BinaryImport(@"
COPY binaryimportperson 
(
id,
firstname,
~StartInner::Identification:id~
    ~Reinterpret::id~
binaryimportidentification_id,
~EndInner::Identification~
middlename,
lastname
) 
FROM STDIN (FORMAT BINARY)
", 
            "BinaryImport",
            typeof(ReadFixtureModel),
            new NpgsqlDbType[] 
            { 
                NpgsqlDbType.Integer,
                NpgsqlDbType.Text,
                NpgsqlDbType.Integer,
                NpgsqlDbType.Text,
                NpgsqlDbType.Text
            },
            Gedaq.Common.Enums.MethodType.Sync | Gedaq.Common.Enums.MethodType.Async
            )]
        public void BinaryImportTest()
        {
            using var connection = _dataSource.OpenConnection();
            connection.BinaryImport(_persons);

            var list = connection.ExportBinaryImportFixture().ToList();
            BinaryExportTableCheck(list);
        }

        [Test]
        public async Task BinaryImportAsyncTest()
        {
            await using var connection = _dataSource.OpenConnection();
            await connection.BinaryImportAsync(_persons);

            var list = await connection.ExportBinaryImportFixtureAsync().ToListAsync();
            BinaryExportTableCheck(list);
        }

        private void BinaryExportTableCheck(List<ReadFixtureModel> list)
        {
            Assert.That(list, Has.Count.EqualTo(10));

            Assert.Multiple(() =>
            {
                Assert.That(list[0].Id, Is.EqualTo(_persons[0].Id));
                Assert.That(list[0].FirstName, Is.EqualTo(_persons[0].FirstName));
                Assert.That(list[0].MiddleName, Is.EqualTo(_persons[0].MiddleName));
                Assert.That(list[0].LastName, Is.EqualTo(_persons[0].LastName));

                Assert.That(list[0].Identification, Is.EqualTo(_persons[0].Identification));
            });

            Assert.Multiple(() =>
            {
                Assert.That(list[4].Id, Is.EqualTo(_persons[4].Id));
                Assert.That(list[4].FirstName, Is.EqualTo(_persons[4].FirstName));
                Assert.That(list[4].MiddleName, Is.EqualTo(_persons[4].MiddleName));
                Assert.That(list[4].LastName, Is.EqualTo(_persons[4].LastName));

                Assert.That(list[4].Identification, Is.Not.EqualTo(null));
                Assert.That(list[4].Identification.Id, Is.EqualTo(_persons[4].Identification.Id));
            });
        }
    }
}