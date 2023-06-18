﻿using Gedaq.Npgsql.Attributes;
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
        [BinaryExport(@"
COPY readfixtureperson 
(
id,
firstname,
~StartInner::Identification:id~
    ~Reinterpret::id~
readfixtureidentification_id,
~EndInner::Identification~
middlename,
lastname
) TO STDOUT (FORMAT BINARY)
", 
            "BinaryExportTable",
            typeof(ReadFixtureModel), 
            methodType: Gedaq.Common.Enums.MethodType.Sync | Gedaq.Common.Enums.MethodType.Async
            )]
        public void BinaryExportTable()
        {
            using var connection = _dataSource.OpenConnection();
            var list = BinaryExportTable(connection).ToList();
            BinaryExportTableCheck(list);
        }

        [Test]
        public async Task BinaryExportTableAsync()
        {
            await using var connection = _dataSource.OpenConnection();
            var list = await BinaryExportTableAsync(connection).ToListAsync();
            BinaryExportTableCheck(list);
        }

        private void BinaryExportTableCheck(List<ReadFixtureModel> list)
        {
            Assert.That(list, Has.Count.EqualTo(10));

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
                Assert.That(list[4].Id, Is.EqualTo(4));
                Assert.That(list[4].FirstName, Is.EqualTo("John4"));
                Assert.That(list[4].MiddleName, Is.EqualTo("Сurly4"));
                Assert.That(list[4].LastName, Is.EqualTo("Doe4"));

                Assert.That(list[4].Identification, Is.Not.EqualTo(null));
            });
        }

        [Test]
        [BinaryExport(@"
COPY 
(
SELECT 
    p.id,
~StartInner::Identification:id~
    i.id,
~StartInner::Country:id~
    c.id,
    c.name,
~EndInner::Country~
    i.typename,
~EndInner::Identification~
    p.firstname,
    p.middlename,
    p.lastname
FROM readfixtureperson p
LEFT JOIN readfixtureidentification i ON i.id = p.readfixtureidentification_id
LEFT JOIN readfixturecountry c ON c.id = i.readfixturecountry_id
ORDER BY p.id ASC
) TO STDOUT (FORMAT BINARY)
", 
            "BinaryExportSubquery",
            typeof(ReadFixtureModel),
            methodType: Gedaq.Common.Enums.MethodType.Sync | Gedaq.Common.Enums.MethodType.Async
            )]
        public void BinaryExportSubquery()
        {
            using var connection = _dataSource.OpenConnection();
            var list = BinaryExportSubquery(connection).ToList();
            BinaryExportSubqueryCheck(list);
        }

        [Test]
        public async Task BinaryExportSubqueryAsync()
        {
            await using var connection = _dataSource.OpenConnection();
            var list = await BinaryExportSubqueryAsync(connection).ToListAsync();
            BinaryExportSubqueryCheck(list);
        }

        private void BinaryExportSubqueryCheck(List<ReadFixtureModel> list)
        {
            Assert.That(list, Has.Count.EqualTo(10));

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
                Assert.That(list[4].Id, Is.EqualTo(4));
                Assert.That(list[4].FirstName, Is.EqualTo("John4"));
                Assert.That(list[4].MiddleName, Is.EqualTo("Сurly4"));
                Assert.That(list[4].LastName, Is.EqualTo("Doe4"));

                Assert.That(list[4].Identification, Is.Not.EqualTo(null));
            });

            var identification = list[4].Identification;
            Assert.Multiple(() =>
            {
                Assert.That(identification.Id, Is.EqualTo(4));
                Assert.That(identification.TypeName, Is.EqualTo("citizen's passport"));

                Assert.That(identification.Country, Is.EqualTo(null));
            });

            Assert.Multiple(() =>
            {
                Assert.That(list[5].Id, Is.EqualTo(5));
                Assert.That(list[5].FirstName, Is.EqualTo("John5"));
                Assert.That(list[5].MiddleName, Is.EqualTo("Сurly5"));
                Assert.That(list[5].LastName, Is.EqualTo("Doe5"));

                Assert.That(list[5].Identification, Is.Not.EqualTo(null));
            });

            identification = list[5].Identification;
            Assert.Multiple(() =>
            {
                Assert.That(identification.Id, Is.EqualTo(5));
                Assert.That(identification.TypeName, Is.EqualTo("party card"));

                Assert.That(identification.Country, Is.Not.EqualTo(null));
            });

            var country = list[5].Identification.Country;
            Assert.Multiple(() =>
            {
                Assert.That(country.Id, Is.EqualTo(5));
                Assert.That(country.Name, Is.EqualTo("Martian colony"));
            });
        }
    }
}