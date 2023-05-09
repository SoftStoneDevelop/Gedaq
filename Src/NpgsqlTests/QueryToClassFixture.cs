using Gedaq.Npgsql.Attributes;
using NpgsqlTests.Model;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NpgsqlTests
{
    [TestFixture]
    internal partial class ReadFixture : BaseFixture
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
FROM readfixtureperson p
LEFT JOIN readfixtureidentification i ON i.id = p.readfixtureidentification_id
LEFT JOIN readfixturecountry c ON c.id = i.readfixturecountry_id
WHERE p.id != $1
ORDER BY p.id ASC
",
            "ToClass1",
            typeof(ReadFixtureModel),
            Gedaq.Common.Enums.MethodType.Async | Gedaq.Common.Enums.MethodType.Sync
            )]
        [Parametr("ToClass1", parametrType: typeof(int), position: 1)]
        public void ReadToClass()
        {
            using var connection = _dataSource.OpenConnection();
            var list = ToClass1(connection, 3).ToList();
            CheckToClass1Result(list);
        }

        [Test]
        public void CreateToClassCommand()
        {
            using var connection = _dataSource.OpenConnection();
            using var command = CreateToClass1Command(connection, false);
            SetToClass1Parametrs(command, 78, 10);
            Assert.That(command.IsPrepared, Is.EqualTo(false));
            Assert.That(command.CommandTimeout, Is.EqualTo(10));

            using var command2 = CreateToClass1Command(connection, true);
            SetToClass1Parametrs(command, 45);
            Assert.That(command2.IsPrepared, Is.EqualTo(true));
            Assert.That(command2.CommandTimeout, Is.EqualTo(30));
            
            SetToClass1Parametrs(command2, 3);
            var list = ExecuteToClass2Command(command2).ToList();
            CheckToClass1Result(list);
        }

        [Test]
        public async Task CreateToClassCommandAsync()
        {
            await using var connection = _dataSource.OpenConnection();
            await using var command = await CreateToClass1CommandAsync(connection, false);
            SetToClass1Parametrs(command, 78, 10);
            Assert.That(command.IsPrepared, Is.EqualTo(false));
            Assert.That(command.CommandTimeout, Is.EqualTo(10));

            await using var command2 = await CreateToClass1CommandAsync(connection, true);
            Assert.That(command2.IsPrepared, Is.EqualTo(true));
            Assert.That(command2.CommandTimeout, Is.EqualTo(30));
            
            SetToClass1Parametrs(command2, 3);
            var list = await ExecuteToClass2CommandAsync(command2).ToListAsync();
            CheckToClass1Result(list);
        }

        private void CheckToClass1Result(List<ReadFixtureModel> list)
        {
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
FROM readfixtureperson p
LEFT JOIN readfixtureidentification i ON i.id = p.readfixtureidentification_id
LEFT JOIN readfixturecountry c ON c.id = i.readfixturecountry_id
WHERE p.id != $1 AND p.id != $2
ORDER BY p.id ASC
",
            "ToClass2",
            typeof(ReadFixtureModel),
            Gedaq.Common.Enums.MethodType.Async | Gedaq.Common.Enums.MethodType.Sync
            )]
        [Parametr("ToClass2", parametrType: typeof(int), position: 1)]
        [Parametr("ToClass2", parametrType: typeof(int), position: 2)]
        public async Task ReadToClassAsync()
        {
            await using var connection = _dataSource.OpenConnection();
            var list = await ToClass2Async(connection, 3, 6).ToListAsync();

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
    }
}