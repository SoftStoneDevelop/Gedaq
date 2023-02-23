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
~Reinterpret::ReinterpId~
    p.id,
~Reinterpret::Name1~
    p.firstname,
~StartInner::Identification:id~
    i.id,
~StartInner::Country:id~
    c.id,
    c.name,
~EndInner::Country~
    i.typename,
~EndInner::Identification~
~Reinterpret::Name2~
    p.middlename,
~Reinterpret::FinalName~
    p.lastname
FROM person p
LEFT JOIN identification i ON i.id = p.identification_id
LEFT JOIN country c ON c.id = i.country_id
WHERE p.id != @id
ORDER BY p.id ASC
",
            "Reinterp",
            typeof(PersonReinerp),
            Gedaq.Common.Enums.MethodType.Async | Gedaq.Common.Enums.MethodType.Sync
            )]
        [Parametr("Reinterp", parametrType: typeof(int), parametrName: "id", dbType: System.Data.DbType.Int32)]
        public void Reinterp()
        {
            using var connection = OpenConnection();
            var list = connection.Reinterp(3).ToList();

            Assert.That(list, Has.Count.EqualTo(9));

            Assert.Multiple(() =>
            {
                Assert.That(list[0].ReinterpId, Is.EqualTo(0));
                Assert.That(list[0].Name1, Is.EqualTo(null));
                Assert.That(list[0].Name2, Is.EqualTo(null));
                Assert.That(list[0].FinalName, Is.EqualTo(null));

                Assert.That(list[0].Identification, Is.EqualTo(null));
            });

            Assert.Multiple(() =>
            {
                Assert.That(list[3].ReinterpId, Is.EqualTo(4));
                Assert.That(list[3].Name1, Is.EqualTo("John4"));
                Assert.That(list[3].Name2, Is.EqualTo("Сurly4"));
                Assert.That(list[3].FinalName, Is.EqualTo("Doe4"));

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
                Assert.That(list[4].ReinterpId, Is.EqualTo(5));
                Assert.That(list[4].Name1, Is.EqualTo("John5"));
                Assert.That(list[4].Name2, Is.EqualTo("Сurly5"));
                Assert.That(list[4].FinalName, Is.EqualTo("Doe5"));

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