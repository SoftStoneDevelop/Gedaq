

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
    internal partial interface IInt16SingleTypesmallint
    {
    }
    
    internal partial class Int16SingleTypesmallint : IInt16SingleTypesmallint
    {


#region TestData

        private readonly Int16smallintE0M[] _testData = new Int16smallintE0M[]
        {
            new Int16smallintE0M
{
    Id = 8,
    Value = 9615,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 15,
    Value = 16824,
    ModelInner = new Int16smallintE0MI
{
    Id = 7,
    Value = 14141,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 23,
    Value = 18902,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 24,
    Value = 2299,
    ModelInner = new Int16smallintE0MI
{
    Id = 13,
    Value = 6865,
    NullableValue = null,
},
    NullableValue = 13848,
},
            new Int16smallintE0M
{
    Id = 31,
    Value = 816,
    ModelInner = null,
    NullableValue = 16081,
},
            new Int16smallintE0M
{
    Id = 40,
    Value = 3098,
    ModelInner = new Int16smallintE0MI
{
    Id = 14,
    Value = 24237,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 41,
    Value = 2843,
    ModelInner = null,
    NullableValue = 28673,
},
            new Int16smallintE0M
{
    Id = 50,
    Value = 5396,
    ModelInner = new Int16smallintE0MI
{
    Id = 22,
    Value = 28599,
    NullableValue = 26161,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 59,
    Value = 15273,
    ModelInner = null,
    NullableValue = 8878,
},
            new Int16smallintE0M
{
    Id = 64,
    Value = 16616,
    ModelInner = new Int16smallintE0MI
{
    Id = 31,
    Value = 16833,
    NullableValue = 18244,
},
    NullableValue = 15836,
},
            new Int16smallintE0M
{
    Id = 70,
    Value = 27870,
    ModelInner = null,
    NullableValue = 6779,
},
            new Int16smallintE0M
{
    Id = 76,
    Value = 7931,
    ModelInner = new Int16smallintE0MI
{
    Id = 34,
    Value = 13660,
    NullableValue = null,
},
    NullableValue = 2197,
},
            new Int16smallintE0M
{
    Id = 83,
    Value = 28433,
    ModelInner = null,
    NullableValue = 24575,
},
            new Int16smallintE0M
{
    Id = 91,
    Value = 5476,
    ModelInner = new Int16smallintE0MI
{
    Id = 40,
    Value = 31226,
    NullableValue = 1259,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 93,
    Value = 31016,
    ModelInner = null,
    NullableValue = 16417,
},
            new Int16smallintE0M
{
    Id = 99,
    Value = 27860,
    ModelInner = new Int16smallintE0MI
{
    Id = 42,
    Value = 18496,
    NullableValue = null,
},
    NullableValue = 23964,
},
            new Int16smallintE0M
{
    Id = 105,
    Value = 3693,
    ModelInner = null,
    NullableValue = 4402,
},
            new Int16smallintE0M
{
    Id = 113,
    Value = 11211,
    ModelInner = new Int16smallintE0MI
{
    Id = 43,
    Value = 12446,
    NullableValue = 25729,
},
    NullableValue = 21479,
},
            new Int16smallintE0M
{
    Id = 114,
    Value = 9855,
    ModelInner = null,
    NullableValue = 28868,
},
            new Int16smallintE0M
{
    Id = 115,
    Value = 24687,
    ModelInner = new Int16smallintE0MI
{
    Id = 47,
    Value = 9662,
    NullableValue = null,
},
    NullableValue = 15141,
},
            new Int16smallintE0M
{
    Id = 116,
    Value = 20900,
    ModelInner = null,
    NullableValue = 25852,
},
            new Int16smallintE0M
{
    Id = 122,
    Value = 8566,
    ModelInner = new Int16smallintE0MI
{
    Id = 48,
    Value = 5336,
    NullableValue = null,
},
    NullableValue = 23669,
},
            new Int16smallintE0M
{
    Id = 125,
    Value = 14645,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 132,
    Value = 14017,
    ModelInner = new Int16smallintE0MI
{
    Id = 56,
    Value = 2177,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 141,
    Value = 20072,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 147,
    Value = 31019,
    ModelInner = new Int16smallintE0MI
{
    Id = 65,
    Value = 5775,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 154,
    Value = 24039,
    ModelInner = null,
    NullableValue = 4390,
},
            new Int16smallintE0M
{
    Id = 162,
    Value = 27217,
    ModelInner = new Int16smallintE0MI
{
    Id = 66,
    Value = 5957,
    NullableValue = null,
},
    NullableValue = 31705,
},
            new Int16smallintE0M
{
    Id = 166,
    Value = 12720,
    ModelInner = null,
    NullableValue = 7918,
},
            new Int16smallintE0M
{
    Id = 170,
    Value = 2938,
    ModelInner = new Int16smallintE0MI
{
    Id = 75,
    Value = 26000,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 178,
    Value = 32154,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 183,
    Value = 7465,
    ModelInner = new Int16smallintE0MI
{
    Id = 76,
    Value = 22803,
    NullableValue = 14281,
},
    NullableValue = 9602,
},
            new Int16smallintE0M
{
    Id = 190,
    Value = 3790,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 198,
    Value = 9043,
    ModelInner = new Int16smallintE0MI
{
    Id = 77,
    Value = 10496,
    NullableValue = null,
},
    NullableValue = 5114,
},
            new Int16smallintE0M
{
    Id = 200,
    Value = 13026,
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallinte0mi(
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
            asPartInterface: typeof(IInt16SingleTypesmallint)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallinte0mi(
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
            queryMapTypes: [typeof(Int16smallintE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
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

                changedRows =  ((IInt16SingleTypesmallint)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt16SingleTypesmallint)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt16SingleTypesmallint)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt16SingleTypesmallint)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt16SingleTypesmallint)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt16SingleTypesmallint)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt16SingleTypesmallint)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.int16smallinte0mi(
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
            asPartInterface: typeof(IInt16SingleTypesmallint)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(10)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
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

                changedRows =  ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallinte0m(
	id,
    value,
    nullablevalue,
    int16smallinte0mi_id
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
            asPartInterface: typeof(IInt16SingleTypesmallint)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int16smallinte0mi_id", 
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
                changedRows =  ((IInt16SingleTypesmallint)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt16SingleTypesmallint)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt16SingleTypesmallint)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt16SingleTypesmallint)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallinte0m(
	id,
    value,
    nullablevalue,
    int16smallinte0mi_id
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
    int16smallinte0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int16smallintE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int16? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Int16>();
                    ((NpgsqlParameter<System.Int16>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(18);
                    ((NpgsqlParameter<System.Int16>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(18);
                    if (_testData[4].NullableValue != null)
                    {
                        parameters[2].Value = _testData[4].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[4].ModelInner != null)
                    {
                        parameters[3].Value = _testData[4].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IInt16SingleTypesmallint)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(16081));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Int16>();
                    ((NpgsqlParameter<System.Int16>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(18);
                    ((NpgsqlParameter<System.Int16>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(18);
                    if (_testData[5].NullableValue != null)
                    {
                        parameters[2].Value = _testData[5].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[5].ModelInner != null)
                    {
                        parameters[3].Value = _testData[5].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IInt16SingleTypesmallint)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int16? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Int16>();
                    ((NpgsqlParameter<System.Int16>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(18);
                    ((NpgsqlParameter<System.Int16>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(18);
                    if (_testData[6].NullableValue != null)
                    {
                        parameters[2].Value = _testData[6].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[6].ModelInner != null)
                    {
                        parameters[3].Value = _testData[6].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IInt16SingleTypesmallint)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(28673));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Int16>();
                    ((NpgsqlParameter<System.Int16>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(18);
                    ((NpgsqlParameter<System.Int16>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(18);
                    if (_testData[7].NullableValue != null)
                    {
                        parameters[2].Value = _testData[7].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[7].ModelInner != null)
                    {
                        parameters[3].Value = _testData[7].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IInt16SingleTypesmallint)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int16smallinte0m(
	id,
    value,
    nullablevalue,
    int16smallinte0mi_id
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
    int16smallinte0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int16smallintE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int16smallinte0mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int16? nullable = null;
                nullable =  ((IInt16SingleTypesmallint)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(8878));
                nullable =  ((IInt16SingleTypesmallint)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(15836));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int16? nullable = null;
                nullable = await ((IInt16SingleTypesmallint)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(6779));
                nullable = await ((IInt16SingleTypesmallint)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(2197));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int16smallintE0M> models = null;

                models =  ((IInt16SingleTypesmallint)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintE0M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt16SingleTypesmallint)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintE0M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt16SingleTypesmallint)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintE0M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt16SingleTypesmallint)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int16smallintE0M> models = null;

                models = await ((IInt16SingleTypesmallint)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintE0M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt16SingleTypesmallint)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintE0M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt16SingleTypesmallint)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintE0M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt16SingleTypesmallint)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int16smallintE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.int16smallinte0m(
	id,
    value,
    nullablevalue,
    int16smallinte0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int16smallinte0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int16), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(10)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(10),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int16smallinte0mi_id", 
                methodParametrName: "int16smallinte0mi_id", 
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

                changedRows =  ((IInt16SingleTypesmallint)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt16SingleTypesmallint)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintE0M), typeof(FlatInt16smallintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM public.int16smallinte0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt16smallintE0M>();
                var models2 = new List<FlatInt16smallintE0M>();
                await ((IInt16SingleTypesmallint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int16smallinte0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt16smallintE0M>();
                var models2 = new List<FlatInt16smallintE0M>();
                ((IInt16SingleTypesmallint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM public.int16smallinte0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt16SingleTypesmallint)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallinte0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt16SingleTypesmallint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallinte0m m
LEFT JOIN public.int16smallinte0mi mi ON mi.id = m.int16smallinte0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int16smallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
                var models = await ((IInt16SingleTypesmallint)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt16SingleTypesmallint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintE0M), typeof(FlatInt16smallintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM public.int16smallinte0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallintE0M>();
                var models2 = new List<FlatInt16smallintE0M>();
                await ((IInt16SingleTypesmallint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int16smallinte0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallintE0M>();
                var models2 = new List<FlatInt16smallintE0M>();
                ((IInt16SingleTypesmallint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM public.int16smallinte0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt16SingleTypesmallint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallinte0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt16SingleTypesmallint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallinte0m m
LEFT JOIN public.int16smallinte0mi mi ON mi.id = m.int16smallinte0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int16smallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
                var models = await ((IInt16SingleTypesmallint)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt16SingleTypesmallint)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintE0M), typeof(FlatInt16smallintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM public.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt16smallintE0M>();
                var models2 = new List<FlatInt16smallintE0M>();
                await((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
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
FROM public.int16smallinte0m m
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
FROM public.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 154;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 190;
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
FROM public.int16smallinte0m m
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
FROM public.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[34], false);
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
FROM public.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt16smallintE0M>();
                var models2 = new List<FlatInt16smallintE0M>();
                ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
FROM public.int16smallinte0m m
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
FROM public.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 190;
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
FROM public.int16smallinte0m m
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
FROM public.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM public.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int16smallinte0m m
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
FROM public.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(models[4],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(models[5],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(models[6],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(models[7],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(models[8],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(models[9],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(models[10],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(models[11],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(models[12],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(models[13],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(models[14],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(models[15],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(models[16],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(models[17],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(models[18],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(models[19],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(models[20],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(models[21],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[22],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[23],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[4],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[5],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int16smallinte0m m
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
FROM public.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 154;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 154;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int16smallinte0m m
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
FROM public.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(models[4],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[5],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[6],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(models[4],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[5],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[6],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int16smallinte0m m
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
FROM public.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.int16smallinte0m m
LEFT JOIN public.int16smallinte0mi mi ON mi.id = m.int16smallinte0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int16smallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
                var models = await((IInt16SingleTypesmallint)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 154;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Int16smallintE0M.AssertModel(models[0],_testData[27], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[28], false);
                        Int16smallintE0M.AssertModel(models[2],_testData[29], false);
                        Int16smallintE0M.AssertModel(models[3],_testData[30], false);
                        Int16smallintE0M.AssertModel(models[4],_testData[31], false);
                        Int16smallintE0M.AssertModel(models[5],_testData[32], false);
                        Int16smallintE0M.AssertModel(models[6],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Int16smallintE0M.AssertModel(models[0],_testData[20], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[21], false);
                        Int16smallintE0M.AssertModel(models[2],_testData[22], false);
                        Int16smallintE0M.AssertModel(models[3],_testData[23], false);
                        Int16smallintE0M.AssertModel(models[4],_testData[24], false);
                        Int16smallintE0M.AssertModel(models[5],_testData[25], false);
                        Int16smallintE0M.AssertModel(models[6],_testData[26], false);
                        Int16smallintE0M.AssertModel(models[7],_testData[27], false);
                        Int16smallintE0M.AssertModel(models[8],_testData[28], false);
                        Int16smallintE0M.AssertModel(models[9],_testData[29], false);
                        Int16smallintE0M.AssertModel(models[10],_testData[30], false);
                        Int16smallintE0M.AssertModel(models[11],_testData[31], false);
                        Int16smallintE0M.AssertModel(models[12],_testData[32], false);
                        Int16smallintE0M.AssertModel(models[13],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[14],_testData[34], false);
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
                var models = ((IInt16SingleTypesmallint)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int16smallintE0M.AssertModel(models[0],_testData[24], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[25], false);
                        Int16smallintE0M.AssertModel(models[2],_testData[26], false);
                        Int16smallintE0M.AssertModel(models[3],_testData[27], false);
                        Int16smallintE0M.AssertModel(models[4],_testData[28], false);
                        Int16smallintE0M.AssertModel(models[5],_testData[29], false);
                        Int16smallintE0M.AssertModel(models[6],_testData[30], false);
                        Int16smallintE0M.AssertModel(models[7],_testData[31], false);
                        Int16smallintE0M.AssertModel(models[8],_testData[32], false);
                        Int16smallintE0M.AssertModel(models[9],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Int16smallintE0M.AssertModel(models[0],_testData[16], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[17], false);
                        Int16smallintE0M.AssertModel(models[2],_testData[18], false);
                        Int16smallintE0M.AssertModel(models[3],_testData[19], false);
                        Int16smallintE0M.AssertModel(models[4],_testData[20], false);
                        Int16smallintE0M.AssertModel(models[5],_testData[21], false);
                        Int16smallintE0M.AssertModel(models[6],_testData[22], false);
                        Int16smallintE0M.AssertModel(models[7],_testData[23], false);
                        Int16smallintE0M.AssertModel(models[8],_testData[24], false);
                        Int16smallintE0M.AssertModel(models[9],_testData[25], false);
                        Int16smallintE0M.AssertModel(models[10],_testData[26], false);
                        Int16smallintE0M.AssertModel(models[11],_testData[27], false);
                        Int16smallintE0M.AssertModel(models[12],_testData[28], false);
                        Int16smallintE0M.AssertModel(models[13],_testData[29], false);
                        Int16smallintE0M.AssertModel(models[14],_testData[30], false);
                        Int16smallintE0M.AssertModel(models[15],_testData[31], false);
                        Int16smallintE0M.AssertModel(models[16],_testData[32], false);
                        Int16smallintE0M.AssertModel(models[17],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintE0M), typeof(FlatInt16smallintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM public.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallintE0M>();
                var models2 = new List<FlatInt16smallintE0M>();
                await((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int16smallinte0m m
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
FROM public.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 40, query1, 162, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.int16smallinte0m m
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
FROM public.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 170, query1, 141, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[34], false);
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
FROM public.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallintE0M>();
                var models2 = new List<FlatInt16smallintE0M>();
                ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int16smallinte0m m
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
FROM public.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 166, query1, 50, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.int16smallinte0m m
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
FROM public.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 23, query1, 23, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[31],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM public.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallinte0m m
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
FROM public.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 31, query1, 24, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(models[4],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(models[5],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(models[6],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(models[7],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(models[8],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(models[9],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(models[10],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(models[11],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(models[12],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(models[13],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(models[14],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(models[15],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(models[16],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(models[17],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(models[18],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(models[19],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(models[20],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(models[21],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(models[22],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(models[23],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(models[24],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(models[25],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(models[26],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[27],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[28],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[4], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(models[4],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(models[5],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(models[6],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(models[7],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(models[8],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(models[9],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(models[10],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(models[11],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(models[12],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(models[13],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(models[14],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(models[15],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(models[16],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(models[17],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(models[18],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(models[19],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(models[20],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(models[21],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(models[22],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(models[23],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(models[24],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(models[25],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(models[26],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(models[27],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[28],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[29],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[30],_testData[34], false);
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
FROM public.int16smallinte0m m
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
FROM public.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 59, query1, 114, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int16smallinte0m m
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
FROM public.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 91, query1, 50, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(models[4],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(models[5],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(models[6],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(models[7],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(models[8],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(models[9],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(models[10],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(models[11],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(models[12],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(models[13],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(models[14],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(models[15],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(models[16],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(models[17],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[18],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[19],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(models[4],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(models[5],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(models[6],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(models[7],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(models[8],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(models[9],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(models[10],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(models[11],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(models[12],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(models[13],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(models[14],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(models[15],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(models[16],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(models[17],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(models[18],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(models[19],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(models[20],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(models[21],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(models[22],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(models[23],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[24],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[25],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[26],_testData[34], false);
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
FROM public.int16smallinte0m m
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
FROM public.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelBatch(connection, 122, query1, 15, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.int16smallinte0m m
LEFT JOIN public.int16smallinte0mi mi ON mi.id = m.int16smallinte0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int16smallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
                var models = await((IInt16SingleTypesmallint)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionSTSelectModelBatchAsync(connection, 190, 105))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int16smallintE0M.AssertModel(models[0],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Int16smallintE0M.AssertModel(models[0],_testData[17], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[18], false);
                        Int16smallintE0M.AssertModel(models[2],_testData[19], false);
                        Int16smallintE0M.AssertModel(models[3],_testData[20], false);
                        Int16smallintE0M.AssertModel(models[4],_testData[21], false);
                        Int16smallintE0M.AssertModel(models[5],_testData[22], false);
                        Int16smallintE0M.AssertModel(models[6],_testData[23], false);
                        Int16smallintE0M.AssertModel(models[7],_testData[24], false);
                        Int16smallintE0M.AssertModel(models[8],_testData[25], false);
                        Int16smallintE0M.AssertModel(models[9],_testData[26], false);
                        Int16smallintE0M.AssertModel(models[10],_testData[27], false);
                        Int16smallintE0M.AssertModel(models[11],_testData[28], false);
                        Int16smallintE0M.AssertModel(models[12],_testData[29], false);
                        Int16smallintE0M.AssertModel(models[13],_testData[30], false);
                        Int16smallintE0M.AssertModel(models[14],_testData[31], false);
                        Int16smallintE0M.AssertModel(models[15],_testData[32], false);
                        Int16smallintE0M.AssertModel(models[16],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[17],_testData[34], false);
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
                var models = ((IInt16SingleTypesmallint)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionSTSelectModelBatch(connection, 113, 99))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Int16smallintE0M.AssertModel(models[0],_testData[18], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[19], false);
                        Int16smallintE0M.AssertModel(models[2],_testData[20], false);
                        Int16smallintE0M.AssertModel(models[3],_testData[21], false);
                        Int16smallintE0M.AssertModel(models[4],_testData[22], false);
                        Int16smallintE0M.AssertModel(models[5],_testData[23], false);
                        Int16smallintE0M.AssertModel(models[6],_testData[24], false);
                        Int16smallintE0M.AssertModel(models[7],_testData[25], false);
                        Int16smallintE0M.AssertModel(models[8],_testData[26], false);
                        Int16smallintE0M.AssertModel(models[9],_testData[27], false);
                        Int16smallintE0M.AssertModel(models[10],_testData[28], false);
                        Int16smallintE0M.AssertModel(models[11],_testData[29], false);
                        Int16smallintE0M.AssertModel(models[12],_testData[30], false);
                        Int16smallintE0M.AssertModel(models[13],_testData[31], false);
                        Int16smallintE0M.AssertModel(models[14],_testData[32], false);
                        Int16smallintE0M.AssertModel(models[15],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Int16smallintE0M.AssertModel(models[0],_testData[16], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[17], false);
                        Int16smallintE0M.AssertModel(models[2],_testData[18], false);
                        Int16smallintE0M.AssertModel(models[3],_testData[19], false);
                        Int16smallintE0M.AssertModel(models[4],_testData[20], false);
                        Int16smallintE0M.AssertModel(models[5],_testData[21], false);
                        Int16smallintE0M.AssertModel(models[6],_testData[22], false);
                        Int16smallintE0M.AssertModel(models[7],_testData[23], false);
                        Int16smallintE0M.AssertModel(models[8],_testData[24], false);
                        Int16smallintE0M.AssertModel(models[9],_testData[25], false);
                        Int16smallintE0M.AssertModel(models[10],_testData[26], false);
                        Int16smallintE0M.AssertModel(models[11],_testData[27], false);
                        Int16smallintE0M.AssertModel(models[12],_testData[28], false);
                        Int16smallintE0M.AssertModel(models[13],_testData[29], false);
                        Int16smallintE0M.AssertModel(models[14],_testData[30], false);
                        Int16smallintE0M.AssertModel(models[15],_testData[31], false);
                        Int16smallintE0M.AssertModel(models[16],_testData[32], false);
                        Int16smallintE0M.AssertModel(models[17],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[18],_testData[34], false);
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
                await using var cmd = await ((IInt16SingleTypesmallint)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt16SingleTypesmallint)this).SetDbConnectionSelectModelParametrs(cmd, 132);
                var models = await ((IInt16SingleTypesmallint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                Int16smallintE0M.AssertModel(models[0],_testData[24], false);
                Int16smallintE0M.AssertModel(models[1],_testData[25], false);
                Int16smallintE0M.AssertModel(models[2],_testData[26], false);
                Int16smallintE0M.AssertModel(models[3],_testData[27], false);
                Int16smallintE0M.AssertModel(models[4],_testData[28], false);
                Int16smallintE0M.AssertModel(models[5],_testData[29], false);
                Int16smallintE0M.AssertModel(models[6],_testData[30], false);
                Int16smallintE0M.AssertModel(models[7],_testData[31], false);
                Int16smallintE0M.AssertModel(models[8],_testData[32], false);
                Int16smallintE0M.AssertModel(models[9],_testData[33], false);
                Int16smallintE0M.AssertModel(models[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt16SingleTypesmallint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt16SingleTypesmallint)this).SetDbConnectionSelectModelParametrs(cmd, 114);
                var models =  ((IInt16SingleTypesmallint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

                Int16smallintE0M.AssertModel(models[0],_testData[19], false);
                Int16smallintE0M.AssertModel(models[1],_testData[20], false);
                Int16smallintE0M.AssertModel(models[2],_testData[21], false);
                Int16smallintE0M.AssertModel(models[3],_testData[22], false);
                Int16smallintE0M.AssertModel(models[4],_testData[23], false);
                Int16smallintE0M.AssertModel(models[5],_testData[24], false);
                Int16smallintE0M.AssertModel(models[6],_testData[25], false);
                Int16smallintE0M.AssertModel(models[7],_testData[26], false);
                Int16smallintE0M.AssertModel(models[8],_testData[27], false);
                Int16smallintE0M.AssertModel(models[9],_testData[28], false);
                Int16smallintE0M.AssertModel(models[10],_testData[29], false);
                Int16smallintE0M.AssertModel(models[11],_testData[30], false);
                Int16smallintE0M.AssertModel(models[12],_testData[31], false);
                Int16smallintE0M.AssertModel(models[13],_testData[32], false);
                Int16smallintE0M.AssertModel(models[14],_testData[33], false);
                Int16smallintE0M.AssertModel(models[15],_testData[34], false);
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
FROM public.int16smallinte0m m
LEFT JOIN public.int16smallinte0mi mi ON mi.id = m.int16smallinte0mi_id
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
            asPartInterface: typeof(IInt16SingleTypesmallint))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt16SingleTypesmallint)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((9615)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((16824)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((14141)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((18902)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((2299)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((6865)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((13848)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((816)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((16081)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((3098)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((24237)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((2843)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((28673)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((5396)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((28599)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((26161)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15273)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((8878)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((16616)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((16833)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((18244)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((15836)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((27870)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((6779)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((7931)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((13660)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((2197)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((28433)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((24575)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((5476)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((31226)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((1259)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((31016)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((16417)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((27860)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((18496)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((23964)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((3693)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((4402)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((11211)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((12446)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((25729)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((21479)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((9855)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((28868)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((24687)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((9662)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((15141)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((20900)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((25852)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((8566)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((5336)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((23669)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((14645)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((14017)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((2177)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((20072)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((31019)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((5775)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((24039)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((4390)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((27217)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((5957)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((31705)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((12720)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((7918)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((2938)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((26000)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((32154)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((7465)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((22803)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((14281)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((9602)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((190)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((3790)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((198)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((9043)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((10496)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((5114)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((200)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((13026)));//Value

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
                var models =  ((IInt16SingleTypesmallint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((9615)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((16824)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((14141)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((18902)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((2299)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((6865)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((13848)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((816)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((16081)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((3098)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((24237)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((2843)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((28673)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((5396)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((28599)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((26161)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15273)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((8878)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((16616)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((16833)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((18244)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((15836)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((27870)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((6779)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((7931)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((13660)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((2197)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((28433)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((24575)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((5476)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((31226)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((1259)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((31016)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((16417)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((27860)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((18496)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((23964)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((3693)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((4402)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((11211)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((12446)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((25729)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((21479)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((9855)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((28868)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((24687)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((9662)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((15141)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((20900)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((25852)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((8566)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((5336)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((23669)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((14645)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((14017)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((2177)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((20072)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((31019)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((5775)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((24039)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((4390)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((27217)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((5957)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((31705)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((12720)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((7918)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((2938)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((26000)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((32154)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((7465)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((22803)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((14281)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((9602)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((190)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((3790)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((198)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((9043)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((10496)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((5114)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((200)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((13026)));//Value

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
FROM public.binary_int16smallinte0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int16smallintE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int16smallintE0MIWA),
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
            asPartInterface: typeof(IInt16SingleTypesmallint))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int16smallintE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt16SingleTypesmallint)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int16smallinte0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt16SingleTypesmallint)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int16smallintE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt16SingleTypesmallint)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int16smallinte0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt16SingleTypesmallint)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int16smallinte0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int16smallintE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int16smallintE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int16smallintE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt16SingleTypesmallint)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int16smallinte0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt16SingleTypesmallint)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int16smallintE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt16SingleTypesmallint)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int16smallinte0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt16SingleTypesmallint)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int16smallinte0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int16smallintE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int16smallinte0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int16smallintE0MI),
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
            asPartInterface: typeof(IInt16SingleTypesmallint))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int16smallintE0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt16SingleTypesmallint)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt16SingleTypesmallint)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int16smallintE0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt16SingleTypesmallint)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt16SingleTypesmallint)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_int16smallinte0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int16smallintE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int16smallinte0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int16smallintE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int16smallintE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt16SingleTypesmallint)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt16SingleTypesmallint)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int16smallintE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int16smallintE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt16SingleTypesmallint)this).ImportModelInner(connection, importCollection);
                var models = ((IInt16SingleTypesmallint)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int16smallintE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int16smallinte0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int16smallinte0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int16smallintE0M),
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
            asPartInterface: typeof(IInt16SingleTypesmallint))]
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
FROM public.binary_int16smallinte0m m
LEFT JOIN public.binary_int16smallinte0mi mi ON mi.id = m.int16smallinte0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int16smallintE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int16smallintE0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt16SingleTypesmallint)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt16SingleTypesmallint)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int16smallintE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int16smallintE0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt16SingleTypesmallint)this).ImportModel(connection, importCollection);
                var models = ((IInt16SingleTypesmallint)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int16smallintE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int16smallinte0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int16smallinte0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int16smallintE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
                var models =  ((IInt16SingleTypesmallint)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int16smallintE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt16SingleTypesmallint)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int16smallintE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int16smallintE0MIWA), typeof(Int16smallintE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
                var models1 = new List<Int16smallintE0MIWA>();
                var models2 = new List<Int16smallintE0MIWA>();
                await ((IInt16SingleTypesmallint)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int16smallinte0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int16smallintE0MIWA>();
                var models2 = new List<Int16smallintE0MIWA>();
                ((IInt16SingleTypesmallint)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int16smallinte0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int16smallintE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
                var models = await ((IInt16SingleTypesmallint)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int16smallinte0mi
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
                    Int16smallintE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt16SingleTypesmallint)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int16smallinte0mi
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
                    Int16smallintE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int16smallintE0MIWA), typeof(Int16smallintE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint))]
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
                var models1 = new List<Int16smallintE0MIWA>();
                var models2 = new List<Int16smallintE0MIWA>();
                await ((IInt16SingleTypesmallint)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int16smallinte0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int16smallintE0MIWA>();
                var models2 = new List<Int16smallintE0MIWA>();
                ((IInt16SingleTypesmallint)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int16smallinte0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int16smallintE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint))]
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
                var models = await ((IInt16SingleTypesmallint)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int16smallinte0mi
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
                    Int16smallintE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt16SingleTypesmallint)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int16smallinte0mi
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
                    Int16smallintE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int16smallinte0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int16smallintE0MI), typeof(Int16smallintE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
                var models1 = new List<Int16smallintE0MI>();
                var models2 = new List<Int16smallintE0MI>();
                await ((IInt16SingleTypesmallint)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int16smallintE0MI>();
                var models2 = new List<Int16smallintE0MI>();
                ((IInt16SingleTypesmallint)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int16smallinte0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int16smallintE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
                var models = await ((IInt16SingleTypesmallint)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int16smallintE0MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt16SingleTypesmallint)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int16smallintE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int16smallinte0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int16smallintE0MIWA), typeof(Int16smallintE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint))]
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
                var models1 = new List<Int16smallintE0MIWA>();
                var models2 = new List<Int16smallintE0MIWA>();
                await ((IInt16SingleTypesmallint)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int16smallintE0MIWA>();
                var models2 = new List<Int16smallintE0MIWA>();
                ((IInt16SingleTypesmallint)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int16smallintE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int16smallintE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int16smallinte0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int16smallintE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint))]
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
                var models = await ((IInt16SingleTypesmallint)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int16smallintE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt16SingleTypesmallint)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int16smallintE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

