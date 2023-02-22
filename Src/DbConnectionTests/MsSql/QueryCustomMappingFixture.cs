using DbConnectionTests.Model;
using Gedaq.DbConnection.Attributes;
using NUnit.Framework;
using System.Linq;

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
~StartInner::Name:?~
    p.firstname,
    p.middlename,
    p.lastname,
~EndInner::Name~
~StartInner::Identification:id~
    i.id,
~StartInner::Country:id~
    c.id,
    c.name,
~EndInner::Country~
    i.typename
~EndInner::Identification~
FROM person p
LEFT JOIN identification i ON i.id = p.identification_id
LEFT JOIN country c ON c.id = i.country_id
WHERE p.id != @id
ORDER BY p.id ASC
",
            "MsSqlCustomMapping",
            typeof(PersonCustom),
            Gedaq.Common.Enums.MethodType.Async | Gedaq.Common.Enums.MethodType.Sync
            )]
        [Parametr("MsSqlCustomMapping", parametrType: typeof(int), parametrName: "id", dbType: System.Data.DbType.Int32)]
        public void CustomMapping()
        {
            using var connection = OpenConnection();
            var list = connection.MsSqlCustomMapping(3).ToList();

            Assert.That(list, Has.Count.EqualTo(9));

            Assert.Multiple(() =>
            {
                Assert.That(list[0].Id, Is.EqualTo(0));
                Assert.That(list[0].Name, Is.EqualTo(null));

                Assert.That(list[0].Identification, Is.EqualTo(null));
            });

            Assert.Multiple(() =>
            {
                Assert.That(list[3].Id, Is.EqualTo(4));
                Assert.That(list[3].Name.FirstName, Is.EqualTo("John4"));
                Assert.That(list[3].Name.MiddleName, Is.EqualTo("Сurly4"));
                Assert.That(list[3].Name.LastName, Is.EqualTo("Doe4"));

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
                Assert.That(list[4].Name.FirstName, Is.EqualTo("John5"));
                Assert.That(list[4].Name.MiddleName, Is.EqualTo("Сurly5"));
                Assert.That(list[4].Name.LastName, Is.EqualTo("Doe5"));

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