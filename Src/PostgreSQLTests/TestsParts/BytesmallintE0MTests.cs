

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
    internal partial interface IByteSingleTypesmallint
    {
    }
    
    internal partial class ByteSingleTypesmallint : IByteSingleTypesmallint
    {


#region TestData

        private readonly BytesmallintE0M[] _testData = new BytesmallintE0M[]
        {
            new BytesmallintE0M
{
    Id = 3,
    Value = 168,
    ModelInner = null,
    NullableValue = 115,
},
            new BytesmallintE0M
{
    Id = 10,
    Value = 177,
    ModelInner = new BytesmallintE0MI
{
    Id = 4,
    Value = 205,
    NullableValue = null,
},
    NullableValue = 60,
},
            new BytesmallintE0M
{
    Id = 13,
    Value = 217,
    ModelInner = null,
    NullableValue = 121,
},
            new BytesmallintE0M
{
    Id = 14,
    Value = 171,
    ModelInner = new BytesmallintE0MI
{
    Id = 8,
    Value = 40,
    NullableValue = null,
},
    NullableValue = null,
},
            new BytesmallintE0M
{
    Id = 18,
    Value = 178,
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintE0M
{
    Id = 20,
    Value = 119,
    ModelInner = new BytesmallintE0MI
{
    Id = 15,
    Value = 49,
    NullableValue = null,
},
    NullableValue = 98,
},
            new BytesmallintE0M
{
    Id = 21,
    Value = 245,
    ModelInner = null,
    NullableValue = 18,
},
            new BytesmallintE0M
{
    Id = 30,
    Value = 70,
    ModelInner = new BytesmallintE0MI
{
    Id = 17,
    Value = 75,
    NullableValue = 74,
},
    NullableValue = null,
},
            new BytesmallintE0M
{
    Id = 39,
    Value = 83,
    ModelInner = null,
    NullableValue = 37,
},
            new BytesmallintE0M
{
    Id = 43,
    Value = 41,
    ModelInner = new BytesmallintE0MI
{
    Id = 24,
    Value = 154,
    NullableValue = null,
},
    NullableValue = 84,
},
            new BytesmallintE0M
{
    Id = 47,
    Value = 148,
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintE0M
{
    Id = 53,
    Value = 106,
    ModelInner = new BytesmallintE0MI
{
    Id = 30,
    Value = 56,
    NullableValue = null,
},
    NullableValue = 45,
},
            new BytesmallintE0M
{
    Id = 56,
    Value = 210,
    ModelInner = null,
    NullableValue = 110,
},
            new BytesmallintE0M
{
    Id = 60,
    Value = 54,
    ModelInner = new BytesmallintE0MI
{
    Id = 39,
    Value = 64,
    NullableValue = null,
},
    NullableValue = 47,
},
            new BytesmallintE0M
{
    Id = 63,
    Value = 216,
    ModelInner = null,
    NullableValue = 228,
},
            new BytesmallintE0M
{
    Id = 70,
    Value = 91,
    ModelInner = new BytesmallintE0MI
{
    Id = 45,
    Value = 199,
    NullableValue = null,
},
    NullableValue = 225,
},
            new BytesmallintE0M
{
    Id = 72,
    Value = 126,
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintE0M
{
    Id = 78,
    Value = 34,
    ModelInner = new BytesmallintE0MI
{
    Id = 47,
    Value = 172,
    NullableValue = null,
},
    NullableValue = null,
},
            new BytesmallintE0M
{
    Id = 83,
    Value = 241,
    ModelInner = null,
    NullableValue = 133,
},
            new BytesmallintE0M
{
    Id = 88,
    Value = 21,
    ModelInner = new BytesmallintE0MI
{
    Id = 55,
    Value = 36,
    NullableValue = null,
},
    NullableValue = 34,
},
            new BytesmallintE0M
{
    Id = 89,
    Value = 200,
    ModelInner = null,
    NullableValue = 99,
},
            new BytesmallintE0M
{
    Id = 96,
    Value = 158,
    ModelInner = new BytesmallintE0MI
{
    Id = 62,
    Value = 226,
    NullableValue = null,
},
    NullableValue = 124,
},
            new BytesmallintE0M
{
    Id = 102,
    Value = 171,
    ModelInner = null,
    NullableValue = 141,
},
            new BytesmallintE0M
{
    Id = 111,
    Value = 232,
    ModelInner = new BytesmallintE0MI
{
    Id = 70,
    Value = 180,
    NullableValue = 125,
},
    NullableValue = 182,
},
            new BytesmallintE0M
{
    Id = 119,
    Value = 9,
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintE0M
{
    Id = 126,
    Value = 66,
    ModelInner = new BytesmallintE0MI
{
    Id = 73,
    Value = 109,
    NullableValue = 160,
},
    NullableValue = null,
},
            new BytesmallintE0M
{
    Id = 133,
    Value = 56,
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintE0M
{
    Id = 139,
    Value = 20,
    ModelInner = new BytesmallintE0MI
{
    Id = 82,
    Value = 96,
    NullableValue = null,
},
    NullableValue = null,
},
            new BytesmallintE0M
{
    Id = 144,
    Value = 182,
    ModelInner = null,
    NullableValue = 16,
},
            new BytesmallintE0M
{
    Id = 146,
    Value = 57,
    ModelInner = new BytesmallintE0MI
{
    Id = 90,
    Value = 51,
    NullableValue = 37,
},
    NullableValue = 203,
},
            new BytesmallintE0M
{
    Id = 148,
    Value = 14,
    ModelInner = null,
    NullableValue = null,
},
            new BytesmallintE0M
{
    Id = 149,
    Value = 246,
    ModelInner = new BytesmallintE0MI
{
    Id = 94,
    Value = 0,
    NullableValue = 43,
},
    NullableValue = 92,
},
            new BytesmallintE0M
{
    Id = 150,
    Value = 126,
    ModelInner = null,
    NullableValue = 29,
},
            new BytesmallintE0M
{
    Id = 151,
    Value = 227,
    ModelInner = new BytesmallintE0MI
{
    Id = 95,
    Value = 82,
    NullableValue = null,
},
    NullableValue = 186,
},
            new BytesmallintE0M
{
    Id = 154,
    Value = 64,
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bytesmallinte0mi(
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
            asPartInterface: typeof(IByteSingleTypesmallint)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Byte),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Byte?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bytesmallinte0mi(
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
            queryMapTypes: [typeof(BytesmallintE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Byte),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Byte?), 
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

                changedRows =  ((IByteSingleTypesmallint)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IByteSingleTypesmallint)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IByteSingleTypesmallint)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IByteSingleTypesmallint)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IByteSingleTypesmallint)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IByteSingleTypesmallint)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IByteSingleTypesmallint)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.bytesmallinte0mi(
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
            asPartInterface: typeof(IByteSingleTypesmallint)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Byte), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(10)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Byte?), 
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

                changedRows =  ((IByteSingleTypesmallint)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bytesmallinte0m(
	id,
    value,
    nullablevalue,
    bytesmallinte0mi_id
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
            asPartInterface: typeof(IByteSingleTypesmallint)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Byte),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Byte?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bytesmallinte0mi_id", 
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
                changedRows =  ((IByteSingleTypesmallint)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IByteSingleTypesmallint)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IByteSingleTypesmallint)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IByteSingleTypesmallint)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bytesmallinte0m(
	id,
    value,
    nullablevalue,
    bytesmallinte0mi_id
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
    bytesmallinte0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BytesmallintE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint)),
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
INSERT INTO public.bytesmallinte0m(
	id,
    value,
    nullablevalue,
    bytesmallinte0mi_id
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
    bytesmallinte0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BytesmallintE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Byte),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Byte?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bytesmallinte0mi_id", 
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
                List<BytesmallintE0M> models = null;

                models =  ((IByteSingleTypesmallint)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintE0M.AssertModel(models[0],_testData[4], true);
                models =  ((IByteSingleTypesmallint)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintE0M.AssertModel(models[0],_testData[5], true);
                models =  ((IByteSingleTypesmallint)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintE0M.AssertModel(models[0],_testData[6], true);
                models =  ((IByteSingleTypesmallint)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintE0M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BytesmallintE0M> models = null;

                models = await ((IByteSingleTypesmallint)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintE0M.AssertModel(models[0],_testData[8], true);
                models = await ((IByteSingleTypesmallint)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintE0M.AssertModel(models[0],_testData[9], true);
                models = await ((IByteSingleTypesmallint)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintE0M.AssertModel(models[0],_testData[10], true);
                models = await ((IByteSingleTypesmallint)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BytesmallintE0M.AssertModel(models[0],_testData[11], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.bytesmallinte0m(
	id,
    value,
    nullablevalue,
    bytesmallinte0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @bytesmallinte0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Byte), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(10)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Byte?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(10),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "bytesmallinte0mi_id", 
                methodParametrName: "bytesmallinte0mi_id", 
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

                changedRows =  ((IByteSingleTypesmallint)this).DbConnectionInsertModel(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IByteSingleTypesmallint)this).DbConnectionInsertModel(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
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

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytesmallintE0M), typeof(FlatBytesmallintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint)),
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
FROM public.bytesmallinte0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBytesmallintE0M>();
                var models2 = new List<FlatBytesmallintE0M>();
                await ((IByteSingleTypesmallint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBytesmallintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bytesmallinte0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBytesmallintE0M>();
                var models2 = new List<FlatBytesmallintE0M>();
                ((IByteSingleTypesmallint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBytesmallintE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytesmallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint)),
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
FROM public.bytesmallinte0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IByteSingleTypesmallint)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallinte0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IByteSingleTypesmallint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallinte0m m
LEFT JOIN public.bytesmallinte0mi mi ON mi.id = m.bytesmallinte0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BytesmallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint)),
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
                var models = await ((IByteSingleTypesmallint)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BytesmallintE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IByteSingleTypesmallint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BytesmallintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytesmallintE0M), typeof(FlatBytesmallintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint)),
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
FROM public.bytesmallinte0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytesmallintE0M>();
                var models2 = new List<FlatBytesmallintE0M>();
                await ((IByteSingleTypesmallint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBytesmallintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bytesmallinte0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytesmallintE0M>();
                var models2 = new List<FlatBytesmallintE0M>();
                ((IByteSingleTypesmallint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBytesmallintE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytesmallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint)),
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
FROM public.bytesmallinte0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IByteSingleTypesmallint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallinte0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IByteSingleTypesmallint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallinte0m m
LEFT JOIN public.bytesmallinte0mi mi ON mi.id = m.bytesmallinte0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BytesmallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint)),
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
                var models = await ((IByteSingleTypesmallint)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BytesmallintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IByteSingleTypesmallint)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BytesmallintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytesmallintE0M), typeof(FlatBytesmallintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint)),
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
            asPartInterface: typeof(IByteSingleTypesmallint)),
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
FROM public.bytesmallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBytesmallintE0M>();
                var models2 = new List<FlatBytesmallintE0M>();
                await((IByteSingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBytesmallintE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
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
FROM public.bytesmallinte0m m
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
FROM public.bytesmallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintE0M>();
                var firstItems2 = new List<FlatBytesmallintE0M>();
                var secondItems1 = new List<FlatBytesmallintE0M>();
                var secondItems2 = new List<FlatBytesmallintE0M>();
                await ((IByteSingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatBytesmallintE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatBytesmallintE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
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
FROM public.bytesmallinte0m m
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
FROM public.bytesmallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintE0M>();
                var firstItems2 = new List<FlatBytesmallintE0M>();
                var secondItems1 = new List<FlatBytesmallintE0M>();
                await ((IByteSingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatBytesmallintE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatBytesmallintE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[3],_testData[34], false);
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
FROM public.bytesmallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBytesmallintE0M>();
                var models2 = new List<FlatBytesmallintE0M>();
                ((IByteSingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBytesmallintE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
FROM public.bytesmallinte0m m
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
FROM public.bytesmallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintE0M>();
                var firstItems2 = new List<FlatBytesmallintE0M>();
                var secondItems1 = new List<FlatBytesmallintE0M>();
                var secondItems2 = new List<FlatBytesmallintE0M>();
                 ((IByteSingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatBytesmallintE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatBytesmallintE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
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
FROM public.bytesmallinte0m m
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
FROM public.bytesmallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintE0M>();
                var firstItems2 = new List<FlatBytesmallintE0M>();
                var secondItems1 = new List<FlatBytesmallintE0M>();
                 ((IByteSingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatBytesmallintE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatBytesmallintE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[8],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytesmallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint)),
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
            asPartInterface: typeof(IByteSingleTypesmallint)),
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
FROM public.bytesmallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IByteSingleTypesmallint)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bytesmallinte0m m
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
FROM public.bytesmallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IByteSingleTypesmallint)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatBytesmallintE0M.AssertModel(models[0],_testData[2], false);
                        FlatBytesmallintE0M.AssertModel(models[1],_testData[3], false);
                        FlatBytesmallintE0M.AssertModel(models[2],_testData[4], false);
                        FlatBytesmallintE0M.AssertModel(models[3],_testData[5], false);
                        FlatBytesmallintE0M.AssertModel(models[4],_testData[6], false);
                        FlatBytesmallintE0M.AssertModel(models[5],_testData[7], false);
                        FlatBytesmallintE0M.AssertModel(models[6],_testData[8], false);
                        FlatBytesmallintE0M.AssertModel(models[7],_testData[9], false);
                        FlatBytesmallintE0M.AssertModel(models[8],_testData[10], false);
                        FlatBytesmallintE0M.AssertModel(models[9],_testData[11], false);
                        FlatBytesmallintE0M.AssertModel(models[10],_testData[12], false);
                        FlatBytesmallintE0M.AssertModel(models[11],_testData[13], false);
                        FlatBytesmallintE0M.AssertModel(models[12],_testData[14], false);
                        FlatBytesmallintE0M.AssertModel(models[13],_testData[15], false);
                        FlatBytesmallintE0M.AssertModel(models[14],_testData[16], false);
                        FlatBytesmallintE0M.AssertModel(models[15],_testData[17], false);
                        FlatBytesmallintE0M.AssertModel(models[16],_testData[18], false);
                        FlatBytesmallintE0M.AssertModel(models[17],_testData[19], false);
                        FlatBytesmallintE0M.AssertModel(models[18],_testData[20], false);
                        FlatBytesmallintE0M.AssertModel(models[19],_testData[21], false);
                        FlatBytesmallintE0M.AssertModel(models[20],_testData[22], false);
                        FlatBytesmallintE0M.AssertModel(models[21],_testData[23], false);
                        FlatBytesmallintE0M.AssertModel(models[22],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(models[23],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(models[24],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(models[25],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(models[26],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(models[27],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(models[28],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(models[29],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(models[30],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(models[31],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatBytesmallintE0M.AssertModel(models[0],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(models[1],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(models[2],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(models[3],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(models[4],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(models[5],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(models[6],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(models[7],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(models[8],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bytesmallinte0m m
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
FROM public.bytesmallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintE0M>();
                var secondItems1 = new List<FlatBytesmallintE0M>();
                var secondItems2 = new List<FlatBytesmallintE0M>();
                await ((IByteSingleTypesmallint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatBytesmallintE0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatBytesmallintE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.bytesmallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IByteSingleTypesmallint)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bytesmallinte0m m
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
FROM public.bytesmallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IByteSingleTypesmallint)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatBytesmallintE0M.AssertModel(models[0],_testData[17], false);
                        FlatBytesmallintE0M.AssertModel(models[1],_testData[18], false);
                        FlatBytesmallintE0M.AssertModel(models[2],_testData[19], false);
                        FlatBytesmallintE0M.AssertModel(models[3],_testData[20], false);
                        FlatBytesmallintE0M.AssertModel(models[4],_testData[21], false);
                        FlatBytesmallintE0M.AssertModel(models[5],_testData[22], false);
                        FlatBytesmallintE0M.AssertModel(models[6],_testData[23], false);
                        FlatBytesmallintE0M.AssertModel(models[7],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(models[8],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(models[9],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(models[10],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(models[11],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(models[12],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(models[13],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(models[14],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(models[15],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(models[16],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatBytesmallintE0M.AssertModel(models[0],_testData[8], false);
                        FlatBytesmallintE0M.AssertModel(models[1],_testData[9], false);
                        FlatBytesmallintE0M.AssertModel(models[2],_testData[10], false);
                        FlatBytesmallintE0M.AssertModel(models[3],_testData[11], false);
                        FlatBytesmallintE0M.AssertModel(models[4],_testData[12], false);
                        FlatBytesmallintE0M.AssertModel(models[5],_testData[13], false);
                        FlatBytesmallintE0M.AssertModel(models[6],_testData[14], false);
                        FlatBytesmallintE0M.AssertModel(models[7],_testData[15], false);
                        FlatBytesmallintE0M.AssertModel(models[8],_testData[16], false);
                        FlatBytesmallintE0M.AssertModel(models[9],_testData[17], false);
                        FlatBytesmallintE0M.AssertModel(models[10],_testData[18], false);
                        FlatBytesmallintE0M.AssertModel(models[11],_testData[19], false);
                        FlatBytesmallintE0M.AssertModel(models[12],_testData[20], false);
                        FlatBytesmallintE0M.AssertModel(models[13],_testData[21], false);
                        FlatBytesmallintE0M.AssertModel(models[14],_testData[22], false);
                        FlatBytesmallintE0M.AssertModel(models[15],_testData[23], false);
                        FlatBytesmallintE0M.AssertModel(models[16],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(models[17],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(models[18],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(models[19],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(models[20],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(models[21],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(models[22],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(models[23],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(models[24],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(models[25],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bytesmallinte0m m
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
FROM public.bytesmallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintE0M>();
                var secondItems1 = new List<FlatBytesmallintE0M>();
                var secondItems2 = new List<FlatBytesmallintE0M>();
                 ((IByteSingleTypesmallint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatBytesmallintE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatBytesmallintE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.bytesmallinte0m m
LEFT JOIN public.bytesmallinte0mi mi ON mi.id = m.bytesmallinte0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BytesmallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint)),
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
                var models = await((IByteSingleTypesmallint)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BytesmallintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IByteSingleTypesmallint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        BytesmallintE0M.AssertModel(models[0],_testData[26], false);
                        BytesmallintE0M.AssertModel(models[1],_testData[27], false);
                        BytesmallintE0M.AssertModel(models[2],_testData[28], false);
                        BytesmallintE0M.AssertModel(models[3],_testData[29], false);
                        BytesmallintE0M.AssertModel(models[4],_testData[30], false);
                        BytesmallintE0M.AssertModel(models[5],_testData[31], false);
                        BytesmallintE0M.AssertModel(models[6],_testData[32], false);
                        BytesmallintE0M.AssertModel(models[7],_testData[33], false);
                        BytesmallintE0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        BytesmallintE0M.AssertModel(models[0],_testData[22], false);
                        BytesmallintE0M.AssertModel(models[1],_testData[23], false);
                        BytesmallintE0M.AssertModel(models[2],_testData[24], false);
                        BytesmallintE0M.AssertModel(models[3],_testData[25], false);
                        BytesmallintE0M.AssertModel(models[4],_testData[26], false);
                        BytesmallintE0M.AssertModel(models[5],_testData[27], false);
                        BytesmallintE0M.AssertModel(models[6],_testData[28], false);
                        BytesmallintE0M.AssertModel(models[7],_testData[29], false);
                        BytesmallintE0M.AssertModel(models[8],_testData[30], false);
                        BytesmallintE0M.AssertModel(models[9],_testData[31], false);
                        BytesmallintE0M.AssertModel(models[10],_testData[32], false);
                        BytesmallintE0M.AssertModel(models[11],_testData[33], false);
                        BytesmallintE0M.AssertModel(models[12],_testData[34], false);
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
                var models = ((IByteSingleTypesmallint)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BytesmallintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IByteSingleTypesmallint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        BytesmallintE0M.AssertModel(models[0],_testData[5], false);
                        BytesmallintE0M.AssertModel(models[1],_testData[6], false);
                        BytesmallintE0M.AssertModel(models[2],_testData[7], false);
                        BytesmallintE0M.AssertModel(models[3],_testData[8], false);
                        BytesmallintE0M.AssertModel(models[4],_testData[9], false);
                        BytesmallintE0M.AssertModel(models[5],_testData[10], false);
                        BytesmallintE0M.AssertModel(models[6],_testData[11], false);
                        BytesmallintE0M.AssertModel(models[7],_testData[12], false);
                        BytesmallintE0M.AssertModel(models[8],_testData[13], false);
                        BytesmallintE0M.AssertModel(models[9],_testData[14], false);
                        BytesmallintE0M.AssertModel(models[10],_testData[15], false);
                        BytesmallintE0M.AssertModel(models[11],_testData[16], false);
                        BytesmallintE0M.AssertModel(models[12],_testData[17], false);
                        BytesmallintE0M.AssertModel(models[13],_testData[18], false);
                        BytesmallintE0M.AssertModel(models[14],_testData[19], false);
                        BytesmallintE0M.AssertModel(models[15],_testData[20], false);
                        BytesmallintE0M.AssertModel(models[16],_testData[21], false);
                        BytesmallintE0M.AssertModel(models[17],_testData[22], false);
                        BytesmallintE0M.AssertModel(models[18],_testData[23], false);
                        BytesmallintE0M.AssertModel(models[19],_testData[24], false);
                        BytesmallintE0M.AssertModel(models[20],_testData[25], false);
                        BytesmallintE0M.AssertModel(models[21],_testData[26], false);
                        BytesmallintE0M.AssertModel(models[22],_testData[27], false);
                        BytesmallintE0M.AssertModel(models[23],_testData[28], false);
                        BytesmallintE0M.AssertModel(models[24],_testData[29], false);
                        BytesmallintE0M.AssertModel(models[25],_testData[30], false);
                        BytesmallintE0M.AssertModel(models[26],_testData[31], false);
                        BytesmallintE0M.AssertModel(models[27],_testData[32], false);
                        BytesmallintE0M.AssertModel(models[28],_testData[33], false);
                        BytesmallintE0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        BytesmallintE0M.AssertModel(models[0],_testData[32], false);
                        BytesmallintE0M.AssertModel(models[1],_testData[33], false);
                        BytesmallintE0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytesmallintE0M), typeof(FlatBytesmallintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint)),
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
            asPartInterface: typeof(IByteSingleTypesmallint)),
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
            asPartInterface: typeof(IByteSingleTypesmallint)),
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
FROM public.bytesmallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytesmallintE0M>();
                var models2 = new List<FlatBytesmallintE0M>();
                await((IByteSingleTypesmallint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBytesmallintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bytesmallinte0m m
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
FROM public.bytesmallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintE0M>();
                var firstItems2 = new List<FlatBytesmallintE0M>();
                var secondItems1 = new List<FlatBytesmallintE0M>();
                var secondItems2 = new List<FlatBytesmallintE0M>();
                await ((IByteSingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 149, query1, 111, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatBytesmallintE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatBytesmallintE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.bytesmallinte0m m
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
FROM public.bytesmallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintE0M>();
                var firstItems2 = new List<FlatBytesmallintE0M>();
                var secondItems1 = new List<FlatBytesmallintE0M>();
                await ((IByteSingleTypesmallint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 88, query1, 133, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatBytesmallintE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatBytesmallintE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[7],_testData[34], false);
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
FROM public.bytesmallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytesmallintE0M>();
                var models2 = new List<FlatBytesmallintE0M>();
                ((IByteSingleTypesmallint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBytesmallintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bytesmallinte0m m
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
FROM public.bytesmallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintE0M>();
                var firstItems2 = new List<FlatBytesmallintE0M>();
                var secondItems1 = new List<FlatBytesmallintE0M>();
                var secondItems2 = new List<FlatBytesmallintE0M>();
                 ((IByteSingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 144, query1, 43, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatBytesmallintE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatBytesmallintE0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.bytesmallinte0m m
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
FROM public.bytesmallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintE0M>();
                var firstItems2 = new List<FlatBytesmallintE0M>();
                var secondItems1 = new List<FlatBytesmallintE0M>();
                 ((IByteSingleTypesmallint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 146, query1, 14, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatBytesmallintE0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatBytesmallintE0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatBytesmallintE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[30],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytesmallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint)),
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
            asPartInterface: typeof(IByteSingleTypesmallint)),
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
            asPartInterface: typeof(IByteSingleTypesmallint)),
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
FROM public.bytesmallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IByteSingleTypesmallint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallinte0m m
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
FROM public.bytesmallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IByteSingleTypesmallint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 83, query1, 56, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatBytesmallintE0M.AssertModel(models[0],_testData[19], false);
                        FlatBytesmallintE0M.AssertModel(models[1],_testData[20], false);
                        FlatBytesmallintE0M.AssertModel(models[2],_testData[21], false);
                        FlatBytesmallintE0M.AssertModel(models[3],_testData[22], false);
                        FlatBytesmallintE0M.AssertModel(models[4],_testData[23], false);
                        FlatBytesmallintE0M.AssertModel(models[5],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(models[6],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(models[7],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(models[8],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(models[9],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(models[10],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(models[11],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(models[12],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(models[13],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(models[14],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatBytesmallintE0M.AssertModel(models[0],_testData[13], false);
                        FlatBytesmallintE0M.AssertModel(models[1],_testData[14], false);
                        FlatBytesmallintE0M.AssertModel(models[2],_testData[15], false);
                        FlatBytesmallintE0M.AssertModel(models[3],_testData[16], false);
                        FlatBytesmallintE0M.AssertModel(models[4],_testData[17], false);
                        FlatBytesmallintE0M.AssertModel(models[5],_testData[18], false);
                        FlatBytesmallintE0M.AssertModel(models[6],_testData[19], false);
                        FlatBytesmallintE0M.AssertModel(models[7],_testData[20], false);
                        FlatBytesmallintE0M.AssertModel(models[8],_testData[21], false);
                        FlatBytesmallintE0M.AssertModel(models[9],_testData[22], false);
                        FlatBytesmallintE0M.AssertModel(models[10],_testData[23], false);
                        FlatBytesmallintE0M.AssertModel(models[11],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(models[12],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(models[13],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(models[14],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(models[15],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(models[16],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(models[17],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(models[18],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(models[19],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(models[20],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(models[21],_testData[34], false);
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
FROM public.bytesmallinte0m m
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
FROM public.bytesmallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintE0M>();
                var secondItems1 = new List<FlatBytesmallintE0M>();
                var secondItems2 = new List<FlatBytesmallintE0M>();
                await ((IByteSingleTypesmallint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 3, query1, 139, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatBytesmallintE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatBytesmallintE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.bytesmallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IByteSingleTypesmallint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytesmallintE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallinte0m m
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
FROM public.bytesmallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IByteSingleTypesmallint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 14, query1, 20, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatBytesmallintE0M.AssertModel(models[0],_testData[4], false);
                        FlatBytesmallintE0M.AssertModel(models[1],_testData[5], false);
                        FlatBytesmallintE0M.AssertModel(models[2],_testData[6], false);
                        FlatBytesmallintE0M.AssertModel(models[3],_testData[7], false);
                        FlatBytesmallintE0M.AssertModel(models[4],_testData[8], false);
                        FlatBytesmallintE0M.AssertModel(models[5],_testData[9], false);
                        FlatBytesmallintE0M.AssertModel(models[6],_testData[10], false);
                        FlatBytesmallintE0M.AssertModel(models[7],_testData[11], false);
                        FlatBytesmallintE0M.AssertModel(models[8],_testData[12], false);
                        FlatBytesmallintE0M.AssertModel(models[9],_testData[13], false);
                        FlatBytesmallintE0M.AssertModel(models[10],_testData[14], false);
                        FlatBytesmallintE0M.AssertModel(models[11],_testData[15], false);
                        FlatBytesmallintE0M.AssertModel(models[12],_testData[16], false);
                        FlatBytesmallintE0M.AssertModel(models[13],_testData[17], false);
                        FlatBytesmallintE0M.AssertModel(models[14],_testData[18], false);
                        FlatBytesmallintE0M.AssertModel(models[15],_testData[19], false);
                        FlatBytesmallintE0M.AssertModel(models[16],_testData[20], false);
                        FlatBytesmallintE0M.AssertModel(models[17],_testData[21], false);
                        FlatBytesmallintE0M.AssertModel(models[18],_testData[22], false);
                        FlatBytesmallintE0M.AssertModel(models[19],_testData[23], false);
                        FlatBytesmallintE0M.AssertModel(models[20],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(models[21],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(models[22],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(models[23],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(models[24],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(models[25],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(models[26],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(models[27],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(models[28],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(models[29],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatBytesmallintE0M.AssertModel(models[0],_testData[6], false);
                        FlatBytesmallintE0M.AssertModel(models[1],_testData[7], false);
                        FlatBytesmallintE0M.AssertModel(models[2],_testData[8], false);
                        FlatBytesmallintE0M.AssertModel(models[3],_testData[9], false);
                        FlatBytesmallintE0M.AssertModel(models[4],_testData[10], false);
                        FlatBytesmallintE0M.AssertModel(models[5],_testData[11], false);
                        FlatBytesmallintE0M.AssertModel(models[6],_testData[12], false);
                        FlatBytesmallintE0M.AssertModel(models[7],_testData[13], false);
                        FlatBytesmallintE0M.AssertModel(models[8],_testData[14], false);
                        FlatBytesmallintE0M.AssertModel(models[9],_testData[15], false);
                        FlatBytesmallintE0M.AssertModel(models[10],_testData[16], false);
                        FlatBytesmallintE0M.AssertModel(models[11],_testData[17], false);
                        FlatBytesmallintE0M.AssertModel(models[12],_testData[18], false);
                        FlatBytesmallintE0M.AssertModel(models[13],_testData[19], false);
                        FlatBytesmallintE0M.AssertModel(models[14],_testData[20], false);
                        FlatBytesmallintE0M.AssertModel(models[15],_testData[21], false);
                        FlatBytesmallintE0M.AssertModel(models[16],_testData[22], false);
                        FlatBytesmallintE0M.AssertModel(models[17],_testData[23], false);
                        FlatBytesmallintE0M.AssertModel(models[18],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(models[19],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(models[20],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(models[21],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(models[22],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(models[23],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(models[24],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(models[25],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(models[26],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(models[27],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(models[28],_testData[34], false);
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
FROM public.bytesmallinte0m m
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
FROM public.bytesmallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallintE0M>();
                var secondItems1 = new List<FlatBytesmallintE0M>();
                var secondItems2 = new List<FlatBytesmallintE0M>();
                 ((IByteSingleTypesmallint)this).DbConnectionDynQuerySelectModelBatch(connection, 47, query1, 60, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatBytesmallintE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatBytesmallintE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatBytesmallintE0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatBytesmallintE0M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.bytesmallinte0m m
LEFT JOIN public.bytesmallinte0mi mi ON mi.id = m.bytesmallinte0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BytesmallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint)),
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
            asPartInterface: typeof(IByteSingleTypesmallint)),
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
                var models = await((IByteSingleTypesmallint)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BytesmallintE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IByteSingleTypesmallint)this).DbConnectionSTSelectModelBatchAsync(connection, 13, 78))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        BytesmallintE0M.AssertModel(models[0],_testData[3], false);
                        BytesmallintE0M.AssertModel(models[1],_testData[4], false);
                        BytesmallintE0M.AssertModel(models[2],_testData[5], false);
                        BytesmallintE0M.AssertModel(models[3],_testData[6], false);
                        BytesmallintE0M.AssertModel(models[4],_testData[7], false);
                        BytesmallintE0M.AssertModel(models[5],_testData[8], false);
                        BytesmallintE0M.AssertModel(models[6],_testData[9], false);
                        BytesmallintE0M.AssertModel(models[7],_testData[10], false);
                        BytesmallintE0M.AssertModel(models[8],_testData[11], false);
                        BytesmallintE0M.AssertModel(models[9],_testData[12], false);
                        BytesmallintE0M.AssertModel(models[10],_testData[13], false);
                        BytesmallintE0M.AssertModel(models[11],_testData[14], false);
                        BytesmallintE0M.AssertModel(models[12],_testData[15], false);
                        BytesmallintE0M.AssertModel(models[13],_testData[16], false);
                        BytesmallintE0M.AssertModel(models[14],_testData[17], false);
                        BytesmallintE0M.AssertModel(models[15],_testData[18], false);
                        BytesmallintE0M.AssertModel(models[16],_testData[19], false);
                        BytesmallintE0M.AssertModel(models[17],_testData[20], false);
                        BytesmallintE0M.AssertModel(models[18],_testData[21], false);
                        BytesmallintE0M.AssertModel(models[19],_testData[22], false);
                        BytesmallintE0M.AssertModel(models[20],_testData[23], false);
                        BytesmallintE0M.AssertModel(models[21],_testData[24], false);
                        BytesmallintE0M.AssertModel(models[22],_testData[25], false);
                        BytesmallintE0M.AssertModel(models[23],_testData[26], false);
                        BytesmallintE0M.AssertModel(models[24],_testData[27], false);
                        BytesmallintE0M.AssertModel(models[25],_testData[28], false);
                        BytesmallintE0M.AssertModel(models[26],_testData[29], false);
                        BytesmallintE0M.AssertModel(models[27],_testData[30], false);
                        BytesmallintE0M.AssertModel(models[28],_testData[31], false);
                        BytesmallintE0M.AssertModel(models[29],_testData[32], false);
                        BytesmallintE0M.AssertModel(models[30],_testData[33], false);
                        BytesmallintE0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        BytesmallintE0M.AssertModel(models[0],_testData[18], false);
                        BytesmallintE0M.AssertModel(models[1],_testData[19], false);
                        BytesmallintE0M.AssertModel(models[2],_testData[20], false);
                        BytesmallintE0M.AssertModel(models[3],_testData[21], false);
                        BytesmallintE0M.AssertModel(models[4],_testData[22], false);
                        BytesmallintE0M.AssertModel(models[5],_testData[23], false);
                        BytesmallintE0M.AssertModel(models[6],_testData[24], false);
                        BytesmallintE0M.AssertModel(models[7],_testData[25], false);
                        BytesmallintE0M.AssertModel(models[8],_testData[26], false);
                        BytesmallintE0M.AssertModel(models[9],_testData[27], false);
                        BytesmallintE0M.AssertModel(models[10],_testData[28], false);
                        BytesmallintE0M.AssertModel(models[11],_testData[29], false);
                        BytesmallintE0M.AssertModel(models[12],_testData[30], false);
                        BytesmallintE0M.AssertModel(models[13],_testData[31], false);
                        BytesmallintE0M.AssertModel(models[14],_testData[32], false);
                        BytesmallintE0M.AssertModel(models[15],_testData[33], false);
                        BytesmallintE0M.AssertModel(models[16],_testData[34], false);
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
                var models = ((IByteSingleTypesmallint)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BytesmallintE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IByteSingleTypesmallint)this).DbConnectionSTSelectModelBatch(connection, 89, 63))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        BytesmallintE0M.AssertModel(models[0],_testData[21], false);
                        BytesmallintE0M.AssertModel(models[1],_testData[22], false);
                        BytesmallintE0M.AssertModel(models[2],_testData[23], false);
                        BytesmallintE0M.AssertModel(models[3],_testData[24], false);
                        BytesmallintE0M.AssertModel(models[4],_testData[25], false);
                        BytesmallintE0M.AssertModel(models[5],_testData[26], false);
                        BytesmallintE0M.AssertModel(models[6],_testData[27], false);
                        BytesmallintE0M.AssertModel(models[7],_testData[28], false);
                        BytesmallintE0M.AssertModel(models[8],_testData[29], false);
                        BytesmallintE0M.AssertModel(models[9],_testData[30], false);
                        BytesmallintE0M.AssertModel(models[10],_testData[31], false);
                        BytesmallintE0M.AssertModel(models[11],_testData[32], false);
                        BytesmallintE0M.AssertModel(models[12],_testData[33], false);
                        BytesmallintE0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        BytesmallintE0M.AssertModel(models[0],_testData[15], false);
                        BytesmallintE0M.AssertModel(models[1],_testData[16], false);
                        BytesmallintE0M.AssertModel(models[2],_testData[17], false);
                        BytesmallintE0M.AssertModel(models[3],_testData[18], false);
                        BytesmallintE0M.AssertModel(models[4],_testData[19], false);
                        BytesmallintE0M.AssertModel(models[5],_testData[20], false);
                        BytesmallintE0M.AssertModel(models[6],_testData[21], false);
                        BytesmallintE0M.AssertModel(models[7],_testData[22], false);
                        BytesmallintE0M.AssertModel(models[8],_testData[23], false);
                        BytesmallintE0M.AssertModel(models[9],_testData[24], false);
                        BytesmallintE0M.AssertModel(models[10],_testData[25], false);
                        BytesmallintE0M.AssertModel(models[11],_testData[26], false);
                        BytesmallintE0M.AssertModel(models[12],_testData[27], false);
                        BytesmallintE0M.AssertModel(models[13],_testData[28], false);
                        BytesmallintE0M.AssertModel(models[14],_testData[29], false);
                        BytesmallintE0M.AssertModel(models[15],_testData[30], false);
                        BytesmallintE0M.AssertModel(models[16],_testData[31], false);
                        BytesmallintE0M.AssertModel(models[17],_testData[32], false);
                        BytesmallintE0M.AssertModel(models[18],_testData[33], false);
                        BytesmallintE0M.AssertModel(models[19],_testData[34], false);
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
                await using var cmd = await ((IByteSingleTypesmallint)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IByteSingleTypesmallint)this).SetDbConnectionSelectModelParametrs(cmd, 70);
                var models = await ((IByteSingleTypesmallint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                BytesmallintE0M.AssertModel(models[0],_testData[16], false);
                BytesmallintE0M.AssertModel(models[1],_testData[17], false);
                BytesmallintE0M.AssertModel(models[2],_testData[18], false);
                BytesmallintE0M.AssertModel(models[3],_testData[19], false);
                BytesmallintE0M.AssertModel(models[4],_testData[20], false);
                BytesmallintE0M.AssertModel(models[5],_testData[21], false);
                BytesmallintE0M.AssertModel(models[6],_testData[22], false);
                BytesmallintE0M.AssertModel(models[7],_testData[23], false);
                BytesmallintE0M.AssertModel(models[8],_testData[24], false);
                BytesmallintE0M.AssertModel(models[9],_testData[25], false);
                BytesmallintE0M.AssertModel(models[10],_testData[26], false);
                BytesmallintE0M.AssertModel(models[11],_testData[27], false);
                BytesmallintE0M.AssertModel(models[12],_testData[28], false);
                BytesmallintE0M.AssertModel(models[13],_testData[29], false);
                BytesmallintE0M.AssertModel(models[14],_testData[30], false);
                BytesmallintE0M.AssertModel(models[15],_testData[31], false);
                BytesmallintE0M.AssertModel(models[16],_testData[32], false);
                BytesmallintE0M.AssertModel(models[17],_testData[33], false);
                BytesmallintE0M.AssertModel(models[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IByteSingleTypesmallint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IByteSingleTypesmallint)this).SetDbConnectionSelectModelParametrs(cmd, 149);
                var models =  ((IByteSingleTypesmallint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                BytesmallintE0M.AssertModel(models[0],_testData[32], false);
                BytesmallintE0M.AssertModel(models[1],_testData[33], false);
                BytesmallintE0M.AssertModel(models[2],_testData[34], false);
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
FROM public.bytesmallinte0m m
LEFT JOIN public.bytesmallinte0mi mi ON mi.id = m.bytesmallinte0mi_id
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
            asPartInterface: typeof(IByteSingleTypesmallint))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IByteSingleTypesmallint)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((168)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((115)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((177)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((205)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((60)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((217)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((121)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((171)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((40)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((178)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((119)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((49)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((98)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((245)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((18)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((70)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((75)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((74)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((83)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((37)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((41)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((154)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((84)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((148)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((106)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((56)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((45)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((210)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((110)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((54)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((64)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((47)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((216)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((228)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((91)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((199)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((225)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((126)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((34)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((172)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((241)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((133)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((21)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((36)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((34)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((200)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((99)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((158)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((226)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((124)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((171)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((141)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((232)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((180)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((125)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((182)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((9)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((66)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((109)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((160)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((56)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((20)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((96)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((182)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((16)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((57)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((51)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((37)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((203)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((14)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((246)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((94)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((0)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((43)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((92)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((126)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((29)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((227)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((95)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((82)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((186)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((64)));//Value

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
                var models =  ((IByteSingleTypesmallint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((168)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((115)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((177)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((205)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((60)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((217)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((121)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((171)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((40)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((178)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((119)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((49)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((98)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((245)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((18)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((70)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((75)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((74)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((83)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((37)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((41)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((154)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((84)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((148)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((106)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((56)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((45)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((210)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((110)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((54)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((64)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((47)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((216)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((228)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((91)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((199)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((225)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((126)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((34)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((172)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((241)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((133)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((21)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((36)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((34)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((200)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((99)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((158)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((226)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((124)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((171)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((141)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((232)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((180)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((125)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((182)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((9)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((66)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((109)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((160)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((56)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((20)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((96)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((182)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((16)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((57)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((51)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((37)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((203)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((14)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((246)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((94)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((0)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((43)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((92)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((126)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((29)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((227)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((95)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((82)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((186)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((64)));//Value

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
FROM public.binary_bytesmallinte0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BytesmallintE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(BytesmallintE0MIWA),
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
            asPartInterface: typeof(IByteSingleTypesmallint))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BytesmallintE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BytesmallintE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IByteSingleTypesmallint)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bytesmallinte0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IByteSingleTypesmallint)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BytesmallintE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BytesmallintE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IByteSingleTypesmallint)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bytesmallinte0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IByteSingleTypesmallint)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bytesmallinte0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BytesmallintE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BytesmallintE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BytesmallintE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BytesmallintE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IByteSingleTypesmallint)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bytesmallinte0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IByteSingleTypesmallint)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BytesmallintE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BytesmallintE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IByteSingleTypesmallint)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bytesmallinte0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IByteSingleTypesmallint)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bytesmallinte0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BytesmallintE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bytesmallinte0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(BytesmallintE0MI),
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
            asPartInterface: typeof(IByteSingleTypesmallint))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BytesmallintE0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IByteSingleTypesmallint)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IByteSingleTypesmallint)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BytesmallintE0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IByteSingleTypesmallint)this).WAImportModelInner(connection, importCollection);
                var models = ((IByteSingleTypesmallint)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_bytesmallinte0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BytesmallintE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bytesmallinte0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BytesmallintE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BytesmallintE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BytesmallintE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IByteSingleTypesmallint)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IByteSingleTypesmallint)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BytesmallintE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BytesmallintE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IByteSingleTypesmallint)this).ImportModelInner(connection, importCollection);
                var models = ((IByteSingleTypesmallint)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BytesmallintE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bytesmallinte0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bytesmallinte0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BytesmallintE0M),
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
            asPartInterface: typeof(IByteSingleTypesmallint))]
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
FROM public.binary_bytesmallinte0m m
LEFT JOIN public.binary_bytesmallinte0mi mi ON mi.id = m.bytesmallinte0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BytesmallintE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BytesmallintE0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IByteSingleTypesmallint)this).ImportModelAsync(connection, importCollection);
                var models = await ((IByteSingleTypesmallint)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BytesmallintE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BytesmallintE0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IByteSingleTypesmallint)this).ImportModel(connection, importCollection);
                var models = ((IByteSingleTypesmallint)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BytesmallintE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bytesmallinte0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bytesmallinte0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BytesmallintE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18)
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
                var models =  ((IByteSingleTypesmallint)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BytesmallintE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IByteSingleTypesmallint)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BytesmallintE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(BytesmallintE0MIWA), typeof(BytesmallintE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18),
                (NpgsqlTypes.NpgsqlDbType)(18)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18),
                (NpgsqlTypes.NpgsqlDbType)(18)
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
                var models1 = new List<BytesmallintE0MIWA>();
                var models2 = new List<BytesmallintE0MIWA>();
                await ((IByteSingleTypesmallint)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bytesmallinte0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BytesmallintE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BytesmallintE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BytesmallintE0MIWA>();
                var models2 = new List<BytesmallintE0MIWA>();
                ((IByteSingleTypesmallint)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bytesmallinte0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BytesmallintE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BytesmallintE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BytesmallintE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18),
                (NpgsqlTypes.NpgsqlDbType)(18)
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
                var models = await ((IByteSingleTypesmallint)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_bytesmallinte0mi
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
                    BytesmallintE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IByteSingleTypesmallint)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_bytesmallinte0mi
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
                    BytesmallintE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BytesmallintE0MIWA), typeof(BytesmallintE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint))]
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
                var models1 = new List<BytesmallintE0MIWA>();
                var models2 = new List<BytesmallintE0MIWA>();
                await ((IByteSingleTypesmallint)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bytesmallinte0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BytesmallintE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BytesmallintE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BytesmallintE0MIWA>();
                var models2 = new List<BytesmallintE0MIWA>();
                ((IByteSingleTypesmallint)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bytesmallinte0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BytesmallintE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BytesmallintE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BytesmallintE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint))]
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
                var models = await ((IByteSingleTypesmallint)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bytesmallinte0mi
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
                    BytesmallintE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IByteSingleTypesmallint)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bytesmallinte0mi
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
                    BytesmallintE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bytesmallinte0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BytesmallintE0MI), typeof(BytesmallintE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18),
                (NpgsqlTypes.NpgsqlDbType)(18)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18),
                (NpgsqlTypes.NpgsqlDbType)(18)
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
                var models1 = new List<BytesmallintE0MI>();
                var models2 = new List<BytesmallintE0MI>();
                await ((IByteSingleTypesmallint)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BytesmallintE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BytesmallintE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BytesmallintE0MI>();
                var models2 = new List<BytesmallintE0MI>();
                ((IByteSingleTypesmallint)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BytesmallintE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BytesmallintE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bytesmallinte0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(BytesmallintE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18),
                (NpgsqlTypes.NpgsqlDbType)(18)
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
                var models = await ((IByteSingleTypesmallint)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BytesmallintE0MI.AssertModel(model, expectedModel, false);
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
                var models = ((IByteSingleTypesmallint)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BytesmallintE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bytesmallinte0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BytesmallintE0MIWA), typeof(BytesmallintE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint))]
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
                var models1 = new List<BytesmallintE0MIWA>();
                var models2 = new List<BytesmallintE0MIWA>();
                await ((IByteSingleTypesmallint)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BytesmallintE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BytesmallintE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BytesmallintE0MIWA>();
                var models2 = new List<BytesmallintE0MIWA>();
                ((IByteSingleTypesmallint)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BytesmallintE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BytesmallintE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bytesmallinte0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BytesmallintE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint))]
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
                var models = await ((IByteSingleTypesmallint)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BytesmallintE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IByteSingleTypesmallint)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BytesmallintE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

