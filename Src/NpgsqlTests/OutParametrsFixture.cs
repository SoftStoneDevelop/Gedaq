using Gedaq.Npgsql.Attributes;
using NpgsqlTests.Model;
using NUnit.Framework;
using System;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace NpgsqlTests
{
    [TestFixture]
    internal partial class ReadFixture : BaseFixture
    {
        [Test]
        [Query(
            @"
select * from readfixturefunc(@inParam);
",
            "FuncOut",
            queryType: Gedaq.Common.Enums.QueryType.NonQuery
            )]
        [Parametr("FuncOut", parametrType: typeof(int), parametrName: "inParam", direction: ParameterDirection.Input)]
        [Parametr("FuncOut", parametrType: typeof(int), parametrName: "out1", direction: ParameterDirection.Output)]
        [Parametr("FuncOut", parametrType: typeof(string), parametrName: "out2", direction: ParameterDirection.Output)]
        public void TestFuncOut()
        {
            using var connection = _dataSource.OpenConnection();
            var result = NonQueryFuncOut(connection, 46, out var out1, out var out2);
            Assert.Multiple(() =>
            {
                Assert.That(out1, Is.EqualTo(46));
                Assert.That(out2, Is.EqualTo("46 is text"));
            });
        }

        [Test]
        [Query(
            @"
select out1, out2 from readfixturefunc(@inParam);
",
            "ReadFunc",
            typeof(ReadFunc),
            queryType: Gedaq.Common.Enums.QueryType.Read
            )]
        [Parametr("ReadFunc", parametrType: typeof(int), parametrName: "inParam", direction: ParameterDirection.Input)]
        public void TestReadFunc()
        {
            using var connection = _dataSource.OpenConnection();
            var result = ReadFunc(connection, 24).First();
            Assert.Multiple(() =>
            {
                Assert.That(result.Out1, Is.EqualTo(24));
                Assert.That(result.Out2, Is.EqualTo("24 is text"));
            });
        }

        [Test]
        [Query(
            @"
SELECT 
~StartInner::Person:id~
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
    p.lastname,
~EndInner::Person~
	readfixturefunc.out1,
	readfixturefunc.out2
FROM readfixtureperson p
LEFT JOIN readfixtureidentification i ON i.id = p.readfixtureidentification_id
LEFT JOIN readfixturecountry c ON c.id = i.readfixturecountry_id
LEFT JOIN LATERAL readfixturefunc(@inParam) AS readfixturefunc ON true
WHERE p.id = @personId
ORDER BY p.id ASC
",
            "ReadFuncPerson",
            typeof(ReadFunc),
             queryType: Gedaq.Common.Enums.QueryType.Read
            )]
        [Parametr("ReadFuncPerson", parametrType: typeof(int), parametrName: "inParam", direction: ParameterDirection.Input)]
        [Parametr("ReadFuncPerson", parametrType: typeof(int), parametrName: "personId", direction: ParameterDirection.Input)]
        public void TestReadFuncAndPerson()
        {
            using var connection = _dataSource.OpenConnection();
            var result = ReadFuncPerson(connection, 13, 1).First();
            Assert.Multiple(() =>
            {
                Assert.That(result.Out1, Is.EqualTo(13));
                Assert.That(result.Out2, Is.EqualTo("13 is text"));
                Assert.That(result.Person.Id, Is.EqualTo(1));
                Assert.That(result.Person.Identification.Id, Is.EqualTo(1));
                Assert.That(result.Person.Identification.Country.Id, Is.EqualTo(1));
            });
        }

        [Test]
        [QueryBatch("BatchFixtureOut", Gedaq.Common.Enums.QueryType.NonQuery, Gedaq.Common.Enums.MethodType.Sync)]
        [BatchPart("FuncOut", "BatchFixtureOut", 1)]
        [BatchPart("FuncOut", "BatchFixtureOut", 2)]
        public void BatchFixtureOut()
        {
            Assert.That(() => 
            {
                using var connection = _dataSource.OpenConnection();
                
                NonQueryBatchFixtureOut(
                    connection,
                    24, out var out11, out var out12,
                    75, out var out21, out var out22
                    );
            },
            Throws.Exception.TypeOf(typeof(NotSupportedException)).And.Message.EqualTo("Batches cannot cannot have out parameters")
            );
        }
    }
}
