using Microsoft.Extensions.Configuration;
using Npgsql;
using NpgsqlTests.Helpers;
using NUnit.Framework;
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
    }

    public struct ReadFixtureModelStruct
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }
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

            if (conn.ExistTable(nameof(ReadFixture).ToLowerInvariant()))
            {
                conn.DropTable("readfixture");
            }

            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
CREATE TABLE IF NOT EXISTS public.readfixture
(
    id integer NOT NULL,
    firstname text COLLATE pg_catalog.""default"" NOT NULL,
    middlename text COLLATE pg_catalog.""default"",
    lastname text COLLATE pg_catalog.""default"",
    CONSTRAINT readfixture_pkey PRIMARY KEY (id)
)
";
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"
INSERT INTO public.readfixture(
	id, firstname, middlename, lastname)
	VALUES (
    @id, @firstname, @middlename, @lastname
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
            cmd.Prepare();

            for (int i = 0; i < 10; i++)
            {
                id.Value = i;
                firstname.Value = $"John{i}";
                middlename.Value = $"Сurly{i}";
                lastname.Value = $"Doe{i}";

                cmd.ExecuteNonQuery();
            }
        }

        [TearDown]
        public void Cleanup()
        {
            _dataSource.OpenConnection().DropTable("readfixture");
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
    r.middlename,
    r.lastname
FROM readfixture r
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
    r.middlename,
    r.lastname
FROM readfixture r
",
            typeof(ReadFixtureModel),
            Gedaq.Provider.Enums.MethodType.Sync,
            Gedaq.Npgsql.Enums.SourceType.NpgsqlDataSource,
            "ToClass"
            )]
        public void ReadToClassDataSource()
        {
            var list = _dataSource.ToClass().ToList();

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
    r.middlename,
    r.lastname
FROM readfixture r
",
            typeof(ReadFixtureModelStruct),
            Gedaq.Provider.Enums.MethodType.Sync,
            Gedaq.Npgsql.Enums.SourceType.Connection,
            "ToStruct"
            )]
        public void ReadToStructConnection()
        {
            var list = _dataSource.OpenConnection().ToStruct().ToList();

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
    r.middlename,
    r.lastname
FROM readfixture r
",
            typeof(ReadFixtureModelStruct),
            Gedaq.Provider.Enums.MethodType.Sync,
            Gedaq.Npgsql.Enums.SourceType.NpgsqlDataSource,
            "ToStruct"
            )]
        public void ReadToStructDataSource()
        {
            var list = _dataSource.ToStruct().ToList();

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
    r.middlename,
    r.lastname
FROM readfixture r
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
                Assert.That((string)list[0][2], Is.EqualTo("Сurly0"));
                Assert.That((string)list[0][3], Is.EqualTo("Doe0"));
            });

            Assert.Multiple(() =>
            {
                Assert.That((int)list[6][0], Is.EqualTo(6));
                Assert.That((string)list[6][1], Is.EqualTo("John6"));
                Assert.That((string)list[6][2], Is.EqualTo("Сurly6"));
                Assert.That((string)list[6][3], Is.EqualTo("Doe6"));
            });
        }

        [Test]
        [Gedaq.Npgsql.Attributes.QueryRead(
            @"
SELECT 
    r.id,
    r.firstname,
    r.middlename,
    r.lastname
FROM readfixture r
",
            typeof(object[]),
            Gedaq.Provider.Enums.MethodType.Sync,
            Gedaq.Npgsql.Enums.SourceType.NpgsqlDataSource,
            "ToObjArr"
            )]
        public void ReadToObjArrDataSource()
        {
            var list = _dataSource.ToObjArr().ToList();

            Assert.That(list, Has.Count.EqualTo(10));

            Assert.Multiple(() =>
            {
                Assert.That((int)list[0][0], Is.EqualTo(0));
                Assert.That((string)list[0][1], Is.EqualTo("John0"));
                Assert.That((string)list[0][2], Is.EqualTo("Сurly0"));
                Assert.That((string)list[0][3], Is.EqualTo("Doe0"));
            });

            Assert.Multiple(() =>
            {
                Assert.That((int)list[6][0], Is.EqualTo(6));
                Assert.That((string)list[6][1], Is.EqualTo("John6"));
                Assert.That((string)list[6][2], Is.EqualTo("Сurly6"));
                Assert.That((string)list[6][3], Is.EqualTo("Doe6"));
            });
        }

        [Test]
        [Gedaq.Npgsql.Attributes.QueryRead(
            @"
SELECT 
    (r.id,
    r.firstname,
    r.middlename,
    r.lastname) row
FROM readfixture r
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
                Assert.That((string)((object[])list[0])[2], Is.EqualTo("Сurly0"));
                Assert.That((string)((object[])list[0])[3], Is.EqualTo("Doe0"));
            });

            Assert.Multiple(() =>
            {
                Assert.That((int)((object[])list[6])[0], Is.EqualTo(6));
                Assert.That((string)((object[])list[6])[1], Is.EqualTo("John6"));
                Assert.That((string)((object[])list[6])[2], Is.EqualTo("Сurly6"));
                Assert.That((string)((object[])list[6])[3], Is.EqualTo("Doe6"));
            });
        }

        [Test]
        [Gedaq.Npgsql.Attributes.QueryRead(
            @"
SELECT 
    (r.id,
    r.firstname,
    r.middlename,
    r.lastname) row
FROM readfixture r
",
            typeof(object),
            Gedaq.Provider.Enums.MethodType.Sync,
            Gedaq.Npgsql.Enums.SourceType.NpgsqlDataSource,
            "ToObj"
            )]
        public void ReadToObjDataSource()
        {
            var list = _dataSource.ToObj().ToList();

            Assert.That(list, Has.Count.EqualTo(10));

            Assert.Multiple(() =>
            {
                Assert.That((int)((object[])list[0])[0], Is.EqualTo(0));
                Assert.That((string)((object[])list[0])[1], Is.EqualTo("John0"));
                Assert.That((string)((object[])list[0])[2], Is.EqualTo("Сurly0"));
                Assert.That((string)((object[])list[0])[3], Is.EqualTo("Doe0"));
            });

            Assert.Multiple(() =>
            {
                Assert.That((int)((object[])list[6])[0], Is.EqualTo(6));
                Assert.That((string)((object[])list[6])[1], Is.EqualTo("John6"));
                Assert.That((string)((object[])list[6])[2], Is.EqualTo("Сurly6"));
                Assert.That((string)((object[])list[6])[3], Is.EqualTo("Doe6"));
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
    r.middlename,
    r.lastname
FROM readfixture r
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
    r.middlename,
    r.lastname
FROM readfixture r
",
            typeof(ReadFixtureModel),
            Gedaq.Provider.Enums.MethodType.Async,
            Gedaq.Npgsql.Enums.SourceType.NpgsqlDataSource,
            "ToClass"
            )]
        public async Task ReadToClassDataSourceAsync()
        {
            var list = await _dataSource.ToClassAsync().ToListAsync();

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
    r.middlename,
    r.lastname
FROM readfixture r
",
            typeof(ReadFixtureModelStruct),
            Gedaq.Provider.Enums.MethodType.Async,
            Gedaq.Npgsql.Enums.SourceType.Connection,
            "ToStruct"
            )]
        public async Task ReadToStructConnectionAsync()
        {
            var list = await _dataSource.OpenConnection().ToStructAsync().ToListAsync();

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
    r.middlename,
    r.lastname
FROM readfixture r
",
            typeof(ReadFixtureModelStruct),
            Gedaq.Provider.Enums.MethodType.Async,
            Gedaq.Npgsql.Enums.SourceType.NpgsqlDataSource,
            "ToStruct"
            )]
        public async Task ReadToStructDataSourceAsync()
        {
            var list = await _dataSource.ToStructAsync().ToListAsync();

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
    r.middlename,
    r.lastname
FROM readfixture r
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
                Assert.That((string)list[0][2], Is.EqualTo("Сurly0"));
                Assert.That((string)list[0][3], Is.EqualTo("Doe0"));
            });

            Assert.Multiple(() =>
            {
                Assert.That((int)list[6][0], Is.EqualTo(6));
                Assert.That((string)list[6][1], Is.EqualTo("John6"));
                Assert.That((string)list[6][2], Is.EqualTo("Сurly6"));
                Assert.That((string)list[6][3], Is.EqualTo("Doe6"));
            });
        }

        [Test]
        [Gedaq.Npgsql.Attributes.QueryRead(
            @"
SELECT 
    r.id,
    r.firstname,
    r.middlename,
    r.lastname
FROM readfixture r
",
            typeof(object[]),
            Gedaq.Provider.Enums.MethodType.Async,
            Gedaq.Npgsql.Enums.SourceType.NpgsqlDataSource,
            "ToObjArr"
            )]
        public async Task ReadToObjArrDataSourceAsync()
        {
            var list = await _dataSource.ToObjArrAsync().ToListAsync();

            Assert.That(list, Has.Count.EqualTo(10));

            Assert.Multiple(() =>
            {
                Assert.That((int)list[0][0], Is.EqualTo(0));
                Assert.That((string)list[0][1], Is.EqualTo("John0"));
                Assert.That((string)list[0][2], Is.EqualTo("Сurly0"));
                Assert.That((string)list[0][3], Is.EqualTo("Doe0"));
            });

            Assert.Multiple(() =>
            {
                Assert.That((int)list[6][0], Is.EqualTo(6));
                Assert.That((string)list[6][1], Is.EqualTo("John6"));
                Assert.That((string)list[6][2], Is.EqualTo("Сurly6"));
                Assert.That((string)list[6][3], Is.EqualTo("Doe6"));
            });
        }

        [Test]
        [Gedaq.Npgsql.Attributes.QueryRead(
            @"
SELECT 
    (r.id,
    r.firstname,
    r.middlename,
    r.lastname) row
FROM readfixture r
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
                Assert.That((string)((object[])list[0])[2], Is.EqualTo("Сurly0"));
                Assert.That((string)((object[])list[0])[3], Is.EqualTo("Doe0"));
            });

            Assert.Multiple(() =>
            {
                Assert.That((int)((object[])list[6])[0], Is.EqualTo(6));
                Assert.That((string)((object[])list[6])[1], Is.EqualTo("John6"));
                Assert.That((string)((object[])list[6])[2], Is.EqualTo("Сurly6"));
                Assert.That((string)((object[])list[6])[3], Is.EqualTo("Doe6"));
            });
        }

        [Test]
        [Gedaq.Npgsql.Attributes.QueryRead(
            @"
SELECT 
    (r.id,
    r.firstname,
    r.middlename,
    r.lastname) row
FROM readfixture r
",
            typeof(object),
            Gedaq.Provider.Enums.MethodType.Async,
            Gedaq.Npgsql.Enums.SourceType.NpgsqlDataSource,
            "ToObj"
            )]
        public async Task ReadToObjDataSourceAsync()
        {
            var list = await _dataSource.ToObjAsync().ToListAsync();

            Assert.That(list, Has.Count.EqualTo(10));

            Assert.Multiple(() =>
            {
                Assert.That((int)((object[])list[0])[0], Is.EqualTo(0));
                Assert.That((string)((object[])list[0])[1], Is.EqualTo("John0"));
                Assert.That((string)((object[])list[0])[2], Is.EqualTo("Сurly0"));
                Assert.That((string)((object[])list[0])[3], Is.EqualTo("Doe0"));
            });

            Assert.Multiple(() =>
            {
                Assert.That((int)((object[])list[6])[0], Is.EqualTo(6));
                Assert.That((string)((object[])list[6])[1], Is.EqualTo("John6"));
                Assert.That((string)((object[])list[6])[2], Is.EqualTo("Сurly6"));
                Assert.That((string)((object[])list[6])[3], Is.EqualTo("Doe6"));
            });
        }

        #endregion
    }
}