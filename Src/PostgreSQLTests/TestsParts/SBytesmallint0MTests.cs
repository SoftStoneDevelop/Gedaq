

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
    internal partial interface ISByteSingleTypesmallint
    {
    }
    
    internal partial class SByteSingleTypesmallint : ISByteSingleTypesmallint
    {


#region TestData

        private readonly SBytesmallint0M[] _testData = new SBytesmallint0M[]
        {
            new SBytesmallint0M
{
    Id = 9,
    Value = 35,
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallint0M
{
    Id = 15,
    Value = 85,
    ModelInner = new SBytesmallint0MI
{
    Id = 5,
    Value = 96,
    NullableValue = -46,
},
    NullableValue = null,
},
            new SBytesmallint0M
{
    Id = 19,
    Value = 50,
    ModelInner = null,
    NullableValue = 75,
},
            new SBytesmallint0M
{
    Id = 25,
    Value = 95,
    ModelInner = new SBytesmallint0MI
{
    Id = 9,
    Value = 28,
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallint0M
{
    Id = 27,
    Value = -75,
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallint0M
{
    Id = 30,
    Value = -3,
    ModelInner = new SBytesmallint0MI
{
    Id = 11,
    Value = -97,
    NullableValue = 25,
},
    NullableValue = 10,
},
            new SBytesmallint0M
{
    Id = 37,
    Value = -116,
    ModelInner = null,
    NullableValue = -68,
},
            new SBytesmallint0M
{
    Id = 41,
    Value = -99,
    ModelInner = new SBytesmallint0MI
{
    Id = 16,
    Value = 94,
    NullableValue = 33,
},
    NullableValue = -67,
},
            new SBytesmallint0M
{
    Id = 48,
    Value = 76,
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallint0M
{
    Id = 49,
    Value = -53,
    ModelInner = new SBytesmallint0MI
{
    Id = 22,
    Value = -2,
    NullableValue = 7,
},
    NullableValue = null,
},
            new SBytesmallint0M
{
    Id = 58,
    Value = 75,
    ModelInner = null,
    NullableValue = -22,
},
            new SBytesmallint0M
{
    Id = 64,
    Value = -94,
    ModelInner = new SBytesmallint0MI
{
    Id = 23,
    Value = 3,
    NullableValue = null,
},
    NullableValue = 50,
},
            new SBytesmallint0M
{
    Id = 72,
    Value = 45,
    ModelInner = null,
    NullableValue = 33,
},
            new SBytesmallint0M
{
    Id = 75,
    Value = -121,
    ModelInner = new SBytesmallint0MI
{
    Id = 28,
    Value = -58,
    NullableValue = 25,
},
    NullableValue = null,
},
            new SBytesmallint0M
{
    Id = 82,
    Value = -3,
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallint0M
{
    Id = 91,
    Value = -109,
    ModelInner = new SBytesmallint0MI
{
    Id = 31,
    Value = -102,
    NullableValue = -93,
},
    NullableValue = null,
},
            new SBytesmallint0M
{
    Id = 95,
    Value = 94,
    ModelInner = null,
    NullableValue = 17,
},
            new SBytesmallint0M
{
    Id = 96,
    Value = -13,
    ModelInner = new SBytesmallint0MI
{
    Id = 34,
    Value = 55,
    NullableValue = null,
},
    NullableValue = null,
},
            new SBytesmallint0M
{
    Id = 100,
    Value = -37,
    ModelInner = null,
    NullableValue = 118,
},
            new SBytesmallint0M
{
    Id = 109,
    Value = -35,
    ModelInner = new SBytesmallint0MI
{
    Id = 41,
    Value = 120,
    NullableValue = null,
},
    NullableValue = -62,
},
            new SBytesmallint0M
{
    Id = 111,
    Value = -69,
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallint0M
{
    Id = 114,
    Value = -114,
    ModelInner = new SBytesmallint0MI
{
    Id = 47,
    Value = 101,
    NullableValue = null,
},
    NullableValue = 50,
},
            new SBytesmallint0M
{
    Id = 121,
    Value = 81,
    ModelInner = null,
    NullableValue = -51,
},
            new SBytesmallint0M
{
    Id = 124,
    Value = -14,
    ModelInner = new SBytesmallint0MI
{
    Id = 53,
    Value = 107,
    NullableValue = 101,
},
    NullableValue = 26,
},
            new SBytesmallint0M
{
    Id = 128,
    Value = 110,
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallint0M
{
    Id = 133,
    Value = -4,
    ModelInner = new SBytesmallint0MI
{
    Id = 55,
    Value = -122,
    NullableValue = -19,
},
    NullableValue = -42,
},
            new SBytesmallint0M
{
    Id = 137,
    Value = -9,
    ModelInner = null,
    NullableValue = -58,
},
            new SBytesmallint0M
{
    Id = 143,
    Value = -72,
    ModelInner = new SBytesmallint0MI
{
    Id = 63,
    Value = 80,
    NullableValue = null,
},
    NullableValue = -38,
},
            new SBytesmallint0M
{
    Id = 150,
    Value = 77,
    ModelInner = null,
    NullableValue = null,
},
            new SBytesmallint0M
{
    Id = 154,
    Value = 67,
    ModelInner = new SBytesmallint0MI
{
    Id = 67,
    Value = 124,
    NullableValue = null,
},
    NullableValue = -68,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.sbytesmallint0mi(
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
            asPartInterface: typeof(ISByteSingleTypesmallint)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.SByte),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.SByte?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.sbytesmallint0mi(
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
            queryMapTypes: [typeof(SBytesmallint0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.SByte),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.SByte?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(18))]
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

                changedRows =  ((ISByteSingleTypesmallint)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISByteSingleTypesmallint)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ISByteSingleTypesmallint)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ISByteSingleTypesmallint)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ISByteSingleTypesmallint)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ISByteSingleTypesmallint)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ISByteSingleTypesmallint)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.sbytesmallint0mi(
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
            asPartInterface: typeof(ISByteSingleTypesmallint)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.SByte), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(10)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.SByte?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(10), 
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

                changedRows =  ((ISByteSingleTypesmallint)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.sbytesmallint0m(
	id,
    value,
    nullablevalue,
    sbytesmallint0mi_id
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
            asPartInterface: typeof(ISByteSingleTypesmallint)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.SByte),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.SByte?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "sbytesmallint0mi_id", 
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
                changedRows =  ((ISByteSingleTypesmallint)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ISByteSingleTypesmallint)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ISByteSingleTypesmallint)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ISByteSingleTypesmallint)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.sbytesmallint0m(
	id,
    value,
    nullablevalue,
    sbytesmallint0mi_id
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
    sbytesmallint0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(SBytesmallint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint)),
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
INSERT INTO public.sbytesmallint0m(
	id,
    value,
    nullablevalue,
    sbytesmallint0mi_id
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
    sbytesmallint0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(SBytesmallint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.SByte),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.SByte?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "sbytesmallint0mi_id", 
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
                List<SBytesmallint0M> models = null;

                models =  ((ISByteSingleTypesmallint)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallint0M.AssertModel(models[0],_testData[4], true);
                models =  ((ISByteSingleTypesmallint)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallint0M.AssertModel(models[0],_testData[5], true);
                models =  ((ISByteSingleTypesmallint)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallint0M.AssertModel(models[0],_testData[6], true);
                models =  ((ISByteSingleTypesmallint)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallint0M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<SBytesmallint0M> models = null;

                models = await ((ISByteSingleTypesmallint)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallint0M.AssertModel(models[0],_testData[8], true);
                models = await ((ISByteSingleTypesmallint)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallint0M.AssertModel(models[0],_testData[9], true);
                models = await ((ISByteSingleTypesmallint)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallint0M.AssertModel(models[0],_testData[10], true);
                models = await ((ISByteSingleTypesmallint)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SBytesmallint0M.AssertModel(models[0],_testData[11], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.sbytesmallint0m(
	id,
    value,
    nullablevalue,
    sbytesmallint0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @sbytesmallint0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.SByte), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(10)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.SByte?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(10),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "sbytesmallint0mi_id", 
                methodParametrName: "sbytesmallint0mi_id", 
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

                changedRows =  ((ISByteSingleTypesmallint)this).DbConnectionInsertModel(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISByteSingleTypesmallint)this).DbConnectionInsertModel(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
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

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSBytesmallint0M), typeof(FlatSBytesmallint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint)),
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
FROM public.sbytesmallint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSBytesmallint0M>();
                var models2 = new List<FlatSBytesmallint0M>();
                await ((ISByteSingleTypesmallint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.sbytesmallint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSBytesmallint0M>();
                var models2 = new List<FlatSBytesmallint0M>();
                ((ISByteSingleTypesmallint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSBytesmallint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint)),
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
FROM public.sbytesmallint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ISByteSingleTypesmallint)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ISByteSingleTypesmallint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallint0m m
LEFT JOIN public.sbytesmallint0mi mi ON mi.id = m.sbytesmallint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(SBytesmallint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint)),
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
                var models = await ((ISByteSingleTypesmallint)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SBytesmallint0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ISByteSingleTypesmallint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SBytesmallint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSBytesmallint0M), typeof(FlatSBytesmallint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint)),
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
FROM public.sbytesmallint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSBytesmallint0M>();
                var models2 = new List<FlatSBytesmallint0M>();
                await ((ISByteSingleTypesmallint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.sbytesmallint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSBytesmallint0M>();
                var models2 = new List<FlatSBytesmallint0M>();
                ((ISByteSingleTypesmallint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatSBytesmallint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint)),
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
FROM public.sbytesmallint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ISByteSingleTypesmallint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ISByteSingleTypesmallint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallint0m m
LEFT JOIN public.sbytesmallint0mi mi ON mi.id = m.sbytesmallint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(SBytesmallint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint)),
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
                var models = await ((ISByteSingleTypesmallint)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SBytesmallint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ISByteSingleTypesmallint)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SBytesmallint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSBytesmallint0M), typeof(FlatSBytesmallint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint)),
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
            asPartInterface: typeof(ISByteSingleTypesmallint)),
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
FROM public.sbytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSBytesmallint0M>();
                var models2 = new List<FlatSBytesmallint0M>();
                await((ISByteSingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallint0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
FROM public.sbytesmallint0m m
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
FROM public.sbytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallint0M>();
                var firstItems2 = new List<FlatSBytesmallint0M>();
                var secondItems1 = new List<FlatSBytesmallint0M>();
                var secondItems2 = new List<FlatSBytesmallint0M>();
                await ((ISByteSingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatSBytesmallint0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatSBytesmallint0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[28],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 58;
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
FROM public.sbytesmallint0m m
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
FROM public.sbytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallint0M>();
                var firstItems2 = new List<FlatSBytesmallint0M>();
                var secondItems1 = new List<FlatSBytesmallint0M>();
                await ((ISByteSingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatSBytesmallint0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatSBytesmallint0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[27],_testData[29], false);
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
FROM public.sbytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSBytesmallint0M>();
                var models2 = new List<FlatSBytesmallint0M>();
                ((ISByteSingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallint0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
FROM public.sbytesmallint0m m
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
FROM public.sbytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallint0M>();
                var firstItems2 = new List<FlatSBytesmallint0M>();
                var secondItems1 = new List<FlatSBytesmallint0M>();
                var secondItems2 = new List<FlatSBytesmallint0M>();
                 ((ISByteSingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatSBytesmallint0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatSBytesmallint0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
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
FROM public.sbytesmallint0m m
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
FROM public.sbytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallint0M>();
                var firstItems2 = new List<FlatSBytesmallint0M>();
                var secondItems1 = new List<FlatSBytesmallint0M>();
                 ((ISByteSingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatSBytesmallint0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatSBytesmallint0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[1],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSBytesmallint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint)),
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
            asPartInterface: typeof(ISByteSingleTypesmallint)),
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
FROM public.sbytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ISByteSingleTypesmallint)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 128;
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
FROM public.sbytesmallint0m m
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
FROM public.sbytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISByteSingleTypesmallint)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatSBytesmallint0M.AssertModel(models[0],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(models[1],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(models[2],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(models[3],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatSBytesmallint0M.AssertModel(models[0],_testData[11], false);
                        FlatSBytesmallint0M.AssertModel(models[1],_testData[12], false);
                        FlatSBytesmallint0M.AssertModel(models[2],_testData[13], false);
                        FlatSBytesmallint0M.AssertModel(models[3],_testData[14], false);
                        FlatSBytesmallint0M.AssertModel(models[4],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(models[5],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(models[6],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(models[7],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(models[8],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(models[9],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(models[10],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(models[11],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(models[12],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(models[13],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(models[14],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(models[15],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(models[16],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(models[17],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(models[18],_testData[29], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.sbytesmallint0m m
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
FROM public.sbytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallint0M>();
                var secondItems1 = new List<FlatSBytesmallint0M>();
                var secondItems2 = new List<FlatSBytesmallint0M>();
                await ((ISByteSingleTypesmallint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatSBytesmallint0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatSBytesmallint0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[2],_testData[29], false);
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
FROM public.sbytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ISByteSingleTypesmallint)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.sbytesmallint0m m
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
FROM public.sbytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISByteSingleTypesmallint)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatSBytesmallint0M.AssertModel(models[0],_testData[14], false);
                        FlatSBytesmallint0M.AssertModel(models[1],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(models[2],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(models[3],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(models[4],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(models[5],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(models[6],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(models[7],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(models[8],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(models[9],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(models[10],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(models[11],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(models[12],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(models[13],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(models[14],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatSBytesmallint0M.AssertModel(models[0],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(models[1],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(models[2],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(models[3],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(models[4],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(models[5],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(models[6],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(models[7],_testData[29], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.sbytesmallint0m m
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
FROM public.sbytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallint0M>();
                var secondItems1 = new List<FlatSBytesmallint0M>();
                var secondItems2 = new List<FlatSBytesmallint0M>();
                 ((ISByteSingleTypesmallint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatSBytesmallint0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatSBytesmallint0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[28],_testData[29], false);
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
FROM public.sbytesmallint0m m
LEFT JOIN public.sbytesmallint0mi mi ON mi.id = m.sbytesmallint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(SBytesmallint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint)),
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
                var models = await((ISByteSingleTypesmallint)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SBytesmallint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISByteSingleTypesmallint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        SBytesmallint0M.AssertModel(models[0],_testData[14], false);
                        SBytesmallint0M.AssertModel(models[1],_testData[15], false);
                        SBytesmallint0M.AssertModel(models[2],_testData[16], false);
                        SBytesmallint0M.AssertModel(models[3],_testData[17], false);
                        SBytesmallint0M.AssertModel(models[4],_testData[18], false);
                        SBytesmallint0M.AssertModel(models[5],_testData[19], false);
                        SBytesmallint0M.AssertModel(models[6],_testData[20], false);
                        SBytesmallint0M.AssertModel(models[7],_testData[21], false);
                        SBytesmallint0M.AssertModel(models[8],_testData[22], false);
                        SBytesmallint0M.AssertModel(models[9],_testData[23], false);
                        SBytesmallint0M.AssertModel(models[10],_testData[24], false);
                        SBytesmallint0M.AssertModel(models[11],_testData[25], false);
                        SBytesmallint0M.AssertModel(models[12],_testData[26], false);
                        SBytesmallint0M.AssertModel(models[13],_testData[27], false);
                        SBytesmallint0M.AssertModel(models[14],_testData[28], false);
                        SBytesmallint0M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        SBytesmallint0M.AssertModel(models[0],_testData[26], false);
                        SBytesmallint0M.AssertModel(models[1],_testData[27], false);
                        SBytesmallint0M.AssertModel(models[2],_testData[28], false);
                        SBytesmallint0M.AssertModel(models[3],_testData[29], false);
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
                var models = ((ISByteSingleTypesmallint)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SBytesmallint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISByteSingleTypesmallint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        SBytesmallint0M.AssertModel(models[0],_testData[6], false);
                        SBytesmallint0M.AssertModel(models[1],_testData[7], false);
                        SBytesmallint0M.AssertModel(models[2],_testData[8], false);
                        SBytesmallint0M.AssertModel(models[3],_testData[9], false);
                        SBytesmallint0M.AssertModel(models[4],_testData[10], false);
                        SBytesmallint0M.AssertModel(models[5],_testData[11], false);
                        SBytesmallint0M.AssertModel(models[6],_testData[12], false);
                        SBytesmallint0M.AssertModel(models[7],_testData[13], false);
                        SBytesmallint0M.AssertModel(models[8],_testData[14], false);
                        SBytesmallint0M.AssertModel(models[9],_testData[15], false);
                        SBytesmallint0M.AssertModel(models[10],_testData[16], false);
                        SBytesmallint0M.AssertModel(models[11],_testData[17], false);
                        SBytesmallint0M.AssertModel(models[12],_testData[18], false);
                        SBytesmallint0M.AssertModel(models[13],_testData[19], false);
                        SBytesmallint0M.AssertModel(models[14],_testData[20], false);
                        SBytesmallint0M.AssertModel(models[15],_testData[21], false);
                        SBytesmallint0M.AssertModel(models[16],_testData[22], false);
                        SBytesmallint0M.AssertModel(models[17],_testData[23], false);
                        SBytesmallint0M.AssertModel(models[18],_testData[24], false);
                        SBytesmallint0M.AssertModel(models[19],_testData[25], false);
                        SBytesmallint0M.AssertModel(models[20],_testData[26], false);
                        SBytesmallint0M.AssertModel(models[21],_testData[27], false);
                        SBytesmallint0M.AssertModel(models[22],_testData[28], false);
                        SBytesmallint0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        SBytesmallint0M.AssertModel(models[0],_testData[11], false);
                        SBytesmallint0M.AssertModel(models[1],_testData[12], false);
                        SBytesmallint0M.AssertModel(models[2],_testData[13], false);
                        SBytesmallint0M.AssertModel(models[3],_testData[14], false);
                        SBytesmallint0M.AssertModel(models[4],_testData[15], false);
                        SBytesmallint0M.AssertModel(models[5],_testData[16], false);
                        SBytesmallint0M.AssertModel(models[6],_testData[17], false);
                        SBytesmallint0M.AssertModel(models[7],_testData[18], false);
                        SBytesmallint0M.AssertModel(models[8],_testData[19], false);
                        SBytesmallint0M.AssertModel(models[9],_testData[20], false);
                        SBytesmallint0M.AssertModel(models[10],_testData[21], false);
                        SBytesmallint0M.AssertModel(models[11],_testData[22], false);
                        SBytesmallint0M.AssertModel(models[12],_testData[23], false);
                        SBytesmallint0M.AssertModel(models[13],_testData[24], false);
                        SBytesmallint0M.AssertModel(models[14],_testData[25], false);
                        SBytesmallint0M.AssertModel(models[15],_testData[26], false);
                        SBytesmallint0M.AssertModel(models[16],_testData[27], false);
                        SBytesmallint0M.AssertModel(models[17],_testData[28], false);
                        SBytesmallint0M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSBytesmallint0M), typeof(FlatSBytesmallint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint)),
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
            asPartInterface: typeof(ISByteSingleTypesmallint)),
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
            asPartInterface: typeof(ISByteSingleTypesmallint)),
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
FROM public.sbytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSBytesmallint0M>();
                var models2 = new List<FlatSBytesmallint0M>();
                await((ISByteSingleTypesmallint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.sbytesmallint0m m
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
FROM public.sbytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallint0M>();
                var firstItems2 = new List<FlatSBytesmallint0M>();
                var secondItems1 = new List<FlatSBytesmallint0M>();
                var secondItems2 = new List<FlatSBytesmallint0M>();
                await ((ISByteSingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 64, query1, 30, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatSBytesmallint0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatSBytesmallint0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[23],_testData[29], false);
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
FROM public.sbytesmallint0m m
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
FROM public.sbytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallint0M>();
                var firstItems2 = new List<FlatSBytesmallint0M>();
                var secondItems1 = new List<FlatSBytesmallint0M>();
                await ((ISByteSingleTypesmallint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 27, query1, 19, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatSBytesmallint0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatSBytesmallint0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[26],_testData[29], false);
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
FROM public.sbytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSBytesmallint0M>();
                var models2 = new List<FlatSBytesmallint0M>();
                ((ISByteSingleTypesmallint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.sbytesmallint0m m
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
FROM public.sbytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallint0M>();
                var firstItems2 = new List<FlatSBytesmallint0M>();
                var secondItems1 = new List<FlatSBytesmallint0M>();
                var secondItems2 = new List<FlatSBytesmallint0M>();
                 ((ISByteSingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 100, query1, 19, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatSBytesmallint0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatSBytesmallint0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[26],_testData[29], false);
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
FROM public.sbytesmallint0m m
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
FROM public.sbytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallint0M>();
                var firstItems2 = new List<FlatSBytesmallint0M>();
                var secondItems1 = new List<FlatSBytesmallint0M>();
                 ((ISByteSingleTypesmallint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 9, query1, 109, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatSBytesmallint0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatSBytesmallint0M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatSBytesmallint0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[9],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSBytesmallint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint)),
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
            asPartInterface: typeof(ISByteSingleTypesmallint)),
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
            asPartInterface: typeof(ISByteSingleTypesmallint)),
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
FROM public.sbytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ISByteSingleTypesmallint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallint0m m
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
FROM public.sbytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISByteSingleTypesmallint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 82, query1, 75, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatSBytesmallint0M.AssertModel(models[0],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(models[1],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(models[2],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(models[3],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(models[4],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(models[5],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(models[6],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(models[7],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(models[8],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(models[9],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(models[10],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(models[11],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(models[12],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(models[13],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatSBytesmallint0M.AssertModel(models[0],_testData[14], false);
                        FlatSBytesmallint0M.AssertModel(models[1],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(models[2],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(models[3],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(models[4],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(models[5],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(models[6],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(models[7],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(models[8],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(models[9],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(models[10],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(models[11],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(models[12],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(models[13],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(models[14],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(models[15],_testData[29], false);
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
FROM public.sbytesmallint0m m
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
FROM public.sbytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallint0M>();
                var secondItems1 = new List<FlatSBytesmallint0M>();
                var secondItems2 = new List<FlatSBytesmallint0M>();
                await ((ISByteSingleTypesmallint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 9, query1, 58, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatSBytesmallint0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatSBytesmallint0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[18],_testData[29], false);
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
FROM public.sbytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ISByteSingleTypesmallint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSBytesmallint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.sbytesmallint0m m
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
FROM public.sbytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISByteSingleTypesmallint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 49, query1, 114, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatSBytesmallint0M.AssertModel(models[0],_testData[10], false);
                        FlatSBytesmallint0M.AssertModel(models[1],_testData[11], false);
                        FlatSBytesmallint0M.AssertModel(models[2],_testData[12], false);
                        FlatSBytesmallint0M.AssertModel(models[3],_testData[13], false);
                        FlatSBytesmallint0M.AssertModel(models[4],_testData[14], false);
                        FlatSBytesmallint0M.AssertModel(models[5],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(models[6],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(models[7],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(models[8],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(models[9],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(models[10],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(models[11],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(models[12],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(models[13],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(models[14],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(models[15],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(models[16],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(models[17],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(models[18],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatSBytesmallint0M.AssertModel(models[0],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(models[1],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(models[2],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(models[3],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(models[4],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(models[5],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(models[6],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(models[7],_testData[29], false);
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
FROM public.sbytesmallint0m m
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
FROM public.sbytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSBytesmallint0M>();
                var secondItems1 = new List<FlatSBytesmallint0M>();
                var secondItems2 = new List<FlatSBytesmallint0M>();
                 ((ISByteSingleTypesmallint)this).DbConnectionDynQuerySelectModelBatch(connection, 128, query1, 9, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatSBytesmallint0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatSBytesmallint0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatSBytesmallint0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatSBytesmallint0M.AssertModel(secondItems2[28],_testData[29], false);
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
FROM public.sbytesmallint0m m
LEFT JOIN public.sbytesmallint0mi mi ON mi.id = m.sbytesmallint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(SBytesmallint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint)),
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
            asPartInterface: typeof(ISByteSingleTypesmallint)),
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
                var models = await((ISByteSingleTypesmallint)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SBytesmallint0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ISByteSingleTypesmallint)this).DbConnectionSTSelectModelBatchAsync(connection, 124, 121))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        SBytesmallint0M.AssertModel(models[0],_testData[24], false);
                        SBytesmallint0M.AssertModel(models[1],_testData[25], false);
                        SBytesmallint0M.AssertModel(models[2],_testData[26], false);
                        SBytesmallint0M.AssertModel(models[3],_testData[27], false);
                        SBytesmallint0M.AssertModel(models[4],_testData[28], false);
                        SBytesmallint0M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        SBytesmallint0M.AssertModel(models[0],_testData[23], false);
                        SBytesmallint0M.AssertModel(models[1],_testData[24], false);
                        SBytesmallint0M.AssertModel(models[2],_testData[25], false);
                        SBytesmallint0M.AssertModel(models[3],_testData[26], false);
                        SBytesmallint0M.AssertModel(models[4],_testData[27], false);
                        SBytesmallint0M.AssertModel(models[5],_testData[28], false);
                        SBytesmallint0M.AssertModel(models[6],_testData[29], false);
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
                var models = ((ISByteSingleTypesmallint)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SBytesmallint0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ISByteSingleTypesmallint)this).DbConnectionSTSelectModelBatch(connection, 114, 124))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        SBytesmallint0M.AssertModel(models[0],_testData[22], false);
                        SBytesmallint0M.AssertModel(models[1],_testData[23], false);
                        SBytesmallint0M.AssertModel(models[2],_testData[24], false);
                        SBytesmallint0M.AssertModel(models[3],_testData[25], false);
                        SBytesmallint0M.AssertModel(models[4],_testData[26], false);
                        SBytesmallint0M.AssertModel(models[5],_testData[27], false);
                        SBytesmallint0M.AssertModel(models[6],_testData[28], false);
                        SBytesmallint0M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        SBytesmallint0M.AssertModel(models[0],_testData[24], false);
                        SBytesmallint0M.AssertModel(models[1],_testData[25], false);
                        SBytesmallint0M.AssertModel(models[2],_testData[26], false);
                        SBytesmallint0M.AssertModel(models[3],_testData[27], false);
                        SBytesmallint0M.AssertModel(models[4],_testData[28], false);
                        SBytesmallint0M.AssertModel(models[5],_testData[29], false);
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
                await using var cmd = await ((ISByteSingleTypesmallint)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ISByteSingleTypesmallint)this).SetDbConnectionSelectModelParametrs(cmd, 49);
                var models = await ((ISByteSingleTypesmallint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
SBytesmallint0M.AssertModel(models[0],_testData[10], false);SBytesmallint0M.AssertModel(models[1],_testData[11], false);SBytesmallint0M.AssertModel(models[2],_testData[12], false);SBytesmallint0M.AssertModel(models[3],_testData[13], false);SBytesmallint0M.AssertModel(models[4],_testData[14], false);SBytesmallint0M.AssertModel(models[5],_testData[15], false);SBytesmallint0M.AssertModel(models[6],_testData[16], false);SBytesmallint0M.AssertModel(models[7],_testData[17], false);SBytesmallint0M.AssertModel(models[8],_testData[18], false);SBytesmallint0M.AssertModel(models[9],_testData[19], false);SBytesmallint0M.AssertModel(models[10],_testData[20], false);SBytesmallint0M.AssertModel(models[11],_testData[21], false);SBytesmallint0M.AssertModel(models[12],_testData[22], false);SBytesmallint0M.AssertModel(models[13],_testData[23], false);SBytesmallint0M.AssertModel(models[14],_testData[24], false);SBytesmallint0M.AssertModel(models[15],_testData[25], false);SBytesmallint0M.AssertModel(models[16],_testData[26], false);SBytesmallint0M.AssertModel(models[17],_testData[27], false);SBytesmallint0M.AssertModel(models[18],_testData[28], false);SBytesmallint0M.AssertModel(models[19],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISByteSingleTypesmallint)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISByteSingleTypesmallint)this).SetDbConnectionSelectModelParametrs(cmd, 111);
                var models =  ((ISByteSingleTypesmallint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
SBytesmallint0M.AssertModel(models[0],_testData[21], false);SBytesmallint0M.AssertModel(models[1],_testData[22], false);SBytesmallint0M.AssertModel(models[2],_testData[23], false);SBytesmallint0M.AssertModel(models[3],_testData[24], false);SBytesmallint0M.AssertModel(models[4],_testData[25], false);SBytesmallint0M.AssertModel(models[5],_testData[26], false);SBytesmallint0M.AssertModel(models[6],_testData[27], false);SBytesmallint0M.AssertModel(models[7],_testData[28], false);SBytesmallint0M.AssertModel(models[8],_testData[29], false);
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
FROM public.sbytesmallint0m m
LEFT JOIN public.sbytesmallint0mi mi ON mi.id = m.sbytesmallint0mi_id
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
            asPartInterface: typeof(ISByteSingleTypesmallint))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISByteSingleTypesmallint)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((35)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((85)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((96)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((-46)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((50)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((75)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((95)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((28)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-75)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-3)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((-97)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((25)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((10)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-116)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((-68)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-99)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((94)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((33)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((-67)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((76)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-53)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((-2)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((7)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((75)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((-22)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-94)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((3)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((50)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((45)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((33)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-121)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((-58)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((25)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-3)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-109)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((-102)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((-93)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((94)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((17)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-13)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((55)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-37)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((118)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-35)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((120)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((-62)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-69)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-114)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((101)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((50)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((81)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((-51)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-14)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((107)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((101)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((26)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((110)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-4)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((-122)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((-19)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((-42)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-9)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((-58)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-72)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((80)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((-38)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((77)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((67)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((124)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((-68)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((ISByteSingleTypesmallint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((35)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((85)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((96)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((-46)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((50)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((75)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((95)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((28)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-75)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-3)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((-97)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((25)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((10)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-116)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((-68)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-99)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((94)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((33)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((-67)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((76)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-53)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((-2)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((7)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((75)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((-22)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-94)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((3)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((50)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((45)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((33)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-121)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((-58)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((25)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-3)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-109)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((-102)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((-93)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((94)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((17)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-13)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((55)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-37)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((118)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-35)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((120)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((-62)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-69)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-114)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((101)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((50)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((81)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((-51)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-14)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((107)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((101)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((26)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((110)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-4)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((-122)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((-19)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((-42)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-9)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((-58)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((-72)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((80)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((-38)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((77)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((67)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((124)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((-68)));

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
FROM public.binary_sbytesmallint0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(SBytesmallint0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(SBytesmallint0MIWA),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18),
                (NpgsqlTypes.NpgsqlDbType)(18)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SBytesmallint0MIWA>(2);
                for (int i = 0; i < 6; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SBytesmallint0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISByteSingleTypesmallint)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_sbytesmallint0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISByteSingleTypesmallint)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallint0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(0)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<SBytesmallint0MIWA>(2);
                for (int i = 4; i < 10; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SBytesmallint0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISByteSingleTypesmallint)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_sbytesmallint0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISByteSingleTypesmallint)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallint0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_sbytesmallint0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(SBytesmallint0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_sbytesmallint0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(SBytesmallint0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18),
                (NpgsqlTypes.NpgsqlDbType)(18)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SBytesmallint0MI>(2);
                for (int i = 8; i < 14; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ISByteSingleTypesmallint)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ISByteSingleTypesmallint)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallint0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(0)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<SBytesmallint0MI>(2);
                for (int i = 12; i < 18; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ISByteSingleTypesmallint)this).ImportModelInner(connection, importCollection);
                var models = ((ISByteSingleTypesmallint)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SBytesmallint0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_sbytesmallint0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
sbytesmallint0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(SBytesmallint0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint))]
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
FROM public.binary_sbytesmallint0m m
LEFT JOIN public.binary_sbytesmallint0mi mi ON mi.id = m.sbytesmallint0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(SBytesmallint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<SBytesmallint0M>(15);

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
                ((ISByteSingleTypesmallint)this).ImportModel(connection, importCollection);
                var models = ((ISByteSingleTypesmallint)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                SBytesmallint0M.AssertModel(models[0],_testData[0], false);
                SBytesmallint0M.AssertModel(models[1],_testData[1], false);
                SBytesmallint0M.AssertModel(models[2],_testData[2], false);
                SBytesmallint0M.AssertModel(models[3],_testData[3], false);
                SBytesmallint0M.AssertModel(models[4],_testData[4], false);
                SBytesmallint0M.AssertModel(models[5],_testData[5], false);
                SBytesmallint0M.AssertModel(models[6],_testData[6], false);
                SBytesmallint0M.AssertModel(models[7],_testData[7], false);
                SBytesmallint0M.AssertModel(models[8],_testData[8], false);
                SBytesmallint0M.AssertModel(models[9],_testData[9], false);
                SBytesmallint0M.AssertModel(models[10],_testData[10], false);
                SBytesmallint0M.AssertModel(models[11],_testData[11], false);
                SBytesmallint0M.AssertModel(models[12],_testData[12], false);
                SBytesmallint0M.AssertModel(models[13],_testData[13], false);
                SBytesmallint0M.AssertModel(models[14],_testData[14], false);
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
                await ((ISByteSingleTypesmallint)this).ImportModelAsync(connection, importCollection);
                models = await ((ISByteSingleTypesmallint)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                SBytesmallint0M.AssertModel(models[0],_testData[0], false);
                SBytesmallint0M.AssertModel(models[1],_testData[1], false);
                SBytesmallint0M.AssertModel(models[2],_testData[2], false);
                SBytesmallint0M.AssertModel(models[3],_testData[3], false);
                SBytesmallint0M.AssertModel(models[4],_testData[4], false);
                SBytesmallint0M.AssertModel(models[5],_testData[5], false);
                SBytesmallint0M.AssertModel(models[6],_testData[6], false);
                SBytesmallint0M.AssertModel(models[7],_testData[7], false);
                SBytesmallint0M.AssertModel(models[8],_testData[8], false);
                SBytesmallint0M.AssertModel(models[9],_testData[9], false);
                SBytesmallint0M.AssertModel(models[10],_testData[10], false);
                SBytesmallint0M.AssertModel(models[11],_testData[11], false);
                SBytesmallint0M.AssertModel(models[12],_testData[12], false);
                SBytesmallint0M.AssertModel(models[13],_testData[13], false);
                SBytesmallint0M.AssertModel(models[14],_testData[14], false);
                SBytesmallint0M.AssertModel(models[15],_testData[15], false);
                SBytesmallint0M.AssertModel(models[16],_testData[16], false);
                SBytesmallint0M.AssertModel(models[17],_testData[17], false);
                SBytesmallint0M.AssertModel(models[18],_testData[18], false);
                SBytesmallint0M.AssertModel(models[19],_testData[19], false);
                SBytesmallint0M.AssertModel(models[20],_testData[20], false);
                SBytesmallint0M.AssertModel(models[21],_testData[21], false);
                SBytesmallint0M.AssertModel(models[22],_testData[22], false);
                SBytesmallint0M.AssertModel(models[23],_testData[23], false);
                SBytesmallint0M.AssertModel(models[24],_testData[24], false);
                SBytesmallint0M.AssertModel(models[25],_testData[25], false);
                SBytesmallint0M.AssertModel(models[26],_testData[26], false);
                SBytesmallint0M.AssertModel(models[27],_testData[27], false);
                SBytesmallint0M.AssertModel(models[28],_testData[28], false);
                SBytesmallint0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_sbytesmallint0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    sbytesmallint0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(SBytesmallint0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ISByteSingleTypesmallint)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SBytesmallint0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISByteSingleTypesmallint)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SBytesmallint0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_sbytesmallint0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(SBytesmallint0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18),
                (NpgsqlTypes.NpgsqlDbType)(18)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypesmallint))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ISByteSingleTypesmallint)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SBytesmallint0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISByteSingleTypesmallint)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SBytesmallint0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

