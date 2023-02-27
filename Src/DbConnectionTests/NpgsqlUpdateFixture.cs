using DbConnectionTests.Model;
using Gedaq.Common.Enums;
using Gedaq.DbConnection.Attributes;
using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;

namespace DbConnectionTests
{
    [TestFixture]
    internal partial class NpgsqlQueryFixture : BaseFixture
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
FROM dbconnectionperson p
LEFT JOIN dbconnectionidentification i ON i.id = p.identification_id
LEFT JOIN dbconnectioncountry c ON c.id = i.country_id
ORDER BY p.id ASC
",
            "GetAllPerson",
            typeof(Person),
            MethodType.Sync | MethodType.Async
            )]
        [Query(
            @"
UPDATE
    dbconnectionperson
SET
    identification_id = @refId
",
            "UpdatePerson",
            queryType: QueryType.NonQuery,
            methodType: Gedaq.Common.Enums.MethodType.Async | Gedaq.Common.Enums.MethodType.Sync
            )]
        [Parametr("UpdatePerson", parametrType: typeof(int?), parametrName: "refId", dbType: System.Data.DbType.Int32, nullable: true)]
        public void UpdatePerson()
        {
            using var connection = _dataSource.OpenConnection();
            var result = connection.NonQueryUpdatePerson(null);
            Assert.That(result, Is.EqualTo(10));

            var list = connection.GetAllPerson().ToList();
            foreach (var person in list)
            {
                Assert.That(person.Identification, Is.EqualTo(null));
            }

            result = connection.NonQueryUpdatePerson(1);
            Assert.That(result, Is.EqualTo(10));

            list = connection.GetAllPerson().ToList();
            foreach (var person in list)
            {
                Assert.That(person.Identification, Is.Not.EqualTo(null));
                Assert.That(person.Identification.Id, Is.EqualTo(1));
            }
        }

        [Test]
        public async Task UpdatePersonAsync()
        {
            using var connection = _dataSource.OpenConnection();
            var result = await connection.NonQueryUpdatePersonAsync(null);
            Assert.That(result, Is.EqualTo(10));

            var list = await connection.GetAllPersonAsync().ToListAsync();
            foreach (var person in list)
            {
                Assert.That(person.Identification, Is.EqualTo(null));
            }

            result = await connection.NonQueryUpdatePersonAsync(1);
            Assert.That(result, Is.EqualTo(10));

            list = await connection.GetAllPersonAsync().ToListAsync();
            foreach (var person in list)
            {
                Assert.That(person.Identification, Is.Not.EqualTo(null));
                Assert.That(person.Identification.Id, Is.EqualTo(1));
            }
        }

        [Test]
        [QueryBatch(
            "UpdatePersonBatch",
            queryType: QueryType.NonQuery,
            methodType: Gedaq.Common.Enums.MethodType.Async | Gedaq.Common.Enums.MethodType.Sync
            )]
        [BatchPart("UpdatePerson", "UpdatePersonBatch", 1)]
        [BatchPart("UpdatePerson", "UpdatePersonBatch", 2)]
        public void UpdatePersonBatch()
        {
            using var connection = _dataSource.OpenConnection();
            var result = connection.NonQueryUpdatePersonBatch(null, 1);

            Assert.That(result, Is.EqualTo(20));

            var list = connection.GetAllPerson().ToList();
            foreach (var person in list)
            {
                Assert.That(person.Identification, Is.Not.EqualTo(null));
                Assert.That(person.Identification.Id, Is.EqualTo(1));
            }

            result = connection.NonQueryUpdatePersonBatch(1, null);

            Assert.That(result, Is.EqualTo(20));

            list = connection.GetAllPerson().ToList();
            foreach (var person in list)
            {
                Assert.That(person.Identification, Is.EqualTo(null));
            }
        }

        [Test]
        public async Task UpdatePersonBatchAsync()
        {
            using var connection = _dataSource.OpenConnection();
            var result = await connection.NonQueryUpdatePersonBatchAsync(null, 1);

            Assert.That(result, Is.EqualTo(20));

            var list = await connection.GetAllPersonAsync().ToListAsync();
            foreach (var person in list)
            {
                Assert.That(person.Identification, Is.Not.EqualTo(null));
                Assert.That(person.Identification.Id, Is.EqualTo(1));
            }

            result = await connection.NonQueryUpdatePersonBatchAsync(1, null);

            Assert.That(result, Is.EqualTo(20));

            list = await connection.GetAllPersonAsync().ToListAsync();
            foreach (var person in list)
            {
                Assert.That(person.Identification, Is.EqualTo(null));
            }
        }
    }
}