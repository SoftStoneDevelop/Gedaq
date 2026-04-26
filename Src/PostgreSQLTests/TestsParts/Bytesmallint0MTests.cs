

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

        private readonly Bytesmallint0M[] _testData = new Bytesmallint0M[]
        {
            new Bytesmallint0M
{
    Id = 5,
    Value = 181,
    ModelInner = null,
    NullableValue = null,
},
            new Bytesmallint0M
{
    Id = 6,
    Value = 105,
    ModelInner = new Bytesmallint0MI
{
    Id = 4,
    Value = 156,
    NullableValue = null,
},
    NullableValue = 10,
},
            new Bytesmallint0M
{
    Id = 8,
    Value = 235,
    ModelInner = null,
    NullableValue = null,
},
            new Bytesmallint0M
{
    Id = 17,
    Value = 157,
    ModelInner = new Bytesmallint0MI
{
    Id = 12,
    Value = 178,
    NullableValue = 203,
},
    NullableValue = 178,
},
            new Bytesmallint0M
{
    Id = 21,
    Value = 61,
    ModelInner = null,
    NullableValue = null,
},
            new Bytesmallint0M
{
    Id = 28,
    Value = 227,
    ModelInner = new Bytesmallint0MI
{
    Id = 19,
    Value = 148,
    NullableValue = 128,
},
    NullableValue = null,
},
            new Bytesmallint0M
{
    Id = 37,
    Value = 46,
    ModelInner = null,
    NullableValue = null,
},
            new Bytesmallint0M
{
    Id = 38,
    Value = 114,
    ModelInner = new Bytesmallint0MI
{
    Id = 23,
    Value = 110,
    NullableValue = 235,
},
    NullableValue = null,
},
            new Bytesmallint0M
{
    Id = 41,
    Value = 40,
    ModelInner = null,
    NullableValue = 45,
},
            new Bytesmallint0M
{
    Id = 42,
    Value = 239,
    ModelInner = new Bytesmallint0MI
{
    Id = 24,
    Value = 130,
    NullableValue = null,
},
    NullableValue = null,
},
            new Bytesmallint0M
{
    Id = 43,
    Value = 118,
    ModelInner = null,
    NullableValue = 34,
},
            new Bytesmallint0M
{
    Id = 46,
    Value = 88,
    ModelInner = new Bytesmallint0MI
{
    Id = 30,
    Value = 215,
    NullableValue = 118,
},
    NullableValue = 104,
},
            new Bytesmallint0M
{
    Id = 55,
    Value = 195,
    ModelInner = null,
    NullableValue = null,
},
            new Bytesmallint0M
{
    Id = 60,
    Value = 240,
    ModelInner = new Bytesmallint0MI
{
    Id = 38,
    Value = 190,
    NullableValue = null,
},
    NullableValue = null,
},
            new Bytesmallint0M
{
    Id = 68,
    Value = 198,
    ModelInner = null,
    NullableValue = null,
},
            new Bytesmallint0M
{
    Id = 69,
    Value = 115,
    ModelInner = new Bytesmallint0MI
{
    Id = 39,
    Value = 234,
    NullableValue = 206,
},
    NullableValue = 1,
},
            new Bytesmallint0M
{
    Id = 78,
    Value = 175,
    ModelInner = null,
    NullableValue = 164,
},
            new Bytesmallint0M
{
    Id = 84,
    Value = 70,
    ModelInner = new Bytesmallint0MI
{
    Id = 43,
    Value = 147,
    NullableValue = null,
},
    NullableValue = 224,
},
            new Bytesmallint0M
{
    Id = 85,
    Value = 168,
    ModelInner = null,
    NullableValue = null,
},
            new Bytesmallint0M
{
    Id = 89,
    Value = 21,
    ModelInner = new Bytesmallint0MI
{
    Id = 45,
    Value = 181,
    NullableValue = 156,
},
    NullableValue = 179,
},
            new Bytesmallint0M
{
    Id = 90,
    Value = 93,
    ModelInner = null,
    NullableValue = null,
},
            new Bytesmallint0M
{
    Id = 91,
    Value = 5,
    ModelInner = new Bytesmallint0MI
{
    Id = 50,
    Value = 192,
    NullableValue = 38,
},
    NullableValue = null,
},
            new Bytesmallint0M
{
    Id = 96,
    Value = 149,
    ModelInner = null,
    NullableValue = 132,
},
            new Bytesmallint0M
{
    Id = 102,
    Value = 199,
    ModelInner = new Bytesmallint0MI
{
    Id = 58,
    Value = 93,
    NullableValue = null,
},
    NullableValue = 219,
},
            new Bytesmallint0M
{
    Id = 106,
    Value = 148,
    ModelInner = null,
    NullableValue = 183,
},
            new Bytesmallint0M
{
    Id = 108,
    Value = 168,
    ModelInner = new Bytesmallint0MI
{
    Id = 63,
    Value = 199,
    NullableValue = null,
},
    NullableValue = null,
},
            new Bytesmallint0M
{
    Id = 113,
    Value = 73,
    ModelInner = null,
    NullableValue = 97,
},
            new Bytesmallint0M
{
    Id = 122,
    Value = 36,
    ModelInner = new Bytesmallint0MI
{
    Id = 66,
    Value = 131,
    NullableValue = null,
},
    NullableValue = 87,
},
            new Bytesmallint0M
{
    Id = 131,
    Value = 65,
    ModelInner = null,
    NullableValue = 168,
},
            new Bytesmallint0M
{
    Id = 132,
    Value = 227,
    ModelInner = new Bytesmallint0MI
{
    Id = 71,
    Value = 163,
    NullableValue = 212,
},
    NullableValue = 244,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bytesmallint0mi(
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
INSERT INTO public.bytesmallint0mi(
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
            queryMapTypes: [typeof(Bytesmallint0MI)],
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
INSERT INTO public.bytesmallint0mi(
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

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bytesmallint0m(
	id,
    value,
    nullablevalue,
    bytesmallint0mi_id
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
                methodParametrName: "bytesmallint0mi_id", 
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
INSERT INTO public.bytesmallint0m(
	id,
    value,
    nullablevalue,
    bytesmallint0mi_id
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
    bytesmallint0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Bytesmallint0M)],
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
INSERT INTO public.bytesmallint0m(
	id,
    value,
    nullablevalue,
    bytesmallint0mi_id
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
    bytesmallint0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Bytesmallint0M)],
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
                methodParametrName: "bytesmallint0mi_id", 
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
                List<Bytesmallint0M> models = null;

                models =  ((IByteSingleTypesmallint)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Bytesmallint0M.AssertModel(models[0],_testData[4], true);
                models =  ((IByteSingleTypesmallint)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Bytesmallint0M.AssertModel(models[0],_testData[5], true);
                models =  ((IByteSingleTypesmallint)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Bytesmallint0M.AssertModel(models[0],_testData[6], true);
                models =  ((IByteSingleTypesmallint)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Bytesmallint0M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Bytesmallint0M> models = null;

                models = await ((IByteSingleTypesmallint)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Bytesmallint0M.AssertModel(models[0],_testData[8], true);
                models = await ((IByteSingleTypesmallint)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Bytesmallint0M.AssertModel(models[0],_testData[9], true);
                models = await ((IByteSingleTypesmallint)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Bytesmallint0M.AssertModel(models[0],_testData[10], true);
                models = await ((IByteSingleTypesmallint)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Bytesmallint0M.AssertModel(models[0],_testData[11], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.bytesmallint0m(
	id,
    value,
    nullablevalue,
    bytesmallint0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @bytesmallint0mi_id
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
                parametrName: "bytesmallint0mi_id", 
                methodParametrName: "bytesmallint0mi_id", 
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

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytesmallint0M), typeof(FlatBytesmallint0M)],
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
FROM public.bytesmallint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBytesmallint0M>();
                var models2 = new List<FlatBytesmallint0M>();
                await ((IByteSingleTypesmallint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bytesmallint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBytesmallint0M>();
                var models2 = new List<FlatBytesmallint0M>();
                ((IByteSingleTypesmallint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytesmallint0M)],
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
FROM public.bytesmallint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IByteSingleTypesmallint)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IByteSingleTypesmallint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallint0m m
LEFT JOIN public.bytesmallint0mi mi ON mi.id = m.bytesmallint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Bytesmallint0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Bytesmallint0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Bytesmallint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytesmallint0M), typeof(FlatBytesmallint0M)],
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
FROM public.bytesmallint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytesmallint0M>();
                var models2 = new List<FlatBytesmallint0M>();
                await ((IByteSingleTypesmallint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bytesmallint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytesmallint0M>();
                var models2 = new List<FlatBytesmallint0M>();
                ((IByteSingleTypesmallint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytesmallint0M)],
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
FROM public.bytesmallint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IByteSingleTypesmallint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IByteSingleTypesmallint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.bytesmallint0m m
LEFT JOIN public.bytesmallint0mi mi ON mi.id = m.bytesmallint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Bytesmallint0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Bytesmallint0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Bytesmallint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytesmallint0M), typeof(FlatBytesmallint0M)],
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
FROM public.bytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBytesmallint0M>();
                var models2 = new List<FlatBytesmallint0M>();
                await((IByteSingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
FROM public.bytesmallint0m m
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
FROM public.bytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallint0M>();
                var firstItems2 = new List<FlatBytesmallint0M>();
                var secondItems1 = new List<FlatBytesmallint0M>();
                var secondItems2 = new List<FlatBytesmallint0M>();
                await ((IByteSingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatBytesmallint0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatBytesmallint0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[9],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
FROM public.bytesmallint0m m
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
FROM public.bytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallint0M>();
                var firstItems2 = new List<FlatBytesmallint0M>();
                var secondItems1 = new List<FlatBytesmallint0M>();
                await ((IByteSingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatBytesmallint0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatBytesmallint0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[23],_testData[29], false);
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
FROM public.bytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBytesmallint0M>();
                var models2 = new List<FlatBytesmallint0M>();
                ((IByteSingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
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
FROM public.bytesmallint0m m
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
FROM public.bytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallint0M>();
                var firstItems2 = new List<FlatBytesmallint0M>();
                var secondItems1 = new List<FlatBytesmallint0M>();
                var secondItems2 = new List<FlatBytesmallint0M>();
                 ((IByteSingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatBytesmallint0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatBytesmallint0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
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
FROM public.bytesmallint0m m
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
FROM public.bytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallint0M>();
                var firstItems2 = new List<FlatBytesmallint0M>();
                var secondItems1 = new List<FlatBytesmallint0M>();
                 ((IByteSingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatBytesmallint0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatBytesmallint0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[12],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytesmallint0M)],
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
FROM public.bytesmallint0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bytesmallint0m m
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
FROM public.bytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IByteSingleTypesmallint)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatBytesmallint0M.AssertModel(models[0],_testData[7], false);
                        FlatBytesmallint0M.AssertModel(models[1],_testData[8], false);
                        FlatBytesmallint0M.AssertModel(models[2],_testData[9], false);
                        FlatBytesmallint0M.AssertModel(models[3],_testData[10], false);
                        FlatBytesmallint0M.AssertModel(models[4],_testData[11], false);
                        FlatBytesmallint0M.AssertModel(models[5],_testData[12], false);
                        FlatBytesmallint0M.AssertModel(models[6],_testData[13], false);
                        FlatBytesmallint0M.AssertModel(models[7],_testData[14], false);
                        FlatBytesmallint0M.AssertModel(models[8],_testData[15], false);
                        FlatBytesmallint0M.AssertModel(models[9],_testData[16], false);
                        FlatBytesmallint0M.AssertModel(models[10],_testData[17], false);
                        FlatBytesmallint0M.AssertModel(models[11],_testData[18], false);
                        FlatBytesmallint0M.AssertModel(models[12],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(models[13],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(models[14],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(models[15],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(models[16],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(models[17],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(models[18],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(models[19],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(models[20],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(models[21],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatBytesmallint0M.AssertModel(models[0],_testData[10], false);
                        FlatBytesmallint0M.AssertModel(models[1],_testData[11], false);
                        FlatBytesmallint0M.AssertModel(models[2],_testData[12], false);
                        FlatBytesmallint0M.AssertModel(models[3],_testData[13], false);
                        FlatBytesmallint0M.AssertModel(models[4],_testData[14], false);
                        FlatBytesmallint0M.AssertModel(models[5],_testData[15], false);
                        FlatBytesmallint0M.AssertModel(models[6],_testData[16], false);
                        FlatBytesmallint0M.AssertModel(models[7],_testData[17], false);
                        FlatBytesmallint0M.AssertModel(models[8],_testData[18], false);
                        FlatBytesmallint0M.AssertModel(models[9],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(models[10],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(models[11],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(models[12],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(models[13],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(models[14],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(models[15],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(models[16],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(models[17],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(models[18],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(models[19],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bytesmallint0m m
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
FROM public.bytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallint0M>();
                var secondItems1 = new List<FlatBytesmallint0M>();
                var secondItems2 = new List<FlatBytesmallint0M>();
                await ((IByteSingleTypesmallint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatBytesmallint0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatBytesmallint0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[13],_testData[29], false);
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
FROM public.bytesmallint0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bytesmallint0m m
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
FROM public.bytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IByteSingleTypesmallint)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatBytesmallint0M.AssertModel(models[0],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(models[1],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(models[2],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(models[3],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(models[4],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(models[5],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(models[6],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(models[7],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatBytesmallint0M.AssertModel(models[0],_testData[10], false);
                        FlatBytesmallint0M.AssertModel(models[1],_testData[11], false);
                        FlatBytesmallint0M.AssertModel(models[2],_testData[12], false);
                        FlatBytesmallint0M.AssertModel(models[3],_testData[13], false);
                        FlatBytesmallint0M.AssertModel(models[4],_testData[14], false);
                        FlatBytesmallint0M.AssertModel(models[5],_testData[15], false);
                        FlatBytesmallint0M.AssertModel(models[6],_testData[16], false);
                        FlatBytesmallint0M.AssertModel(models[7],_testData[17], false);
                        FlatBytesmallint0M.AssertModel(models[8],_testData[18], false);
                        FlatBytesmallint0M.AssertModel(models[9],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(models[10],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(models[11],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(models[12],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(models[13],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(models[14],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(models[15],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(models[16],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(models[17],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(models[18],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(models[19],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bytesmallint0m m
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
FROM public.bytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallint0M>();
                var secondItems1 = new List<FlatBytesmallint0M>();
                var secondItems2 = new List<FlatBytesmallint0M>();
                 ((IByteSingleTypesmallint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatBytesmallint0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatBytesmallint0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[28],_testData[29], false);
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
FROM public.bytesmallint0m m
LEFT JOIN public.bytesmallint0mi mi ON mi.id = m.bytesmallint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Bytesmallint0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Bytesmallint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IByteSingleTypesmallint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Bytesmallint0M.AssertModel(models[0],_testData[25], false);
                        Bytesmallint0M.AssertModel(models[1],_testData[26], false);
                        Bytesmallint0M.AssertModel(models[2],_testData[27], false);
                        Bytesmallint0M.AssertModel(models[3],_testData[28], false);
                        Bytesmallint0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Bytesmallint0M.AssertModel(models[0],_testData[10], false);
                        Bytesmallint0M.AssertModel(models[1],_testData[11], false);
                        Bytesmallint0M.AssertModel(models[2],_testData[12], false);
                        Bytesmallint0M.AssertModel(models[3],_testData[13], false);
                        Bytesmallint0M.AssertModel(models[4],_testData[14], false);
                        Bytesmallint0M.AssertModel(models[5],_testData[15], false);
                        Bytesmallint0M.AssertModel(models[6],_testData[16], false);
                        Bytesmallint0M.AssertModel(models[7],_testData[17], false);
                        Bytesmallint0M.AssertModel(models[8],_testData[18], false);
                        Bytesmallint0M.AssertModel(models[9],_testData[19], false);
                        Bytesmallint0M.AssertModel(models[10],_testData[20], false);
                        Bytesmallint0M.AssertModel(models[11],_testData[21], false);
                        Bytesmallint0M.AssertModel(models[12],_testData[22], false);
                        Bytesmallint0M.AssertModel(models[13],_testData[23], false);
                        Bytesmallint0M.AssertModel(models[14],_testData[24], false);
                        Bytesmallint0M.AssertModel(models[15],_testData[25], false);
                        Bytesmallint0M.AssertModel(models[16],_testData[26], false);
                        Bytesmallint0M.AssertModel(models[17],_testData[27], false);
                        Bytesmallint0M.AssertModel(models[18],_testData[28], false);
                        Bytesmallint0M.AssertModel(models[19],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Bytesmallint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IByteSingleTypesmallint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Bytesmallint0M.AssertModel(models[0],_testData[9], false);
                        Bytesmallint0M.AssertModel(models[1],_testData[10], false);
                        Bytesmallint0M.AssertModel(models[2],_testData[11], false);
                        Bytesmallint0M.AssertModel(models[3],_testData[12], false);
                        Bytesmallint0M.AssertModel(models[4],_testData[13], false);
                        Bytesmallint0M.AssertModel(models[5],_testData[14], false);
                        Bytesmallint0M.AssertModel(models[6],_testData[15], false);
                        Bytesmallint0M.AssertModel(models[7],_testData[16], false);
                        Bytesmallint0M.AssertModel(models[8],_testData[17], false);
                        Bytesmallint0M.AssertModel(models[9],_testData[18], false);
                        Bytesmallint0M.AssertModel(models[10],_testData[19], false);
                        Bytesmallint0M.AssertModel(models[11],_testData[20], false);
                        Bytesmallint0M.AssertModel(models[12],_testData[21], false);
                        Bytesmallint0M.AssertModel(models[13],_testData[22], false);
                        Bytesmallint0M.AssertModel(models[14],_testData[23], false);
                        Bytesmallint0M.AssertModel(models[15],_testData[24], false);
                        Bytesmallint0M.AssertModel(models[16],_testData[25], false);
                        Bytesmallint0M.AssertModel(models[17],_testData[26], false);
                        Bytesmallint0M.AssertModel(models[18],_testData[27], false);
                        Bytesmallint0M.AssertModel(models[19],_testData[28], false);
                        Bytesmallint0M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Bytesmallint0M.AssertModel(models[0],_testData[11], false);
                        Bytesmallint0M.AssertModel(models[1],_testData[12], false);
                        Bytesmallint0M.AssertModel(models[2],_testData[13], false);
                        Bytesmallint0M.AssertModel(models[3],_testData[14], false);
                        Bytesmallint0M.AssertModel(models[4],_testData[15], false);
                        Bytesmallint0M.AssertModel(models[5],_testData[16], false);
                        Bytesmallint0M.AssertModel(models[6],_testData[17], false);
                        Bytesmallint0M.AssertModel(models[7],_testData[18], false);
                        Bytesmallint0M.AssertModel(models[8],_testData[19], false);
                        Bytesmallint0M.AssertModel(models[9],_testData[20], false);
                        Bytesmallint0M.AssertModel(models[10],_testData[21], false);
                        Bytesmallint0M.AssertModel(models[11],_testData[22], false);
                        Bytesmallint0M.AssertModel(models[12],_testData[23], false);
                        Bytesmallint0M.AssertModel(models[13],_testData[24], false);
                        Bytesmallint0M.AssertModel(models[14],_testData[25], false);
                        Bytesmallint0M.AssertModel(models[15],_testData[26], false);
                        Bytesmallint0M.AssertModel(models[16],_testData[27], false);
                        Bytesmallint0M.AssertModel(models[17],_testData[28], false);
                        Bytesmallint0M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytesmallint0M), typeof(FlatBytesmallint0M)],
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
FROM public.bytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytesmallint0M>();
                var models2 = new List<FlatBytesmallint0M>();
                await((IByteSingleTypesmallint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.bytesmallint0m m
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
FROM public.bytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallint0M>();
                var firstItems2 = new List<FlatBytesmallint0M>();
                var secondItems1 = new List<FlatBytesmallint0M>();
                var secondItems2 = new List<FlatBytesmallint0M>();
                await ((IByteSingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 69, query1, 102, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatBytesmallint0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatBytesmallint0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[5],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.bytesmallint0m m
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
FROM public.bytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallint0M>();
                var firstItems2 = new List<FlatBytesmallint0M>();
                var secondItems1 = new List<FlatBytesmallint0M>();
                await ((IByteSingleTypesmallint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 122, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatBytesmallint0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatBytesmallint0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[20],_testData[29], false);
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
FROM public.bytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytesmallint0M>();
                var models2 = new List<FlatBytesmallint0M>();
                ((IByteSingleTypesmallint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.bytesmallint0m m
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
FROM public.bytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallint0M>();
                var firstItems2 = new List<FlatBytesmallint0M>();
                var secondItems1 = new List<FlatBytesmallint0M>();
                var secondItems2 = new List<FlatBytesmallint0M>();
                 ((IByteSingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 6, query1, 17, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatBytesmallint0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatBytesmallint0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[25],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.bytesmallint0m m
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
FROM public.bytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallint0M>();
                var firstItems2 = new List<FlatBytesmallint0M>();
                var secondItems1 = new List<FlatBytesmallint0M>();
                 ((IByteSingleTypesmallint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 38, query1, 113, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatBytesmallint0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatBytesmallint0M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatBytesmallint0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[2],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytesmallint0M)],
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
FROM public.bytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IByteSingleTypesmallint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bytesmallint0m m
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
FROM public.bytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IByteSingleTypesmallint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 55, query1, 38, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatBytesmallint0M.AssertModel(models[0],_testData[13], false);
                        FlatBytesmallint0M.AssertModel(models[1],_testData[14], false);
                        FlatBytesmallint0M.AssertModel(models[2],_testData[15], false);
                        FlatBytesmallint0M.AssertModel(models[3],_testData[16], false);
                        FlatBytesmallint0M.AssertModel(models[4],_testData[17], false);
                        FlatBytesmallint0M.AssertModel(models[5],_testData[18], false);
                        FlatBytesmallint0M.AssertModel(models[6],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(models[7],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(models[8],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(models[9],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(models[10],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(models[11],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(models[12],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(models[13],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(models[14],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(models[15],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatBytesmallint0M.AssertModel(models[0],_testData[8], false);
                        FlatBytesmallint0M.AssertModel(models[1],_testData[9], false);
                        FlatBytesmallint0M.AssertModel(models[2],_testData[10], false);
                        FlatBytesmallint0M.AssertModel(models[3],_testData[11], false);
                        FlatBytesmallint0M.AssertModel(models[4],_testData[12], false);
                        FlatBytesmallint0M.AssertModel(models[5],_testData[13], false);
                        FlatBytesmallint0M.AssertModel(models[6],_testData[14], false);
                        FlatBytesmallint0M.AssertModel(models[7],_testData[15], false);
                        FlatBytesmallint0M.AssertModel(models[8],_testData[16], false);
                        FlatBytesmallint0M.AssertModel(models[9],_testData[17], false);
                        FlatBytesmallint0M.AssertModel(models[10],_testData[18], false);
                        FlatBytesmallint0M.AssertModel(models[11],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(models[12],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(models[13],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(models[14],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(models[15],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(models[16],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(models[17],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(models[18],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(models[19],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(models[20],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(models[21],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bytesmallint0m m
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
FROM public.bytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallint0M>();
                var secondItems1 = new List<FlatBytesmallint0M>();
                var secondItems2 = new List<FlatBytesmallint0M>();
                await ((IByteSingleTypesmallint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 37, query1, 96, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatBytesmallint0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatBytesmallint0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[6],_testData[29], false);
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
FROM public.bytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IByteSingleTypesmallint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBytesmallint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bytesmallint0m m
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
FROM public.bytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IByteSingleTypesmallint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 43, query1, 8, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatBytesmallint0M.AssertModel(models[0],_testData[11], false);
                        FlatBytesmallint0M.AssertModel(models[1],_testData[12], false);
                        FlatBytesmallint0M.AssertModel(models[2],_testData[13], false);
                        FlatBytesmallint0M.AssertModel(models[3],_testData[14], false);
                        FlatBytesmallint0M.AssertModel(models[4],_testData[15], false);
                        FlatBytesmallint0M.AssertModel(models[5],_testData[16], false);
                        FlatBytesmallint0M.AssertModel(models[6],_testData[17], false);
                        FlatBytesmallint0M.AssertModel(models[7],_testData[18], false);
                        FlatBytesmallint0M.AssertModel(models[8],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(models[9],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(models[10],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(models[11],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(models[12],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(models[13],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(models[14],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(models[15],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(models[16],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(models[17],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatBytesmallint0M.AssertModel(models[0],_testData[3], false);
                        FlatBytesmallint0M.AssertModel(models[1],_testData[4], false);
                        FlatBytesmallint0M.AssertModel(models[2],_testData[5], false);
                        FlatBytesmallint0M.AssertModel(models[3],_testData[6], false);
                        FlatBytesmallint0M.AssertModel(models[4],_testData[7], false);
                        FlatBytesmallint0M.AssertModel(models[5],_testData[8], false);
                        FlatBytesmallint0M.AssertModel(models[6],_testData[9], false);
                        FlatBytesmallint0M.AssertModel(models[7],_testData[10], false);
                        FlatBytesmallint0M.AssertModel(models[8],_testData[11], false);
                        FlatBytesmallint0M.AssertModel(models[9],_testData[12], false);
                        FlatBytesmallint0M.AssertModel(models[10],_testData[13], false);
                        FlatBytesmallint0M.AssertModel(models[11],_testData[14], false);
                        FlatBytesmallint0M.AssertModel(models[12],_testData[15], false);
                        FlatBytesmallint0M.AssertModel(models[13],_testData[16], false);
                        FlatBytesmallint0M.AssertModel(models[14],_testData[17], false);
                        FlatBytesmallint0M.AssertModel(models[15],_testData[18], false);
                        FlatBytesmallint0M.AssertModel(models[16],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(models[17],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(models[18],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(models[19],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(models[20],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(models[21],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(models[22],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(models[23],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(models[24],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(models[25],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(models[26],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bytesmallint0m m
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
FROM public.bytesmallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytesmallint0M>();
                var secondItems1 = new List<FlatBytesmallint0M>();
                var secondItems2 = new List<FlatBytesmallint0M>();
                 ((IByteSingleTypesmallint)this).DbConnectionDynQuerySelectModelBatch(connection, 41, query1, 85, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatBytesmallint0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(firstItems1[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatBytesmallint0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatBytesmallint0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatBytesmallint0M.AssertModel(secondItems2[10],_testData[29], false);
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
FROM public.bytesmallint0m m
LEFT JOIN public.bytesmallint0mi mi ON mi.id = m.bytesmallint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Bytesmallint0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Bytesmallint0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IByteSingleTypesmallint)this).DbConnectionSTSelectModelBatchAsync(connection, 8, 41))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Bytesmallint0M.AssertModel(models[0],_testData[3], false);
                        Bytesmallint0M.AssertModel(models[1],_testData[4], false);
                        Bytesmallint0M.AssertModel(models[2],_testData[5], false);
                        Bytesmallint0M.AssertModel(models[3],_testData[6], false);
                        Bytesmallint0M.AssertModel(models[4],_testData[7], false);
                        Bytesmallint0M.AssertModel(models[5],_testData[8], false);
                        Bytesmallint0M.AssertModel(models[6],_testData[9], false);
                        Bytesmallint0M.AssertModel(models[7],_testData[10], false);
                        Bytesmallint0M.AssertModel(models[8],_testData[11], false);
                        Bytesmallint0M.AssertModel(models[9],_testData[12], false);
                        Bytesmallint0M.AssertModel(models[10],_testData[13], false);
                        Bytesmallint0M.AssertModel(models[11],_testData[14], false);
                        Bytesmallint0M.AssertModel(models[12],_testData[15], false);
                        Bytesmallint0M.AssertModel(models[13],_testData[16], false);
                        Bytesmallint0M.AssertModel(models[14],_testData[17], false);
                        Bytesmallint0M.AssertModel(models[15],_testData[18], false);
                        Bytesmallint0M.AssertModel(models[16],_testData[19], false);
                        Bytesmallint0M.AssertModel(models[17],_testData[20], false);
                        Bytesmallint0M.AssertModel(models[18],_testData[21], false);
                        Bytesmallint0M.AssertModel(models[19],_testData[22], false);
                        Bytesmallint0M.AssertModel(models[20],_testData[23], false);
                        Bytesmallint0M.AssertModel(models[21],_testData[24], false);
                        Bytesmallint0M.AssertModel(models[22],_testData[25], false);
                        Bytesmallint0M.AssertModel(models[23],_testData[26], false);
                        Bytesmallint0M.AssertModel(models[24],_testData[27], false);
                        Bytesmallint0M.AssertModel(models[25],_testData[28], false);
                        Bytesmallint0M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Bytesmallint0M.AssertModel(models[0],_testData[9], false);
                        Bytesmallint0M.AssertModel(models[1],_testData[10], false);
                        Bytesmallint0M.AssertModel(models[2],_testData[11], false);
                        Bytesmallint0M.AssertModel(models[3],_testData[12], false);
                        Bytesmallint0M.AssertModel(models[4],_testData[13], false);
                        Bytesmallint0M.AssertModel(models[5],_testData[14], false);
                        Bytesmallint0M.AssertModel(models[6],_testData[15], false);
                        Bytesmallint0M.AssertModel(models[7],_testData[16], false);
                        Bytesmallint0M.AssertModel(models[8],_testData[17], false);
                        Bytesmallint0M.AssertModel(models[9],_testData[18], false);
                        Bytesmallint0M.AssertModel(models[10],_testData[19], false);
                        Bytesmallint0M.AssertModel(models[11],_testData[20], false);
                        Bytesmallint0M.AssertModel(models[12],_testData[21], false);
                        Bytesmallint0M.AssertModel(models[13],_testData[22], false);
                        Bytesmallint0M.AssertModel(models[14],_testData[23], false);
                        Bytesmallint0M.AssertModel(models[15],_testData[24], false);
                        Bytesmallint0M.AssertModel(models[16],_testData[25], false);
                        Bytesmallint0M.AssertModel(models[17],_testData[26], false);
                        Bytesmallint0M.AssertModel(models[18],_testData[27], false);
                        Bytesmallint0M.AssertModel(models[19],_testData[28], false);
                        Bytesmallint0M.AssertModel(models[20],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Bytesmallint0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IByteSingleTypesmallint)this).DbConnectionSTSelectModelBatch(connection, 68, 37))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Bytesmallint0M.AssertModel(models[0],_testData[15], false);
                        Bytesmallint0M.AssertModel(models[1],_testData[16], false);
                        Bytesmallint0M.AssertModel(models[2],_testData[17], false);
                        Bytesmallint0M.AssertModel(models[3],_testData[18], false);
                        Bytesmallint0M.AssertModel(models[4],_testData[19], false);
                        Bytesmallint0M.AssertModel(models[5],_testData[20], false);
                        Bytesmallint0M.AssertModel(models[6],_testData[21], false);
                        Bytesmallint0M.AssertModel(models[7],_testData[22], false);
                        Bytesmallint0M.AssertModel(models[8],_testData[23], false);
                        Bytesmallint0M.AssertModel(models[9],_testData[24], false);
                        Bytesmallint0M.AssertModel(models[10],_testData[25], false);
                        Bytesmallint0M.AssertModel(models[11],_testData[26], false);
                        Bytesmallint0M.AssertModel(models[12],_testData[27], false);
                        Bytesmallint0M.AssertModel(models[13],_testData[28], false);
                        Bytesmallint0M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Bytesmallint0M.AssertModel(models[0],_testData[7], false);
                        Bytesmallint0M.AssertModel(models[1],_testData[8], false);
                        Bytesmallint0M.AssertModel(models[2],_testData[9], false);
                        Bytesmallint0M.AssertModel(models[3],_testData[10], false);
                        Bytesmallint0M.AssertModel(models[4],_testData[11], false);
                        Bytesmallint0M.AssertModel(models[5],_testData[12], false);
                        Bytesmallint0M.AssertModel(models[6],_testData[13], false);
                        Bytesmallint0M.AssertModel(models[7],_testData[14], false);
                        Bytesmallint0M.AssertModel(models[8],_testData[15], false);
                        Bytesmallint0M.AssertModel(models[9],_testData[16], false);
                        Bytesmallint0M.AssertModel(models[10],_testData[17], false);
                        Bytesmallint0M.AssertModel(models[11],_testData[18], false);
                        Bytesmallint0M.AssertModel(models[12],_testData[19], false);
                        Bytesmallint0M.AssertModel(models[13],_testData[20], false);
                        Bytesmallint0M.AssertModel(models[14],_testData[21], false);
                        Bytesmallint0M.AssertModel(models[15],_testData[22], false);
                        Bytesmallint0M.AssertModel(models[16],_testData[23], false);
                        Bytesmallint0M.AssertModel(models[17],_testData[24], false);
                        Bytesmallint0M.AssertModel(models[18],_testData[25], false);
                        Bytesmallint0M.AssertModel(models[19],_testData[26], false);
                        Bytesmallint0M.AssertModel(models[20],_testData[27], false);
                        Bytesmallint0M.AssertModel(models[21],_testData[28], false);
                        Bytesmallint0M.AssertModel(models[22],_testData[29], false);
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
                ((IByteSingleTypesmallint)this).SetDbConnectionSelectModelParametrs(cmd, 69);
                var models = await ((IByteSingleTypesmallint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(14));
Bytesmallint0M.AssertModel(models[0],_testData[16], false);Bytesmallint0M.AssertModel(models[1],_testData[17], false);Bytesmallint0M.AssertModel(models[2],_testData[18], false);Bytesmallint0M.AssertModel(models[3],_testData[19], false);Bytesmallint0M.AssertModel(models[4],_testData[20], false);Bytesmallint0M.AssertModel(models[5],_testData[21], false);Bytesmallint0M.AssertModel(models[6],_testData[22], false);Bytesmallint0M.AssertModel(models[7],_testData[23], false);Bytesmallint0M.AssertModel(models[8],_testData[24], false);Bytesmallint0M.AssertModel(models[9],_testData[25], false);Bytesmallint0M.AssertModel(models[10],_testData[26], false);Bytesmallint0M.AssertModel(models[11],_testData[27], false);Bytesmallint0M.AssertModel(models[12],_testData[28], false);Bytesmallint0M.AssertModel(models[13],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IByteSingleTypesmallint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IByteSingleTypesmallint)this).SetDbConnectionSelectModelParametrs(cmd, 37);
                var models =  ((IByteSingleTypesmallint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
Bytesmallint0M.AssertModel(models[0],_testData[7], false);Bytesmallint0M.AssertModel(models[1],_testData[8], false);Bytesmallint0M.AssertModel(models[2],_testData[9], false);Bytesmallint0M.AssertModel(models[3],_testData[10], false);Bytesmallint0M.AssertModel(models[4],_testData[11], false);Bytesmallint0M.AssertModel(models[5],_testData[12], false);Bytesmallint0M.AssertModel(models[6],_testData[13], false);Bytesmallint0M.AssertModel(models[7],_testData[14], false);Bytesmallint0M.AssertModel(models[8],_testData[15], false);Bytesmallint0M.AssertModel(models[9],_testData[16], false);Bytesmallint0M.AssertModel(models[10],_testData[17], false);Bytesmallint0M.AssertModel(models[11],_testData[18], false);Bytesmallint0M.AssertModel(models[12],_testData[19], false);Bytesmallint0M.AssertModel(models[13],_testData[20], false);Bytesmallint0M.AssertModel(models[14],_testData[21], false);Bytesmallint0M.AssertModel(models[15],_testData[22], false);Bytesmallint0M.AssertModel(models[16],_testData[23], false);Bytesmallint0M.AssertModel(models[17],_testData[24], false);Bytesmallint0M.AssertModel(models[18],_testData[25], false);Bytesmallint0M.AssertModel(models[19],_testData[26], false);Bytesmallint0M.AssertModel(models[20],_testData[27], false);Bytesmallint0M.AssertModel(models[21],_testData[28], false);Bytesmallint0M.AssertModel(models[22],_testData[29], false);
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
FROM public.bytesmallint0m m
LEFT JOIN public.bytesmallint0mi mi ON mi.id = m.bytesmallint0mi_id
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((181)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((105)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((156)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((10)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((235)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((157)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((178)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((203)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((178)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((61)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((227)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((148)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((128)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((46)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((114)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((110)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((235)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((40)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((45)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((239)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((130)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((118)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((34)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((88)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((215)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((118)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((104)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((195)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((240)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((190)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((198)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((115)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((234)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((206)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((1)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((175)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((164)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((70)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((147)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((224)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((168)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((21)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((181)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((156)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((179)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((93)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((5)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((192)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((38)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((149)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((132)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((199)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((93)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((219)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((148)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((183)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((168)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((199)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((73)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((97)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((36)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((131)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((87)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((65)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((168)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((227)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((163)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((212)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((244)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IByteSingleTypesmallint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((181)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((105)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((156)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((10)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((235)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((157)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((178)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((203)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((178)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((61)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((227)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((148)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((128)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((46)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((114)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((110)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((235)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((40)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((45)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((239)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((130)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((118)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((34)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((88)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((215)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((118)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((104)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((195)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((240)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((190)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((198)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((115)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((234)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((206)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((1)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((175)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((164)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((70)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((147)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((224)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((168)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((21)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((181)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((156)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((179)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((93)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((5)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((192)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((38)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((149)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((132)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((199)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((93)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((219)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((148)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((183)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((168)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((199)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((73)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((97)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((36)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((131)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((87)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((65)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((168)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((227)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((163)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((212)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((244)));

            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bytesmallint0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(Bytesmallint0MI)],
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
        private void ImportModelInnerConfig()
        {
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_bytesmallint0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Bytesmallint0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Bytesmallint0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IByteSingleTypesmallint)this).ImportModelInner(connection, importCollection);
                var models = ((IByteSingleTypesmallint)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Bytesmallint0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((IByteSingleTypesmallint)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IByteSingleTypesmallint)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Bytesmallint0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bytesmallint0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bytesmallint0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(Bytesmallint0M)],
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
FROM public.binary_bytesmallint0m m
LEFT JOIN public.binary_bytesmallint0mi mi ON mi.id = m.bytesmallint0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Bytesmallint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Bytesmallint0M>(15);

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
                ((IByteSingleTypesmallint)this).ImportModel(connection, importCollection);
                var models = ((IByteSingleTypesmallint)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Bytesmallint0M.AssertModel(models[0],_testData[0], false);
                Bytesmallint0M.AssertModel(models[1],_testData[1], false);
                Bytesmallint0M.AssertModel(models[2],_testData[2], false);
                Bytesmallint0M.AssertModel(models[3],_testData[3], false);
                Bytesmallint0M.AssertModel(models[4],_testData[4], false);
                Bytesmallint0M.AssertModel(models[5],_testData[5], false);
                Bytesmallint0M.AssertModel(models[6],_testData[6], false);
                Bytesmallint0M.AssertModel(models[7],_testData[7], false);
                Bytesmallint0M.AssertModel(models[8],_testData[8], false);
                Bytesmallint0M.AssertModel(models[9],_testData[9], false);
                Bytesmallint0M.AssertModel(models[10],_testData[10], false);
                Bytesmallint0M.AssertModel(models[11],_testData[11], false);
                Bytesmallint0M.AssertModel(models[12],_testData[12], false);
                Bytesmallint0M.AssertModel(models[13],_testData[13], false);
                Bytesmallint0M.AssertModel(models[14],_testData[14], false);
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
                await ((IByteSingleTypesmallint)this).ImportModelAsync(connection, importCollection);
                models = await ((IByteSingleTypesmallint)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Bytesmallint0M.AssertModel(models[0],_testData[0], false);
                Bytesmallint0M.AssertModel(models[1],_testData[1], false);
                Bytesmallint0M.AssertModel(models[2],_testData[2], false);
                Bytesmallint0M.AssertModel(models[3],_testData[3], false);
                Bytesmallint0M.AssertModel(models[4],_testData[4], false);
                Bytesmallint0M.AssertModel(models[5],_testData[5], false);
                Bytesmallint0M.AssertModel(models[6],_testData[6], false);
                Bytesmallint0M.AssertModel(models[7],_testData[7], false);
                Bytesmallint0M.AssertModel(models[8],_testData[8], false);
                Bytesmallint0M.AssertModel(models[9],_testData[9], false);
                Bytesmallint0M.AssertModel(models[10],_testData[10], false);
                Bytesmallint0M.AssertModel(models[11],_testData[11], false);
                Bytesmallint0M.AssertModel(models[12],_testData[12], false);
                Bytesmallint0M.AssertModel(models[13],_testData[13], false);
                Bytesmallint0M.AssertModel(models[14],_testData[14], false);
                Bytesmallint0M.AssertModel(models[15],_testData[15], false);
                Bytesmallint0M.AssertModel(models[16],_testData[16], false);
                Bytesmallint0M.AssertModel(models[17],_testData[17], false);
                Bytesmallint0M.AssertModel(models[18],_testData[18], false);
                Bytesmallint0M.AssertModel(models[19],_testData[19], false);
                Bytesmallint0M.AssertModel(models[20],_testData[20], false);
                Bytesmallint0M.AssertModel(models[21],_testData[21], false);
                Bytesmallint0M.AssertModel(models[22],_testData[22], false);
                Bytesmallint0M.AssertModel(models[23],_testData[23], false);
                Bytesmallint0M.AssertModel(models[24],_testData[24], false);
                Bytesmallint0M.AssertModel(models[25],_testData[25], false);
                Bytesmallint0M.AssertModel(models[26],_testData[26], false);
                Bytesmallint0M.AssertModel(models[27],_testData[27], false);
                Bytesmallint0M.AssertModel(models[28],_testData[28], false);
                Bytesmallint0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bytesmallint0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bytesmallint0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Bytesmallint0M)],
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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
                    Bytesmallint0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
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
                    Bytesmallint0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bytesmallint0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Bytesmallint0MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IByteSingleTypesmallint)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Bytesmallint0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IByteSingleTypesmallint)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Bytesmallint0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

