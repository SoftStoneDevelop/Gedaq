

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
    internal partial interface INpgsqlIntervalSingleTypeinterval
    {
    }
    
    internal partial class NpgsqlIntervalSingleTypeinterval : INpgsqlIntervalSingleTypeinterval
    {


#region TestData

        private readonly NpgsqlIntervalintervalE0M[] _testData = new NpgsqlIntervalintervalE0M[]
        {
            new NpgsqlIntervalintervalE0M
{
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3549),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalE0M
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4849),
    ModelInner = new NpgsqlIntervalintervalE0MI
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 135),
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1741),
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalE0M
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 316),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalE0M
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1449),
    ModelInner = new NpgsqlIntervalintervalE0MI
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1668),
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3445),
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalE0M
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 848),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4056),
},
            new NpgsqlIntervalintervalE0M
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4962),
    ModelInner = new NpgsqlIntervalintervalE0MI
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4639),
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2829),
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalE0M
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4386),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalE0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2596),
    ModelInner = new NpgsqlIntervalintervalE0MI
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2927),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 651),
},
            new NpgsqlIntervalintervalE0M
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2320),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalE0M
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4203),
    ModelInner = new NpgsqlIntervalintervalE0MI
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4749),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalE0M
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3706),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4819),
},
            new NpgsqlIntervalintervalE0M
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3182),
    ModelInner = new NpgsqlIntervalintervalE0MI
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1405),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2070),
},
            new NpgsqlIntervalintervalE0M
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 884),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalE0M
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2789),
    ModelInner = new NpgsqlIntervalintervalE0MI
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3904),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalE0M
{
    Id = 89,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3521),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4369),
},
            new NpgsqlIntervalintervalE0M
{
    Id = 94,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3209),
    ModelInner = new NpgsqlIntervalintervalE0MI
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1646),
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3945),
},
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3352),
},
            new NpgsqlIntervalintervalE0M
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4063),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2006),
},
            new NpgsqlIntervalintervalE0M
{
    Id = 103,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 957),
    ModelInner = new NpgsqlIntervalintervalE0MI
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2187),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4378),
},
            new NpgsqlIntervalintervalE0M
{
    Id = 111,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 338),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalE0M
{
    Id = 120,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1877),
    ModelInner = new NpgsqlIntervalintervalE0MI
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3037),
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4917),
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalE0M
{
    Id = 127,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1516),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3428),
},
            new NpgsqlIntervalintervalE0M
{
    Id = 129,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4562),
    ModelInner = new NpgsqlIntervalintervalE0MI
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2515),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalE0M
{
    Id = 136,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1275),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalE0M
{
    Id = 145,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 369),
    ModelInner = new NpgsqlIntervalintervalE0MI
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4999),
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 334),
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalE0M
{
    Id = 147,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3347),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4044),
},
            new NpgsqlIntervalintervalE0M
{
    Id = 150,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 940),
    ModelInner = new NpgsqlIntervalintervalE0MI
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2693),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3490),
},
            new NpgsqlIntervalintervalE0M
{
    Id = 151,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1681),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 817),
},
            new NpgsqlIntervalintervalE0M
{
    Id = 156,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3244),
    ModelInner = new NpgsqlIntervalintervalE0MI
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 222),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4100),
},
            new NpgsqlIntervalintervalE0M
{
    Id = 161,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3163),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalE0M
{
    Id = 167,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4728),
    ModelInner = new NpgsqlIntervalintervalE0MI
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2495),
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1075),
},
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3919),
},
            new NpgsqlIntervalintervalE0M
{
    Id = 176,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2137),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalE0M
{
    Id = 179,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2213),
    ModelInner = new NpgsqlIntervalintervalE0MI
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1656),
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 645),
},
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4336),
},
            new NpgsqlIntervalintervalE0M
{
    Id = 184,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2591),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalE0M
{
    Id = 192,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1845),
    ModelInner = new NpgsqlIntervalintervalE0MI
{
    Id = 91,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 775),
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4703),
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalE0M
{
    Id = 197,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4689),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervale0mi(
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
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(30)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(30))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervale0mi(
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
            queryMapTypes: [typeof(NpgsqlIntervalintervalE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(30)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(30))]
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

                changedRows =  ((INpgsqlIntervalSingleTypeinterval)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlIntervalSingleTypeinterval)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlIntervalSingleTypeinterval)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlIntervalSingleTypeinterval)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlIntervalSingleTypeinterval)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlIntervalSingleTypeinterval)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervale0mi(
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
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13), 
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

                changedRows =  ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervale0m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervale0mi_id
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
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(30)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(30)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlintervalintervale0mi_id", 
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
                changedRows =  ((INpgsqlIntervalSingleTypeinterval)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlIntervalSingleTypeinterval)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervale0m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervale0mi_id
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
    npgsqlintervalintervale0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlIntervalintervalE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervale0m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervale0mi_id
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
    npgsqlintervalintervale0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlIntervalintervalE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(30)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(30)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlintervalintervale0mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlIntervalintervalE0M> models = null;

                models =  ((INpgsqlIntervalSingleTypeinterval)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalE0M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlIntervalSingleTypeinterval)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalE0M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlIntervalSingleTypeinterval)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalE0M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlIntervalSingleTypeinterval)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalE0M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlIntervalintervalE0M> models = null;

                models = await ((INpgsqlIntervalSingleTypeinterval)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalE0M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlIntervalSingleTypeinterval)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalE0M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlIntervalSingleTypeinterval)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalE0M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlIntervalSingleTypeinterval)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalE0M.AssertModel(models[0],_testData[11], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervale0m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervale0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlintervalintervale0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlInterval), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlintervalintervale0mi_id", 
                methodParametrName: "npgsqlintervalintervale0mi_id", 
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

                changedRows =  ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModel(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModel(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
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

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalE0M), typeof(FlatNpgsqlIntervalintervalE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)),
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
FROM public.npgsqlintervalintervale0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlIntervalintervalE0M>();
                var models2 = new List<FlatNpgsqlIntervalintervalE0M>();
                await ((INpgsqlIntervalSingleTypeinterval)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalintervale0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlIntervalintervalE0M>();
                var models2 = new List<FlatNpgsqlIntervalintervalE0M>();
                ((INpgsqlIntervalSingleTypeinterval)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)),
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
FROM public.npgsqlintervalintervale0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlIntervalSingleTypeinterval)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervale0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlIntervalSingleTypeinterval)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervale0m m
LEFT JOIN public.npgsqlintervalintervale0mi mi ON mi.id = m.npgsqlintervalintervale0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlIntervalintervalE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)),
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
                var models = await ((INpgsqlIntervalSingleTypeinterval)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlIntervalSingleTypeinterval)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalE0M), typeof(FlatNpgsqlIntervalintervalE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)),
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
FROM public.npgsqlintervalintervale0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalE0M>();
                var models2 = new List<FlatNpgsqlIntervalintervalE0M>();
                await ((INpgsqlIntervalSingleTypeinterval)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalintervale0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalE0M>();
                var models2 = new List<FlatNpgsqlIntervalintervalE0M>();
                ((INpgsqlIntervalSingleTypeinterval)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)),
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
FROM public.npgsqlintervalintervale0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlIntervalSingleTypeinterval)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervale0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlIntervalSingleTypeinterval)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervale0m m
LEFT JOIN public.npgsqlintervalintervale0mi mi ON mi.id = m.npgsqlintervalintervale0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)),
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
                var models = await ((INpgsqlIntervalSingleTypeinterval)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlIntervalSingleTypeinterval)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalE0M), typeof(FlatNpgsqlIntervalintervalE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)),
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
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)),
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
FROM public.npgsqlintervalintervale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlIntervalintervalE0M>();
                var models2 = new List<FlatNpgsqlIntervalintervalE0M>();
                await((INpgsqlIntervalSingleTypeinterval)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 184;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 156;
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
FROM public.npgsqlintervalintervale0m m
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
FROM public.npgsqlintervalintervale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalE0M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalE0M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalE0M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalE0M>();
                await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
FROM public.npgsqlintervalintervale0m m
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
FROM public.npgsqlintervalintervale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalE0M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalE0M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalE0M>();
                await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[16],_testData[34], false);
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
FROM public.npgsqlintervalintervale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlIntervalintervalE0M>();
                var models2 = new List<FlatNpgsqlIntervalintervalE0M>();
                ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 176;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 184;
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
FROM public.npgsqlintervalintervale0m m
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
FROM public.npgsqlintervalintervale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalE0M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalE0M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalE0M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalE0M>();
                 ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
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
FROM public.npgsqlintervalintervale0m m
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
FROM public.npgsqlintervalintervale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalE0M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalE0M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalE0M>();
                 ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[32],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)),
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
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)),
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
FROM public.npgsqlintervalintervale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlIntervalSingleTypeinterval)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 167;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 167;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervale0m m
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
FROM public.npgsqlintervalintervale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervale0m m
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
FROM public.npgsqlintervalintervale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalE0M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalE0M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalE0M>();
                await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlintervalintervale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervale0m m
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
FROM public.npgsqlintervalintervale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 167;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervale0m m
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
FROM public.npgsqlintervalintervale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalE0M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalE0M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalE0M>();
                 ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlintervalintervale0m m
LEFT JOIN public.npgsqlintervalintervale0mi mi ON mi.id = m.npgsqlintervalintervale0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlIntervalintervalE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)),
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
                var models = await((INpgsqlIntervalSingleTypeinterval)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 176;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 184;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlIntervalintervalE0M.AssertModel(models[0],_testData[31], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[1],_testData[32], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[2],_testData[33], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlIntervalintervalE0M.AssertModel(models[0],_testData[33], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[1],_testData[34], false);
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
                var models = ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlIntervalintervalE0M.AssertModel(models[0],_testData[1], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[1],_testData[2], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[2],_testData[3], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[3],_testData[4], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[4],_testData[5], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[5],_testData[6], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[6],_testData[7], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[7],_testData[8], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[8],_testData[9], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[9],_testData[10], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[10],_testData[11], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[11],_testData[12], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[12],_testData[13], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[13],_testData[14], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[14],_testData[15], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[15],_testData[16], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[16],_testData[17], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[17],_testData[18], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[18],_testData[19], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[19],_testData[20], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[20],_testData[21], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[21],_testData[22], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[22],_testData[23], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[23],_testData[24], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[24],_testData[25], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[25],_testData[26], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[26],_testData[27], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[27],_testData[28], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[28],_testData[29], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[29],_testData[30], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[30],_testData[31], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[31],_testData[32], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[32],_testData[33], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlIntervalintervalE0M.AssertModel(models[0],_testData[4], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[1],_testData[5], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[2],_testData[6], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[3],_testData[7], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[4],_testData[8], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[5],_testData[9], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[6],_testData[10], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[7],_testData[11], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[8],_testData[12], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[9],_testData[13], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[10],_testData[14], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[11],_testData[15], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[12],_testData[16], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[13],_testData[17], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[14],_testData[18], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[15],_testData[19], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[16],_testData[20], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[17],_testData[21], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[18],_testData[22], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[19],_testData[23], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[20],_testData[24], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[21],_testData[25], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[22],_testData[26], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[23],_testData[27], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[24],_testData[28], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[25],_testData[29], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[26],_testData[30], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[27],_testData[31], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[28],_testData[32], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[29],_testData[33], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalE0M), typeof(FlatNpgsqlIntervalintervalE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)),
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
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)),
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
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)),
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
FROM public.npgsqlintervalintervale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalE0M>();
                var models2 = new List<FlatNpgsqlIntervalintervalE0M>();
                await((INpgsqlIntervalSingleTypeinterval)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalintervale0m m
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
FROM public.npgsqlintervalintervale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalE0M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalE0M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalE0M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalE0M>();
                await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 184, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlintervalintervale0m m
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
FROM public.npgsqlintervalintervale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalE0M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalE0M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalE0M>();
                await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 179, query1, 176, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[3],_testData[34], false);
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
FROM public.npgsqlintervalintervale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalE0M>();
                var models2 = new List<FlatNpgsqlIntervalintervalE0M>();
                ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalintervale0m m
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
FROM public.npgsqlintervalintervale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalE0M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalE0M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalE0M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalE0M>();
                 ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 60, query1, 167, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlintervalintervale0m m
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
FROM public.npgsqlintervalintervale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalE0M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalE0M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalE0M>();
                 ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionMMDynQuerySelectModelBatch(connection, 60, query1, 69, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)),
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
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)),
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
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)),
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
FROM public.npgsqlintervalintervale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlIntervalSingleTypeinterval)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervale0m m
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
FROM public.npgsqlintervalintervale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 94, query1, 111, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[15],_testData[34], false);
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
FROM public.npgsqlintervalintervale0m m
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
FROM public.npgsqlintervalintervale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalE0M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalE0M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalE0M>();
                await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 40, query1, 136, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.npgsqlintervalintervale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervale0m m
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
FROM public.npgsqlintervalintervale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionSTDynQuerySelectModelBatch(connection, 156, query1, 127, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(models[13],_testData[34], false);
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
FROM public.npgsqlintervalintervale0m m
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
FROM public.npgsqlintervalintervale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalE0M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalE0M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalE0M>();
                 ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionDynQuerySelectModelBatch(connection, 25, query1, 111, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlIntervalintervalE0M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqlintervalintervale0m m
LEFT JOIN public.npgsqlintervalintervale0mi mi ON mi.id = m.npgsqlintervalintervale0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)),
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
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)),
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
                var models = await((INpgsqlIntervalSingleTypeinterval)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionSTSelectModelBatchAsync(connection, 129, 156))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlIntervalintervalE0M.AssertModel(models[0],_testData[22], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[1],_testData[23], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[2],_testData[24], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[3],_testData[25], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[4],_testData[26], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[5],_testData[27], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[6],_testData[28], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[7],_testData[29], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[8],_testData[30], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[9],_testData[31], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[10],_testData[32], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[11],_testData[33], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlIntervalintervalE0M.AssertModel(models[0],_testData[28], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[1],_testData[29], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[2],_testData[30], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[3],_testData[31], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[4],_testData[32], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[5],_testData[33], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[6],_testData[34], false);
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
                var models = ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionSTSelectModelBatch(connection, 5, 145))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlIntervalintervalE0M.AssertModel(models[0],_testData[1], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[1],_testData[2], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[2],_testData[3], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[3],_testData[4], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[4],_testData[5], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[5],_testData[6], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[6],_testData[7], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[7],_testData[8], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[8],_testData[9], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[9],_testData[10], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[10],_testData[11], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[11],_testData[12], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[12],_testData[13], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[13],_testData[14], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[14],_testData[15], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[15],_testData[16], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[16],_testData[17], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[17],_testData[18], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[18],_testData[19], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[19],_testData[20], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[20],_testData[21], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[21],_testData[22], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[22],_testData[23], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[23],_testData[24], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[24],_testData[25], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[25],_testData[26], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[26],_testData[27], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[27],_testData[28], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[28],_testData[29], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[29],_testData[30], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[30],_testData[31], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[31],_testData[32], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[32],_testData[33], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlIntervalintervalE0M.AssertModel(models[0],_testData[24], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[1],_testData[25], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[2],_testData[26], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[3],_testData[27], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[4],_testData[28], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[5],_testData[29], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[6],_testData[30], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[7],_testData[31], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[8],_testData[32], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[9],_testData[33], false);
                        NpgsqlIntervalintervalE0M.AssertModel(models[10],_testData[34], false);
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
                await using var cmd = await ((INpgsqlIntervalSingleTypeinterval)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlIntervalSingleTypeinterval)this).SetDbConnectionSelectModelParametrs(cmd, 151);
                var models = await ((INpgsqlIntervalSingleTypeinterval)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                NpgsqlIntervalintervalE0M.AssertModel(models[0],_testData[27], false);
                NpgsqlIntervalintervalE0M.AssertModel(models[1],_testData[28], false);
                NpgsqlIntervalintervalE0M.AssertModel(models[2],_testData[29], false);
                NpgsqlIntervalintervalE0M.AssertModel(models[3],_testData[30], false);
                NpgsqlIntervalintervalE0M.AssertModel(models[4],_testData[31], false);
                NpgsqlIntervalintervalE0M.AssertModel(models[5],_testData[32], false);
                NpgsqlIntervalintervalE0M.AssertModel(models[6],_testData[33], false);
                NpgsqlIntervalintervalE0M.AssertModel(models[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlIntervalSingleTypeinterval)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlIntervalSingleTypeinterval)this).SetDbConnectionSelectModelParametrs(cmd, 69);
                var models =  ((INpgsqlIntervalSingleTypeinterval)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                NpgsqlIntervalintervalE0M.AssertModel(models[0],_testData[11], false);
                NpgsqlIntervalintervalE0M.AssertModel(models[1],_testData[12], false);
                NpgsqlIntervalintervalE0M.AssertModel(models[2],_testData[13], false);
                NpgsqlIntervalintervalE0M.AssertModel(models[3],_testData[14], false);
                NpgsqlIntervalintervalE0M.AssertModel(models[4],_testData[15], false);
                NpgsqlIntervalintervalE0M.AssertModel(models[5],_testData[16], false);
                NpgsqlIntervalintervalE0M.AssertModel(models[6],_testData[17], false);
                NpgsqlIntervalintervalE0M.AssertModel(models[7],_testData[18], false);
                NpgsqlIntervalintervalE0M.AssertModel(models[8],_testData[19], false);
                NpgsqlIntervalintervalE0M.AssertModel(models[9],_testData[20], false);
                NpgsqlIntervalintervalE0M.AssertModel(models[10],_testData[21], false);
                NpgsqlIntervalintervalE0M.AssertModel(models[11],_testData[22], false);
                NpgsqlIntervalintervalE0M.AssertModel(models[12],_testData[23], false);
                NpgsqlIntervalintervalE0M.AssertModel(models[13],_testData[24], false);
                NpgsqlIntervalintervalE0M.AssertModel(models[14],_testData[25], false);
                NpgsqlIntervalintervalE0M.AssertModel(models[15],_testData[26], false);
                NpgsqlIntervalintervalE0M.AssertModel(models[16],_testData[27], false);
                NpgsqlIntervalintervalE0M.AssertModel(models[17],_testData[28], false);
                NpgsqlIntervalintervalE0M.AssertModel(models[18],_testData[29], false);
                NpgsqlIntervalintervalE0M.AssertModel(models[19],_testData[30], false);
                NpgsqlIntervalintervalE0M.AssertModel(models[20],_testData[31], false);
                NpgsqlIntervalintervalE0M.AssertModel(models[21],_testData[32], false);
                NpgsqlIntervalintervalE0M.AssertModel(models[22],_testData[33], false);
                NpgsqlIntervalintervalE0M.AssertModel(models[23],_testData[34], false);
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
FROM public.binary_npgsqlintervalintervale0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalE0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(30),
                (NpgsqlTypes.NpgsqlDbType)(30)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlIntervalSingleTypeinterval)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervale0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlIntervalSingleTypeinterval)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlIntervalSingleTypeinterval)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervale0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlIntervalSingleTypeinterval)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlintervalintervale0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlIntervalSingleTypeinterval)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervale0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlIntervalSingleTypeinterval)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlIntervalSingleTypeinterval)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervale0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlIntervalSingleTypeinterval)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlintervalintervale0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlintervalintervale0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalE0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(30),
                (NpgsqlTypes.NpgsqlDbType)(30)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalE0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlIntervalSingleTypeinterval)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlIntervalSingleTypeinterval)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalE0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlIntervalSingleTypeinterval)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlIntervalSingleTypeinterval)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlintervalintervale0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlintervalintervale0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlIntervalSingleTypeinterval)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlIntervalSingleTypeinterval)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlIntervalSingleTypeinterval)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlIntervalSingleTypeinterval)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlintervalintervale0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlintervalintervale0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlIntervalintervalE0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(30),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(30)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval))]
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
FROM public.binary_npgsqlintervalintervale0m m
LEFT JOIN public.binary_npgsqlintervalintervale0mi mi ON mi.id = m.npgsqlintervalintervale0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalE0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlIntervalSingleTypeinterval)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlIntervalSingleTypeinterval)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlIntervalintervalE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalE0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlIntervalSingleTypeinterval)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlIntervalSingleTypeinterval)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlIntervalintervalE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalintervale0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlintervalintervale0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(30),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(30)
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
                var models =  ((INpgsqlIntervalSingleTypeinterval)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlIntervalintervalE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlIntervalSingleTypeinterval)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlIntervalintervalE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalE0MIWA), typeof(NpgsqlIntervalintervalE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(30),
                (NpgsqlTypes.NpgsqlDbType)(30)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(30),
                (NpgsqlTypes.NpgsqlDbType)(30)
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
                var models1 = new List<NpgsqlIntervalintervalE0MIWA>();
                var models2 = new List<NpgsqlIntervalintervalE0MIWA>();
                await ((INpgsqlIntervalSingleTypeinterval)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervale0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlIntervalintervalE0MIWA>();
                var models2 = new List<NpgsqlIntervalintervalE0MIWA>();
                ((INpgsqlIntervalSingleTypeinterval)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervale0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(30),
                (NpgsqlTypes.NpgsqlDbType)(30)
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
                var models = await ((INpgsqlIntervalSingleTypeinterval)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlintervalintervale0mi
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
                    NpgsqlIntervalintervalE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlIntervalSingleTypeinterval)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlintervalintervale0mi
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
                    NpgsqlIntervalintervalE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalE0MIWA), typeof(NpgsqlIntervalintervalE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval))]
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
                var models1 = new List<NpgsqlIntervalintervalE0MIWA>();
                var models2 = new List<NpgsqlIntervalintervalE0MIWA>();
                await ((INpgsqlIntervalSingleTypeinterval)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervale0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlIntervalintervalE0MIWA>();
                var models2 = new List<NpgsqlIntervalintervalE0MIWA>();
                ((INpgsqlIntervalSingleTypeinterval)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervale0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval))]
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
                var models = await ((INpgsqlIntervalSingleTypeinterval)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlintervalintervale0mi
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
                    NpgsqlIntervalintervalE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlIntervalSingleTypeinterval)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlintervalintervale0mi
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
                    NpgsqlIntervalintervalE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlintervalintervale0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalE0MI), typeof(NpgsqlIntervalintervalE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(30),
                (NpgsqlTypes.NpgsqlDbType)(30)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(30),
                (NpgsqlTypes.NpgsqlDbType)(30)
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
                var models1 = new List<NpgsqlIntervalintervalE0MI>();
                var models2 = new List<NpgsqlIntervalintervalE0MI>();
                await ((INpgsqlIntervalSingleTypeinterval)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlIntervalintervalE0MI>();
                var models2 = new List<NpgsqlIntervalintervalE0MI>();
                ((INpgsqlIntervalSingleTypeinterval)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalintervale0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(30),
                (NpgsqlTypes.NpgsqlDbType)(30)
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
                var models = await ((INpgsqlIntervalSingleTypeinterval)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalE0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlIntervalSingleTypeinterval)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlintervalintervale0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalE0MIWA), typeof(NpgsqlIntervalintervalE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval))]
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
                var models1 = new List<NpgsqlIntervalintervalE0MIWA>();
                var models2 = new List<NpgsqlIntervalintervalE0MIWA>();
                await ((INpgsqlIntervalSingleTypeinterval)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlIntervalintervalE0MIWA>();
                var models2 = new List<NpgsqlIntervalintervalE0MIWA>();
                ((INpgsqlIntervalSingleTypeinterval)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalintervale0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval))]
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
                var models = await ((INpgsqlIntervalSingleTypeinterval)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlIntervalSingleTypeinterval)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

