

using Microsoft.Data.SqlClient;
using Gedaq.Common.Enums;
using Gedaq.SqlClient.Attributes;
using System;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IDateOnlySingleTypedate
    {
    }
    
    internal partial class DateOnlySingleTypedate : IDateOnlySingleTypedate
    {


#region TestData

        private readonly DateOnlydate0M[] _testData = new DateOnlydate0M[]
        {
            new DateOnlydate0M
{
    Id = 8,
    Value = new DateOnly(year: 2013, month: 10, day: 13),
    ModelInner = null,
    NullableValue = new DateOnly(year: 1997, month: 10, day: 16),
},
            new DateOnlydate0M
{
    Id = 14,
    Value = new DateOnly(year: 2008, month: 10, day: 12),
    ModelInner = new DateOnlydate0MI
{
    Id = 2,
    Value = new DateOnly(year: 1985, month: 10, day: 7),
    NullableValue = null,
},
    NullableValue = new DateOnly(year: 2015, month: 10, day: 3),
},
            new DateOnlydate0M
{
    Id = 17,
    Value = new DateOnly(year: 1923, month: 10, day: 10),
    ModelInner = null,
    NullableValue = new DateOnly(year: 1929, month: 10, day: 17),
},
            new DateOnlydate0M
{
    Id = 21,
    Value = new DateOnly(year: 1941, month: 10, day: 18),
    ModelInner = new DateOnlydate0MI
{
    Id = 9,
    Value = new DateOnly(year: 1967, month: 10, day: 7),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 28,
    Value = new DateOnly(year: 2001, month: 10, day: 8),
    ModelInner = null,
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 37,
    Value = new DateOnly(year: 1996, month: 10, day: 19),
    ModelInner = new DateOnlydate0MI
{
    Id = 10,
    Value = new DateOnly(year: 1923, month: 10, day: 18),
    NullableValue = new DateOnly(year: 1998, month: 10, day: 11),
},
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 39,
    Value = new DateOnly(year: 1968, month: 10, day: 5),
    ModelInner = null,
    NullableValue = new DateOnly(year: 1999, month: 10, day: 9),
},
            new DateOnlydate0M
{
    Id = 41,
    Value = new DateOnly(year: 1931, month: 10, day: 18),
    ModelInner = new DateOnlydate0MI
{
    Id = 16,
    Value = new DateOnly(year: 1946, month: 10, day: 5),
    NullableValue = new DateOnly(year: 1946, month: 10, day: 3),
},
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 49,
    Value = new DateOnly(year: 1955, month: 10, day: 4),
    ModelInner = null,
    NullableValue = new DateOnly(year: 1945, month: 10, day: 12),
},
            new DateOnlydate0M
{
    Id = 52,
    Value = new DateOnly(year: 2003, month: 10, day: 4),
    ModelInner = new DateOnlydate0MI
{
    Id = 19,
    Value = new DateOnly(year: 1985, month: 10, day: 17),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 54,
    Value = new DateOnly(year: 2001, month: 10, day: 4),
    ModelInner = null,
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 58,
    Value = new DateOnly(year: 1929, month: 10, day: 8),
    ModelInner = new DateOnlydate0MI
{
    Id = 27,
    Value = new DateOnly(year: 1963, month: 10, day: 19),
    NullableValue = new DateOnly(year: 2013, month: 10, day: 4),
},
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 65,
    Value = new DateOnly(year: 2015, month: 10, day: 17),
    ModelInner = null,
    NullableValue = new DateOnly(year: 1983, month: 10, day: 1),
},
            new DateOnlydate0M
{
    Id = 66,
    Value = new DateOnly(year: 1987, month: 10, day: 8),
    ModelInner = new DateOnlydate0MI
{
    Id = 35,
    Value = new DateOnly(year: 1946, month: 10, day: 3),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 68,
    Value = new DateOnly(year: 1926, month: 10, day: 2),
    ModelInner = null,
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 70,
    Value = new DateOnly(year: 1982, month: 10, day: 1),
    ModelInner = new DateOnlydate0MI
{
    Id = 42,
    Value = new DateOnly(year: 1942, month: 10, day: 19),
    NullableValue = null,
},
    NullableValue = new DateOnly(year: 1999, month: 10, day: 1),
},
            new DateOnlydate0M
{
    Id = 79,
    Value = new DateOnly(year: 1980, month: 10, day: 1),
    ModelInner = null,
    NullableValue = new DateOnly(year: 1967, month: 10, day: 9),
},
            new DateOnlydate0M
{
    Id = 82,
    Value = new DateOnly(year: 1970, month: 10, day: 5),
    ModelInner = new DateOnlydate0MI
{
    Id = 48,
    Value = new DateOnly(year: 1940, month: 10, day: 17),
    NullableValue = new DateOnly(year: 1941, month: 10, day: 13),
},
    NullableValue = new DateOnly(year: 2011, month: 10, day: 12),
},
            new DateOnlydate0M
{
    Id = 89,
    Value = new DateOnly(year: 1968, month: 10, day: 16),
    ModelInner = null,
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 95,
    Value = new DateOnly(year: 2013, month: 10, day: 7),
    ModelInner = new DateOnlydate0MI
{
    Id = 51,
    Value = new DateOnly(year: 2018, month: 10, day: 3),
    NullableValue = new DateOnly(year: 1922, month: 10, day: 12),
},
    NullableValue = new DateOnly(year: 2002, month: 10, day: 7),
},
            new DateOnlydate0M
{
    Id = 97,
    Value = new DateOnly(year: 1952, month: 10, day: 2),
    ModelInner = null,
    NullableValue = new DateOnly(year: 1964, month: 10, day: 10),
},
            new DateOnlydate0M
{
    Id = 100,
    Value = new DateOnly(year: 1938, month: 10, day: 2),
    ModelInner = new DateOnlydate0MI
{
    Id = 59,
    Value = new DateOnly(year: 1989, month: 10, day: 9),
    NullableValue = new DateOnly(year: 1955, month: 10, day: 1),
},
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 102,
    Value = new DateOnly(year: 1929, month: 10, day: 6),
    ModelInner = null,
    NullableValue = new DateOnly(year: 1994, month: 10, day: 8),
},
            new DateOnlydate0M
{
    Id = 107,
    Value = new DateOnly(year: 2008, month: 10, day: 19),
    ModelInner = new DateOnlydate0MI
{
    Id = 63,
    Value = new DateOnly(year: 1996, month: 10, day: 6),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 108,
    Value = new DateOnly(year: 1925, month: 10, day: 16),
    ModelInner = null,
    NullableValue = new DateOnly(year: 1952, month: 10, day: 12),
},
            new DateOnlydate0M
{
    Id = 117,
    Value = new DateOnly(year: 1946, month: 10, day: 8),
    ModelInner = new DateOnlydate0MI
{
    Id = 69,
    Value = new DateOnly(year: 1923, month: 10, day: 15),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 118,
    Value = new DateOnly(year: 1999, month: 10, day: 10),
    ModelInner = null,
    NullableValue = new DateOnly(year: 1961, month: 10, day: 18),
},
            new DateOnlydate0M
{
    Id = 124,
    Value = new DateOnly(year: 1950, month: 10, day: 3),
    ModelInner = new DateOnlydate0MI
{
    Id = 71,
    Value = new DateOnly(year: 1955, month: 10, day: 13),
    NullableValue = null,
},
    NullableValue = new DateOnly(year: 1958, month: 10, day: 5),
},
            new DateOnlydate0M
{
    Id = 130,
    Value = new DateOnly(year: 1987, month: 10, day: 7),
    ModelInner = null,
    NullableValue = new DateOnly(year: 1963, month: 10, day: 6),
},
            new DateOnlydate0M
{
    Id = 131,
    Value = new DateOnly(year: 2011, month: 10, day: 19),
    ModelInner = new DateOnlydate0MI
{
    Id = 73,
    Value = new DateOnly(year: 1997, month: 10, day: 15),
    NullableValue = new DateOnly(year: 2018, month: 10, day: 7),
},
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 135,
    Value = new DateOnly(year: 1939, month: 10, day: 8),
    ModelInner = null,
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 138,
    Value = new DateOnly(year: 1919, month: 10, day: 9),
    ModelInner = new DateOnlydate0MI
{
    Id = 82,
    Value = new DateOnly(year: 1972, month: 10, day: 12),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 147,
    Value = new DateOnly(year: 1979, month: 10, day: 12),
    ModelInner = null,
    NullableValue = new DateOnly(year: 1950, month: 10, day: 18),
},
            new DateOnlydate0M
{
    Id = 156,
    Value = new DateOnly(year: 2012, month: 10, day: 10),
    ModelInner = new DateOnlydate0MI
{
    Id = 90,
    Value = new DateOnly(year: 1980, month: 10, day: 11),
    NullableValue = new DateOnly(year: 1938, month: 10, day: 18),
},
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 164,
    Value = new DateOnly(year: 1972, month: 10, day: 4),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.dateonlydate0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id, 
    @value, 
    @nullablevalue
);
",
            methodName:"InsertModelInner",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.DateOnly),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (System.Data.SqlDbType)(31)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.DateOnly?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (System.Data.SqlDbType)(31))
            ]
        public void InsertModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((IDateOnlySingleTypedate)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateOnlySingleTypedate)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((IDateOnlySingleTypedate)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.dateonlydate0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id,
    @value, 
    @nullablevalue
)
",
            methodName:"DbConnectionInsertInnerModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateOnly), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)5),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateOnly?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)5, 
                nullable: true)]
        public void DbConnectionInsertInnerModelConfig()
        {
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.dateonlydate0m(
	id,
    value,
    nullablevalue,
    dateonlydate0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @dateonlydate0mi_id
)
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id",
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.DateOnly), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.SqlDbType)(31)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.DateOnly?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.SqlDbType)(31),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "dateonlydate0mi_id", 
                methodParametrName: "dateonlydate0mi_id", 
                dbType: (System.Data.SqlDbType)(8),
                nullable: true)]
        public void InsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((IDateOnlySingleTypedate)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateOnlySingleTypedate)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((IDateOnlySingleTypedate)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.dateonlydate0m(
	id,
    value,
    nullablevalue,
    dateonlydate0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @dateonlydate0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.DateOnly), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)5),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateOnly?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)5,
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "dateonlydate0mi_id", 
                methodParametrName: "dateonlydate0mi_id", 
                dbType: (System.Data.DbType)11,
                nullable: true)]
        public void DbConnectionInsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((IDateOnlySingleTypedate)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateOnlySingleTypedate)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlySingleTypedate)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateOnlydate0M), typeof(FlatDateOnlydate0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
Gedaq.SqlClient.Attributes.DynamicParametr()]
        private void MMDynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM dbo.dateonlydate0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateOnlydate0M>();
                var models2 = new List<FlatDateOnlydate0M>();
                await((IDateOnlySingleTypedate)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM dbo.dateonlydate0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateOnlydate0M>();
                var models2 = new List<FlatDateOnlydate0M>();
                ((IDateOnlySingleTypedate)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateOnlydate0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
Gedaq.SqlClient.Attributes.DynamicParametr()]
        private void DynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.dateonlydate0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = await((IDateOnlySingleTypedate)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.dateonlydate0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((IDateOnlySingleTypedate)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM dbo.dateonlydate0m m
LEFT JOIN dbo.dateonlydate0mi mi ON mi.id = m.dateonlydate0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DateOnlydate0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
Gedaq.SqlClient.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = await((IDateOnlySingleTypedate)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateOnlydate0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((IDateOnlySingleTypedate)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateOnlydate0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateOnlydate0M), typeof(FlatDateOnlydate0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (System.Data.SqlDbType)(8))]
        private void MMDynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM dbo.dateonlydate0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateOnlydate0M>();
                var models2 = new List<FlatDateOnlydate0M>();
                await((IDateOnlySingleTypedate)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM dbo.dateonlydate0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateOnlydate0M>();
                var models2 = new List<FlatDateOnlydate0M>();
                ((IDateOnlySingleTypedate)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateOnlydate0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (System.Data.SqlDbType)(8))]
        private void DynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.dateonlydate0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDateOnlySingleTypedate)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.dateonlydate0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDateOnlySingleTypedate)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM dbo.dateonlydate0m m
LEFT JOIN dbo.dateonlydate0mi mi ON mi.id = m.dateonlydate0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DateOnlydate0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (System.Data.SqlDbType)(8))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await((IDateOnlySingleTypedate)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateOnlydate0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDateOnlySingleTypedate)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateOnlydate0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateOnlydate0M), typeof(FlatDateOnlydate0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionSTMMDynQuerySelectModelDynParBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionMMDynQuerySelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateOnlydate0M>();
                var models2 = new List<FlatDateOnlydate0M>();
                await((IDateOnlySingleTypedate)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydate0M>();
                var firstItems2 = new List<FlatDateOnlydate0M>();
                var secondItems1 = new List<FlatDateOnlydate0M>();
                var secondItems2 = new List<FlatDateOnlydate0M>();
                await ((IDateOnlySingleTypedate)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDateOnlydate0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDateOnlydate0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydate0M>();
                var firstItems2 = new List<FlatDateOnlydate0M>();
                var secondItems1 = new List<FlatDateOnlydate0M>();
                await ((IDateOnlySingleTypedate)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDateOnlydate0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatDateOnlydate0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDateOnlydate0M>();
                var models2 = new List<FlatDateOnlydate0M>();
                ((IDateOnlySingleTypedate)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydate0M>();
                var firstItems2 = new List<FlatDateOnlydate0M>();
                var secondItems1 = new List<FlatDateOnlydate0M>();
                var secondItems2 = new List<FlatDateOnlydate0M>();
                 ((IDateOnlySingleTypedate)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatDateOnlydate0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatDateOnlydate0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydate0M>();
                var firstItems2 = new List<FlatDateOnlydate0M>();
                var secondItems1 = new List<FlatDateOnlydate0M>();
                 ((IDateOnlySingleTypedate)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatDateOnlydate0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatDateOnlydate0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateOnlydate0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionDynQuerySelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDateOnlySingleTypedate)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateOnlySingleTypedate)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDateOnlydate0M.AssertModel(models[0],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(models[1],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(models[2],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(models[3],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(models[4],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(models[5],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDateOnlydate0M.AssertModel(models[0],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(models[1],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(models[2],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(models[3],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(models[4],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(models[5],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(models[6],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(models[7],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(models[8],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(models[9],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(models[10],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(models[11],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(models[12],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(models[13],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(models[14],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(models[15],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(models[16],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(models[17],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(models[18],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(models[19],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(models[20],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(models[21],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydate0M>();
                var secondItems1 = new List<FlatDateOnlydate0M>();
                var secondItems2 = new List<FlatDateOnlydate0M>();
                await ((IDateOnlySingleTypedate)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatDateOnlydate0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDateOnlydate0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDateOnlySingleTypedate)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateOnlySingleTypedate)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatDateOnlydate0M.AssertModel(models[0],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(models[1],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(models[2],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(models[3],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(models[4],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(models[5],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(models[6],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(models[7],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(models[8],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(models[9],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(models[10],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(models[11],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(models[12],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(models[13],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(models[14],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(models[15],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(models[16],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(models[17],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(models[18],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDateOnlydate0M.AssertModel(models[0],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(models[1],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(models[2],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(models[3],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(models[4],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(models[5],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(models[6],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(models[7],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(models[8],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(models[9],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(models[10],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(models[11],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(models[12],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(models[13],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(models[14],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(models[15],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(models[16],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(models[17],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(models[18],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(models[19],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydate0M>();
                var secondItems1 = new List<FlatDateOnlydate0M>();
                var secondItems2 = new List<FlatDateOnlydate0M>();
                 ((IDateOnlySingleTypedate)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatDateOnlydate0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatDateOnlydate0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 

@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM dbo.dateonlydate0m m
LEFT JOIN dbo.dateonlydate0mi mi ON mi.id = m.dateonlydate0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DateOnlydate0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSTSelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDateOnlySingleTypedate)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateOnlydate0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateOnlySingleTypedate)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        DateOnlydate0M.AssertModel(models[0],_testData[6], false);
                        DateOnlydate0M.AssertModel(models[1],_testData[7], false);
                        DateOnlydate0M.AssertModel(models[2],_testData[8], false);
                        DateOnlydate0M.AssertModel(models[3],_testData[9], false);
                        DateOnlydate0M.AssertModel(models[4],_testData[10], false);
                        DateOnlydate0M.AssertModel(models[5],_testData[11], false);
                        DateOnlydate0M.AssertModel(models[6],_testData[12], false);
                        DateOnlydate0M.AssertModel(models[7],_testData[13], false);
                        DateOnlydate0M.AssertModel(models[8],_testData[14], false);
                        DateOnlydate0M.AssertModel(models[9],_testData[15], false);
                        DateOnlydate0M.AssertModel(models[10],_testData[16], false);
                        DateOnlydate0M.AssertModel(models[11],_testData[17], false);
                        DateOnlydate0M.AssertModel(models[12],_testData[18], false);
                        DateOnlydate0M.AssertModel(models[13],_testData[19], false);
                        DateOnlydate0M.AssertModel(models[14],_testData[20], false);
                        DateOnlydate0M.AssertModel(models[15],_testData[21], false);
                        DateOnlydate0M.AssertModel(models[16],_testData[22], false);
                        DateOnlydate0M.AssertModel(models[17],_testData[23], false);
                        DateOnlydate0M.AssertModel(models[18],_testData[24], false);
                        DateOnlydate0M.AssertModel(models[19],_testData[25], false);
                        DateOnlydate0M.AssertModel(models[20],_testData[26], false);
                        DateOnlydate0M.AssertModel(models[21],_testData[27], false);
                        DateOnlydate0M.AssertModel(models[22],_testData[28], false);
                        DateOnlydate0M.AssertModel(models[23],_testData[29], false);
                        DateOnlydate0M.AssertModel(models[24],_testData[30], false);
                        DateOnlydate0M.AssertModel(models[25],_testData[31], false);
                        DateOnlydate0M.AssertModel(models[26],_testData[32], false);
                        DateOnlydate0M.AssertModel(models[27],_testData[33], false);
                        DateOnlydate0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        DateOnlydate0M.AssertModel(models[0],_testData[3], false);
                        DateOnlydate0M.AssertModel(models[1],_testData[4], false);
                        DateOnlydate0M.AssertModel(models[2],_testData[5], false);
                        DateOnlydate0M.AssertModel(models[3],_testData[6], false);
                        DateOnlydate0M.AssertModel(models[4],_testData[7], false);
                        DateOnlydate0M.AssertModel(models[5],_testData[8], false);
                        DateOnlydate0M.AssertModel(models[6],_testData[9], false);
                        DateOnlydate0M.AssertModel(models[7],_testData[10], false);
                        DateOnlydate0M.AssertModel(models[8],_testData[11], false);
                        DateOnlydate0M.AssertModel(models[9],_testData[12], false);
                        DateOnlydate0M.AssertModel(models[10],_testData[13], false);
                        DateOnlydate0M.AssertModel(models[11],_testData[14], false);
                        DateOnlydate0M.AssertModel(models[12],_testData[15], false);
                        DateOnlydate0M.AssertModel(models[13],_testData[16], false);
                        DateOnlydate0M.AssertModel(models[14],_testData[17], false);
                        DateOnlydate0M.AssertModel(models[15],_testData[18], false);
                        DateOnlydate0M.AssertModel(models[16],_testData[19], false);
                        DateOnlydate0M.AssertModel(models[17],_testData[20], false);
                        DateOnlydate0M.AssertModel(models[18],_testData[21], false);
                        DateOnlydate0M.AssertModel(models[19],_testData[22], false);
                        DateOnlydate0M.AssertModel(models[20],_testData[23], false);
                        DateOnlydate0M.AssertModel(models[21],_testData[24], false);
                        DateOnlydate0M.AssertModel(models[22],_testData[25], false);
                        DateOnlydate0M.AssertModel(models[23],_testData[26], false);
                        DateOnlydate0M.AssertModel(models[24],_testData[27], false);
                        DateOnlydate0M.AssertModel(models[25],_testData[28], false);
                        DateOnlydate0M.AssertModel(models[26],_testData[29], false);
                        DateOnlydate0M.AssertModel(models[27],_testData[30], false);
                        DateOnlydate0M.AssertModel(models[28],_testData[31], false);
                        DateOnlydate0M.AssertModel(models[29],_testData[32], false);
                        DateOnlydate0M.AssertModel(models[30],_testData[33], false);
                        DateOnlydate0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDateOnlySingleTypedate)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateOnlydate0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateOnlySingleTypedate)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        DateOnlydate0M.AssertModel(models[0],_testData[16], false);
                        DateOnlydate0M.AssertModel(models[1],_testData[17], false);
                        DateOnlydate0M.AssertModel(models[2],_testData[18], false);
                        DateOnlydate0M.AssertModel(models[3],_testData[19], false);
                        DateOnlydate0M.AssertModel(models[4],_testData[20], false);
                        DateOnlydate0M.AssertModel(models[5],_testData[21], false);
                        DateOnlydate0M.AssertModel(models[6],_testData[22], false);
                        DateOnlydate0M.AssertModel(models[7],_testData[23], false);
                        DateOnlydate0M.AssertModel(models[8],_testData[24], false);
                        DateOnlydate0M.AssertModel(models[9],_testData[25], false);
                        DateOnlydate0M.AssertModel(models[10],_testData[26], false);
                        DateOnlydate0M.AssertModel(models[11],_testData[27], false);
                        DateOnlydate0M.AssertModel(models[12],_testData[28], false);
                        DateOnlydate0M.AssertModel(models[13],_testData[29], false);
                        DateOnlydate0M.AssertModel(models[14],_testData[30], false);
                        DateOnlydate0M.AssertModel(models[15],_testData[31], false);
                        DateOnlydate0M.AssertModel(models[16],_testData[32], false);
                        DateOnlydate0M.AssertModel(models[17],_testData[33], false);
                        DateOnlydate0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        DateOnlydate0M.AssertModel(models[0],_testData[18], false);
                        DateOnlydate0M.AssertModel(models[1],_testData[19], false);
                        DateOnlydate0M.AssertModel(models[2],_testData[20], false);
                        DateOnlydate0M.AssertModel(models[3],_testData[21], false);
                        DateOnlydate0M.AssertModel(models[4],_testData[22], false);
                        DateOnlydate0M.AssertModel(models[5],_testData[23], false);
                        DateOnlydate0M.AssertModel(models[6],_testData[24], false);
                        DateOnlydate0M.AssertModel(models[7],_testData[25], false);
                        DateOnlydate0M.AssertModel(models[8],_testData[26], false);
                        DateOnlydate0M.AssertModel(models[9],_testData[27], false);
                        DateOnlydate0M.AssertModel(models[10],_testData[28], false);
                        DateOnlydate0M.AssertModel(models[11],_testData[29], false);
                        DateOnlydate0M.AssertModel(models[12],_testData[30], false);
                        DateOnlydate0M.AssertModel(models[13],_testData[31], false);
                        DateOnlydate0M.AssertModel(models[14],_testData[32], false);
                        DateOnlydate0M.AssertModel(models[15],_testData[33], false);
                        DateOnlydate0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateOnlydate0M), typeof(FlatDateOnlydate0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)11)]
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 2)]
        private void DbConnectionSTMMDynQuerySelectModelBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionMMDynQuerySelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateOnlydate0M>();
                var models2 = new List<FlatDateOnlydate0M>();
                await((IDateOnlySingleTypedate)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydate0M>();
                var firstItems2 = new List<FlatDateOnlydate0M>();
                var secondItems1 = new List<FlatDateOnlydate0M>();
                var secondItems2 = new List<FlatDateOnlydate0M>();
                await ((IDateOnlySingleTypedate)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 138, query1, 14, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDateOnlydate0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatDateOnlydate0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydate0M>();
                var firstItems2 = new List<FlatDateOnlydate0M>();
                var secondItems1 = new List<FlatDateOnlydate0M>();
                await ((IDateOnlySingleTypedate)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 97, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDateOnlydate0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatDateOnlydate0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateOnlydate0M>();
                var models2 = new List<FlatDateOnlydate0M>();
                ((IDateOnlySingleTypedate)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydate0M>();
                var firstItems2 = new List<FlatDateOnlydate0M>();
                var secondItems1 = new List<FlatDateOnlydate0M>();
                var secondItems2 = new List<FlatDateOnlydate0M>();
                 ((IDateOnlySingleTypedate)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 68, query1, 82, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatDateOnlydate0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatDateOnlydate0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydate0M>();
                var firstItems2 = new List<FlatDateOnlydate0M>();
                var secondItems1 = new List<FlatDateOnlydate0M>();
                 ((IDateOnlySingleTypedate)this).DbConnectionMMDynQuerySelectModelBatch(connection, 100, query1, 131, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatDateOnlydate0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatDateOnlydate0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[4],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateOnlydate0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)11)]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 2)]
        private void DbConnectionDynQuerySelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDateOnlySingleTypedate)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateOnlySingleTypedate)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 52, query1, 37, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatDateOnlydate0M.AssertModel(models[0],_testData[10], false);
                        FlatDateOnlydate0M.AssertModel(models[1],_testData[11], false);
                        FlatDateOnlydate0M.AssertModel(models[2],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(models[3],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(models[4],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(models[5],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(models[6],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(models[7],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(models[8],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(models[9],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(models[10],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(models[11],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(models[12],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(models[13],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(models[14],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(models[15],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(models[16],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(models[17],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(models[18],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(models[19],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(models[20],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(models[21],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(models[22],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(models[23],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatDateOnlydate0M.AssertModel(models[0],_testData[6], false);
                        FlatDateOnlydate0M.AssertModel(models[1],_testData[7], false);
                        FlatDateOnlydate0M.AssertModel(models[2],_testData[8], false);
                        FlatDateOnlydate0M.AssertModel(models[3],_testData[9], false);
                        FlatDateOnlydate0M.AssertModel(models[4],_testData[10], false);
                        FlatDateOnlydate0M.AssertModel(models[5],_testData[11], false);
                        FlatDateOnlydate0M.AssertModel(models[6],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(models[7],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(models[8],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(models[9],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(models[10],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(models[11],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(models[12],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(models[13],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(models[14],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(models[15],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(models[16],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(models[17],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(models[18],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(models[19],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(models[20],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(models[21],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(models[22],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(models[23],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(models[24],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(models[25],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(models[26],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(models[27],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydate0M>();
                var secondItems1 = new List<FlatDateOnlydate0M>();
                var secondItems2 = new List<FlatDateOnlydate0M>();
                await ((IDateOnlySingleTypedate)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 14, query1, 39, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatDateOnlydate0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDateOnlydate0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDateOnlySingleTypedate)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateOnlySingleTypedate)this).DbConnectionSTDynQuerySelectModelBatch(connection, 108, query1, 58, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDateOnlydate0M.AssertModel(models[0],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(models[1],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(models[2],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(models[3],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(models[4],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(models[5],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(models[6],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(models[7],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(models[8],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDateOnlydate0M.AssertModel(models[0],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(models[1],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(models[2],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(models[3],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(models[4],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(models[5],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(models[6],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(models[7],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(models[8],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(models[9],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(models[10],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(models[11],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(models[12],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(models[13],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(models[14],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(models[15],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(models[16],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(models[17],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(models[18],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(models[19],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(models[20],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(models[21],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM dbo.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydate0M>();
                var secondItems1 = new List<FlatDateOnlydate0M>();
                var secondItems2 = new List<FlatDateOnlydate0M>();
                 ((IDateOnlySingleTypedate)this).DbConnectionDynQuerySelectModelBatch(connection, 68, query1, 82, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatDateOnlydate0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatDateOnlydate0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 

@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM dbo.dateonlydate0m m
LEFT JOIN dbo.dateonlydate0mi mi ON mi.id = m.dateonlydate0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DateOnlydate0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)11)]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((IDateOnlySingleTypedate)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateOnlydate0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateOnlySingleTypedate)this).DbConnectionSTSelectModelBatchAsync(connection, 70, 17))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        DateOnlydate0M.AssertModel(models[0],_testData[16], false);
                        DateOnlydate0M.AssertModel(models[1],_testData[17], false);
                        DateOnlydate0M.AssertModel(models[2],_testData[18], false);
                        DateOnlydate0M.AssertModel(models[3],_testData[19], false);
                        DateOnlydate0M.AssertModel(models[4],_testData[20], false);
                        DateOnlydate0M.AssertModel(models[5],_testData[21], false);
                        DateOnlydate0M.AssertModel(models[6],_testData[22], false);
                        DateOnlydate0M.AssertModel(models[7],_testData[23], false);
                        DateOnlydate0M.AssertModel(models[8],_testData[24], false);
                        DateOnlydate0M.AssertModel(models[9],_testData[25], false);
                        DateOnlydate0M.AssertModel(models[10],_testData[26], false);
                        DateOnlydate0M.AssertModel(models[11],_testData[27], false);
                        DateOnlydate0M.AssertModel(models[12],_testData[28], false);
                        DateOnlydate0M.AssertModel(models[13],_testData[29], false);
                        DateOnlydate0M.AssertModel(models[14],_testData[30], false);
                        DateOnlydate0M.AssertModel(models[15],_testData[31], false);
                        DateOnlydate0M.AssertModel(models[16],_testData[32], false);
                        DateOnlydate0M.AssertModel(models[17],_testData[33], false);
                        DateOnlydate0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        DateOnlydate0M.AssertModel(models[0],_testData[3], false);
                        DateOnlydate0M.AssertModel(models[1],_testData[4], false);
                        DateOnlydate0M.AssertModel(models[2],_testData[5], false);
                        DateOnlydate0M.AssertModel(models[3],_testData[6], false);
                        DateOnlydate0M.AssertModel(models[4],_testData[7], false);
                        DateOnlydate0M.AssertModel(models[5],_testData[8], false);
                        DateOnlydate0M.AssertModel(models[6],_testData[9], false);
                        DateOnlydate0M.AssertModel(models[7],_testData[10], false);
                        DateOnlydate0M.AssertModel(models[8],_testData[11], false);
                        DateOnlydate0M.AssertModel(models[9],_testData[12], false);
                        DateOnlydate0M.AssertModel(models[10],_testData[13], false);
                        DateOnlydate0M.AssertModel(models[11],_testData[14], false);
                        DateOnlydate0M.AssertModel(models[12],_testData[15], false);
                        DateOnlydate0M.AssertModel(models[13],_testData[16], false);
                        DateOnlydate0M.AssertModel(models[14],_testData[17], false);
                        DateOnlydate0M.AssertModel(models[15],_testData[18], false);
                        DateOnlydate0M.AssertModel(models[16],_testData[19], false);
                        DateOnlydate0M.AssertModel(models[17],_testData[20], false);
                        DateOnlydate0M.AssertModel(models[18],_testData[21], false);
                        DateOnlydate0M.AssertModel(models[19],_testData[22], false);
                        DateOnlydate0M.AssertModel(models[20],_testData[23], false);
                        DateOnlydate0M.AssertModel(models[21],_testData[24], false);
                        DateOnlydate0M.AssertModel(models[22],_testData[25], false);
                        DateOnlydate0M.AssertModel(models[23],_testData[26], false);
                        DateOnlydate0M.AssertModel(models[24],_testData[27], false);
                        DateOnlydate0M.AssertModel(models[25],_testData[28], false);
                        DateOnlydate0M.AssertModel(models[26],_testData[29], false);
                        DateOnlydate0M.AssertModel(models[27],_testData[30], false);
                        DateOnlydate0M.AssertModel(models[28],_testData[31], false);
                        DateOnlydate0M.AssertModel(models[29],_testData[32], false);
                        DateOnlydate0M.AssertModel(models[30],_testData[33], false);
                        DateOnlydate0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = ((IDateOnlySingleTypedate)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateOnlydate0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateOnlySingleTypedate)this).DbConnectionSTSelectModelBatch(connection, 37, 41))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        DateOnlydate0M.AssertModel(models[0],_testData[6], false);
                        DateOnlydate0M.AssertModel(models[1],_testData[7], false);
                        DateOnlydate0M.AssertModel(models[2],_testData[8], false);
                        DateOnlydate0M.AssertModel(models[3],_testData[9], false);
                        DateOnlydate0M.AssertModel(models[4],_testData[10], false);
                        DateOnlydate0M.AssertModel(models[5],_testData[11], false);
                        DateOnlydate0M.AssertModel(models[6],_testData[12], false);
                        DateOnlydate0M.AssertModel(models[7],_testData[13], false);
                        DateOnlydate0M.AssertModel(models[8],_testData[14], false);
                        DateOnlydate0M.AssertModel(models[9],_testData[15], false);
                        DateOnlydate0M.AssertModel(models[10],_testData[16], false);
                        DateOnlydate0M.AssertModel(models[11],_testData[17], false);
                        DateOnlydate0M.AssertModel(models[12],_testData[18], false);
                        DateOnlydate0M.AssertModel(models[13],_testData[19], false);
                        DateOnlydate0M.AssertModel(models[14],_testData[20], false);
                        DateOnlydate0M.AssertModel(models[15],_testData[21], false);
                        DateOnlydate0M.AssertModel(models[16],_testData[22], false);
                        DateOnlydate0M.AssertModel(models[17],_testData[23], false);
                        DateOnlydate0M.AssertModel(models[18],_testData[24], false);
                        DateOnlydate0M.AssertModel(models[19],_testData[25], false);
                        DateOnlydate0M.AssertModel(models[20],_testData[26], false);
                        DateOnlydate0M.AssertModel(models[21],_testData[27], false);
                        DateOnlydate0M.AssertModel(models[22],_testData[28], false);
                        DateOnlydate0M.AssertModel(models[23],_testData[29], false);
                        DateOnlydate0M.AssertModel(models[24],_testData[30], false);
                        DateOnlydate0M.AssertModel(models[25],_testData[31], false);
                        DateOnlydate0M.AssertModel(models[26],_testData[32], false);
                        DateOnlydate0M.AssertModel(models[27],_testData[33], false);
                        DateOnlydate0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        DateOnlydate0M.AssertModel(models[0],_testData[8], false);
                        DateOnlydate0M.AssertModel(models[1],_testData[9], false);
                        DateOnlydate0M.AssertModel(models[2],_testData[10], false);
                        DateOnlydate0M.AssertModel(models[3],_testData[11], false);
                        DateOnlydate0M.AssertModel(models[4],_testData[12], false);
                        DateOnlydate0M.AssertModel(models[5],_testData[13], false);
                        DateOnlydate0M.AssertModel(models[6],_testData[14], false);
                        DateOnlydate0M.AssertModel(models[7],_testData[15], false);
                        DateOnlydate0M.AssertModel(models[8],_testData[16], false);
                        DateOnlydate0M.AssertModel(models[9],_testData[17], false);
                        DateOnlydate0M.AssertModel(models[10],_testData[18], false);
                        DateOnlydate0M.AssertModel(models[11],_testData[19], false);
                        DateOnlydate0M.AssertModel(models[12],_testData[20], false);
                        DateOnlydate0M.AssertModel(models[13],_testData[21], false);
                        DateOnlydate0M.AssertModel(models[14],_testData[22], false);
                        DateOnlydate0M.AssertModel(models[15],_testData[23], false);
                        DateOnlydate0M.AssertModel(models[16],_testData[24], false);
                        DateOnlydate0M.AssertModel(models[17],_testData[25], false);
                        DateOnlydate0M.AssertModel(models[18],_testData[26], false);
                        DateOnlydate0M.AssertModel(models[19],_testData[27], false);
                        DateOnlydate0M.AssertModel(models[20],_testData[28], false);
                        DateOnlydate0M.AssertModel(models[21],_testData[29], false);
                        DateOnlydate0M.AssertModel(models[22],_testData[30], false);
                        DateOnlydate0M.AssertModel(models[23],_testData[31], false);
                        DateOnlydate0M.AssertModel(models[24],_testData[32], false);
                        DateOnlydate0M.AssertModel(models[25],_testData[33], false);
                        DateOnlydate0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IDateOnlySingleTypedate)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDateOnlySingleTypedate)this).SetDbConnectionSelectModelParametrs(cmd, 52);
                var models = await ((IDateOnlySingleTypedate)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
DateOnlydate0M.AssertModel(models[0],_testData[10], false);DateOnlydate0M.AssertModel(models[1],_testData[11], false);DateOnlydate0M.AssertModel(models[2],_testData[12], false);DateOnlydate0M.AssertModel(models[3],_testData[13], false);DateOnlydate0M.AssertModel(models[4],_testData[14], false);DateOnlydate0M.AssertModel(models[5],_testData[15], false);DateOnlydate0M.AssertModel(models[6],_testData[16], false);DateOnlydate0M.AssertModel(models[7],_testData[17], false);DateOnlydate0M.AssertModel(models[8],_testData[18], false);DateOnlydate0M.AssertModel(models[9],_testData[19], false);DateOnlydate0M.AssertModel(models[10],_testData[20], false);DateOnlydate0M.AssertModel(models[11],_testData[21], false);DateOnlydate0M.AssertModel(models[12],_testData[22], false);DateOnlydate0M.AssertModel(models[13],_testData[23], false);DateOnlydate0M.AssertModel(models[14],_testData[24], false);DateOnlydate0M.AssertModel(models[15],_testData[25], false);DateOnlydate0M.AssertModel(models[16],_testData[26], false);DateOnlydate0M.AssertModel(models[17],_testData[27], false);DateOnlydate0M.AssertModel(models[18],_testData[28], false);DateOnlydate0M.AssertModel(models[19],_testData[29], false);DateOnlydate0M.AssertModel(models[20],_testData[30], false);DateOnlydate0M.AssertModel(models[21],_testData[31], false);DateOnlydate0M.AssertModel(models[22],_testData[32], false);DateOnlydate0M.AssertModel(models[23],_testData[33], false);DateOnlydate0M.AssertModel(models[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateOnlySingleTypedate)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateOnlySingleTypedate)this).SetDbConnectionSelectModelParametrs(cmd, 107);
                var models =  ((IDateOnlySingleTypedate)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(11));
DateOnlydate0M.AssertModel(models[0],_testData[24], false);DateOnlydate0M.AssertModel(models[1],_testData[25], false);DateOnlydate0M.AssertModel(models[2],_testData[26], false);DateOnlydate0M.AssertModel(models[3],_testData[27], false);DateOnlydate0M.AssertModel(models[4],_testData[28], false);DateOnlydate0M.AssertModel(models[5],_testData[29], false);DateOnlydate0M.AssertModel(models[6],_testData[30], false);DateOnlydate0M.AssertModel(models[7],_testData[31], false);DateOnlydate0M.AssertModel(models[8],_testData[32], false);DateOnlydate0M.AssertModel(models[9],_testData[33], false);DateOnlydate0M.AssertModel(models[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM dbo.dateonlydate0m m
LEFT JOIN dbo.dateonlydate0mi mi ON mi.id = m.dateonlydate0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelToObjArr",
            queryMapTypes: [typeof(object[])],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateOnlySingleTypedate)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2013, month: 10, day: 13)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1997, month: 10, day: 16)).ToDateTime(TimeOnly.MinValue)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2008, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1985, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 2015, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1923, month: 10, day: 10)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1929, month: 10, day: 17)).ToDateTime(TimeOnly.MinValue)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1941, month: 10, day: 18)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1967, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2001, month: 10, day: 8)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1996, month: 10, day: 19)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1923, month: 10, day: 18)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1998, month: 10, day: 11)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1968, month: 10, day: 5)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1999, month: 10, day: 9)).ToDateTime(TimeOnly.MinValue)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1931, month: 10, day: 18)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1946, month: 10, day: 5)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1946, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1955, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1945, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2003, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1985, month: 10, day: 17)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2001, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1929, month: 10, day: 8)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1963, month: 10, day: 19)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 2013, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2015, month: 10, day: 17)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1983, month: 10, day: 1)).ToDateTime(TimeOnly.MinValue)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1987, month: 10, day: 8)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1946, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1926, month: 10, day: 2)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1982, month: 10, day: 1)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1942, month: 10, day: 19)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1999, month: 10, day: 1)).ToDateTime(TimeOnly.MinValue)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1980, month: 10, day: 1)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1967, month: 10, day: 9)).ToDateTime(TimeOnly.MinValue)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1970, month: 10, day: 5)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1940, month: 10, day: 17)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1941, month: 10, day: 13)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 2011, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1968, month: 10, day: 16)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2013, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 2018, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1922, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 2002, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1952, month: 10, day: 2)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1964, month: 10, day: 10)).ToDateTime(TimeOnly.MinValue)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1938, month: 10, day: 2)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1989, month: 10, day: 9)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1955, month: 10, day: 1)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1929, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1994, month: 10, day: 8)).ToDateTime(TimeOnly.MinValue)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2008, month: 10, day: 19)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1996, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1925, month: 10, day: 16)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1952, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1946, month: 10, day: 8)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1923, month: 10, day: 15)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1999, month: 10, day: 10)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1961, month: 10, day: 18)).ToDateTime(TimeOnly.MinValue)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1950, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1955, month: 10, day: 13)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1958, month: 10, day: 5)).ToDateTime(TimeOnly.MinValue)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1987, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1963, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2011, month: 10, day: 19)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1997, month: 10, day: 15)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 2018, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1939, month: 10, day: 8)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1919, month: 10, day: 9)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1972, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1979, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1950, month: 10, day: 18)).ToDateTime(TimeOnly.MinValue)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2012, month: 10, day: 10)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1980, month: 10, day: 11)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1938, month: 10, day: 18)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1972, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDateOnlySingleTypedate)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2013, month: 10, day: 13)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1997, month: 10, day: 16)).ToDateTime(TimeOnly.MinValue)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2008, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1985, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 2015, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1923, month: 10, day: 10)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1929, month: 10, day: 17)).ToDateTime(TimeOnly.MinValue)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1941, month: 10, day: 18)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1967, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2001, month: 10, day: 8)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1996, month: 10, day: 19)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1923, month: 10, day: 18)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1998, month: 10, day: 11)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1968, month: 10, day: 5)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1999, month: 10, day: 9)).ToDateTime(TimeOnly.MinValue)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1931, month: 10, day: 18)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1946, month: 10, day: 5)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1946, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1955, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1945, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2003, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1985, month: 10, day: 17)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2001, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1929, month: 10, day: 8)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1963, month: 10, day: 19)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 2013, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2015, month: 10, day: 17)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1983, month: 10, day: 1)).ToDateTime(TimeOnly.MinValue)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1987, month: 10, day: 8)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1946, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1926, month: 10, day: 2)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1982, month: 10, day: 1)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1942, month: 10, day: 19)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1999, month: 10, day: 1)).ToDateTime(TimeOnly.MinValue)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1980, month: 10, day: 1)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1967, month: 10, day: 9)).ToDateTime(TimeOnly.MinValue)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1970, month: 10, day: 5)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1940, month: 10, day: 17)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1941, month: 10, day: 13)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 2011, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1968, month: 10, day: 16)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2013, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 2018, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1922, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 2002, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1952, month: 10, day: 2)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1964, month: 10, day: 10)).ToDateTime(TimeOnly.MinValue)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1938, month: 10, day: 2)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1989, month: 10, day: 9)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1955, month: 10, day: 1)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1929, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1994, month: 10, day: 8)).ToDateTime(TimeOnly.MinValue)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2008, month: 10, day: 19)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1996, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1925, month: 10, day: 16)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1952, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1946, month: 10, day: 8)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1923, month: 10, day: 15)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1999, month: 10, day: 10)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1961, month: 10, day: 18)).ToDateTime(TimeOnly.MinValue)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1950, month: 10, day: 3)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1955, month: 10, day: 13)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1958, month: 10, day: 5)).ToDateTime(TimeOnly.MinValue)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1987, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1963, month: 10, day: 6)).ToDateTime(TimeOnly.MinValue)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2011, month: 10, day: 19)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1997, month: 10, day: 15)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 2018, month: 10, day: 7)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1939, month: 10, day: 8)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1919, month: 10, day: 9)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1972, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1979, month: 10, day: 12)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateTime?)model[5], Is.EqualTo((new DateOnly(year: 1950, month: 10, day: 18)).ToDateTime(TimeOnly.MinValue)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 2012, month: 10, day: 10)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((System.DateTime)model[3], Is.EqualTo((new DateOnly(year: 1980, month: 10, day: 11)).ToDateTime(TimeOnly.MinValue)));//InnerModel.Value

                Assert.That((System.DateTime?)model[4], Is.EqualTo((new DateOnly(year: 1938, month: 10, day: 18)).ToDateTime(TimeOnly.MinValue)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.DateTime)model[1], Is.EqualTo((new DateOnly(year: 1972, month: 10, day: 4)).ToDateTime(TimeOnly.MinValue)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

