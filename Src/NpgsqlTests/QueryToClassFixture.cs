using Gedaq.Npgsql.Attributes;
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
            var list = _dataSource.OpenConnection().ToClass1(3).ToList();
            CheckToClass1Result(list);
        }

        [Test]
        public void CreateToClassCommand()
        {
            using var command = _dataSource.OpenConnection().CreateToClass1Command(false, 10);
            Assert.That(command.IsPrepared, Is.EqualTo(false));
            Assert.That(command.CommandTimeout, Is.EqualTo(10));

            using var command2 = _dataSource.OpenConnection().CreateToClass1Command(true);
            Assert.That(command2.IsPrepared, Is.EqualTo(true));
            Assert.That(command2.CommandTimeout, Is.EqualTo(30));
            
            command2.SetToClass1Parametrs(3);
            var list = command2.ExecuteToClass2Command().ToList();
            CheckToClass1Result(list);
        }

        [Test]
        public async Task CreateToClassCommandAsync()
        {
            await using var command = await _dataSource.OpenConnection().CreateToClass1CommandAsync(false, timeout: 10);
            Assert.That(command.IsPrepared, Is.EqualTo(false));
            Assert.That(command.CommandTimeout, Is.EqualTo(10));

            await using var command2 = await _dataSource.OpenConnection().CreateToClass1CommandAsync(true);
            Assert.That(command2.IsPrepared, Is.EqualTo(true));
            Assert.That(command2.CommandTimeout, Is.EqualTo(30));
            
            command2.SetToClass1Parametrs(3);
            var list = await command2.ExecuteToClass2CommandAsync().ToListAsync();
            CheckToClass1Result(list);
        }

        private void CheckToClass1Result(List<ReadFixtureModel> list)
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
    }
}