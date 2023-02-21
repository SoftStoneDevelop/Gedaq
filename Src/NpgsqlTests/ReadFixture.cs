using Gedaq.Npgsql.Attributes;
using NUnit.Framework;
using System;
using System.Data;
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
    internal partial class ReadFixture : BaseFixture
    {
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
FROM readfixtureperson p
LEFT JOIN readfixtureidentification i ON i.id = p.readfixtureidentification_id
LEFT JOIN readfixturecountry c ON c.id = i.readfixturecountry_id
WHERE p.id != $1
ORDER BY p.id ASC
",
            "ToObjArr",
            typeof(object[]),
            Gedaq.Common.Enums.MethodType.Async | Gedaq.Common.Enums.MethodType.Sync
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
        [Query(
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
            "ToObj",
            typeof(object),
            Gedaq.Common.Enums.MethodType.Async | Gedaq.Common.Enums.MethodType.Sync
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