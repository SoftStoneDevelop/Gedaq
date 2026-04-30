

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

        private readonly NpgsqlIntervalinterval0M[] _testData = new NpgsqlIntervalinterval0M[]
        {
            new NpgsqlIntervalinterval0M
{
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1109),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalinterval0M
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2378),
    ModelInner = new NpgsqlIntervalinterval0MI
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1213),
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 932),
},
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 493),
},
            new NpgsqlIntervalinterval0M
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4101),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4479),
},
            new NpgsqlIntervalinterval0M
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 166),
    ModelInner = new NpgsqlIntervalinterval0MI
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3162),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1879),
},
            new NpgsqlIntervalinterval0M
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 925),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1204),
},
            new NpgsqlIntervalinterval0M
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 958),
    ModelInner = new NpgsqlIntervalinterval0MI
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3487),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalinterval0M
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4457),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1308),
},
            new NpgsqlIntervalinterval0M
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1003),
    ModelInner = new NpgsqlIntervalinterval0MI
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 656),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalinterval0M
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3136),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1142),
},
            new NpgsqlIntervalinterval0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 14),
    ModelInner = new NpgsqlIntervalinterval0MI
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3186),
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1049),
},
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2),
},
            new NpgsqlIntervalinterval0M
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4944),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalinterval0M
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2790),
    ModelInner = new NpgsqlIntervalinterval0MI
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2894),
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3905),
},
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4051),
},
            new NpgsqlIntervalinterval0M
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2269),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalinterval0M
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3804),
    ModelInner = new NpgsqlIntervalinterval0MI
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4145),
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 387),
},
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2233),
},
            new NpgsqlIntervalinterval0M
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2731),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 258),
},
            new NpgsqlIntervalinterval0M
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 411),
    ModelInner = new NpgsqlIntervalinterval0MI
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1468),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalinterval0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1319),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4167),
},
            new NpgsqlIntervalinterval0M
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2269),
    ModelInner = new NpgsqlIntervalinterval0MI
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2600),
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1402),
},
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1370),
},
            new NpgsqlIntervalinterval0M
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2674),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalinterval0M
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4762),
    ModelInner = new NpgsqlIntervalinterval0MI
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1511),
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4899),
},
    NullableValue = null,
},
            new NpgsqlIntervalinterval0M
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2566),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalinterval0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 620),
    ModelInner = new NpgsqlIntervalinterval0MI
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3054),
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1467),
},
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2491),
},
            new NpgsqlIntervalinterval0M
{
    Id = 97,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4466),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalinterval0M
{
    Id = 106,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4728),
    ModelInner = new NpgsqlIntervalinterval0MI
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2773),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1140),
},
            new NpgsqlIntervalinterval0M
{
    Id = 110,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2859),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4017),
},
            new NpgsqlIntervalinterval0M
{
    Id = 113,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1217),
    ModelInner = new NpgsqlIntervalinterval0MI
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3618),
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1565),
},
    NullableValue = null,
},
            new NpgsqlIntervalinterval0M
{
    Id = 122,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1370),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalinterval0M
{
    Id = 130,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4387),
    ModelInner = new NpgsqlIntervalinterval0MI
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1052),
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4814),
},
    NullableValue = null,
},
            new NpgsqlIntervalinterval0M
{
    Id = 133,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1373),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalinterval0M
{
    Id = 140,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2024),
    ModelInner = new NpgsqlIntervalinterval0MI
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3461),
    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 359),
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalinterval0mi(
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
INSERT INTO public.npgsqlintervalinterval0mi(
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
            queryMapTypes: [typeof(NpgsqlIntervalinterval0MI)],
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
INSERT INTO public.npgsqlintervalinterval0mi(
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

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalinterval0m(
	id,
    value,
    nullablevalue,
    npgsqlintervalinterval0mi_id
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
                methodParametrName: "npgsqlintervalinterval0mi_id", 
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
INSERT INTO public.npgsqlintervalinterval0m(
	id,
    value,
    nullablevalue,
    npgsqlintervalinterval0mi_id
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
    npgsqlintervalinterval0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlIntervalinterval0M)],
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
INSERT INTO public.npgsqlintervalinterval0m(
	id,
    value,
    nullablevalue,
    npgsqlintervalinterval0mi_id
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
    npgsqlintervalinterval0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlIntervalinterval0M)],
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
                methodParametrName: "npgsqlintervalinterval0mi_id", 
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
                List<NpgsqlIntervalinterval0M> models = null;

                models =  ((INpgsqlIntervalSingleTypeinterval)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalinterval0M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlIntervalSingleTypeinterval)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalinterval0M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlIntervalSingleTypeinterval)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalinterval0M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlIntervalSingleTypeinterval)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalinterval0M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlIntervalinterval0M> models = null;

                models = await ((INpgsqlIntervalSingleTypeinterval)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalinterval0M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlIntervalSingleTypeinterval)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalinterval0M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlIntervalSingleTypeinterval)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalinterval0M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlIntervalSingleTypeinterval)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalinterval0M.AssertModel(models[0],_testData[11], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalinterval0m(
	id,
    value,
    nullablevalue,
    npgsqlintervalinterval0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlintervalinterval0mi_id
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
                parametrName: "npgsqlintervalinterval0mi_id", 
                methodParametrName: "npgsqlintervalinterval0mi_id", 
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

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalinterval0M), typeof(FlatNpgsqlIntervalinterval0M)],
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
FROM public.npgsqlintervalinterval0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlIntervalinterval0M>();
                var models2 = new List<FlatNpgsqlIntervalinterval0M>();
                await ((INpgsqlIntervalSingleTypeinterval)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalinterval0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalinterval0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalinterval0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlIntervalinterval0M>();
                var models2 = new List<FlatNpgsqlIntervalinterval0M>();
                ((INpgsqlIntervalSingleTypeinterval)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalinterval0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalinterval0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalinterval0M)],
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
FROM public.npgsqlintervalinterval0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlIntervalSingleTypeinterval)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalinterval0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalinterval0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlIntervalSingleTypeinterval)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalinterval0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalinterval0m m
LEFT JOIN public.npgsqlintervalinterval0mi mi ON mi.id = m.npgsqlintervalinterval0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlIntervalinterval0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalinterval0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalinterval0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalinterval0M), typeof(FlatNpgsqlIntervalinterval0M)],
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
FROM public.npgsqlintervalinterval0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalinterval0M>();
                var models2 = new List<FlatNpgsqlIntervalinterval0M>();
                await ((INpgsqlIntervalSingleTypeinterval)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalinterval0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalinterval0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalinterval0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalinterval0M>();
                var models2 = new List<FlatNpgsqlIntervalinterval0M>();
                ((INpgsqlIntervalSingleTypeinterval)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalinterval0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalinterval0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalinterval0M)],
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
FROM public.npgsqlintervalinterval0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlIntervalSingleTypeinterval)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalinterval0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalinterval0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlIntervalSingleTypeinterval)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalinterval0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalinterval0m m
LEFT JOIN public.npgsqlintervalinterval0mi mi ON mi.id = m.npgsqlintervalinterval0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlIntervalinterval0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalinterval0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalinterval0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalinterval0M), typeof(FlatNpgsqlIntervalinterval0M)],
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
FROM public.npgsqlintervalinterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlIntervalinterval0M>();
                var models2 = new List<FlatNpgsqlIntervalinterval0M>();
                await((INpgsqlIntervalSingleTypeinterval)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalinterval0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalinterval0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
FROM public.npgsqlintervalinterval0m m
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
FROM public.npgsqlintervalinterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalinterval0M>();
                var firstItems2 = new List<FlatNpgsqlIntervalinterval0M>();
                var secondItems1 = new List<FlatNpgsqlIntervalinterval0M>();
                var secondItems2 = new List<FlatNpgsqlIntervalinterval0M>();
                await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[13],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
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
FROM public.npgsqlintervalinterval0m m
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
FROM public.npgsqlintervalinterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalinterval0M>();
                var firstItems2 = new List<FlatNpgsqlIntervalinterval0M>();
                var secondItems1 = new List<FlatNpgsqlIntervalinterval0M>();
                await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[15],_testData[29], false);
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
FROM public.npgsqlintervalinterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlIntervalinterval0M>();
                var models2 = new List<FlatNpgsqlIntervalinterval0M>();
                ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalinterval0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalinterval0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
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
FROM public.npgsqlintervalinterval0m m
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
FROM public.npgsqlintervalinterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalinterval0M>();
                var firstItems2 = new List<FlatNpgsqlIntervalinterval0M>();
                var secondItems1 = new List<FlatNpgsqlIntervalinterval0M>();
                var secondItems2 = new List<FlatNpgsqlIntervalinterval0M>();
                 ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[10],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
FROM public.npgsqlintervalinterval0m m
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
FROM public.npgsqlintervalinterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalinterval0M>();
                var firstItems2 = new List<FlatNpgsqlIntervalinterval0M>();
                var secondItems1 = new List<FlatNpgsqlIntervalinterval0M>();
                 ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[26],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalinterval0M)],
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
FROM public.npgsqlintervalinterval0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalinterval0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalinterval0m m
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
FROM public.npgsqlintervalinterval0m m
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
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlIntervalinterval0M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlIntervalinterval0M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[24],_testData[29], false);
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalinterval0m m
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
FROM public.npgsqlintervalinterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalinterval0M>();
                var secondItems1 = new List<FlatNpgsqlIntervalinterval0M>();
                var secondItems2 = new List<FlatNpgsqlIntervalinterval0M>();
                await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[17],_testData[29], false);
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
FROM public.npgsqlintervalinterval0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalinterval0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalinterval0m m
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
FROM public.npgsqlintervalinterval0m m
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
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlIntervalinterval0M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlIntervalinterval0M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[15],_testData[29], false);
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalinterval0m m
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
FROM public.npgsqlintervalinterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalinterval0M>();
                var secondItems1 = new List<FlatNpgsqlIntervalinterval0M>();
                var secondItems2 = new List<FlatNpgsqlIntervalinterval0M>();
                 ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[3],_testData[29], false);
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
FROM public.npgsqlintervalinterval0m m
LEFT JOIN public.npgsqlintervalinterval0mi mi ON mi.id = m.npgsqlintervalinterval0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlIntervalinterval0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalinterval0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlIntervalinterval0M.AssertModel(models[0],_testData[28], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlIntervalinterval0M.AssertModel(models[0],_testData[2], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[1],_testData[3], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[2],_testData[4], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[3],_testData[5], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[4],_testData[6], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[5],_testData[7], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[6],_testData[8], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[7],_testData[9], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[8],_testData[10], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[9],_testData[11], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[10],_testData[12], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[11],_testData[13], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[12],_testData[14], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[13],_testData[15], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[14],_testData[16], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[15],_testData[17], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[16],_testData[18], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[17],_testData[19], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[18],_testData[20], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[19],_testData[21], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[20],_testData[22], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[21],_testData[23], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[22],_testData[24], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[23],_testData[25], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[24],_testData[26], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[25],_testData[27], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[26],_testData[28], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[27],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalinterval0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlIntervalinterval0M.AssertModel(models[0],_testData[26], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[1],_testData[27], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[2],_testData[28], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlIntervalinterval0M.AssertModel(models[0],_testData[25], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[1],_testData[26], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[2],_testData[27], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[3],_testData[28], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalinterval0M), typeof(FlatNpgsqlIntervalinterval0M)],
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
FROM public.npgsqlintervalinterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalinterval0M>();
                var models2 = new List<FlatNpgsqlIntervalinterval0M>();
                await((INpgsqlIntervalSingleTypeinterval)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalinterval0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalinterval0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalinterval0m m
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
FROM public.npgsqlintervalinterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalinterval0M>();
                var firstItems2 = new List<FlatNpgsqlIntervalinterval0M>();
                var secondItems1 = new List<FlatNpgsqlIntervalinterval0M>();
                var secondItems2 = new List<FlatNpgsqlIntervalinterval0M>();
                await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 43, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[1],_testData[29], false);
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
FROM public.npgsqlintervalinterval0m m
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
FROM public.npgsqlintervalinterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalinterval0M>();
                var firstItems2 = new List<FlatNpgsqlIntervalinterval0M>();
                var secondItems1 = new List<FlatNpgsqlIntervalinterval0M>();
                await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 5, query1, 15, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[26],_testData[29], false);
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
FROM public.npgsqlintervalinterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalinterval0M>();
                var models2 = new List<FlatNpgsqlIntervalinterval0M>();
                ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalinterval0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalinterval0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalinterval0m m
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
FROM public.npgsqlintervalinterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalinterval0M>();
                var firstItems2 = new List<FlatNpgsqlIntervalinterval0M>();
                var secondItems1 = new List<FlatNpgsqlIntervalinterval0M>();
                var secondItems2 = new List<FlatNpgsqlIntervalinterval0M>();
                 ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 110, query1, 67, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[11],_testData[29], false);
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
FROM public.npgsqlintervalinterval0m m
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
FROM public.npgsqlintervalinterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalinterval0M>();
                var firstItems2 = new List<FlatNpgsqlIntervalinterval0M>();
                var secondItems1 = new List<FlatNpgsqlIntervalinterval0M>();
                 ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionMMDynQuerySelectModelBatch(connection, 35, query1, 21, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[25],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalinterval0M)],
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
FROM public.npgsqlintervalinterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlIntervalSingleTypeinterval)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalinterval0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalinterval0m m
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
FROM public.npgsqlintervalinterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 24, query1, 113, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlIntervalinterval0M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlIntervalinterval0M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[3],_testData[29], false);
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
FROM public.npgsqlintervalinterval0m m
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
FROM public.npgsqlintervalinterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalinterval0M>();
                var secondItems1 = new List<FlatNpgsqlIntervalinterval0M>();
                var secondItems2 = new List<FlatNpgsqlIntervalinterval0M>();
                await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 8, query1, 122, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[2],_testData[29], false);
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
FROM public.npgsqlintervalinterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalinterval0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalinterval0m m
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
FROM public.npgsqlintervalinterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionSTDynQuerySelectModelBatch(connection, 58, query1, 71, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlIntervalinterval0M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlIntervalinterval0M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(models[10],_testData[29], false);
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
FROM public.npgsqlintervalinterval0m m
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
FROM public.npgsqlintervalinterval0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalinterval0M>();
                var secondItems1 = new List<FlatNpgsqlIntervalinterval0M>();
                var secondItems2 = new List<FlatNpgsqlIntervalinterval0M>();
                 ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionDynQuerySelectModelBatch(connection, 58, query1, 65, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlIntervalinterval0M.AssertModel(secondItems2[12],_testData[29], false);
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
FROM public.npgsqlintervalinterval0m m
LEFT JOIN public.npgsqlintervalinterval0mi mi ON mi.id = m.npgsqlintervalinterval0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlIntervalinterval0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalinterval0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionSTSelectModelBatchAsync(connection, 64, 65))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlIntervalinterval0M.AssertModel(models[0],_testData[16], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[1],_testData[17], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[2],_testData[18], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[3],_testData[19], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[4],_testData[20], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[5],_testData[21], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[6],_testData[22], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[7],_testData[23], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[8],_testData[24], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[9],_testData[25], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[10],_testData[26], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[11],_testData[27], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[12],_testData[28], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlIntervalinterval0M.AssertModel(models[0],_testData[17], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[1],_testData[18], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[2],_testData[19], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[3],_testData[20], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[4],_testData[21], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[5],_testData[22], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[6],_testData[23], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[7],_testData[24], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[8],_testData[25], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[9],_testData[26], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[10],_testData[27], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[11],_testData[28], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[12],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalinterval0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionSTSelectModelBatch(connection, 78, 15))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlIntervalinterval0M.AssertModel(models[0],_testData[20], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[1],_testData[21], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[2],_testData[22], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[3],_testData[23], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[4],_testData[24], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[5],_testData[25], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[6],_testData[26], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[7],_testData[27], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[8],_testData[28], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlIntervalinterval0M.AssertModel(models[0],_testData[3], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[1],_testData[4], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[2],_testData[5], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[3],_testData[6], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[4],_testData[7], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[5],_testData[8], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[6],_testData[9], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[7],_testData[10], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[8],_testData[11], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[9],_testData[12], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[10],_testData[13], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[11],_testData[14], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[12],_testData[15], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[13],_testData[16], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[14],_testData[17], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[15],_testData[18], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[16],_testData[19], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[17],_testData[20], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[18],_testData[21], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[19],_testData[22], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[20],_testData[23], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[21],_testData[24], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[22],_testData[25], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[23],_testData[26], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[24],_testData[27], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[25],_testData[28], false);
                        NpgsqlIntervalinterval0M.AssertModel(models[26],_testData[29], false);
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
                ((INpgsqlIntervalSingleTypeinterval)this).SetDbConnectionSelectModelParametrs(cmd, 15);
                var models = await ((INpgsqlIntervalSingleTypeinterval)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
NpgsqlIntervalinterval0M.AssertModel(models[0],_testData[3], false);NpgsqlIntervalinterval0M.AssertModel(models[1],_testData[4], false);NpgsqlIntervalinterval0M.AssertModel(models[2],_testData[5], false);NpgsqlIntervalinterval0M.AssertModel(models[3],_testData[6], false);NpgsqlIntervalinterval0M.AssertModel(models[4],_testData[7], false);NpgsqlIntervalinterval0M.AssertModel(models[5],_testData[8], false);NpgsqlIntervalinterval0M.AssertModel(models[6],_testData[9], false);NpgsqlIntervalinterval0M.AssertModel(models[7],_testData[10], false);NpgsqlIntervalinterval0M.AssertModel(models[8],_testData[11], false);NpgsqlIntervalinterval0M.AssertModel(models[9],_testData[12], false);NpgsqlIntervalinterval0M.AssertModel(models[10],_testData[13], false);NpgsqlIntervalinterval0M.AssertModel(models[11],_testData[14], false);NpgsqlIntervalinterval0M.AssertModel(models[12],_testData[15], false);NpgsqlIntervalinterval0M.AssertModel(models[13],_testData[16], false);NpgsqlIntervalinterval0M.AssertModel(models[14],_testData[17], false);NpgsqlIntervalinterval0M.AssertModel(models[15],_testData[18], false);NpgsqlIntervalinterval0M.AssertModel(models[16],_testData[19], false);NpgsqlIntervalinterval0M.AssertModel(models[17],_testData[20], false);NpgsqlIntervalinterval0M.AssertModel(models[18],_testData[21], false);NpgsqlIntervalinterval0M.AssertModel(models[19],_testData[22], false);NpgsqlIntervalinterval0M.AssertModel(models[20],_testData[23], false);NpgsqlIntervalinterval0M.AssertModel(models[21],_testData[24], false);NpgsqlIntervalinterval0M.AssertModel(models[22],_testData[25], false);NpgsqlIntervalinterval0M.AssertModel(models[23],_testData[26], false);NpgsqlIntervalinterval0M.AssertModel(models[24],_testData[27], false);NpgsqlIntervalinterval0M.AssertModel(models[25],_testData[28], false);NpgsqlIntervalinterval0M.AssertModel(models[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlIntervalSingleTypeinterval)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlIntervalSingleTypeinterval)this).SetDbConnectionSelectModelParametrs(cmd, 90);
                var models =  ((INpgsqlIntervalSingleTypeinterval)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
NpgsqlIntervalinterval0M.AssertModel(models[0],_testData[22], false);NpgsqlIntervalinterval0M.AssertModel(models[1],_testData[23], false);NpgsqlIntervalinterval0M.AssertModel(models[2],_testData[24], false);NpgsqlIntervalinterval0M.AssertModel(models[3],_testData[25], false);NpgsqlIntervalinterval0M.AssertModel(models[4],_testData[26], false);NpgsqlIntervalinterval0M.AssertModel(models[5],_testData[27], false);NpgsqlIntervalinterval0M.AssertModel(models[6],_testData[28], false);NpgsqlIntervalinterval0M.AssertModel(models[7],_testData[29], false);
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
FROM public.binary_npgsqlintervalinterval0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalinterval0MIWA)],
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
            queryMapType: typeof(NpgsqlIntervalinterval0MIWA),
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalinterval0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalinterval0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlIntervalSingleTypeinterval)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlintervalinterval0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlIntervalSingleTypeinterval)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalinterval0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlIntervalinterval0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalinterval0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlIntervalSingleTypeinterval)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlintervalinterval0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlIntervalSingleTypeinterval)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalinterval0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlintervalinterval0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalinterval0MI)],
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
COPY public.binary_npgsqlintervalinterval0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlIntervalinterval0MI),
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
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalinterval0MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlIntervalSingleTypeinterval)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlIntervalSingleTypeinterval)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalinterval0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlIntervalinterval0MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlIntervalSingleTypeinterval)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlIntervalSingleTypeinterval)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalinterval0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlintervalinterval0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlintervalinterval0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlIntervalinterval0M),
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
FROM public.binary_npgsqlintervalinterval0m m
LEFT JOIN public.binary_npgsqlintervalinterval0mi mi ON mi.id = m.npgsqlintervalinterval0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlIntervalinterval0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(5)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlIntervalinterval0M>(15);

                    importCollection.Add(_testData[0]);
                    importCollection.Add(_testData[1]);
                    importCollection.Add(_testData[2]);
                    importCollection.Add(_testData[3]);
                    importCollection.Add(_testData[4]);
                    importCollection.Add(_testData[5]);
                    importCollection.Add(_testData[6]);
                    importCollection.Add(_testData[7]);
                    importCollection.Add(_testData[8]);
                    importCollection.Add(_testData[9]);
                    importCollection.Add(_testData[10]);
                    importCollection.Add(_testData[11]);
                    importCollection.Add(_testData[12]);
                    importCollection.Add(_testData[13]);
                    importCollection.Add(_testData[14]);
                ((INpgsqlIntervalSingleTypeinterval)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlIntervalSingleTypeinterval)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlIntervalinterval0M.AssertModel(models[0],_testData[0], false);
                NpgsqlIntervalinterval0M.AssertModel(models[1],_testData[1], false);
                NpgsqlIntervalinterval0M.AssertModel(models[2],_testData[2], false);
                NpgsqlIntervalinterval0M.AssertModel(models[3],_testData[3], false);
                NpgsqlIntervalinterval0M.AssertModel(models[4],_testData[4], false);
                NpgsqlIntervalinterval0M.AssertModel(models[5],_testData[5], false);
                NpgsqlIntervalinterval0M.AssertModel(models[6],_testData[6], false);
                NpgsqlIntervalinterval0M.AssertModel(models[7],_testData[7], false);
                NpgsqlIntervalinterval0M.AssertModel(models[8],_testData[8], false);
                NpgsqlIntervalinterval0M.AssertModel(models[9],_testData[9], false);
                NpgsqlIntervalinterval0M.AssertModel(models[10],_testData[10], false);
                NpgsqlIntervalinterval0M.AssertModel(models[11],_testData[11], false);
                NpgsqlIntervalinterval0M.AssertModel(models[12],_testData[12], false);
                NpgsqlIntervalinterval0M.AssertModel(models[13],_testData[13], false);
                NpgsqlIntervalinterval0M.AssertModel(models[14],_testData[14], false);
                importCollection.Clear();

                    importCollection.Add(_testData[15]);
                    importCollection.Add(_testData[16]);
                    importCollection.Add(_testData[17]);
                    importCollection.Add(_testData[18]);
                    importCollection.Add(_testData[19]);
                    importCollection.Add(_testData[20]);
                    importCollection.Add(_testData[21]);
                    importCollection.Add(_testData[22]);
                    importCollection.Add(_testData[23]);
                    importCollection.Add(_testData[24]);
                    importCollection.Add(_testData[25]);
                    importCollection.Add(_testData[26]);
                    importCollection.Add(_testData[27]);
                    importCollection.Add(_testData[28]);
                    importCollection.Add(_testData[29]);
                await ((INpgsqlIntervalSingleTypeinterval)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlIntervalSingleTypeinterval)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlIntervalinterval0M.AssertModel(models[0],_testData[0], false);
                NpgsqlIntervalinterval0M.AssertModel(models[1],_testData[1], false);
                NpgsqlIntervalinterval0M.AssertModel(models[2],_testData[2], false);
                NpgsqlIntervalinterval0M.AssertModel(models[3],_testData[3], false);
                NpgsqlIntervalinterval0M.AssertModel(models[4],_testData[4], false);
                NpgsqlIntervalinterval0M.AssertModel(models[5],_testData[5], false);
                NpgsqlIntervalinterval0M.AssertModel(models[6],_testData[6], false);
                NpgsqlIntervalinterval0M.AssertModel(models[7],_testData[7], false);
                NpgsqlIntervalinterval0M.AssertModel(models[8],_testData[8], false);
                NpgsqlIntervalinterval0M.AssertModel(models[9],_testData[9], false);
                NpgsqlIntervalinterval0M.AssertModel(models[10],_testData[10], false);
                NpgsqlIntervalinterval0M.AssertModel(models[11],_testData[11], false);
                NpgsqlIntervalinterval0M.AssertModel(models[12],_testData[12], false);
                NpgsqlIntervalinterval0M.AssertModel(models[13],_testData[13], false);
                NpgsqlIntervalinterval0M.AssertModel(models[14],_testData[14], false);
                NpgsqlIntervalinterval0M.AssertModel(models[15],_testData[15], false);
                NpgsqlIntervalinterval0M.AssertModel(models[16],_testData[16], false);
                NpgsqlIntervalinterval0M.AssertModel(models[17],_testData[17], false);
                NpgsqlIntervalinterval0M.AssertModel(models[18],_testData[18], false);
                NpgsqlIntervalinterval0M.AssertModel(models[19],_testData[19], false);
                NpgsqlIntervalinterval0M.AssertModel(models[20],_testData[20], false);
                NpgsqlIntervalinterval0M.AssertModel(models[21],_testData[21], false);
                NpgsqlIntervalinterval0M.AssertModel(models[22],_testData[22], false);
                NpgsqlIntervalinterval0M.AssertModel(models[23],_testData[23], false);
                NpgsqlIntervalinterval0M.AssertModel(models[24],_testData[24], false);
                NpgsqlIntervalinterval0M.AssertModel(models[25],_testData[25], false);
                NpgsqlIntervalinterval0M.AssertModel(models[26],_testData[26], false);
                NpgsqlIntervalinterval0M.AssertModel(models[27],_testData[27], false);
                NpgsqlIntervalinterval0M.AssertModel(models[28],_testData[28], false);
                NpgsqlIntervalinterval0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalinterval0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlintervalinterval0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlIntervalinterval0M)],
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(6)]
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
                    NpgsqlIntervalinterval0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(6)]
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
                    NpgsqlIntervalinterval0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalinterval0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalinterval0MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlIntervalSingleTypeinterval)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalinterval0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlIntervalSingleTypeinterval)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalinterval0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

