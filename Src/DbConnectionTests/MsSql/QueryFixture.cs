using DbConnectionTests.Model;
using Gedaq.Common.Enums;
using Gedaq.DbConnection.Attributes;
using NUnit.Framework;
using System;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;

namespace DbConnectionTests
{
    [TestFixture]
    internal partial class QueryFixture : BaseFixture
    {
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
FROM person p
LEFT JOIN identification i ON i.id = p.identification_id
LEFT JOIN country c ON c.id = i.country_id
WHERE p.id != @id
ORDER BY p.id ASC
",
            "MsSqlToClass1",
            typeof(Person),
            Gedaq.Common.Enums.MethodType.Async | Gedaq.Common.Enums.MethodType.Sync
            )]
        [Parametr("MsSqlToClass1", parametrType: typeof(int), parametrName: "id", dbType: System.Data.DbType.Int32)]
        public void ReadToClass()
        {
            using var connection = OpenConnection();
            var list = MsSqlToClass1(connection, 3).ToList();

            Assert.That(list, Has.Count.EqualTo(9));

            Assert.Multiple(() =>
            {
                Assert.That(list[0].Id, Is.EqualTo(0));
                Assert.That(list[0].FirstName, Is.EqualTo(null));
                Assert.That(list[0].MiddleName, Is.EqualTo(null));
                Assert.That(list[0].LastName, Is.EqualTo(null));

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
FROM person p
LEFT JOIN identification i ON i.id = p.identification_id
LEFT JOIN country c ON c.id = i.country_id
WHERE p.id != @id AND p.id != @id2
ORDER BY p.id ASC
",
            "MsSqlToClass2",
            typeof(Person),
            Gedaq.Common.Enums.MethodType.Async | Gedaq.Common.Enums.MethodType.Sync
            )]
        [Parametr("MsSqlToClass2", parametrType: typeof(int), parametrName: "id")]
        [Parametr("MsSqlToClass2", parametrType: typeof(int), parametrName: "id2")]
        public async Task ReadToClassAsync()
        {
            using var connection = OpenConnection();
            var list = await MsSqlToClass2Async(connection, 3, 6).ToListAsync();

            Assert.That(list, Has.Count.EqualTo(8));

            Assert.Multiple(() =>
            {
                Assert.That(list[0].Id, Is.EqualTo(0));
                Assert.That(list[0].FirstName, Is.EqualTo(null));
                Assert.That(list[0].MiddleName, Is.EqualTo(null));
                Assert.That(list[0].LastName, Is.EqualTo(null));

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
            using var command = CreateMsSqlToClass1Command(connection, false);
            SetMsSqlToClass1Parametrs(command, 26, 10);
            Assert.That(command.CommandTimeout, Is.EqualTo(10));

            using var command2 = CreateMsSqlToClass1Command(connection, true);
            SetMsSqlToClass1Parametrs(command2, 15);
            Assert.That(command2.CommandTimeout, Is.EqualTo(30));
        }

        [Test]
        public async Task CreateCommandAsync()
        {
            using var connection = OpenConnection();
            await using var command = await CreateMsSqlToClass1CommandAsync(connection, false);
            SetMsSqlToClass1Parametrs(command, 26, 10);
            Assert.That(command.CommandTimeout, Is.EqualTo(10));

            await using var command2 = await CreateMsSqlToClass1CommandAsync(connection, true);
            SetMsSqlToClass1Parametrs(command2, 15);
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
FROM person p
LEFT JOIN identification i ON i.id = p.identification_id
LEFT JOIN country c ON c.id = i.country_id
WHERE p.id != @id
ORDER BY p.id ASC
",
            "MsSqlToObjArr",
            typeof(object[]),
            Gedaq.Common.Enums.MethodType.Async | Gedaq.Common.Enums.MethodType.Sync
            )]
        [Parametr("MsSqlToObjArr", parametrType: typeof(int), parametrName: "id")]
        public void ReadToObjArr()
        {
            using var connection = OpenConnection();
            var list = MsSqlToObjArr(connection, 3).ToList();

            Assert.That(list, Has.Count.EqualTo(9));

            Assert.Multiple(() =>
            {
                Assert.That((int)list[0][0], Is.EqualTo(0));
                Assert.That((DBNull)list[0][1], Is.EqualTo(DBNull.Value));
                Assert.That((DBNull)list[0][2], Is.EqualTo(DBNull.Value));
                Assert.That((DBNull)list[0][3], Is.EqualTo(DBNull.Value));
                Assert.That((DBNull)list[0][4], Is.EqualTo(DBNull.Value));
                Assert.That((DBNull)list[0][5], Is.EqualTo(DBNull.Value));
                Assert.That((DBNull)list[0][6], Is.EqualTo(DBNull.Value));
                Assert.That((DBNull)list[0][7], Is.EqualTo(DBNull.Value));
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
            var list = await MsSqlToObjArrAsync(connection, 3).ToListAsync();

            Assert.That(list, Has.Count.EqualTo(9));

            Assert.Multiple(() =>
            {
                Assert.That((int)list[0][0], Is.EqualTo(0));
                Assert.That((DBNull)list[0][1], Is.EqualTo(DBNull.Value));
                Assert.That((DBNull)list[0][2], Is.EqualTo(DBNull.Value));
                Assert.That((DBNull)list[0][3], Is.EqualTo(DBNull.Value));
                Assert.That((DBNull)list[0][4], Is.EqualTo(DBNull.Value));
                Assert.That((DBNull)list[0][5], Is.EqualTo(DBNull.Value));
                Assert.That((DBNull)list[0][6], Is.EqualTo(DBNull.Value));
                Assert.That((DBNull)list[0][7], Is.EqualTo(DBNull.Value));
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