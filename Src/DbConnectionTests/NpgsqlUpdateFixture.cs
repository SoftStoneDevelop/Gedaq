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
            var result = NonQueryUpdatePerson(connection, null);
            Assert.That(result, Is.EqualTo(10));

            var list = GetAllPerson(connection).ToList();
            foreach (var person in list)
            {
                Assert.That(person.Identification, Is.EqualTo(null));
            }

            result = NonQueryUpdatePerson(connection, 1);
            Assert.That(result, Is.EqualTo(10));

            list = GetAllPerson(connection).ToList();
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
            var result = await NonQueryUpdatePersonAsync(connection, null);
            Assert.That(result, Is.EqualTo(10));

            var list = await GetAllPersonAsync(connection).ToListAsync();
            foreach (var person in list)
            {
                Assert.That(person.Identification, Is.EqualTo(null));
            }

            result = await NonQueryUpdatePersonAsync(connection, 1);
            Assert.That(result, Is.EqualTo(10));

            list = await GetAllPersonAsync(connection).ToListAsync();
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
            var result = NonQueryUpdatePersonBatch(connection, null, 1);

            Assert.That(result, Is.EqualTo(20));

            var list = GetAllPerson(connection).ToList();
            foreach (var person in list)
            {
                Assert.That(person.Identification, Is.Not.EqualTo(null));
                Assert.That(person.Identification.Id, Is.EqualTo(1));
            }

            result = NonQueryUpdatePersonBatch(connection, 1, null);

            Assert.That(result, Is.EqualTo(20));

            list = GetAllPerson(connection).ToList();
            foreach (var person in list)
            {
                Assert.That(person.Identification, Is.EqualTo(null));
            }
        }

        [Test]
        public async Task UpdatePersonBatchAsync()
        {
            using var connection = _dataSource.OpenConnection();
            var result = await NonQueryUpdatePersonBatchAsync(connection, null, 1);

            Assert.That(result, Is.EqualTo(20));

            var list = await GetAllPersonAsync(connection).ToListAsync();
            foreach (var person in list)
            {
                Assert.That(person.Identification, Is.Not.EqualTo(null));
                Assert.That(person.Identification.Id, Is.EqualTo(1));
            }

            result = await NonQueryUpdatePersonBatchAsync(connection, 1, null);

            Assert.That(result, Is.EqualTo(20));

            list = await GetAllPersonAsync(connection).ToListAsync();
            foreach (var person in list)
            {
                Assert.That(person.Identification, Is.EqualTo(null));
            }
        }
    }
}