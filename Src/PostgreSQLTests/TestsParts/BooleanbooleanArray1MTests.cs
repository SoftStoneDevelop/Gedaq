

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
    internal partial interface IBooleanArraybooleanArray
    {
    }
    
    internal partial class BooleanArraybooleanArray : IBooleanArraybooleanArray
    {


#region TestData

        private readonly BooleanbooleanArray1M[] _testData = new BooleanbooleanArray1M[]
        {
            new BooleanbooleanArray1M
{
    Id = 9,
    Value = 
new System.Boolean[3]
{
false,
false,
false,
},
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanArray1M
{
    Id = 15,
    Value = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
    ModelInner = new BooleanbooleanArray1MI
{
    Id = 3,
    Value = 
new System.Boolean[3]
{
false,
false,
false,
},
    NullableValue = 
new System.Boolean[3]
{
false,
false,
false,
},
},
    NullableValue = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
},
            new BooleanbooleanArray1M
{
    Id = 20,
    Value = 
new System.Boolean[3]
{
false,
false,
false,
},
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanArray1M
{
    Id = 25,
    Value = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
    ModelInner = new BooleanbooleanArray1MI
{
    Id = 9,
    Value = 
new System.Boolean[3]
{
false,
false,
false,
},
    NullableValue = 
new System.Boolean[3]
{
false,
false,
false,
},
},
    NullableValue = 
new System.Boolean[3]
{
false,
false,
false,
},
},
            new BooleanbooleanArray1M
{
    Id = 27,
    Value = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
    ModelInner = null,
    NullableValue = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
},
            new BooleanbooleanArray1M
{
    Id = 31,
    Value = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
    ModelInner = new BooleanbooleanArray1MI
{
    Id = 14,
    Value = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
    NullableValue = 
new System.Boolean[3]
{
false,
false,
false,
},
},
    NullableValue = null,
},
            new BooleanbooleanArray1M
{
    Id = 38,
    Value = 
new System.Boolean[3]
{
false,
false,
false,
},
    ModelInner = null,
    NullableValue = 
new System.Boolean[3]
{
false,
false,
false,
},
},
            new BooleanbooleanArray1M
{
    Id = 47,
    Value = 
new System.Boolean[3]
{
false,
false,
false,
},
    ModelInner = new BooleanbooleanArray1MI
{
    Id = 22,
    Value = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BooleanbooleanArray1M
{
    Id = 49,
    Value = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
    ModelInner = null,
    NullableValue = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
},
            new BooleanbooleanArray1M
{
    Id = 54,
    Value = 
new System.Boolean[3]
{
false,
false,
false,
},
    ModelInner = new BooleanbooleanArray1MI
{
    Id = 25,
    Value = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
    NullableValue = 
new System.Boolean[3]
{
false,
false,
false,
},
},
    NullableValue = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
},
            new BooleanbooleanArray1M
{
    Id = 63,
    Value = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanArray1M
{
    Id = 70,
    Value = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
    ModelInner = new BooleanbooleanArray1MI
{
    Id = 28,
    Value = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
    NullableValue = 
new System.Boolean[3]
{
false,
false,
false,
},
},
    NullableValue = null,
},
            new BooleanbooleanArray1M
{
    Id = 76,
    Value = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanArray1M
{
    Id = 81,
    Value = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
    ModelInner = new BooleanbooleanArray1MI
{
    Id = 35,
    Value = 
new System.Boolean[3]
{
false,
false,
false,
},
    NullableValue = 
new System.Boolean[3]
{
false,
false,
false,
},
},
    NullableValue = null,
},
            new BooleanbooleanArray1M
{
    Id = 84,
    Value = 
new System.Boolean[3]
{
false,
false,
false,
},
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanArray1M
{
    Id = 91,
    Value = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
    ModelInner = new BooleanbooleanArray1MI
{
    Id = 44,
    Value = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
    NullableValue = null,
},
    NullableValue = 
new System.Boolean[3]
{
false,
false,
false,
},
},
            new BooleanbooleanArray1M
{
    Id = 96,
    Value = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanArray1M
{
    Id = 98,
    Value = 
new System.Boolean[3]
{
false,
false,
false,
},
    ModelInner = new BooleanbooleanArray1MI
{
    Id = 45,
    Value = 
new System.Boolean[3]
{
false,
false,
false,
},
    NullableValue = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
},
    NullableValue = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
},
            new BooleanbooleanArray1M
{
    Id = 101,
    Value = 
new System.Boolean[3]
{
false,
false,
false,
},
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanArray1M
{
    Id = 104,
    Value = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
    ModelInner = new BooleanbooleanArray1MI
{
    Id = 48,
    Value = 
new System.Boolean[3]
{
false,
false,
false,
},
    NullableValue = null,
},
    NullableValue = 
new System.Boolean[3]
{
false,
false,
false,
},
},
            new BooleanbooleanArray1M
{
    Id = 113,
    Value = 
new System.Boolean[3]
{
false,
false,
false,
},
    ModelInner = null,
    NullableValue = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
},
            new BooleanbooleanArray1M
{
    Id = 115,
    Value = 
new System.Boolean[3]
{
false,
false,
false,
},
    ModelInner = new BooleanbooleanArray1MI
{
    Id = 52,
    Value = 
new System.Boolean[3]
{
false,
false,
false,
},
    NullableValue = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
},
    NullableValue = null,
},
            new BooleanbooleanArray1M
{
    Id = 124,
    Value = 
new System.Boolean[3]
{
false,
false,
false,
},
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanArray1M
{
    Id = 132,
    Value = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
    ModelInner = new BooleanbooleanArray1MI
{
    Id = 55,
    Value = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
    NullableValue = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
},
    NullableValue = 
new System.Boolean[3]
{
false,
false,
false,
},
},
            new BooleanbooleanArray1M
{
    Id = 139,
    Value = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanArray1M
{
    Id = 144,
    Value = 
new System.Boolean[3]
{
false,
false,
false,
},
    ModelInner = new BooleanbooleanArray1MI
{
    Id = 56,
    Value = 
new System.Boolean[3]
{
false,
false,
false,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BooleanbooleanArray1M
{
    Id = 148,
    Value = 
new System.Boolean[3]
{
false,
false,
false,
},
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanArray1M
{
    Id = 152,
    Value = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
    ModelInner = new BooleanbooleanArray1MI
{
    Id = 62,
    Value = 
new System.Boolean[3]
{
false,
false,
false,
},
    NullableValue = 
new System.Boolean[3]
{
false,
false,
false,
},
},
    NullableValue = 
new System.Boolean[3]
{
false,
false,
false,
},
},
            new BooleanbooleanArray1M
{
    Id = 153,
    Value = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanArray1M
{
    Id = 159,
    Value = 
new System.Boolean[3]
{
false,
false,
false,
},
    ModelInner = new BooleanbooleanArray1MI
{
    Id = 70,
    Value = 
new System.Boolean[3]
{
false,
false,
false,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BooleanbooleanArray1M
{
    Id = 167,
    Value = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanArray1M
{
    Id = 171,
    Value = 
new System.Boolean[3]
{
false,
false,
false,
},
    ModelInner = new BooleanbooleanArray1MI
{
    Id = 71,
    Value = 
new System.Boolean[3]
{
false,
false,
false,
},
    NullableValue = null,
},
    NullableValue = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
},
            new BooleanbooleanArray1M
{
    Id = 174,
    Value = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
    ModelInner = null,
    NullableValue = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
},
            new BooleanbooleanArray1M
{
    Id = 180,
    Value = 
new System.Boolean[4]
{
false,
false,
false,
false,
},
    ModelInner = new BooleanbooleanArray1MI
{
    Id = 79,
    Value = 
new System.Boolean[3]
{
false,
false,
false,
},
    NullableValue = 
new System.Boolean[3]
{
false,
false,
false,
},
},
    NullableValue = null,
},
            new BooleanbooleanArray1M
{
    Id = 184,
    Value = 
new System.Boolean[3]
{
false,
false,
false,
},
    ModelInner = null,
    NullableValue = 
new System.Boolean[3]
{
false,
false,
false,
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.booleanbooleanarray1mi(
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
            asPartInterface: typeof(IBooleanArraybooleanArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Boolean[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483646)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Boolean[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483646))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.booleanbooleanarray1mi(
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
            queryMapTypes: [typeof(BooleanbooleanArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Boolean[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483646)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Boolean[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483646))]
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

                changedRows =  ((IBooleanArraybooleanArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBooleanArraybooleanArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBooleanArraybooleanArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanArraybooleanArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBooleanArraybooleanArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBooleanArraybooleanArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBooleanArraybooleanArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBooleanArraybooleanArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IBooleanArraybooleanArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IBooleanArraybooleanArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IBooleanArraybooleanArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IBooleanArraybooleanArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IBooleanArraybooleanArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IBooleanArraybooleanArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IBooleanArraybooleanArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IBooleanArraybooleanArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IBooleanArraybooleanArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.booleanbooleanarray1m(
	id,
    value,
    nullablevalue,
    booleanbooleanarray1mi_id
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
            asPartInterface: typeof(IBooleanArraybooleanArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Boolean[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483646)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Boolean[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483646)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "booleanbooleanarray1mi_id", 
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
                changedRows =  ((IBooleanArraybooleanArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBooleanArraybooleanArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBooleanArraybooleanArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBooleanArraybooleanArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.booleanbooleanarray1m(
	id,
    value,
    nullablevalue,
    booleanbooleanarray1mi_id
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
    booleanbooleanarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BooleanbooleanArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray)),
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
                System.Boolean[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Boolean[]>();
                    ((NpgsqlParameter<System.Boolean[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483646);
                    ((NpgsqlParameter<System.Boolean[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483646);
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

                    nullable =  ((IBooleanArraybooleanArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Boolean[4]
{
false,
false,
false,
false,
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Boolean[]>();
                    ((NpgsqlParameter<System.Boolean[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483646);
                    ((NpgsqlParameter<System.Boolean[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483646);
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

                    nullable =  ((IBooleanArraybooleanArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.Boolean[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Boolean[]>();
                    ((NpgsqlParameter<System.Boolean[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483646);
                    ((NpgsqlParameter<System.Boolean[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483646);
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

                    nullable = await ((IBooleanArraybooleanArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Boolean[3]
{
false,
false,
false,
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Boolean[]>();
                    ((NpgsqlParameter<System.Boolean[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483646);
                    ((NpgsqlParameter<System.Boolean[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483646);
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

                    nullable = await ((IBooleanArraybooleanArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.booleanbooleanarray1m(
	id,
    value,
    nullablevalue,
    booleanbooleanarray1mi_id
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
    booleanbooleanarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BooleanbooleanArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Boolean[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483646)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Boolean[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483646)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "booleanbooleanarray1mi_id", 
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
                System.Boolean[] nullable = null;
                nullable =  ((IBooleanArraybooleanArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Boolean[4]
{
false,
false,
false,
false,
}));
                nullable =  ((IBooleanArraybooleanArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Boolean[4]
{
false,
false,
false,
false,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Boolean[] nullable = null;
                nullable = await ((IBooleanArraybooleanArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IBooleanArraybooleanArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BooleanbooleanArray1M> models = null;

                models =  ((IBooleanArraybooleanArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((IBooleanArraybooleanArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((IBooleanArraybooleanArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((IBooleanArraybooleanArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BooleanbooleanArray1M> models = null;

                models = await ((IBooleanArraybooleanArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IBooleanArraybooleanArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IBooleanArraybooleanArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IBooleanArraybooleanArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IBooleanArraybooleanArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IBooleanArraybooleanArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IBooleanArraybooleanArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IBooleanArraybooleanArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IBooleanArraybooleanArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IBooleanArraybooleanArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IBooleanArraybooleanArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IBooleanArraybooleanArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IBooleanArraybooleanArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IBooleanArraybooleanArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((IBooleanArraybooleanArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IBooleanArraybooleanArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IBooleanArraybooleanArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IBooleanArraybooleanArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IBooleanArraybooleanArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBooleanbooleanArray1M), typeof(FlatBooleanbooleanArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray)),
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
FROM public.booleanbooleanarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBooleanbooleanArray1M>();
                var models2 = new List<FlatBooleanbooleanArray1M>();
                await ((IBooleanArraybooleanArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatBooleanbooleanArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.booleanbooleanarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBooleanbooleanArray1M>();
                var models2 = new List<FlatBooleanbooleanArray1M>();
                ((IBooleanArraybooleanArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatBooleanbooleanArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBooleanbooleanArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray)),
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
FROM public.booleanbooleanarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IBooleanArraybooleanArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.booleanbooleanarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBooleanArraybooleanArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.booleanbooleanarray1m m
LEFT JOIN public.booleanbooleanarray1mi mi ON mi.id = m.booleanbooleanarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BooleanbooleanArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray)),
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
                var models = await ((IBooleanArraybooleanArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BooleanbooleanArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IBooleanArraybooleanArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BooleanbooleanArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBooleanbooleanArray1M), typeof(FlatBooleanbooleanArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray)),
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
FROM public.booleanbooleanarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBooleanbooleanArray1M>();
                var models2 = new List<FlatBooleanbooleanArray1M>();
                await ((IBooleanArraybooleanArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatBooleanbooleanArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.booleanbooleanarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBooleanbooleanArray1M>();
                var models2 = new List<FlatBooleanbooleanArray1M>();
                ((IBooleanArraybooleanArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatBooleanbooleanArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBooleanbooleanArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray)),
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
FROM public.booleanbooleanarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBooleanArraybooleanArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.booleanbooleanarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBooleanArraybooleanArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.booleanbooleanarray1m m
LEFT JOIN public.booleanbooleanarray1mi mi ON mi.id = m.booleanbooleanarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BooleanbooleanArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray)),
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
                var models = await ((IBooleanArraybooleanArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BooleanbooleanArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IBooleanArraybooleanArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BooleanbooleanArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBooleanbooleanArray1M), typeof(FlatBooleanbooleanArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray)),
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
            asPartInterface: typeof(IBooleanArraybooleanArray)),
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
FROM public.booleanbooleanarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBooleanbooleanArray1M>();
                var models2 = new List<FlatBooleanbooleanArray1M>();
                await((IBooleanArraybooleanArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatBooleanbooleanArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
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
FROM public.booleanbooleanarray1m m
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
FROM public.booleanbooleanarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanArray1M>();
                var firstItems2 = new List<FlatBooleanbooleanArray1M>();
                var secondItems1 = new List<FlatBooleanbooleanArray1M>();
                var secondItems2 = new List<FlatBooleanbooleanArray1M>();
                await ((IBooleanArraybooleanArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
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
FROM public.booleanbooleanarray1m m
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
FROM public.booleanbooleanarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanArray1M>();
                var firstItems2 = new List<FlatBooleanbooleanArray1M>();
                var secondItems1 = new List<FlatBooleanbooleanArray1M>();
                await ((IBooleanArraybooleanArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.booleanbooleanarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBooleanbooleanArray1M>();
                var models2 = new List<FlatBooleanbooleanArray1M>();
                ((IBooleanArraybooleanArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatBooleanbooleanArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 171;
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
FROM public.booleanbooleanarray1m m
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
FROM public.booleanbooleanarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanArray1M>();
                var firstItems2 = new List<FlatBooleanbooleanArray1M>();
                var secondItems1 = new List<FlatBooleanbooleanArray1M>();
                var secondItems2 = new List<FlatBooleanbooleanArray1M>();
                 ((IBooleanArraybooleanArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 27;
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
FROM public.booleanbooleanarray1m m
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
FROM public.booleanbooleanarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanArray1M>();
                var firstItems2 = new List<FlatBooleanbooleanArray1M>();
                var secondItems1 = new List<FlatBooleanbooleanArray1M>();
                 ((IBooleanArraybooleanArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[18],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBooleanbooleanArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray)),
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
            asPartInterface: typeof(IBooleanArraybooleanArray)),
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
FROM public.booleanbooleanarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBooleanArraybooleanArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 84;
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
FROM public.booleanbooleanarray1m m
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
FROM public.booleanbooleanarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBooleanArraybooleanArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatBooleanbooleanArray1M.AssertModel(models[0],_testData[15], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[1],_testData[16], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[2],_testData[17], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[3],_testData[18], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[4],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[5],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[6],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[7],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[8],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[9],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[10],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[11],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[12],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[13],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[14],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[15],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[16],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[17],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[18],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatBooleanbooleanArray1M.AssertModel(models[0],_testData[12], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[1],_testData[13], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[2],_testData[14], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[3],_testData[15], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[4],_testData[16], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[5],_testData[17], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[6],_testData[18], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[7],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[8],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[9],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[10],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[11],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[12],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[13],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[14],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[15],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[16],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[17],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[18],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[19],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[20],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[21],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 9;
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
FROM public.booleanbooleanarray1m m
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
FROM public.booleanbooleanarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanArray1M>();
                var secondItems1 = new List<FlatBooleanbooleanArray1M>();
                var secondItems2 = new List<FlatBooleanbooleanArray1M>();
                await ((IBooleanArraybooleanArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.booleanbooleanarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBooleanArraybooleanArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.booleanbooleanarray1m m
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
FROM public.booleanbooleanarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBooleanArraybooleanArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatBooleanbooleanArray1M.AssertModel(models[0],_testData[4], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[1],_testData[5], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[2],_testData[6], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[3],_testData[7], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[4],_testData[8], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[5],_testData[9], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[6],_testData[10], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[7],_testData[11], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[8],_testData[12], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[9],_testData[13], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[10],_testData[14], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[11],_testData[15], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[12],_testData[16], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[13],_testData[17], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[14],_testData[18], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[15],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[16],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[17],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[18],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[19],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[20],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[21],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[22],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[23],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[24],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[25],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[26],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[27],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[28],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[29],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatBooleanbooleanArray1M.AssertModel(models[0],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[1],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[2],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[3],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[4],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[5],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[6],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[7],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[8],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[9],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[10],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[11],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[12],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[13],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[14],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 174;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.booleanbooleanarray1m m
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
FROM public.booleanbooleanarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanArray1M>();
                var secondItems1 = new List<FlatBooleanbooleanArray1M>();
                var secondItems2 = new List<FlatBooleanbooleanArray1M>();
                 ((IBooleanArraybooleanArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.booleanbooleanarray1m m
LEFT JOIN public.booleanbooleanarray1mi mi ON mi.id = m.booleanbooleanarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BooleanbooleanArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray)),
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
                var models = await((IBooleanArraybooleanArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BooleanbooleanArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 171;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBooleanArraybooleanArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        BooleanbooleanArray1M.AssertModel(models[0],_testData[32], false);
                        BooleanbooleanArray1M.AssertModel(models[1],_testData[33], false);
                        BooleanbooleanArray1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        BooleanbooleanArray1M.AssertModel(models[0],_testData[5], false);
                        BooleanbooleanArray1M.AssertModel(models[1],_testData[6], false);
                        BooleanbooleanArray1M.AssertModel(models[2],_testData[7], false);
                        BooleanbooleanArray1M.AssertModel(models[3],_testData[8], false);
                        BooleanbooleanArray1M.AssertModel(models[4],_testData[9], false);
                        BooleanbooleanArray1M.AssertModel(models[5],_testData[10], false);
                        BooleanbooleanArray1M.AssertModel(models[6],_testData[11], false);
                        BooleanbooleanArray1M.AssertModel(models[7],_testData[12], false);
                        BooleanbooleanArray1M.AssertModel(models[8],_testData[13], false);
                        BooleanbooleanArray1M.AssertModel(models[9],_testData[14], false);
                        BooleanbooleanArray1M.AssertModel(models[10],_testData[15], false);
                        BooleanbooleanArray1M.AssertModel(models[11],_testData[16], false);
                        BooleanbooleanArray1M.AssertModel(models[12],_testData[17], false);
                        BooleanbooleanArray1M.AssertModel(models[13],_testData[18], false);
                        BooleanbooleanArray1M.AssertModel(models[14],_testData[19], false);
                        BooleanbooleanArray1M.AssertModel(models[15],_testData[20], false);
                        BooleanbooleanArray1M.AssertModel(models[16],_testData[21], false);
                        BooleanbooleanArray1M.AssertModel(models[17],_testData[22], false);
                        BooleanbooleanArray1M.AssertModel(models[18],_testData[23], false);
                        BooleanbooleanArray1M.AssertModel(models[19],_testData[24], false);
                        BooleanbooleanArray1M.AssertModel(models[20],_testData[25], false);
                        BooleanbooleanArray1M.AssertModel(models[21],_testData[26], false);
                        BooleanbooleanArray1M.AssertModel(models[22],_testData[27], false);
                        BooleanbooleanArray1M.AssertModel(models[23],_testData[28], false);
                        BooleanbooleanArray1M.AssertModel(models[24],_testData[29], false);
                        BooleanbooleanArray1M.AssertModel(models[25],_testData[30], false);
                        BooleanbooleanArray1M.AssertModel(models[26],_testData[31], false);
                        BooleanbooleanArray1M.AssertModel(models[27],_testData[32], false);
                        BooleanbooleanArray1M.AssertModel(models[28],_testData[33], false);
                        BooleanbooleanArray1M.AssertModel(models[29],_testData[34], false);
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
                var models = ((IBooleanArraybooleanArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BooleanbooleanArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBooleanArraybooleanArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        BooleanbooleanArray1M.AssertModel(models[0],_testData[17], false);
                        BooleanbooleanArray1M.AssertModel(models[1],_testData[18], false);
                        BooleanbooleanArray1M.AssertModel(models[2],_testData[19], false);
                        BooleanbooleanArray1M.AssertModel(models[3],_testData[20], false);
                        BooleanbooleanArray1M.AssertModel(models[4],_testData[21], false);
                        BooleanbooleanArray1M.AssertModel(models[5],_testData[22], false);
                        BooleanbooleanArray1M.AssertModel(models[6],_testData[23], false);
                        BooleanbooleanArray1M.AssertModel(models[7],_testData[24], false);
                        BooleanbooleanArray1M.AssertModel(models[8],_testData[25], false);
                        BooleanbooleanArray1M.AssertModel(models[9],_testData[26], false);
                        BooleanbooleanArray1M.AssertModel(models[10],_testData[27], false);
                        BooleanbooleanArray1M.AssertModel(models[11],_testData[28], false);
                        BooleanbooleanArray1M.AssertModel(models[12],_testData[29], false);
                        BooleanbooleanArray1M.AssertModel(models[13],_testData[30], false);
                        BooleanbooleanArray1M.AssertModel(models[14],_testData[31], false);
                        BooleanbooleanArray1M.AssertModel(models[15],_testData[32], false);
                        BooleanbooleanArray1M.AssertModel(models[16],_testData[33], false);
                        BooleanbooleanArray1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        BooleanbooleanArray1M.AssertModel(models[0],_testData[14], false);
                        BooleanbooleanArray1M.AssertModel(models[1],_testData[15], false);
                        BooleanbooleanArray1M.AssertModel(models[2],_testData[16], false);
                        BooleanbooleanArray1M.AssertModel(models[3],_testData[17], false);
                        BooleanbooleanArray1M.AssertModel(models[4],_testData[18], false);
                        BooleanbooleanArray1M.AssertModel(models[5],_testData[19], false);
                        BooleanbooleanArray1M.AssertModel(models[6],_testData[20], false);
                        BooleanbooleanArray1M.AssertModel(models[7],_testData[21], false);
                        BooleanbooleanArray1M.AssertModel(models[8],_testData[22], false);
                        BooleanbooleanArray1M.AssertModel(models[9],_testData[23], false);
                        BooleanbooleanArray1M.AssertModel(models[10],_testData[24], false);
                        BooleanbooleanArray1M.AssertModel(models[11],_testData[25], false);
                        BooleanbooleanArray1M.AssertModel(models[12],_testData[26], false);
                        BooleanbooleanArray1M.AssertModel(models[13],_testData[27], false);
                        BooleanbooleanArray1M.AssertModel(models[14],_testData[28], false);
                        BooleanbooleanArray1M.AssertModel(models[15],_testData[29], false);
                        BooleanbooleanArray1M.AssertModel(models[16],_testData[30], false);
                        BooleanbooleanArray1M.AssertModel(models[17],_testData[31], false);
                        BooleanbooleanArray1M.AssertModel(models[18],_testData[32], false);
                        BooleanbooleanArray1M.AssertModel(models[19],_testData[33], false);
                        BooleanbooleanArray1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBooleanbooleanArray1M), typeof(FlatBooleanbooleanArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray)),
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
            asPartInterface: typeof(IBooleanArraybooleanArray)),
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
            asPartInterface: typeof(IBooleanArraybooleanArray)),
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
FROM public.booleanbooleanarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBooleanbooleanArray1M>();
                var models2 = new List<FlatBooleanbooleanArray1M>();
                await((IBooleanArraybooleanArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatBooleanbooleanArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.booleanbooleanarray1m m
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
FROM public.booleanbooleanarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanArray1M>();
                var firstItems2 = new List<FlatBooleanbooleanArray1M>();
                var secondItems1 = new List<FlatBooleanbooleanArray1M>();
                var secondItems2 = new List<FlatBooleanbooleanArray1M>();
                await ((IBooleanArraybooleanArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 25, query1, 96, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.booleanbooleanarray1m m
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
FROM public.booleanbooleanarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanArray1M>();
                var firstItems2 = new List<FlatBooleanbooleanArray1M>();
                var secondItems1 = new List<FlatBooleanbooleanArray1M>();
                await ((IBooleanArraybooleanArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 20, query1, 15, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[32],_testData[34], false);
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
FROM public.booleanbooleanarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBooleanbooleanArray1M>();
                var models2 = new List<FlatBooleanbooleanArray1M>();
                ((IBooleanArraybooleanArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatBooleanbooleanArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.booleanbooleanarray1m m
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
FROM public.booleanbooleanarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanArray1M>();
                var firstItems2 = new List<FlatBooleanbooleanArray1M>();
                var secondItems1 = new List<FlatBooleanbooleanArray1M>();
                var secondItems2 = new List<FlatBooleanbooleanArray1M>();
                 ((IBooleanArraybooleanArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 15, query1, 144, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.booleanbooleanarray1m m
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
FROM public.booleanbooleanarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanArray1M>();
                var firstItems2 = new List<FlatBooleanbooleanArray1M>();
                var secondItems1 = new List<FlatBooleanbooleanArray1M>();
                 ((IBooleanArraybooleanArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 47, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBooleanbooleanArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray)),
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
            asPartInterface: typeof(IBooleanArraybooleanArray)),
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
            asPartInterface: typeof(IBooleanArraybooleanArray)),
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
FROM public.booleanbooleanarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBooleanArraybooleanArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.booleanbooleanarray1m m
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
FROM public.booleanbooleanarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBooleanArraybooleanArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 27, query1, 9, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatBooleanbooleanArray1M.AssertModel(models[0],_testData[5], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[1],_testData[6], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[2],_testData[7], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[3],_testData[8], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[4],_testData[9], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[5],_testData[10], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[6],_testData[11], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[7],_testData[12], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[8],_testData[13], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[9],_testData[14], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[10],_testData[15], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[11],_testData[16], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[12],_testData[17], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[13],_testData[18], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[14],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[15],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[16],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[17],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[18],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[19],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[20],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[21],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[22],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[23],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[24],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[25],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[26],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[27],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[28],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatBooleanbooleanArray1M.AssertModel(models[0],_testData[1], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[1],_testData[2], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[2],_testData[3], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[3],_testData[4], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[4],_testData[5], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[5],_testData[6], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[6],_testData[7], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[7],_testData[8], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[8],_testData[9], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[9],_testData[10], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[10],_testData[11], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[11],_testData[12], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[12],_testData[13], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[13],_testData[14], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[14],_testData[15], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[15],_testData[16], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[16],_testData[17], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[17],_testData[18], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[18],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[19],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[20],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[21],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[22],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[23],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[24],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[25],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[26],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[27],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[28],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[29],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[30],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[31],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[32],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[33],_testData[34], false);
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
FROM public.booleanbooleanarray1m m
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
FROM public.booleanbooleanarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanArray1M>();
                var secondItems1 = new List<FlatBooleanbooleanArray1M>();
                var secondItems2 = new List<FlatBooleanbooleanArray1M>();
                await ((IBooleanArraybooleanArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 63, query1, 153, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.booleanbooleanarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBooleanArraybooleanArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.booleanbooleanarray1m m
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
FROM public.booleanbooleanarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBooleanArraybooleanArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 132, query1, 27, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatBooleanbooleanArray1M.AssertModel(models[0],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[1],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[2],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[3],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[4],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[5],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[6],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[7],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[8],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[9],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatBooleanbooleanArray1M.AssertModel(models[0],_testData[5], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[1],_testData[6], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[2],_testData[7], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[3],_testData[8], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[4],_testData[9], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[5],_testData[10], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[6],_testData[11], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[7],_testData[12], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[8],_testData[13], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[9],_testData[14], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[10],_testData[15], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[11],_testData[16], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[12],_testData[17], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[13],_testData[18], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[14],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[15],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[16],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[17],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[18],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[19],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[20],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[21],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[22],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[23],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[24],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[25],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[26],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[27],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[28],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(models[29],_testData[34], false);
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
FROM public.booleanbooleanarray1m m
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
FROM public.booleanbooleanarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanArray1M>();
                var secondItems1 = new List<FlatBooleanbooleanArray1M>();
                var secondItems2 = new List<FlatBooleanbooleanArray1M>();
                 ((IBooleanArraybooleanArray)this).DbConnectionDynQuerySelectModelBatch(connection, 115, query1, 98, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatBooleanbooleanArray1M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.booleanbooleanarray1m m
LEFT JOIN public.booleanbooleanarray1mi mi ON mi.id = m.booleanbooleanarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BooleanbooleanArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray)),
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
            asPartInterface: typeof(IBooleanArraybooleanArray)),
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
                var models = await((IBooleanArraybooleanArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BooleanbooleanArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBooleanArraybooleanArray)this).DbConnectionSTSelectModelBatchAsync(connection, 54, 27))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        BooleanbooleanArray1M.AssertModel(models[0],_testData[10], false);
                        BooleanbooleanArray1M.AssertModel(models[1],_testData[11], false);
                        BooleanbooleanArray1M.AssertModel(models[2],_testData[12], false);
                        BooleanbooleanArray1M.AssertModel(models[3],_testData[13], false);
                        BooleanbooleanArray1M.AssertModel(models[4],_testData[14], false);
                        BooleanbooleanArray1M.AssertModel(models[5],_testData[15], false);
                        BooleanbooleanArray1M.AssertModel(models[6],_testData[16], false);
                        BooleanbooleanArray1M.AssertModel(models[7],_testData[17], false);
                        BooleanbooleanArray1M.AssertModel(models[8],_testData[18], false);
                        BooleanbooleanArray1M.AssertModel(models[9],_testData[19], false);
                        BooleanbooleanArray1M.AssertModel(models[10],_testData[20], false);
                        BooleanbooleanArray1M.AssertModel(models[11],_testData[21], false);
                        BooleanbooleanArray1M.AssertModel(models[12],_testData[22], false);
                        BooleanbooleanArray1M.AssertModel(models[13],_testData[23], false);
                        BooleanbooleanArray1M.AssertModel(models[14],_testData[24], false);
                        BooleanbooleanArray1M.AssertModel(models[15],_testData[25], false);
                        BooleanbooleanArray1M.AssertModel(models[16],_testData[26], false);
                        BooleanbooleanArray1M.AssertModel(models[17],_testData[27], false);
                        BooleanbooleanArray1M.AssertModel(models[18],_testData[28], false);
                        BooleanbooleanArray1M.AssertModel(models[19],_testData[29], false);
                        BooleanbooleanArray1M.AssertModel(models[20],_testData[30], false);
                        BooleanbooleanArray1M.AssertModel(models[21],_testData[31], false);
                        BooleanbooleanArray1M.AssertModel(models[22],_testData[32], false);
                        BooleanbooleanArray1M.AssertModel(models[23],_testData[33], false);
                        BooleanbooleanArray1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        BooleanbooleanArray1M.AssertModel(models[0],_testData[5], false);
                        BooleanbooleanArray1M.AssertModel(models[1],_testData[6], false);
                        BooleanbooleanArray1M.AssertModel(models[2],_testData[7], false);
                        BooleanbooleanArray1M.AssertModel(models[3],_testData[8], false);
                        BooleanbooleanArray1M.AssertModel(models[4],_testData[9], false);
                        BooleanbooleanArray1M.AssertModel(models[5],_testData[10], false);
                        BooleanbooleanArray1M.AssertModel(models[6],_testData[11], false);
                        BooleanbooleanArray1M.AssertModel(models[7],_testData[12], false);
                        BooleanbooleanArray1M.AssertModel(models[8],_testData[13], false);
                        BooleanbooleanArray1M.AssertModel(models[9],_testData[14], false);
                        BooleanbooleanArray1M.AssertModel(models[10],_testData[15], false);
                        BooleanbooleanArray1M.AssertModel(models[11],_testData[16], false);
                        BooleanbooleanArray1M.AssertModel(models[12],_testData[17], false);
                        BooleanbooleanArray1M.AssertModel(models[13],_testData[18], false);
                        BooleanbooleanArray1M.AssertModel(models[14],_testData[19], false);
                        BooleanbooleanArray1M.AssertModel(models[15],_testData[20], false);
                        BooleanbooleanArray1M.AssertModel(models[16],_testData[21], false);
                        BooleanbooleanArray1M.AssertModel(models[17],_testData[22], false);
                        BooleanbooleanArray1M.AssertModel(models[18],_testData[23], false);
                        BooleanbooleanArray1M.AssertModel(models[19],_testData[24], false);
                        BooleanbooleanArray1M.AssertModel(models[20],_testData[25], false);
                        BooleanbooleanArray1M.AssertModel(models[21],_testData[26], false);
                        BooleanbooleanArray1M.AssertModel(models[22],_testData[27], false);
                        BooleanbooleanArray1M.AssertModel(models[23],_testData[28], false);
                        BooleanbooleanArray1M.AssertModel(models[24],_testData[29], false);
                        BooleanbooleanArray1M.AssertModel(models[25],_testData[30], false);
                        BooleanbooleanArray1M.AssertModel(models[26],_testData[31], false);
                        BooleanbooleanArray1M.AssertModel(models[27],_testData[32], false);
                        BooleanbooleanArray1M.AssertModel(models[28],_testData[33], false);
                        BooleanbooleanArray1M.AssertModel(models[29],_testData[34], false);
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
                var models = ((IBooleanArraybooleanArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BooleanbooleanArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBooleanArraybooleanArray)this).DbConnectionSTSelectModelBatch(connection, 20, 47))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        BooleanbooleanArray1M.AssertModel(models[0],_testData[3], false);
                        BooleanbooleanArray1M.AssertModel(models[1],_testData[4], false);
                        BooleanbooleanArray1M.AssertModel(models[2],_testData[5], false);
                        BooleanbooleanArray1M.AssertModel(models[3],_testData[6], false);
                        BooleanbooleanArray1M.AssertModel(models[4],_testData[7], false);
                        BooleanbooleanArray1M.AssertModel(models[5],_testData[8], false);
                        BooleanbooleanArray1M.AssertModel(models[6],_testData[9], false);
                        BooleanbooleanArray1M.AssertModel(models[7],_testData[10], false);
                        BooleanbooleanArray1M.AssertModel(models[8],_testData[11], false);
                        BooleanbooleanArray1M.AssertModel(models[9],_testData[12], false);
                        BooleanbooleanArray1M.AssertModel(models[10],_testData[13], false);
                        BooleanbooleanArray1M.AssertModel(models[11],_testData[14], false);
                        BooleanbooleanArray1M.AssertModel(models[12],_testData[15], false);
                        BooleanbooleanArray1M.AssertModel(models[13],_testData[16], false);
                        BooleanbooleanArray1M.AssertModel(models[14],_testData[17], false);
                        BooleanbooleanArray1M.AssertModel(models[15],_testData[18], false);
                        BooleanbooleanArray1M.AssertModel(models[16],_testData[19], false);
                        BooleanbooleanArray1M.AssertModel(models[17],_testData[20], false);
                        BooleanbooleanArray1M.AssertModel(models[18],_testData[21], false);
                        BooleanbooleanArray1M.AssertModel(models[19],_testData[22], false);
                        BooleanbooleanArray1M.AssertModel(models[20],_testData[23], false);
                        BooleanbooleanArray1M.AssertModel(models[21],_testData[24], false);
                        BooleanbooleanArray1M.AssertModel(models[22],_testData[25], false);
                        BooleanbooleanArray1M.AssertModel(models[23],_testData[26], false);
                        BooleanbooleanArray1M.AssertModel(models[24],_testData[27], false);
                        BooleanbooleanArray1M.AssertModel(models[25],_testData[28], false);
                        BooleanbooleanArray1M.AssertModel(models[26],_testData[29], false);
                        BooleanbooleanArray1M.AssertModel(models[27],_testData[30], false);
                        BooleanbooleanArray1M.AssertModel(models[28],_testData[31], false);
                        BooleanbooleanArray1M.AssertModel(models[29],_testData[32], false);
                        BooleanbooleanArray1M.AssertModel(models[30],_testData[33], false);
                        BooleanbooleanArray1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        BooleanbooleanArray1M.AssertModel(models[0],_testData[8], false);
                        BooleanbooleanArray1M.AssertModel(models[1],_testData[9], false);
                        BooleanbooleanArray1M.AssertModel(models[2],_testData[10], false);
                        BooleanbooleanArray1M.AssertModel(models[3],_testData[11], false);
                        BooleanbooleanArray1M.AssertModel(models[4],_testData[12], false);
                        BooleanbooleanArray1M.AssertModel(models[5],_testData[13], false);
                        BooleanbooleanArray1M.AssertModel(models[6],_testData[14], false);
                        BooleanbooleanArray1M.AssertModel(models[7],_testData[15], false);
                        BooleanbooleanArray1M.AssertModel(models[8],_testData[16], false);
                        BooleanbooleanArray1M.AssertModel(models[9],_testData[17], false);
                        BooleanbooleanArray1M.AssertModel(models[10],_testData[18], false);
                        BooleanbooleanArray1M.AssertModel(models[11],_testData[19], false);
                        BooleanbooleanArray1M.AssertModel(models[12],_testData[20], false);
                        BooleanbooleanArray1M.AssertModel(models[13],_testData[21], false);
                        BooleanbooleanArray1M.AssertModel(models[14],_testData[22], false);
                        BooleanbooleanArray1M.AssertModel(models[15],_testData[23], false);
                        BooleanbooleanArray1M.AssertModel(models[16],_testData[24], false);
                        BooleanbooleanArray1M.AssertModel(models[17],_testData[25], false);
                        BooleanbooleanArray1M.AssertModel(models[18],_testData[26], false);
                        BooleanbooleanArray1M.AssertModel(models[19],_testData[27], false);
                        BooleanbooleanArray1M.AssertModel(models[20],_testData[28], false);
                        BooleanbooleanArray1M.AssertModel(models[21],_testData[29], false);
                        BooleanbooleanArray1M.AssertModel(models[22],_testData[30], false);
                        BooleanbooleanArray1M.AssertModel(models[23],_testData[31], false);
                        BooleanbooleanArray1M.AssertModel(models[24],_testData[32], false);
                        BooleanbooleanArray1M.AssertModel(models[25],_testData[33], false);
                        BooleanbooleanArray1M.AssertModel(models[26],_testData[34], false);
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
                await using var cmd = await ((IBooleanArraybooleanArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBooleanArraybooleanArray)this).SetDbConnectionSelectModelParametrs(cmd, 124);
                var models = await ((IBooleanArraybooleanArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));

                BooleanbooleanArray1M.AssertModel(models[0],_testData[23], false);
                BooleanbooleanArray1M.AssertModel(models[1],_testData[24], false);
                BooleanbooleanArray1M.AssertModel(models[2],_testData[25], false);
                BooleanbooleanArray1M.AssertModel(models[3],_testData[26], false);
                BooleanbooleanArray1M.AssertModel(models[4],_testData[27], false);
                BooleanbooleanArray1M.AssertModel(models[5],_testData[28], false);
                BooleanbooleanArray1M.AssertModel(models[6],_testData[29], false);
                BooleanbooleanArray1M.AssertModel(models[7],_testData[30], false);
                BooleanbooleanArray1M.AssertModel(models[8],_testData[31], false);
                BooleanbooleanArray1M.AssertModel(models[9],_testData[32], false);
                BooleanbooleanArray1M.AssertModel(models[10],_testData[33], false);
                BooleanbooleanArray1M.AssertModel(models[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBooleanArraybooleanArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBooleanArraybooleanArray)this).SetDbConnectionSelectModelParametrs(cmd, 54);
                var models =  ((IBooleanArraybooleanArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));

                BooleanbooleanArray1M.AssertModel(models[0],_testData[10], false);
                BooleanbooleanArray1M.AssertModel(models[1],_testData[11], false);
                BooleanbooleanArray1M.AssertModel(models[2],_testData[12], false);
                BooleanbooleanArray1M.AssertModel(models[3],_testData[13], false);
                BooleanbooleanArray1M.AssertModel(models[4],_testData[14], false);
                BooleanbooleanArray1M.AssertModel(models[5],_testData[15], false);
                BooleanbooleanArray1M.AssertModel(models[6],_testData[16], false);
                BooleanbooleanArray1M.AssertModel(models[7],_testData[17], false);
                BooleanbooleanArray1M.AssertModel(models[8],_testData[18], false);
                BooleanbooleanArray1M.AssertModel(models[9],_testData[19], false);
                BooleanbooleanArray1M.AssertModel(models[10],_testData[20], false);
                BooleanbooleanArray1M.AssertModel(models[11],_testData[21], false);
                BooleanbooleanArray1M.AssertModel(models[12],_testData[22], false);
                BooleanbooleanArray1M.AssertModel(models[13],_testData[23], false);
                BooleanbooleanArray1M.AssertModel(models[14],_testData[24], false);
                BooleanbooleanArray1M.AssertModel(models[15],_testData[25], false);
                BooleanbooleanArray1M.AssertModel(models[16],_testData[26], false);
                BooleanbooleanArray1M.AssertModel(models[17],_testData[27], false);
                BooleanbooleanArray1M.AssertModel(models[18],_testData[28], false);
                BooleanbooleanArray1M.AssertModel(models[19],_testData[29], false);
                BooleanbooleanArray1M.AssertModel(models[20],_testData[30], false);
                BooleanbooleanArray1M.AssertModel(models[21],_testData[31], false);
                BooleanbooleanArray1M.AssertModel(models[22],_testData[32], false);
                BooleanbooleanArray1M.AssertModel(models[23],_testData[33], false);
                BooleanbooleanArray1M.AssertModel(models[24],_testData[34], false);
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
FROM public.binary_booleanbooleanarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BooleanbooleanArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(BooleanbooleanArray1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483646),
                (NpgsqlTypes.NpgsqlDbType)(-2147483646)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BooleanbooleanArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BooleanbooleanArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBooleanArraybooleanArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_booleanbooleanarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBooleanArraybooleanArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BooleanbooleanArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BooleanbooleanArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BooleanbooleanArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBooleanArraybooleanArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_booleanbooleanarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBooleanArraybooleanArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BooleanbooleanArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_booleanbooleanarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BooleanbooleanArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BooleanbooleanArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BooleanbooleanArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BooleanbooleanArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBooleanArraybooleanArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_booleanbooleanarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBooleanArraybooleanArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BooleanbooleanArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BooleanbooleanArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BooleanbooleanArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBooleanArraybooleanArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_booleanbooleanarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBooleanArraybooleanArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BooleanbooleanArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_booleanbooleanarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BooleanbooleanArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_booleanbooleanarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(BooleanbooleanArray1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483646),
                (NpgsqlTypes.NpgsqlDbType)(-2147483646)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BooleanbooleanArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBooleanArraybooleanArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IBooleanArraybooleanArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BooleanbooleanArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BooleanbooleanArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBooleanArraybooleanArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IBooleanArraybooleanArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BooleanbooleanArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_booleanbooleanarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BooleanbooleanArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_booleanbooleanarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BooleanbooleanArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BooleanbooleanArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BooleanbooleanArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBooleanArraybooleanArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBooleanArraybooleanArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BooleanbooleanArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BooleanbooleanArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BooleanbooleanArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBooleanArraybooleanArray)this).ImportModelInner(connection, importCollection);
                var models = ((IBooleanArraybooleanArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BooleanbooleanArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_booleanbooleanarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
booleanbooleanarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BooleanbooleanArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483646),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483646)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray))]
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
FROM public.binary_booleanbooleanarray1m m
LEFT JOIN public.binary_booleanbooleanarray1mi mi ON mi.id = m.booleanbooleanarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BooleanbooleanArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BooleanbooleanArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IBooleanArraybooleanArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IBooleanArraybooleanArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BooleanbooleanArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BooleanbooleanArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IBooleanArraybooleanArray)this).ImportModel(connection, importCollection);
                var models = ((IBooleanArraybooleanArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BooleanbooleanArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_booleanbooleanarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    booleanbooleanarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BooleanbooleanArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483646),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483646)
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
                var models =  ((IBooleanArraybooleanArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BooleanbooleanArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBooleanArraybooleanArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BooleanbooleanArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(BooleanbooleanArray1MIWA), typeof(BooleanbooleanArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483646),
                (NpgsqlTypes.NpgsqlDbType)(-2147483646)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483646),
                (NpgsqlTypes.NpgsqlDbType)(-2147483646)
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
                var models1 = new List<BooleanbooleanArray1MIWA>();
                var models2 = new List<BooleanbooleanArray1MIWA>();
                await ((IBooleanArraybooleanArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_booleanbooleanarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BooleanbooleanArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BooleanbooleanArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BooleanbooleanArray1MIWA>();
                var models2 = new List<BooleanbooleanArray1MIWA>();
                ((IBooleanArraybooleanArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_booleanbooleanarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BooleanbooleanArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BooleanbooleanArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BooleanbooleanArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483646),
                (NpgsqlTypes.NpgsqlDbType)(-2147483646)
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
                var models = await ((IBooleanArraybooleanArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_booleanbooleanarray1mi
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
                    BooleanbooleanArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBooleanArraybooleanArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_booleanbooleanarray1mi
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
                    BooleanbooleanArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BooleanbooleanArray1MIWA), typeof(BooleanbooleanArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray))]
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
                var models1 = new List<BooleanbooleanArray1MIWA>();
                var models2 = new List<BooleanbooleanArray1MIWA>();
                await ((IBooleanArraybooleanArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_booleanbooleanarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BooleanbooleanArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BooleanbooleanArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BooleanbooleanArray1MIWA>();
                var models2 = new List<BooleanbooleanArray1MIWA>();
                ((IBooleanArraybooleanArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_booleanbooleanarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BooleanbooleanArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BooleanbooleanArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BooleanbooleanArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray))]
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
                var models = await ((IBooleanArraybooleanArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_booleanbooleanarray1mi
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
                    BooleanbooleanArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBooleanArraybooleanArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_booleanbooleanarray1mi
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
                    BooleanbooleanArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_booleanbooleanarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BooleanbooleanArray1MI), typeof(BooleanbooleanArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483646),
                (NpgsqlTypes.NpgsqlDbType)(-2147483646)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483646),
                (NpgsqlTypes.NpgsqlDbType)(-2147483646)
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
                var models1 = new List<BooleanbooleanArray1MI>();
                var models2 = new List<BooleanbooleanArray1MI>();
                await ((IBooleanArraybooleanArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BooleanbooleanArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BooleanbooleanArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BooleanbooleanArray1MI>();
                var models2 = new List<BooleanbooleanArray1MI>();
                ((IBooleanArraybooleanArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BooleanbooleanArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BooleanbooleanArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_booleanbooleanarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(BooleanbooleanArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483646),
                (NpgsqlTypes.NpgsqlDbType)(-2147483646)
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
                var models = await ((IBooleanArraybooleanArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BooleanbooleanArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IBooleanArraybooleanArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BooleanbooleanArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_booleanbooleanarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BooleanbooleanArray1MIWA), typeof(BooleanbooleanArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray))]
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
                var models1 = new List<BooleanbooleanArray1MIWA>();
                var models2 = new List<BooleanbooleanArray1MIWA>();
                await ((IBooleanArraybooleanArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BooleanbooleanArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BooleanbooleanArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BooleanbooleanArray1MIWA>();
                var models2 = new List<BooleanbooleanArray1MIWA>();
                ((IBooleanArraybooleanArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BooleanbooleanArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BooleanbooleanArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_booleanbooleanarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BooleanbooleanArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanArraybooleanArray))]
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
                var models = await ((IBooleanArraybooleanArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BooleanbooleanArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBooleanArraybooleanArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BooleanbooleanArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

