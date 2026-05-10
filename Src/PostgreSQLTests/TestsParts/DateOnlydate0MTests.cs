

using Npgsql;
using NpgsqlTypes;
using Gedaq.Common.Enums;
using Gedaq.Npgsql.Attributes;
using Gedaq.Npgsql.Enums;
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
    Id = 7,
    Value = new DateOnly(year: 1998, month: 10, day: 14),
    ModelInner = null,
    NullableValue = new DateOnly(year: 1929, month: 10, day: 1),
},
            new DateOnlydate0M
{
    Id = 12,
    Value = new DateOnly(year: 1936, month: 10, day: 7),
    ModelInner = new DateOnlydate0MI
{
    Id = 9,
    Value = new DateOnly(year: 1944, month: 10, day: 6),
    NullableValue = new DateOnly(year: 1947, month: 10, day: 3),
},
    NullableValue = new DateOnly(year: 1988, month: 10, day: 10),
},
            new DateOnlydate0M
{
    Id = 13,
    Value = new DateOnly(year: 1996, month: 10, day: 4),
    ModelInner = null,
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 21,
    Value = new DateOnly(year: 1917, month: 10, day: 12),
    ModelInner = new DateOnlydate0MI
{
    Id = 16,
    Value = new DateOnly(year: 1947, month: 10, day: 9),
    NullableValue = new DateOnly(year: 1994, month: 10, day: 17),
},
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 27,
    Value = new DateOnly(year: 1988, month: 10, day: 10),
    ModelInner = null,
    NullableValue = new DateOnly(year: 1918, month: 10, day: 16),
},
            new DateOnlydate0M
{
    Id = 31,
    Value = new DateOnly(year: 2001, month: 10, day: 2),
    ModelInner = new DateOnlydate0MI
{
    Id = 24,
    Value = new DateOnly(year: 1966, month: 10, day: 3),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 40,
    Value = new DateOnly(year: 1956, month: 10, day: 13),
    ModelInner = null,
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 41,
    Value = new DateOnly(year: 2012, month: 10, day: 15),
    ModelInner = new DateOnlydate0MI
{
    Id = 30,
    Value = new DateOnly(year: 1974, month: 10, day: 8),
    NullableValue = null,
},
    NullableValue = new DateOnly(year: 1991, month: 10, day: 14),
},
            new DateOnlydate0M
{
    Id = 48,
    Value = new DateOnly(year: 1976, month: 10, day: 9),
    ModelInner = null,
    NullableValue = new DateOnly(year: 1960, month: 10, day: 11),
},
            new DateOnlydate0M
{
    Id = 49,
    Value = new DateOnly(year: 1972, month: 10, day: 4),
    ModelInner = new DateOnlydate0MI
{
    Id = 32,
    Value = new DateOnly(year: 1940, month: 10, day: 1),
    NullableValue = new DateOnly(year: 1991, month: 10, day: 7),
},
    NullableValue = new DateOnly(year: 1919, month: 10, day: 8),
},
            new DateOnlydate0M
{
    Id = 56,
    Value = new DateOnly(year: 1948, month: 10, day: 10),
    ModelInner = null,
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 65,
    Value = new DateOnly(year: 1985, month: 10, day: 13),
    ModelInner = new DateOnlydate0MI
{
    Id = 35,
    Value = new DateOnly(year: 1989, month: 10, day: 5),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 70,
    Value = new DateOnly(year: 1996, month: 10, day: 18),
    ModelInner = null,
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 71,
    Value = new DateOnly(year: 1972, month: 10, day: 15),
    ModelInner = new DateOnlydate0MI
{
    Id = 40,
    Value = new DateOnly(year: 1934, month: 10, day: 18),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 74,
    Value = new DateOnly(year: 1982, month: 10, day: 16),
    ModelInner = null,
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 79,
    Value = new DateOnly(year: 1949, month: 10, day: 1),
    ModelInner = new DateOnlydate0MI
{
    Id = 45,
    Value = new DateOnly(year: 1985, month: 10, day: 13),
    NullableValue = new DateOnly(year: 2000, month: 10, day: 2),
},
    NullableValue = new DateOnly(year: 1972, month: 10, day: 3),
},
            new DateOnlydate0M
{
    Id = 87,
    Value = new DateOnly(year: 1944, month: 10, day: 5),
    ModelInner = null,
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 88,
    Value = new DateOnly(year: 1921, month: 10, day: 1),
    ModelInner = new DateOnlydate0MI
{
    Id = 51,
    Value = new DateOnly(year: 1918, month: 10, day: 8),
    NullableValue = null,
},
    NullableValue = new DateOnly(year: 1964, month: 10, day: 15),
},
            new DateOnlydate0M
{
    Id = 92,
    Value = new DateOnly(year: 1998, month: 10, day: 5),
    ModelInner = null,
    NullableValue = new DateOnly(year: 1922, month: 10, day: 18),
},
            new DateOnlydate0M
{
    Id = 100,
    Value = new DateOnly(year: 1991, month: 10, day: 9),
    ModelInner = new DateOnlydate0MI
{
    Id = 53,
    Value = new DateOnly(year: 1947, month: 10, day: 9),
    NullableValue = new DateOnly(year: 1983, month: 10, day: 5),
},
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 101,
    Value = new DateOnly(year: 1986, month: 10, day: 15),
    ModelInner = null,
    NullableValue = new DateOnly(year: 1920, month: 10, day: 10),
},
            new DateOnlydate0M
{
    Id = 108,
    Value = new DateOnly(year: 1933, month: 10, day: 10),
    ModelInner = new DateOnlydate0MI
{
    Id = 57,
    Value = new DateOnly(year: 1970, month: 10, day: 5),
    NullableValue = new DateOnly(year: 1973, month: 10, day: 17),
},
    NullableValue = new DateOnly(year: 1923, month: 10, day: 13),
},
            new DateOnlydate0M
{
    Id = 113,
    Value = new DateOnly(year: 2012, month: 10, day: 2),
    ModelInner = null,
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 119,
    Value = new DateOnly(year: 1929, month: 10, day: 5),
    ModelInner = new DateOnlydate0MI
{
    Id = 65,
    Value = new DateOnly(year: 2013, month: 10, day: 19),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 121,
    Value = new DateOnly(year: 1950, month: 10, day: 15),
    ModelInner = null,
    NullableValue = new DateOnly(year: 1970, month: 10, day: 14),
},
            new DateOnlydate0M
{
    Id = 122,
    Value = new DateOnly(year: 1923, month: 10, day: 13),
    ModelInner = new DateOnlydate0MI
{
    Id = 71,
    Value = new DateOnly(year: 1973, month: 10, day: 11),
    NullableValue = new DateOnly(year: 1924, month: 10, day: 11),
},
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 127,
    Value = new DateOnly(year: 2019, month: 10, day: 14),
    ModelInner = null,
    NullableValue = new DateOnly(year: 1943, month: 10, day: 3),
},
            new DateOnlydate0M
{
    Id = 128,
    Value = new DateOnly(year: 1980, month: 10, day: 6),
    ModelInner = new DateOnlydate0MI
{
    Id = 76,
    Value = new DateOnly(year: 1968, month: 10, day: 16),
    NullableValue = new DateOnly(year: 1945, month: 10, day: 7),
},
    NullableValue = new DateOnly(year: 1937, month: 10, day: 11),
},
            new DateOnlydate0M
{
    Id = 134,
    Value = new DateOnly(year: 1968, month: 10, day: 5),
    ModelInner = null,
    NullableValue = new DateOnly(year: 1947, month: 10, day: 15),
},
            new DateOnlydate0M
{
    Id = 142,
    Value = new DateOnly(year: 1953, month: 10, day: 10),
    ModelInner = new DateOnlydate0MI
{
    Id = 85,
    Value = new DateOnly(year: 1997, month: 10, day: 3),
    NullableValue = new DateOnly(year: 2006, month: 10, day: 1),
},
    NullableValue = new DateOnly(year: 2017, month: 10, day: 13),
},
            new DateOnlydate0M
{
    Id = 150,
    Value = new DateOnly(year: 1962, month: 10, day: 16),
    ModelInner = null,
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 154,
    Value = new DateOnly(year: 1924, month: 10, day: 9),
    ModelInner = new DateOnlydate0MI
{
    Id = 86,
    Value = new DateOnly(year: 1993, month: 10, day: 14),
    NullableValue = null,
},
    NullableValue = null,
},
            new DateOnlydate0M
{
    Id = 158,
    Value = new DateOnly(year: 1919, month: 10, day: 6),
    ModelInner = null,
    NullableValue = new DateOnly(year: 1985, month: 10, day: 12),
},
            new DateOnlydate0M
{
    Id = 165,
    Value = new DateOnly(year: 2008, month: 10, day: 19),
    ModelInner = new DateOnlydate0MI
{
    Id = 93,
    Value = new DateOnly(year: 1946, month: 10, day: 12),
    NullableValue = new DateOnly(year: 1972, month: 10, day: 1),
},
    NullableValue = new DateOnly(year: 1918, month: 10, day: 16),
},
            new DateOnlydate0M
{
    Id = 166,
    Value = new DateOnly(year: 1939, month: 10, day: 2),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.dateonlydate0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    $1, 
    $2, 
    $3
);
",
            methodName:"InsertModelInner",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateOnly),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(7)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateOnly?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(7))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.dateonlydate0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    $1, 
    $2, 
    $3
)
RETURNING
    id,
    value,
    nullablevalue
;
",
            methodName:"InsertModelInnerReturning",
            queryMapTypes: [typeof(DateOnlydate0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateOnly),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(7)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateOnly?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(7))]
        public void InsertModelInnerReturningConfig()
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

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id =  ((IDateOnlySingleTypedate)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDateOnlySingleTypedate)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[11].ModelInner.Id));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IDateOnlySingleTypedate)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDateOnlySingleTypedate)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.dateonlydate0mi(
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
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateOnly), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(5)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateOnly?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(5), 
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

                changedRows =  ((IDateOnlySingleTypedate)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.dateonlydate0m(
	id,
    value,
    nullablevalue,
    dateonlydate0mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
);
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateOnly),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(7)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateOnly?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(7)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "dateonlydate0mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
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

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.dateonlydate0m(
	id,
    value,
    nullablevalue,
    dateonlydate0mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
)
RETURNING
    nullablevalue,
    value,
~StartInner::ModelInner:Id~
~Reinterpret::Id~
    dateonlydate0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DateOnlydate0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.dateonlydate0m(
	id,
    value,
    nullablevalue,
    dateonlydate0mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
)
RETURNING
    nullablevalue,
    value,
~StartInner::ModelInner:Id~
~Reinterpret::Id~
    dateonlydate0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DateOnlydate0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateOnly),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(7)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateOnly?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(7)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "dateonlydate0mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DateOnlydate0M> models = null;

                models =  ((IDateOnlySingleTypedate)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydate0M.AssertModel(models[0],_testData[4], true);
                models =  ((IDateOnlySingleTypedate)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydate0M.AssertModel(models[0],_testData[5], true);
                models =  ((IDateOnlySingleTypedate)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydate0M.AssertModel(models[0],_testData[6], true);
                models =  ((IDateOnlySingleTypedate)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydate0M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DateOnlydate0M> models = null;

                models = await ((IDateOnlySingleTypedate)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydate0M.AssertModel(models[0],_testData[8], true);
                models = await ((IDateOnlySingleTypedate)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydate0M.AssertModel(models[0],_testData[9], true);
                models = await ((IDateOnlySingleTypedate)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydate0M.AssertModel(models[0],_testData[10], true);
                models = await ((IDateOnlySingleTypedate)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DateOnlydate0M.AssertModel(models[0],_testData[11], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.dateonlydate0m(
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
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.DateOnly), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(5)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.DateOnly?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(5),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "dateonlydate0mi_id", 
                methodParametrName: "dateonlydate0mi_id", 
                dbType: (System.Data.DbType)(11),
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

                changedRows =  ((IDateOnlySingleTypedate)this).DbConnectionInsertModel(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateOnlySingleTypedate)this).DbConnectionInsertModel(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
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

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateOnlydate0M), typeof(FlatDateOnlydate0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
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
FROM public.dateonlydate0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDateOnlydate0M>();
                var models2 = new List<FlatDateOnlydate0M>();
                await ((IDateOnlySingleTypedate)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models1[i],_testData[i], false);
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
FROM public.dateonlydate0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDateOnlydate0M>();
                var models2 = new List<FlatDateOnlydate0M>();
                ((IDateOnlySingleTypedate)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateOnlydate0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDateOnlydate0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
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
FROM public.dateonlydate0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDateOnlySingleTypedate)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
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
FROM public.dateonlydate0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDateOnlySingleTypedate)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
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
FROM public.dateonlydate0m m
LEFT JOIN public.dateonlydate0mi mi ON mi.id = m.dateonlydate0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DateOnlydate0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDateOnlySingleTypedate)this).SelectModelDynParAsync(connection, [parametr1]);
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
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDateOnlySingleTypedate)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DateOnlydate0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateOnlydate0M), typeof(FlatDateOnlydate0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
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
FROM public.dateonlydate0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateOnlydate0M>();
                var models2 = new List<FlatDateOnlydate0M>();
                await ((IDateOnlySingleTypedate)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models1[i],_testData[i], false);
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
FROM public.dateonlydate0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateOnlydate0M>();
                var models2 = new List<FlatDateOnlydate0M>();
                ((IDateOnlySingleTypedate)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models1[i],_testData[i], false);
                    FlatDateOnlydate0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDateOnlydate0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
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
FROM public.dateonlydate0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDateOnlySingleTypedate)this).DynQuerySelectModelAsync(connection,  query, 0);
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
FROM public.dateonlydate0m m
WHERE 
    m.id > $1
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

[Gedaq.Npgsql.Attributes.Query(
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
FROM public.dateonlydate0m m
LEFT JOIN public.dateonlydate0mi mi ON mi.id = m.dateonlydate0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DateOnlydate0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateOnlySingleTypedate)this).SelectModelAsync(connection, 0);
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
FROM public.dateonlydate0m m
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
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
FROM public.dateonlydate0m m
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
FROM public.dateonlydate0m m
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatDateOnlydate0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDateOnlydate0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
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
FROM public.dateonlydate0m m
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
FROM public.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydate0M>();
                var firstItems2 = new List<FlatDateOnlydate0M>();
                var secondItems1 = new List<FlatDateOnlydate0M>();
                await ((IDateOnlySingleTypedate)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDateOnlydate0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatDateOnlydate0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[9],_testData[34], false);
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
FROM public.dateonlydate0m m
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
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
FROM public.dateonlydate0m m
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
FROM public.dateonlydate0m m
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatDateOnlydate0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[10],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
FROM public.dateonlydate0m m
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
FROM public.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydate0M>();
                var firstItems2 = new List<FlatDateOnlydate0M>();
                var secondItems1 = new List<FlatDateOnlydate0M>();
                 ((IDateOnlySingleTypedate)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatDateOnlydate0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[27],_testData[34], false);
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
FROM public.dateonlydate0m m
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.dateonlydate0m m
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
FROM public.dateonlydate0m m
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDateOnlydate0M.AssertModel(models[0],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(models[1],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(models[2],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(models[3],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(models[4],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(models[5],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(models[6],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(models[7],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(models[8],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(models[9],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(models[10],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(models[11],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(models[12],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(models[13],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(models[14],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(models[15],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(models[16],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(models[17],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(models[18],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(models[19],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(models[20],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.dateonlydate0m m
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
FROM public.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydate0M>();
                var secondItems1 = new List<FlatDateOnlydate0M>();
                var secondItems2 = new List<FlatDateOnlydate0M>();
                await ((IDateOnlySingleTypedate)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatDateOnlydate0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatDateOnlydate0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.dateonlydate0m m
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.dateonlydate0m m
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
FROM public.dateonlydate0m m
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
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDateOnlydate0M.AssertModel(models[0],_testData[9], false);
                        FlatDateOnlydate0M.AssertModel(models[1],_testData[10], false);
                        FlatDateOnlydate0M.AssertModel(models[2],_testData[11], false);
                        FlatDateOnlydate0M.AssertModel(models[3],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(models[4],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(models[5],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(models[6],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(models[7],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(models[8],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(models[9],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(models[10],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(models[11],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(models[12],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(models[13],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(models[14],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(models[15],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(models[16],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(models[17],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(models[18],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(models[19],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(models[20],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(models[21],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(models[22],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(models[23],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(models[24],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatDateOnlydate0M.AssertModel(models[0],_testData[7], false);
                        FlatDateOnlydate0M.AssertModel(models[1],_testData[8], false);
                        FlatDateOnlydate0M.AssertModel(models[2],_testData[9], false);
                        FlatDateOnlydate0M.AssertModel(models[3],_testData[10], false);
                        FlatDateOnlydate0M.AssertModel(models[4],_testData[11], false);
                        FlatDateOnlydate0M.AssertModel(models[5],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(models[6],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(models[7],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(models[8],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(models[9],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(models[10],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(models[11],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(models[12],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(models[13],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(models[14],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(models[15],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(models[16],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(models[17],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(models[18],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(models[19],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(models[20],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(models[21],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(models[22],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(models[23],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(models[24],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(models[25],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(models[26],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 56;
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
FROM public.dateonlydate0m m
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
FROM public.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydate0M>();
                var secondItems1 = new List<FlatDateOnlydate0M>();
                var secondItems2 = new List<FlatDateOnlydate0M>();
                 ((IDateOnlySingleTypedate)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatDateOnlydate0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatDateOnlydate0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.dateonlydate0m m
LEFT JOIN public.dateonlydate0mi mi ON mi.id = m.dateonlydate0mi_id
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateOnlySingleTypedate)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        DateOnlydate0M.AssertModel(models[0],_testData[14], false);
                        DateOnlydate0M.AssertModel(models[1],_testData[15], false);
                        DateOnlydate0M.AssertModel(models[2],_testData[16], false);
                        DateOnlydate0M.AssertModel(models[3],_testData[17], false);
                        DateOnlydate0M.AssertModel(models[4],_testData[18], false);
                        DateOnlydate0M.AssertModel(models[5],_testData[19], false);
                        DateOnlydate0M.AssertModel(models[6],_testData[20], false);
                        DateOnlydate0M.AssertModel(models[7],_testData[21], false);
                        DateOnlydate0M.AssertModel(models[8],_testData[22], false);
                        DateOnlydate0M.AssertModel(models[9],_testData[23], false);
                        DateOnlydate0M.AssertModel(models[10],_testData[24], false);
                        DateOnlydate0M.AssertModel(models[11],_testData[25], false);
                        DateOnlydate0M.AssertModel(models[12],_testData[26], false);
                        DateOnlydate0M.AssertModel(models[13],_testData[27], false);
                        DateOnlydate0M.AssertModel(models[14],_testData[28], false);
                        DateOnlydate0M.AssertModel(models[15],_testData[29], false);
                        DateOnlydate0M.AssertModel(models[16],_testData[30], false);
                        DateOnlydate0M.AssertModel(models[17],_testData[31], false);
                        DateOnlydate0M.AssertModel(models[18],_testData[32], false);
                        DateOnlydate0M.AssertModel(models[19],_testData[33], false);
                        DateOnlydate0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        DateOnlydate0M.AssertModel(models[0],_testData[12], false);
                        DateOnlydate0M.AssertModel(models[1],_testData[13], false);
                        DateOnlydate0M.AssertModel(models[2],_testData[14], false);
                        DateOnlydate0M.AssertModel(models[3],_testData[15], false);
                        DateOnlydate0M.AssertModel(models[4],_testData[16], false);
                        DateOnlydate0M.AssertModel(models[5],_testData[17], false);
                        DateOnlydate0M.AssertModel(models[6],_testData[18], false);
                        DateOnlydate0M.AssertModel(models[7],_testData[19], false);
                        DateOnlydate0M.AssertModel(models[8],_testData[20], false);
                        DateOnlydate0M.AssertModel(models[9],_testData[21], false);
                        DateOnlydate0M.AssertModel(models[10],_testData[22], false);
                        DateOnlydate0M.AssertModel(models[11],_testData[23], false);
                        DateOnlydate0M.AssertModel(models[12],_testData[24], false);
                        DateOnlydate0M.AssertModel(models[13],_testData[25], false);
                        DateOnlydate0M.AssertModel(models[14],_testData[26], false);
                        DateOnlydate0M.AssertModel(models[15],_testData[27], false);
                        DateOnlydate0M.AssertModel(models[16],_testData[28], false);
                        DateOnlydate0M.AssertModel(models[17],_testData[29], false);
                        DateOnlydate0M.AssertModel(models[18],_testData[30], false);
                        DateOnlydate0M.AssertModel(models[19],_testData[31], false);
                        DateOnlydate0M.AssertModel(models[20],_testData[32], false);
                        DateOnlydate0M.AssertModel(models[21],_testData[33], false);
                        DateOnlydate0M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateOnlySingleTypedate)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        DateOnlydate0M.AssertModel(models[0],_testData[20], false);
                        DateOnlydate0M.AssertModel(models[1],_testData[21], false);
                        DateOnlydate0M.AssertModel(models[2],_testData[22], false);
                        DateOnlydate0M.AssertModel(models[3],_testData[23], false);
                        DateOnlydate0M.AssertModel(models[4],_testData[24], false);
                        DateOnlydate0M.AssertModel(models[5],_testData[25], false);
                        DateOnlydate0M.AssertModel(models[6],_testData[26], false);
                        DateOnlydate0M.AssertModel(models[7],_testData[27], false);
                        DateOnlydate0M.AssertModel(models[8],_testData[28], false);
                        DateOnlydate0M.AssertModel(models[9],_testData[29], false);
                        DateOnlydate0M.AssertModel(models[10],_testData[30], false);
                        DateOnlydate0M.AssertModel(models[11],_testData[31], false);
                        DateOnlydate0M.AssertModel(models[12],_testData[32], false);
                        DateOnlydate0M.AssertModel(models[13],_testData[33], false);
                        DateOnlydate0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        DateOnlydate0M.AssertModel(models[0],_testData[4], false);
                        DateOnlydate0M.AssertModel(models[1],_testData[5], false);
                        DateOnlydate0M.AssertModel(models[2],_testData[6], false);
                        DateOnlydate0M.AssertModel(models[3],_testData[7], false);
                        DateOnlydate0M.AssertModel(models[4],_testData[8], false);
                        DateOnlydate0M.AssertModel(models[5],_testData[9], false);
                        DateOnlydate0M.AssertModel(models[6],_testData[10], false);
                        DateOnlydate0M.AssertModel(models[7],_testData[11], false);
                        DateOnlydate0M.AssertModel(models[8],_testData[12], false);
                        DateOnlydate0M.AssertModel(models[9],_testData[13], false);
                        DateOnlydate0M.AssertModel(models[10],_testData[14], false);
                        DateOnlydate0M.AssertModel(models[11],_testData[15], false);
                        DateOnlydate0M.AssertModel(models[12],_testData[16], false);
                        DateOnlydate0M.AssertModel(models[13],_testData[17], false);
                        DateOnlydate0M.AssertModel(models[14],_testData[18], false);
                        DateOnlydate0M.AssertModel(models[15],_testData[19], false);
                        DateOnlydate0M.AssertModel(models[16],_testData[20], false);
                        DateOnlydate0M.AssertModel(models[17],_testData[21], false);
                        DateOnlydate0M.AssertModel(models[18],_testData[22], false);
                        DateOnlydate0M.AssertModel(models[19],_testData[23], false);
                        DateOnlydate0M.AssertModel(models[20],_testData[24], false);
                        DateOnlydate0M.AssertModel(models[21],_testData[25], false);
                        DateOnlydate0M.AssertModel(models[22],_testData[26], false);
                        DateOnlydate0M.AssertModel(models[23],_testData[27], false);
                        DateOnlydate0M.AssertModel(models[24],_testData[28], false);
                        DateOnlydate0M.AssertModel(models[25],_testData[29], false);
                        DateOnlydate0M.AssertModel(models[26],_testData[30], false);
                        DateOnlydate0M.AssertModel(models[27],_testData[31], false);
                        DateOnlydate0M.AssertModel(models[28],_testData[32], false);
                        DateOnlydate0M.AssertModel(models[29],_testData[33], false);
                        DateOnlydate0M.AssertModel(models[30],_testData[34], false);
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
            dbType: (System.Data.DbType)(11))]
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
FROM public.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateOnlydate0M>();
                var models2 = new List<FlatDateOnlydate0M>();
                await((IDateOnlySingleTypedate)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models1[i],_testData[i], false);
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
FROM public.dateonlydate0m m
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
FROM public.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydate0M>();
                var firstItems2 = new List<FlatDateOnlydate0M>();
                var secondItems1 = new List<FlatDateOnlydate0M>();
                var secondItems2 = new List<FlatDateOnlydate0M>();
                await ((IDateOnlySingleTypedate)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 56, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDateOnlydate0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDateOnlydate0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.dateonlydate0m m
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
FROM public.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydate0M>();
                var firstItems2 = new List<FlatDateOnlydate0M>();
                var secondItems1 = new List<FlatDateOnlydate0M>();
                await ((IDateOnlySingleTypedate)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 92, query1, 122, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatDateOnlydate0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatDateOnlydate0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM public.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDateOnlydate0M>();
                var models2 = new List<FlatDateOnlydate0M>();
                ((IDateOnlySingleTypedate)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDateOnlydate0M.AssertModel(models1[i],_testData[i], false);
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
FROM public.dateonlydate0m m
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
FROM public.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydate0M>();
                var firstItems2 = new List<FlatDateOnlydate0M>();
                var secondItems1 = new List<FlatDateOnlydate0M>();
                var secondItems2 = new List<FlatDateOnlydate0M>();
                 ((IDateOnlySingleTypedate)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 74, query1, 92, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatDateOnlydate0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.dateonlydate0m m
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
FROM public.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydate0M>();
                var firstItems2 = new List<FlatDateOnlydate0M>();
                var secondItems1 = new List<FlatDateOnlydate0M>();
                 ((IDateOnlySingleTypedate)this).DbConnectionMMDynQuerySelectModelBatch(connection, 119, query1, 108, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatDateOnlydate0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatDateOnlydate0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatDateOnlydate0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[12],_testData[34], false);
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
            dbType: (System.Data.DbType)(11))]
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
FROM public.dateonlydate0m m
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
FROM public.dateonlydate0m m
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
FROM public.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDateOnlySingleTypedate)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 119, query1, 158, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDateOnlydate0M.AssertModel(models[0],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(models[1],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(models[2],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(models[3],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(models[4],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(models[5],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(models[6],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(models[7],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(models[8],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(models[9],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDateOnlydate0M.AssertModel(models[0],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(models[1],_testData[34], false);
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
FROM public.dateonlydate0m m
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
FROM public.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydate0M>();
                var secondItems1 = new List<FlatDateOnlydate0M>();
                var secondItems2 = new List<FlatDateOnlydate0M>();
                await ((IDateOnlySingleTypedate)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 101, query1, 108, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatDateOnlydate0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[13],_testData[34], false);
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
FROM public.dateonlydate0m m
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
FROM public.dateonlydate0m m
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
FROM public.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDateOnlySingleTypedate)this).DbConnectionSTDynQuerySelectModelBatch(connection, 127, query1, 13, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatDateOnlydate0M.AssertModel(models[0],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(models[1],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(models[2],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(models[3],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(models[4],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(models[5],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(models[6],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatDateOnlydate0M.AssertModel(models[0],_testData[3], false);
                        FlatDateOnlydate0M.AssertModel(models[1],_testData[4], false);
                        FlatDateOnlydate0M.AssertModel(models[2],_testData[5], false);
                        FlatDateOnlydate0M.AssertModel(models[3],_testData[6], false);
                        FlatDateOnlydate0M.AssertModel(models[4],_testData[7], false);
                        FlatDateOnlydate0M.AssertModel(models[5],_testData[8], false);
                        FlatDateOnlydate0M.AssertModel(models[6],_testData[9], false);
                        FlatDateOnlydate0M.AssertModel(models[7],_testData[10], false);
                        FlatDateOnlydate0M.AssertModel(models[8],_testData[11], false);
                        FlatDateOnlydate0M.AssertModel(models[9],_testData[12], false);
                        FlatDateOnlydate0M.AssertModel(models[10],_testData[13], false);
                        FlatDateOnlydate0M.AssertModel(models[11],_testData[14], false);
                        FlatDateOnlydate0M.AssertModel(models[12],_testData[15], false);
                        FlatDateOnlydate0M.AssertModel(models[13],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(models[14],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(models[15],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(models[16],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(models[17],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(models[18],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(models[19],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(models[20],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(models[21],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(models[22],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(models[23],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(models[24],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(models[25],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(models[26],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(models[27],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(models[28],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(models[29],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(models[30],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(models[31],_testData[34], false);
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
FROM public.dateonlydate0m m
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
FROM public.dateonlydate0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDateOnlydate0M>();
                var secondItems1 = new List<FlatDateOnlydate0M>();
                var secondItems2 = new List<FlatDateOnlydate0M>();
                 ((IDateOnlySingleTypedate)this).DbConnectionDynQuerySelectModelBatch(connection, 121, query1, 79, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatDateOnlydate0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatDateOnlydate0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatDateOnlydate0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatDateOnlydate0M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.dateonlydate0m m
LEFT JOIN public.dateonlydate0mi mi ON mi.id = m.dateonlydate0mi_id
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
            dbType: (System.Data.DbType)(11))]
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
                foreach(var batchResult in await ((IDateOnlySingleTypedate)this).DbConnectionSTSelectModelBatchAsync(connection, 49, 142))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        DateOnlydate0M.AssertModel(models[0],_testData[10], false);
                        DateOnlydate0M.AssertModel(models[1],_testData[11], false);
                        DateOnlydate0M.AssertModel(models[2],_testData[12], false);
                        DateOnlydate0M.AssertModel(models[3],_testData[13], false);
                        DateOnlydate0M.AssertModel(models[4],_testData[14], false);
                        DateOnlydate0M.AssertModel(models[5],_testData[15], false);
                        DateOnlydate0M.AssertModel(models[6],_testData[16], false);
                        DateOnlydate0M.AssertModel(models[7],_testData[17], false);
                        DateOnlydate0M.AssertModel(models[8],_testData[18], false);
                        DateOnlydate0M.AssertModel(models[9],_testData[19], false);
                        DateOnlydate0M.AssertModel(models[10],_testData[20], false);
                        DateOnlydate0M.AssertModel(models[11],_testData[21], false);
                        DateOnlydate0M.AssertModel(models[12],_testData[22], false);
                        DateOnlydate0M.AssertModel(models[13],_testData[23], false);
                        DateOnlydate0M.AssertModel(models[14],_testData[24], false);
                        DateOnlydate0M.AssertModel(models[15],_testData[25], false);
                        DateOnlydate0M.AssertModel(models[16],_testData[26], false);
                        DateOnlydate0M.AssertModel(models[17],_testData[27], false);
                        DateOnlydate0M.AssertModel(models[18],_testData[28], false);
                        DateOnlydate0M.AssertModel(models[19],_testData[29], false);
                        DateOnlydate0M.AssertModel(models[20],_testData[30], false);
                        DateOnlydate0M.AssertModel(models[21],_testData[31], false);
                        DateOnlydate0M.AssertModel(models[22],_testData[32], false);
                        DateOnlydate0M.AssertModel(models[23],_testData[33], false);
                        DateOnlydate0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        DateOnlydate0M.AssertModel(models[0],_testData[30], false);
                        DateOnlydate0M.AssertModel(models[1],_testData[31], false);
                        DateOnlydate0M.AssertModel(models[2],_testData[32], false);
                        DateOnlydate0M.AssertModel(models[3],_testData[33], false);
                        DateOnlydate0M.AssertModel(models[4],_testData[34], false);
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
                foreach(var batchResult in  ((IDateOnlySingleTypedate)this).DbConnectionSTSelectModelBatch(connection, 88, 134))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        DateOnlydate0M.AssertModel(models[0],_testData[29], false);
                        DateOnlydate0M.AssertModel(models[1],_testData[30], false);
                        DateOnlydate0M.AssertModel(models[2],_testData[31], false);
                        DateOnlydate0M.AssertModel(models[3],_testData[32], false);
                        DateOnlydate0M.AssertModel(models[4],_testData[33], false);
                        DateOnlydate0M.AssertModel(models[5],_testData[34], false);
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
                ((IDateOnlySingleTypedate)this).SetDbConnectionSelectModelParametrs(cmd, 92);
                var models = await ((IDateOnlySingleTypedate)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

                DateOnlydate0M.AssertModel(models[0],_testData[19], false);
                DateOnlydate0M.AssertModel(models[1],_testData[20], false);
                DateOnlydate0M.AssertModel(models[2],_testData[21], false);
                DateOnlydate0M.AssertModel(models[3],_testData[22], false);
                DateOnlydate0M.AssertModel(models[4],_testData[23], false);
                DateOnlydate0M.AssertModel(models[5],_testData[24], false);
                DateOnlydate0M.AssertModel(models[6],_testData[25], false);
                DateOnlydate0M.AssertModel(models[7],_testData[26], false);
                DateOnlydate0M.AssertModel(models[8],_testData[27], false);
                DateOnlydate0M.AssertModel(models[9],_testData[28], false);
                DateOnlydate0M.AssertModel(models[10],_testData[29], false);
                DateOnlydate0M.AssertModel(models[11],_testData[30], false);
                DateOnlydate0M.AssertModel(models[12],_testData[31], false);
                DateOnlydate0M.AssertModel(models[13],_testData[32], false);
                DateOnlydate0M.AssertModel(models[14],_testData[33], false);
                DateOnlydate0M.AssertModel(models[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateOnlySingleTypedate)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateOnlySingleTypedate)this).SetDbConnectionSelectModelParametrs(cmd, 150);
                var models =  ((IDateOnlySingleTypedate)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                DateOnlydate0M.AssertModel(models[0],_testData[31], false);
                DateOnlydate0M.AssertModel(models[1],_testData[32], false);
                DateOnlydate0M.AssertModel(models[2],_testData[33], false);
                DateOnlydate0M.AssertModel(models[3],_testData[34], false);
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
FROM public.dateonlydate0m m
LEFT JOIN public.dateonlydate0mi mi ON mi.id = m.dateonlydate0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1998, month: 10, day: 14))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1929, month: 10, day: 1))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1936, month: 10, day: 7))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 1944, month: 10, day: 6))));//InnerModel.Value

                Assert.That((System.DateOnly?)model[4], Is.EqualTo((new DateOnly(year: 1947, month: 10, day: 3))));//InnerModel.NullableValue

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1988, month: 10, day: 10))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1996, month: 10, day: 4))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1917, month: 10, day: 12))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 1947, month: 10, day: 9))));//InnerModel.Value

                Assert.That((System.DateOnly?)model[4], Is.EqualTo((new DateOnly(year: 1994, month: 10, day: 17))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1988, month: 10, day: 10))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1918, month: 10, day: 16))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 2001, month: 10, day: 2))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 1966, month: 10, day: 3))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1956, month: 10, day: 13))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 2012, month: 10, day: 15))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 1974, month: 10, day: 8))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1991, month: 10, day: 14))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1976, month: 10, day: 9))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1960, month: 10, day: 11))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1972, month: 10, day: 4))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 1940, month: 10, day: 1))));//InnerModel.Value

                Assert.That((System.DateOnly?)model[4], Is.EqualTo((new DateOnly(year: 1991, month: 10, day: 7))));//InnerModel.NullableValue

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1919, month: 10, day: 8))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1948, month: 10, day: 10))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1985, month: 10, day: 13))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 1989, month: 10, day: 5))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1996, month: 10, day: 18))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1972, month: 10, day: 15))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 1934, month: 10, day: 18))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1982, month: 10, day: 16))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1949, month: 10, day: 1))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 1985, month: 10, day: 13))));//InnerModel.Value

                Assert.That((System.DateOnly?)model[4], Is.EqualTo((new DateOnly(year: 2000, month: 10, day: 2))));//InnerModel.NullableValue

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1972, month: 10, day: 3))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1944, month: 10, day: 5))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1921, month: 10, day: 1))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 1918, month: 10, day: 8))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1964, month: 10, day: 15))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1998, month: 10, day: 5))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1922, month: 10, day: 18))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1991, month: 10, day: 9))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 1947, month: 10, day: 9))));//InnerModel.Value

                Assert.That((System.DateOnly?)model[4], Is.EqualTo((new DateOnly(year: 1983, month: 10, day: 5))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1986, month: 10, day: 15))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1920, month: 10, day: 10))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1933, month: 10, day: 10))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 1970, month: 10, day: 5))));//InnerModel.Value

                Assert.That((System.DateOnly?)model[4], Is.EqualTo((new DateOnly(year: 1973, month: 10, day: 17))));//InnerModel.NullableValue

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1923, month: 10, day: 13))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 2012, month: 10, day: 2))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1929, month: 10, day: 5))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 2013, month: 10, day: 19))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1950, month: 10, day: 15))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1970, month: 10, day: 14))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1923, month: 10, day: 13))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 1973, month: 10, day: 11))));//InnerModel.Value

                Assert.That((System.DateOnly?)model[4], Is.EqualTo((new DateOnly(year: 1924, month: 10, day: 11))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 2019, month: 10, day: 14))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1943, month: 10, day: 3))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1980, month: 10, day: 6))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 1968, month: 10, day: 16))));//InnerModel.Value

                Assert.That((System.DateOnly?)model[4], Is.EqualTo((new DateOnly(year: 1945, month: 10, day: 7))));//InnerModel.NullableValue

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1937, month: 10, day: 11))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1968, month: 10, day: 5))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1947, month: 10, day: 15))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1953, month: 10, day: 10))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 1997, month: 10, day: 3))));//InnerModel.Value

                Assert.That((System.DateOnly?)model[4], Is.EqualTo((new DateOnly(year: 2006, month: 10, day: 1))));//InnerModel.NullableValue

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 2017, month: 10, day: 13))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1962, month: 10, day: 16))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1924, month: 10, day: 9))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 1993, month: 10, day: 14))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1919, month: 10, day: 6))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1985, month: 10, day: 12))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 2008, month: 10, day: 19))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((93)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 1946, month: 10, day: 12))));//InnerModel.Value

                Assert.That((System.DateOnly?)model[4], Is.EqualTo((new DateOnly(year: 1972, month: 10, day: 1))));//InnerModel.NullableValue

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1918, month: 10, day: 16))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1939, month: 10, day: 2))));//Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1998, month: 10, day: 14))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1929, month: 10, day: 1))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1936, month: 10, day: 7))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 1944, month: 10, day: 6))));//InnerModel.Value

                Assert.That((System.DateOnly?)model[4], Is.EqualTo((new DateOnly(year: 1947, month: 10, day: 3))));//InnerModel.NullableValue

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1988, month: 10, day: 10))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1996, month: 10, day: 4))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1917, month: 10, day: 12))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 1947, month: 10, day: 9))));//InnerModel.Value

                Assert.That((System.DateOnly?)model[4], Is.EqualTo((new DateOnly(year: 1994, month: 10, day: 17))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1988, month: 10, day: 10))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1918, month: 10, day: 16))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 2001, month: 10, day: 2))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 1966, month: 10, day: 3))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1956, month: 10, day: 13))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 2012, month: 10, day: 15))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 1974, month: 10, day: 8))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1991, month: 10, day: 14))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1976, month: 10, day: 9))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1960, month: 10, day: 11))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1972, month: 10, day: 4))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 1940, month: 10, day: 1))));//InnerModel.Value

                Assert.That((System.DateOnly?)model[4], Is.EqualTo((new DateOnly(year: 1991, month: 10, day: 7))));//InnerModel.NullableValue

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1919, month: 10, day: 8))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1948, month: 10, day: 10))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1985, month: 10, day: 13))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 1989, month: 10, day: 5))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1996, month: 10, day: 18))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1972, month: 10, day: 15))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 1934, month: 10, day: 18))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1982, month: 10, day: 16))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1949, month: 10, day: 1))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 1985, month: 10, day: 13))));//InnerModel.Value

                Assert.That((System.DateOnly?)model[4], Is.EqualTo((new DateOnly(year: 2000, month: 10, day: 2))));//InnerModel.NullableValue

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1972, month: 10, day: 3))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1944, month: 10, day: 5))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1921, month: 10, day: 1))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 1918, month: 10, day: 8))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1964, month: 10, day: 15))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1998, month: 10, day: 5))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1922, month: 10, day: 18))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1991, month: 10, day: 9))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 1947, month: 10, day: 9))));//InnerModel.Value

                Assert.That((System.DateOnly?)model[4], Is.EqualTo((new DateOnly(year: 1983, month: 10, day: 5))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1986, month: 10, day: 15))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1920, month: 10, day: 10))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1933, month: 10, day: 10))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 1970, month: 10, day: 5))));//InnerModel.Value

                Assert.That((System.DateOnly?)model[4], Is.EqualTo((new DateOnly(year: 1973, month: 10, day: 17))));//InnerModel.NullableValue

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1923, month: 10, day: 13))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 2012, month: 10, day: 2))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1929, month: 10, day: 5))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 2013, month: 10, day: 19))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1950, month: 10, day: 15))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1970, month: 10, day: 14))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1923, month: 10, day: 13))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 1973, month: 10, day: 11))));//InnerModel.Value

                Assert.That((System.DateOnly?)model[4], Is.EqualTo((new DateOnly(year: 1924, month: 10, day: 11))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 2019, month: 10, day: 14))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1943, month: 10, day: 3))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1980, month: 10, day: 6))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 1968, month: 10, day: 16))));//InnerModel.Value

                Assert.That((System.DateOnly?)model[4], Is.EqualTo((new DateOnly(year: 1945, month: 10, day: 7))));//InnerModel.NullableValue

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1937, month: 10, day: 11))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1968, month: 10, day: 5))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1947, month: 10, day: 15))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1953, month: 10, day: 10))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 1997, month: 10, day: 3))));//InnerModel.Value

                Assert.That((System.DateOnly?)model[4], Is.EqualTo((new DateOnly(year: 2006, month: 10, day: 1))));//InnerModel.NullableValue

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 2017, month: 10, day: 13))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1962, month: 10, day: 16))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1924, month: 10, day: 9))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 1993, month: 10, day: 14))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1919, month: 10, day: 6))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1985, month: 10, day: 12))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 2008, month: 10, day: 19))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((93)));//InnerModel.Id
                Assert.That((System.DateOnly)model[3], Is.EqualTo((new DateOnly(year: 1946, month: 10, day: 12))));//InnerModel.Value

                Assert.That((System.DateOnly?)model[4], Is.EqualTo((new DateOnly(year: 1972, month: 10, day: 1))));//InnerModel.NullableValue

                Assert.That((System.DateOnly?)model[5], Is.EqualTo((new DateOnly(year: 1918, month: 10, day: 16))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.DateOnly)model[1], Is.EqualTo((new DateOnly(year: 1939, month: 10, day: 2))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_dateonlydate0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DateOnlydate0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(DateOnlydate0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(7),
                (NpgsqlTypes.NpgsqlDbType)(7)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateOnlydate0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateOnlydate0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDateOnlySingleTypedate)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_dateonlydate0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDateOnlySingleTypedate)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateOnlydate0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryWAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<DateOnlydate0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateOnlydate0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDateOnlySingleTypedate)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_dateonlydate0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDateOnlySingleTypedate)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateOnlydate0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_dateonlydate0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DateOnlydate0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DateOnlydate0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateOnlydate0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateOnlydate0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDateOnlySingleTypedate)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_dateonlydate0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDateOnlySingleTypedate)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateOnlydate0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<DateOnlydate0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateOnlydate0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDateOnlySingleTypedate)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_dateonlydate0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDateOnlySingleTypedate)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateOnlydate0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_dateonlydate0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DateOnlydate0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_dateonlydate0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(DateOnlydate0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(7),
                (NpgsqlTypes.NpgsqlDbType)(7)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateOnlydate0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDateOnlySingleTypedate)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDateOnlySingleTypedate)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateOnlydate0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<DateOnlydate0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDateOnlySingleTypedate)this).WAImportModelInner(connection, importCollection);
                var models = ((IDateOnlySingleTypedate)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateOnlydate0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_dateonlydate0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DateOnlydate0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_dateonlydate0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DateOnlydate0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateOnlydate0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateOnlydate0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDateOnlySingleTypedate)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDateOnlySingleTypedate)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateOnlydate0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<DateOnlydate0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DateOnlydate0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDateOnlySingleTypedate)this).ImportModelInner(connection, importCollection);
                var models = ((IDateOnlySingleTypedate)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DateOnlydate0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_dateonlydate0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
dateonlydate0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DateOnlydate0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(7),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(7)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate))]
        private void ImportModelConfig()
        {
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
FROM public.binary_dateonlydate0m m
LEFT JOIN public.binary_dateonlydate0mi mi ON mi.id = m.dateonlydate0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DateOnlydate0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DateOnlydate0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDateOnlySingleTypedate)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDateOnlySingleTypedate)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DateOnlydate0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(10)]
        public  void ImportModelTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<DateOnlydate0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDateOnlySingleTypedate)this).ImportModel(connection, importCollection);
                var models = ((IDateOnlySingleTypedate)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DateOnlydate0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_dateonlydate0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    dateonlydate0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DateOnlydate0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(7),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(7)
            })]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDateOnlySingleTypedate)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DateOnlydate0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateOnlySingleTypedate)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DateOnlydate0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(DateOnlydate0MIWA), typeof(DateOnlydate0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(7),
                (NpgsqlTypes.NpgsqlDbType)(7)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(7),
                (NpgsqlTypes.NpgsqlDbType)(7)
            })]
        private void MMDynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<DateOnlydate0MIWA>();
                var models2 = new List<DateOnlydate0MIWA>();
                await ((IDateOnlySingleTypedate)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_dateonlydate0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateOnlydate0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateOnlydate0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<DateOnlydate0MIWA>();
                var models2 = new List<DateOnlydate0MIWA>();
                ((IDateOnlySingleTypedate)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_dateonlydate0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateOnlydate0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateOnlydate0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(DateOnlydate0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(7),
                (NpgsqlTypes.NpgsqlDbType)(7)
            })]
        private void DynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IDateOnlySingleTypedate)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_dateonlydate0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateOnlydate0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IDateOnlySingleTypedate)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_dateonlydate0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateOnlydate0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(DateOnlydate0MIWA), typeof(DateOnlydate0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate))]
        private void MMDynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<DateOnlydate0MIWA>();
                var models2 = new List<DateOnlydate0MIWA>();
                await ((IDateOnlySingleTypedate)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_dateonlydate0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateOnlydate0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateOnlydate0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<DateOnlydate0MIWA>();
                var models2 = new List<DateOnlydate0MIWA>();
                ((IDateOnlySingleTypedate)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_dateonlydate0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateOnlydate0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateOnlydate0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DateOnlydate0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IDateOnlySingleTypedate)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_dateonlydate0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateOnlydate0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IDateOnlySingleTypedate)this).DynQueryExportModelInner(connection, @"
COPY public.binary_dateonlydate0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateOnlydate0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_dateonlydate0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(DateOnlydate0MI), typeof(DateOnlydate0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(7),
                (NpgsqlTypes.NpgsqlDbType)(7)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(7),
                (NpgsqlTypes.NpgsqlDbType)(7)
            })]
        private void MMWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<DateOnlydate0MI>();
                var models2 = new List<DateOnlydate0MI>();
                await ((IDateOnlySingleTypedate)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateOnlydate0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateOnlydate0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<DateOnlydate0MI>();
                var models2 = new List<DateOnlydate0MI>();
                ((IDateOnlySingleTypedate)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateOnlydate0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateOnlydate0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_dateonlydate0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(DateOnlydate0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(7),
                (NpgsqlTypes.NpgsqlDbType)(7)
            })]
        private void WAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task WAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IDateOnlySingleTypedate)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateOnlydate0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void WAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IDateOnlySingleTypedate)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateOnlydate0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_dateonlydate0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(DateOnlydate0MIWA), typeof(DateOnlydate0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate))]
        private void MMExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<DateOnlydate0MIWA>();
                var models2 = new List<DateOnlydate0MIWA>();
                await ((IDateOnlySingleTypedate)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateOnlydate0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateOnlydate0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<DateOnlydate0MIWA>();
                var models2 = new List<DateOnlydate0MIWA>();
                ((IDateOnlySingleTypedate)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DateOnlydate0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DateOnlydate0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_dateonlydate0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DateOnlydate0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlySingleTypedate))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IDateOnlySingleTypedate)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateOnlydate0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IDateOnlySingleTypedate)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DateOnlydate0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

