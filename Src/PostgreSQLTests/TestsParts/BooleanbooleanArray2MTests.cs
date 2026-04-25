

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
    internal partial interface IBooleanListbooleanArray
    {
    }
    
    internal partial class BooleanListbooleanArray : IBooleanListbooleanArray
    {


#region TestData

        private readonly BooleanbooleanArray2M[] _testData = new BooleanbooleanArray2M[]
        {
            new BooleanbooleanArray2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
},
            new BooleanbooleanArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
    ModelInner = new BooleanbooleanArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
},
            new BooleanbooleanArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
},
            new BooleanbooleanArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
    ModelInner = new BooleanbooleanArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
},
            new BooleanbooleanArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
    ModelInner = new BooleanbooleanArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
},
            new BooleanbooleanArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
    ModelInner = new BooleanbooleanArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
    NullableValue = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
},
    NullableValue = null,
},
            new BooleanbooleanArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
    ModelInner = new BooleanbooleanArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
},
            new BooleanbooleanArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
},
            new BooleanbooleanArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
    ModelInner = new BooleanbooleanArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
},
            new BooleanbooleanArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
},
            new BooleanbooleanArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
    ModelInner = new BooleanbooleanArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
    NullableValue = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
},
            new BooleanbooleanArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
},
            new BooleanbooleanArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
    ModelInner = new BooleanbooleanArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
    NullableValue = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
},
    NullableValue = null,
},
            new BooleanbooleanArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
    ModelInner = new BooleanbooleanArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
},
            new BooleanbooleanArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
    ModelInner = new BooleanbooleanArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
    NullableValue = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
},
            new BooleanbooleanArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
    ModelInner = new BooleanbooleanArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
    NullableValue = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
},
    NullableValue = null,
},
            new BooleanbooleanArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
},
            new BooleanbooleanArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
    ModelInner = new BooleanbooleanArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
},
            new BooleanbooleanArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
    ModelInner = new BooleanbooleanArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
},
            new BooleanbooleanArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
},
            new BooleanbooleanArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
    ModelInner = new BooleanbooleanArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
},
            new BooleanbooleanArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Boolean>(4)
{
false,

false,

false,

false,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
},
            new BooleanbooleanArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
    ModelInner = new BooleanbooleanArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
    NullableValue = 
new System.Collections.Generic.List<System.Boolean>(3)
{
false,

false,

false,

},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.booleanbooleanarray2mi(
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
            asPartInterface: typeof(IBooleanListbooleanArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Boolean>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483646)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Boolean>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483646))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.booleanbooleanarray2mi(
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
            queryMapTypes: [typeof(BooleanbooleanArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanListbooleanArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Boolean>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483646)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Boolean>), 
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

                changedRows =  ((IBooleanListbooleanArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBooleanListbooleanArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBooleanListbooleanArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanListbooleanArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBooleanListbooleanArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBooleanListbooleanArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBooleanListbooleanArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBooleanListbooleanArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IBooleanListbooleanArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IBooleanListbooleanArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IBooleanListbooleanArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IBooleanListbooleanArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IBooleanListbooleanArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IBooleanListbooleanArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IBooleanListbooleanArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.booleanbooleanarray2m(
	id,
    value,
    nullablevalue,
    booleanbooleanarray2mi_id
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
            asPartInterface: typeof(IBooleanListbooleanArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Boolean>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483646)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Boolean>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483646)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "booleanbooleanarray2mi_id", 
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
                changedRows =  ((IBooleanListbooleanArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBooleanListbooleanArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBooleanListbooleanArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBooleanListbooleanArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.booleanbooleanarray2m(
	id,
    value,
    nullablevalue,
    booleanbooleanarray2mi_id
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
    booleanbooleanarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BooleanbooleanArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanListbooleanArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.booleanbooleanarray2m(
	id,
    value,
    nullablevalue,
    booleanbooleanarray2mi_id
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
    booleanbooleanarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BooleanbooleanArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanListbooleanArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Boolean>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483646)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Boolean>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483646)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "booleanbooleanarray2mi_id", 
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
                List<BooleanbooleanArray2M> models = null;

                models =  ((IBooleanListbooleanArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IBooleanListbooleanArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IBooleanListbooleanArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IBooleanListbooleanArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BooleanbooleanArray2M> models = null;

                models = await ((IBooleanListbooleanArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IBooleanListbooleanArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IBooleanListbooleanArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IBooleanListbooleanArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IBooleanListbooleanArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IBooleanListbooleanArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IBooleanListbooleanArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IBooleanListbooleanArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IBooleanListbooleanArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IBooleanListbooleanArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IBooleanListbooleanArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IBooleanListbooleanArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IBooleanListbooleanArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IBooleanListbooleanArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IBooleanListbooleanArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IBooleanListbooleanArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IBooleanListbooleanArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IBooleanListbooleanArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IBooleanListbooleanArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IBooleanListbooleanArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IBooleanListbooleanArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IBooleanListbooleanArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BooleanbooleanArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBooleanbooleanArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanListbooleanArray)),
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
FROM public.booleanbooleanarray2m m
LEFT JOIN public.booleanbooleanarray2mi mi ON mi.id = m.booleanbooleanarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((IBooleanListbooleanArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanbooleanArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.booleanbooleanarray2m m
LEFT JOIN public.booleanbooleanarray2mi mi ON mi.id = m.booleanbooleanarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((IBooleanListbooleanArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanbooleanArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.booleanbooleanarray2m m
LEFT JOIN public.booleanbooleanarray2mi mi ON mi.id = m.booleanbooleanarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BooleanbooleanArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanListbooleanArray)),
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

                var models = await ((IBooleanListbooleanArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BooleanbooleanArray2M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((IBooleanListbooleanArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BooleanbooleanArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBooleanbooleanArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanListbooleanArray)),
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
FROM public.booleanbooleanarray2m m
LEFT JOIN public.booleanbooleanarray2mi mi ON mi.id = m.booleanbooleanarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBooleanListbooleanArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanbooleanArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.booleanbooleanarray2m m
LEFT JOIN public.booleanbooleanarray2mi mi ON mi.id = m.booleanbooleanarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((IBooleanListbooleanArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanbooleanArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.booleanbooleanarray2m m
LEFT JOIN public.booleanbooleanarray2mi mi ON mi.id = m.booleanbooleanarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BooleanbooleanArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanListbooleanArray)),
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
                var models = await ((IBooleanListbooleanArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BooleanbooleanArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IBooleanListbooleanArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BooleanbooleanArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBooleanbooleanArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanListbooleanArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanListbooleanArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
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
FROM public.booleanbooleanarray2m m
LEFT JOIN public.booleanbooleanarray2mi mi ON mi.id = m.booleanbooleanarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IBooleanListbooleanArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanbooleanArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.booleanbooleanarray2m m
LEFT JOIN public.booleanbooleanarray2mi mi ON mi.id = m.booleanbooleanarray2mi_id
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
FROM public.booleanbooleanarray2m m
LEFT JOIN public.booleanbooleanarray2mi mi ON mi.id = m.booleanbooleanarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IBooleanListbooleanArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatBooleanbooleanArray2M.AssertModel(models[0],_testData[12], false);FlatBooleanbooleanArray2M.AssertModel(models[1],_testData[13], false);FlatBooleanbooleanArray2M.AssertModel(models[2],_testData[14], false);FlatBooleanbooleanArray2M.AssertModel(models[3],_testData[15], false);FlatBooleanbooleanArray2M.AssertModel(models[4],_testData[16], false);FlatBooleanbooleanArray2M.AssertModel(models[5],_testData[17], false);FlatBooleanbooleanArray2M.AssertModel(models[6],_testData[18], false);FlatBooleanbooleanArray2M.AssertModel(models[7],_testData[19], false);FlatBooleanbooleanArray2M.AssertModel(models[8],_testData[20], false);FlatBooleanbooleanArray2M.AssertModel(models[9],_testData[21], false);FlatBooleanbooleanArray2M.AssertModel(models[10],_testData[22], false);FlatBooleanbooleanArray2M.AssertModel(models[11],_testData[23], false);FlatBooleanbooleanArray2M.AssertModel(models[12],_testData[24], false);FlatBooleanbooleanArray2M.AssertModel(models[13],_testData[25], false);FlatBooleanbooleanArray2M.AssertModel(models[14],_testData[26], false);FlatBooleanbooleanArray2M.AssertModel(models[15],_testData[27], false);FlatBooleanbooleanArray2M.AssertModel(models[16],_testData[28], false);FlatBooleanbooleanArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatBooleanbooleanArray2M.AssertModel(models[0],_testData[8], false);FlatBooleanbooleanArray2M.AssertModel(models[1],_testData[9], false);FlatBooleanbooleanArray2M.AssertModel(models[2],_testData[10], false);FlatBooleanbooleanArray2M.AssertModel(models[3],_testData[11], false);FlatBooleanbooleanArray2M.AssertModel(models[4],_testData[12], false);FlatBooleanbooleanArray2M.AssertModel(models[5],_testData[13], false);FlatBooleanbooleanArray2M.AssertModel(models[6],_testData[14], false);FlatBooleanbooleanArray2M.AssertModel(models[7],_testData[15], false);FlatBooleanbooleanArray2M.AssertModel(models[8],_testData[16], false);FlatBooleanbooleanArray2M.AssertModel(models[9],_testData[17], false);FlatBooleanbooleanArray2M.AssertModel(models[10],_testData[18], false);FlatBooleanbooleanArray2M.AssertModel(models[11],_testData[19], false);FlatBooleanbooleanArray2M.AssertModel(models[12],_testData[20], false);FlatBooleanbooleanArray2M.AssertModel(models[13],_testData[21], false);FlatBooleanbooleanArray2M.AssertModel(models[14],_testData[22], false);FlatBooleanbooleanArray2M.AssertModel(models[15],_testData[23], false);FlatBooleanbooleanArray2M.AssertModel(models[16],_testData[24], false);FlatBooleanbooleanArray2M.AssertModel(models[17],_testData[25], false);FlatBooleanbooleanArray2M.AssertModel(models[18],_testData[26], false);FlatBooleanbooleanArray2M.AssertModel(models[19],_testData[27], false);FlatBooleanbooleanArray2M.AssertModel(models[20],_testData[28], false);FlatBooleanbooleanArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.booleanbooleanarray2m m
LEFT JOIN public.booleanbooleanarray2mi mi ON mi.id = m.booleanbooleanarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IBooleanListbooleanArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanbooleanArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.booleanbooleanarray2m m
LEFT JOIN public.booleanbooleanarray2mi mi ON mi.id = m.booleanbooleanarray2mi_id
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
FROM public.booleanbooleanarray2m m
LEFT JOIN public.booleanbooleanarray2mi mi ON mi.id = m.booleanbooleanarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IBooleanListbooleanArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatBooleanbooleanArray2M.AssertModel(models[0],_testData[15], false);FlatBooleanbooleanArray2M.AssertModel(models[1],_testData[16], false);FlatBooleanbooleanArray2M.AssertModel(models[2],_testData[17], false);FlatBooleanbooleanArray2M.AssertModel(models[3],_testData[18], false);FlatBooleanbooleanArray2M.AssertModel(models[4],_testData[19], false);FlatBooleanbooleanArray2M.AssertModel(models[5],_testData[20], false);FlatBooleanbooleanArray2M.AssertModel(models[6],_testData[21], false);FlatBooleanbooleanArray2M.AssertModel(models[7],_testData[22], false);FlatBooleanbooleanArray2M.AssertModel(models[8],_testData[23], false);FlatBooleanbooleanArray2M.AssertModel(models[9],_testData[24], false);FlatBooleanbooleanArray2M.AssertModel(models[10],_testData[25], false);FlatBooleanbooleanArray2M.AssertModel(models[11],_testData[26], false);FlatBooleanbooleanArray2M.AssertModel(models[12],_testData[27], false);FlatBooleanbooleanArray2M.AssertModel(models[13],_testData[28], false);FlatBooleanbooleanArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
FlatBooleanbooleanArray2M.AssertModel(models[0],_testData[18], false);FlatBooleanbooleanArray2M.AssertModel(models[1],_testData[19], false);FlatBooleanbooleanArray2M.AssertModel(models[2],_testData[20], false);FlatBooleanbooleanArray2M.AssertModel(models[3],_testData[21], false);FlatBooleanbooleanArray2M.AssertModel(models[4],_testData[22], false);FlatBooleanbooleanArray2M.AssertModel(models[5],_testData[23], false);FlatBooleanbooleanArray2M.AssertModel(models[6],_testData[24], false);FlatBooleanbooleanArray2M.AssertModel(models[7],_testData[25], false);FlatBooleanbooleanArray2M.AssertModel(models[8],_testData[26], false);FlatBooleanbooleanArray2M.AssertModel(models[9],_testData[27], false);FlatBooleanbooleanArray2M.AssertModel(models[10],_testData[28], false);FlatBooleanbooleanArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.booleanbooleanarray2m m
LEFT JOIN public.booleanbooleanarray2mi mi ON mi.id = m.booleanbooleanarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BooleanbooleanArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanListbooleanArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanListbooleanArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSelectModelDynParBatchConfig()
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

                var models = await ((IBooleanListbooleanArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BooleanbooleanArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
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
                parametr2.Value = 77;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IBooleanListbooleanArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
BooleanbooleanArray2M.AssertModel(models[0],_testData[25], false);BooleanbooleanArray2M.AssertModel(models[1],_testData[26], false);BooleanbooleanArray2M.AssertModel(models[2],_testData[27], false);BooleanbooleanArray2M.AssertModel(models[3],_testData[28], false);BooleanbooleanArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
BooleanbooleanArray2M.AssertModel(models[0],_testData[16], false);BooleanbooleanArray2M.AssertModel(models[1],_testData[17], false);BooleanbooleanArray2M.AssertModel(models[2],_testData[18], false);BooleanbooleanArray2M.AssertModel(models[3],_testData[19], false);BooleanbooleanArray2M.AssertModel(models[4],_testData[20], false);BooleanbooleanArray2M.AssertModel(models[5],_testData[21], false);BooleanbooleanArray2M.AssertModel(models[6],_testData[22], false);BooleanbooleanArray2M.AssertModel(models[7],_testData[23], false);BooleanbooleanArray2M.AssertModel(models[8],_testData[24], false);BooleanbooleanArray2M.AssertModel(models[9],_testData[25], false);BooleanbooleanArray2M.AssertModel(models[10],_testData[26], false);BooleanbooleanArray2M.AssertModel(models[11],_testData[27], false);BooleanbooleanArray2M.AssertModel(models[12],_testData[28], false);BooleanbooleanArray2M.AssertModel(models[13],_testData[29], false);
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

                var models =  ((IBooleanListbooleanArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BooleanbooleanArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IBooleanListbooleanArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
BooleanbooleanArray2M.AssertModel(models[0],_testData[18], false);BooleanbooleanArray2M.AssertModel(models[1],_testData[19], false);BooleanbooleanArray2M.AssertModel(models[2],_testData[20], false);BooleanbooleanArray2M.AssertModel(models[3],_testData[21], false);BooleanbooleanArray2M.AssertModel(models[4],_testData[22], false);BooleanbooleanArray2M.AssertModel(models[5],_testData[23], false);BooleanbooleanArray2M.AssertModel(models[6],_testData[24], false);BooleanbooleanArray2M.AssertModel(models[7],_testData[25], false);BooleanbooleanArray2M.AssertModel(models[8],_testData[26], false);BooleanbooleanArray2M.AssertModel(models[9],_testData[27], false);BooleanbooleanArray2M.AssertModel(models[10],_testData[28], false);BooleanbooleanArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
BooleanbooleanArray2M.AssertModel(models[0],_testData[18], false);BooleanbooleanArray2M.AssertModel(models[1],_testData[19], false);BooleanbooleanArray2M.AssertModel(models[2],_testData[20], false);BooleanbooleanArray2M.AssertModel(models[3],_testData[21], false);BooleanbooleanArray2M.AssertModel(models[4],_testData[22], false);BooleanbooleanArray2M.AssertModel(models[5],_testData[23], false);BooleanbooleanArray2M.AssertModel(models[6],_testData[24], false);BooleanbooleanArray2M.AssertModel(models[7],_testData[25], false);BooleanbooleanArray2M.AssertModel(models[8],_testData[26], false);BooleanbooleanArray2M.AssertModel(models[9],_testData[27], false);BooleanbooleanArray2M.AssertModel(models[10],_testData[28], false);BooleanbooleanArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBooleanbooleanArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanListbooleanArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanListbooleanArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
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
FROM public.booleanbooleanarray2m m
LEFT JOIN public.booleanbooleanarray2mi mi ON mi.id = m.booleanbooleanarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IBooleanListbooleanArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanbooleanArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.booleanbooleanarray2m m
LEFT JOIN public.booleanbooleanarray2mi mi ON mi.id = m.booleanbooleanarray2mi_id
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
FROM public.booleanbooleanarray2m m
LEFT JOIN public.booleanbooleanarray2mi mi ON mi.id = m.booleanbooleanarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IBooleanListbooleanArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 32, query1, 20, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatBooleanbooleanArray2M.AssertModel(models[0],_testData[7], false);FlatBooleanbooleanArray2M.AssertModel(models[1],_testData[8], false);FlatBooleanbooleanArray2M.AssertModel(models[2],_testData[9], false);FlatBooleanbooleanArray2M.AssertModel(models[3],_testData[10], false);FlatBooleanbooleanArray2M.AssertModel(models[4],_testData[11], false);FlatBooleanbooleanArray2M.AssertModel(models[5],_testData[12], false);FlatBooleanbooleanArray2M.AssertModel(models[6],_testData[13], false);FlatBooleanbooleanArray2M.AssertModel(models[7],_testData[14], false);FlatBooleanbooleanArray2M.AssertModel(models[8],_testData[15], false);FlatBooleanbooleanArray2M.AssertModel(models[9],_testData[16], false);FlatBooleanbooleanArray2M.AssertModel(models[10],_testData[17], false);FlatBooleanbooleanArray2M.AssertModel(models[11],_testData[18], false);FlatBooleanbooleanArray2M.AssertModel(models[12],_testData[19], false);FlatBooleanbooleanArray2M.AssertModel(models[13],_testData[20], false);FlatBooleanbooleanArray2M.AssertModel(models[14],_testData[21], false);FlatBooleanbooleanArray2M.AssertModel(models[15],_testData[22], false);FlatBooleanbooleanArray2M.AssertModel(models[16],_testData[23], false);FlatBooleanbooleanArray2M.AssertModel(models[17],_testData[24], false);FlatBooleanbooleanArray2M.AssertModel(models[18],_testData[25], false);FlatBooleanbooleanArray2M.AssertModel(models[19],_testData[26], false);FlatBooleanbooleanArray2M.AssertModel(models[20],_testData[27], false);FlatBooleanbooleanArray2M.AssertModel(models[21],_testData[28], false);FlatBooleanbooleanArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatBooleanbooleanArray2M.AssertModel(models[0],_testData[4], false);FlatBooleanbooleanArray2M.AssertModel(models[1],_testData[5], false);FlatBooleanbooleanArray2M.AssertModel(models[2],_testData[6], false);FlatBooleanbooleanArray2M.AssertModel(models[3],_testData[7], false);FlatBooleanbooleanArray2M.AssertModel(models[4],_testData[8], false);FlatBooleanbooleanArray2M.AssertModel(models[5],_testData[9], false);FlatBooleanbooleanArray2M.AssertModel(models[6],_testData[10], false);FlatBooleanbooleanArray2M.AssertModel(models[7],_testData[11], false);FlatBooleanbooleanArray2M.AssertModel(models[8],_testData[12], false);FlatBooleanbooleanArray2M.AssertModel(models[9],_testData[13], false);FlatBooleanbooleanArray2M.AssertModel(models[10],_testData[14], false);FlatBooleanbooleanArray2M.AssertModel(models[11],_testData[15], false);FlatBooleanbooleanArray2M.AssertModel(models[12],_testData[16], false);FlatBooleanbooleanArray2M.AssertModel(models[13],_testData[17], false);FlatBooleanbooleanArray2M.AssertModel(models[14],_testData[18], false);FlatBooleanbooleanArray2M.AssertModel(models[15],_testData[19], false);FlatBooleanbooleanArray2M.AssertModel(models[16],_testData[20], false);FlatBooleanbooleanArray2M.AssertModel(models[17],_testData[21], false);FlatBooleanbooleanArray2M.AssertModel(models[18],_testData[22], false);FlatBooleanbooleanArray2M.AssertModel(models[19],_testData[23], false);FlatBooleanbooleanArray2M.AssertModel(models[20],_testData[24], false);FlatBooleanbooleanArray2M.AssertModel(models[21],_testData[25], false);FlatBooleanbooleanArray2M.AssertModel(models[22],_testData[26], false);FlatBooleanbooleanArray2M.AssertModel(models[23],_testData[27], false);FlatBooleanbooleanArray2M.AssertModel(models[24],_testData[28], false);FlatBooleanbooleanArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.booleanbooleanarray2m m
LEFT JOIN public.booleanbooleanarray2mi mi ON mi.id = m.booleanbooleanarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IBooleanListbooleanArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanbooleanArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.booleanbooleanarray2m m
LEFT JOIN public.booleanbooleanarray2mi mi ON mi.id = m.booleanbooleanarray2mi_id
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
FROM public.booleanbooleanarray2m m
LEFT JOIN public.booleanbooleanarray2mi mi ON mi.id = m.booleanbooleanarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IBooleanListbooleanArray)this).DbConnectionDynQuerySelectModelBatch(connection, 50, query1, 79, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatBooleanbooleanArray2M.AssertModel(models[0],_testData[11], false);FlatBooleanbooleanArray2M.AssertModel(models[1],_testData[12], false);FlatBooleanbooleanArray2M.AssertModel(models[2],_testData[13], false);FlatBooleanbooleanArray2M.AssertModel(models[3],_testData[14], false);FlatBooleanbooleanArray2M.AssertModel(models[4],_testData[15], false);FlatBooleanbooleanArray2M.AssertModel(models[5],_testData[16], false);FlatBooleanbooleanArray2M.AssertModel(models[6],_testData[17], false);FlatBooleanbooleanArray2M.AssertModel(models[7],_testData[18], false);FlatBooleanbooleanArray2M.AssertModel(models[8],_testData[19], false);FlatBooleanbooleanArray2M.AssertModel(models[9],_testData[20], false);FlatBooleanbooleanArray2M.AssertModel(models[10],_testData[21], false);FlatBooleanbooleanArray2M.AssertModel(models[11],_testData[22], false);FlatBooleanbooleanArray2M.AssertModel(models[12],_testData[23], false);FlatBooleanbooleanArray2M.AssertModel(models[13],_testData[24], false);FlatBooleanbooleanArray2M.AssertModel(models[14],_testData[25], false);FlatBooleanbooleanArray2M.AssertModel(models[15],_testData[26], false);FlatBooleanbooleanArray2M.AssertModel(models[16],_testData[27], false);FlatBooleanbooleanArray2M.AssertModel(models[17],_testData[28], false);FlatBooleanbooleanArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
FlatBooleanbooleanArray2M.AssertModel(models[0],_testData[17], false);FlatBooleanbooleanArray2M.AssertModel(models[1],_testData[18], false);FlatBooleanbooleanArray2M.AssertModel(models[2],_testData[19], false);FlatBooleanbooleanArray2M.AssertModel(models[3],_testData[20], false);FlatBooleanbooleanArray2M.AssertModel(models[4],_testData[21], false);FlatBooleanbooleanArray2M.AssertModel(models[5],_testData[22], false);FlatBooleanbooleanArray2M.AssertModel(models[6],_testData[23], false);FlatBooleanbooleanArray2M.AssertModel(models[7],_testData[24], false);FlatBooleanbooleanArray2M.AssertModel(models[8],_testData[25], false);FlatBooleanbooleanArray2M.AssertModel(models[9],_testData[26], false);FlatBooleanbooleanArray2M.AssertModel(models[10],_testData[27], false);FlatBooleanbooleanArray2M.AssertModel(models[11],_testData[28], false);FlatBooleanbooleanArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.booleanbooleanarray2m m
LEFT JOIN public.booleanbooleanarray2mi mi ON mi.id = m.booleanbooleanarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BooleanbooleanArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanListbooleanArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanListbooleanArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBooleanListbooleanArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BooleanbooleanArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IBooleanListbooleanArray)this).DbConnectionSelectModelBatchAsync(connection, 36, 88))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
BooleanbooleanArray2M.AssertModel(models[0],_testData[9], false);BooleanbooleanArray2M.AssertModel(models[1],_testData[10], false);BooleanbooleanArray2M.AssertModel(models[2],_testData[11], false);BooleanbooleanArray2M.AssertModel(models[3],_testData[12], false);BooleanbooleanArray2M.AssertModel(models[4],_testData[13], false);BooleanbooleanArray2M.AssertModel(models[5],_testData[14], false);BooleanbooleanArray2M.AssertModel(models[6],_testData[15], false);BooleanbooleanArray2M.AssertModel(models[7],_testData[16], false);BooleanbooleanArray2M.AssertModel(models[8],_testData[17], false);BooleanbooleanArray2M.AssertModel(models[9],_testData[18], false);BooleanbooleanArray2M.AssertModel(models[10],_testData[19], false);BooleanbooleanArray2M.AssertModel(models[11],_testData[20], false);BooleanbooleanArray2M.AssertModel(models[12],_testData[21], false);BooleanbooleanArray2M.AssertModel(models[13],_testData[22], false);BooleanbooleanArray2M.AssertModel(models[14],_testData[23], false);BooleanbooleanArray2M.AssertModel(models[15],_testData[24], false);BooleanbooleanArray2M.AssertModel(models[16],_testData[25], false);BooleanbooleanArray2M.AssertModel(models[17],_testData[26], false);BooleanbooleanArray2M.AssertModel(models[18],_testData[27], false);BooleanbooleanArray2M.AssertModel(models[19],_testData[28], false);BooleanbooleanArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
BooleanbooleanArray2M.AssertModel(models[0],_testData[21], false);BooleanbooleanArray2M.AssertModel(models[1],_testData[22], false);BooleanbooleanArray2M.AssertModel(models[2],_testData[23], false);BooleanbooleanArray2M.AssertModel(models[3],_testData[24], false);BooleanbooleanArray2M.AssertModel(models[4],_testData[25], false);BooleanbooleanArray2M.AssertModel(models[5],_testData[26], false);BooleanbooleanArray2M.AssertModel(models[6],_testData[27], false);BooleanbooleanArray2M.AssertModel(models[7],_testData[28], false);BooleanbooleanArray2M.AssertModel(models[8],_testData[29], false);
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
                var models =  ((IBooleanListbooleanArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BooleanbooleanArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IBooleanListbooleanArray)this).DbConnectionSelectModelBatch(connection, 20, 77))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
BooleanbooleanArray2M.AssertModel(models[0],_testData[4], false);BooleanbooleanArray2M.AssertModel(models[1],_testData[5], false);BooleanbooleanArray2M.AssertModel(models[2],_testData[6], false);BooleanbooleanArray2M.AssertModel(models[3],_testData[7], false);BooleanbooleanArray2M.AssertModel(models[4],_testData[8], false);BooleanbooleanArray2M.AssertModel(models[5],_testData[9], false);BooleanbooleanArray2M.AssertModel(models[6],_testData[10], false);BooleanbooleanArray2M.AssertModel(models[7],_testData[11], false);BooleanbooleanArray2M.AssertModel(models[8],_testData[12], false);BooleanbooleanArray2M.AssertModel(models[9],_testData[13], false);BooleanbooleanArray2M.AssertModel(models[10],_testData[14], false);BooleanbooleanArray2M.AssertModel(models[11],_testData[15], false);BooleanbooleanArray2M.AssertModel(models[12],_testData[16], false);BooleanbooleanArray2M.AssertModel(models[13],_testData[17], false);BooleanbooleanArray2M.AssertModel(models[14],_testData[18], false);BooleanbooleanArray2M.AssertModel(models[15],_testData[19], false);BooleanbooleanArray2M.AssertModel(models[16],_testData[20], false);BooleanbooleanArray2M.AssertModel(models[17],_testData[21], false);BooleanbooleanArray2M.AssertModel(models[18],_testData[22], false);BooleanbooleanArray2M.AssertModel(models[19],_testData[23], false);BooleanbooleanArray2M.AssertModel(models[20],_testData[24], false);BooleanbooleanArray2M.AssertModel(models[21],_testData[25], false);BooleanbooleanArray2M.AssertModel(models[22],_testData[26], false);BooleanbooleanArray2M.AssertModel(models[23],_testData[27], false);BooleanbooleanArray2M.AssertModel(models[24],_testData[28], false);BooleanbooleanArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
BooleanbooleanArray2M.AssertModel(models[0],_testData[16], false);BooleanbooleanArray2M.AssertModel(models[1],_testData[17], false);BooleanbooleanArray2M.AssertModel(models[2],_testData[18], false);BooleanbooleanArray2M.AssertModel(models[3],_testData[19], false);BooleanbooleanArray2M.AssertModel(models[4],_testData[20], false);BooleanbooleanArray2M.AssertModel(models[5],_testData[21], false);BooleanbooleanArray2M.AssertModel(models[6],_testData[22], false);BooleanbooleanArray2M.AssertModel(models[7],_testData[23], false);BooleanbooleanArray2M.AssertModel(models[8],_testData[24], false);BooleanbooleanArray2M.AssertModel(models[9],_testData[25], false);BooleanbooleanArray2M.AssertModel(models[10],_testData[26], false);BooleanbooleanArray2M.AssertModel(models[11],_testData[27], false);BooleanbooleanArray2M.AssertModel(models[12],_testData[28], false);BooleanbooleanArray2M.AssertModel(models[13],_testData[29], false);
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
                await using var cmd = await ((IBooleanListbooleanArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBooleanListbooleanArray)this).SetDbConnectionSelectModelParametrs(cmd, 73);
                var models = await ((IBooleanListbooleanArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(15));
BooleanbooleanArray2M.AssertModel(models[0],_testData[15], false);BooleanbooleanArray2M.AssertModel(models[1],_testData[16], false);BooleanbooleanArray2M.AssertModel(models[2],_testData[17], false);BooleanbooleanArray2M.AssertModel(models[3],_testData[18], false);BooleanbooleanArray2M.AssertModel(models[4],_testData[19], false);BooleanbooleanArray2M.AssertModel(models[5],_testData[20], false);BooleanbooleanArray2M.AssertModel(models[6],_testData[21], false);BooleanbooleanArray2M.AssertModel(models[7],_testData[22], false);BooleanbooleanArray2M.AssertModel(models[8],_testData[23], false);BooleanbooleanArray2M.AssertModel(models[9],_testData[24], false);BooleanbooleanArray2M.AssertModel(models[10],_testData[25], false);BooleanbooleanArray2M.AssertModel(models[11],_testData[26], false);BooleanbooleanArray2M.AssertModel(models[12],_testData[27], false);BooleanbooleanArray2M.AssertModel(models[13],_testData[28], false);BooleanbooleanArray2M.AssertModel(models[14],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBooleanListbooleanArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBooleanListbooleanArray)this).SetDbConnectionSelectModelParametrs(cmd, 53);
                var models =  ((IBooleanListbooleanArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
BooleanbooleanArray2M.AssertModel(models[0],_testData[12], false);BooleanbooleanArray2M.AssertModel(models[1],_testData[13], false);BooleanbooleanArray2M.AssertModel(models[2],_testData[14], false);BooleanbooleanArray2M.AssertModel(models[3],_testData[15], false);BooleanbooleanArray2M.AssertModel(models[4],_testData[16], false);BooleanbooleanArray2M.AssertModel(models[5],_testData[17], false);BooleanbooleanArray2M.AssertModel(models[6],_testData[18], false);BooleanbooleanArray2M.AssertModel(models[7],_testData[19], false);BooleanbooleanArray2M.AssertModel(models[8],_testData[20], false);BooleanbooleanArray2M.AssertModel(models[9],_testData[21], false);BooleanbooleanArray2M.AssertModel(models[10],_testData[22], false);BooleanbooleanArray2M.AssertModel(models[11],_testData[23], false);BooleanbooleanArray2M.AssertModel(models[12],_testData[24], false);BooleanbooleanArray2M.AssertModel(models[13],_testData[25], false);BooleanbooleanArray2M.AssertModel(models[14],_testData[26], false);BooleanbooleanArray2M.AssertModel(models[15],_testData[27], false);BooleanbooleanArray2M.AssertModel(models[16],_testData[28], false);BooleanbooleanArray2M.AssertModel(models[17],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_booleanbooleanarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(BooleanbooleanArray2MI)],
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
            asPartInterface: typeof(IBooleanListbooleanArray))]
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
FROM public.binary_booleanbooleanarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BooleanbooleanArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanListbooleanArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<BooleanbooleanArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IBooleanListbooleanArray)this).ImportModelInner(connection, importCollection);
                var models = ((IBooleanListbooleanArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BooleanbooleanArray2MI.AssertModel(actual, expect, false);
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
                await ((IBooleanListbooleanArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IBooleanListbooleanArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BooleanbooleanArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_booleanbooleanarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
booleanbooleanarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(BooleanbooleanArray2M)],
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
            asPartInterface: typeof(IBooleanListbooleanArray))]
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
FROM public.binary_booleanbooleanarray2m m
LEFT JOIN public.binary_booleanbooleanarray2mi mi ON mi.id = m.booleanbooleanarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BooleanbooleanArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanListbooleanArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<BooleanbooleanArray2M>(15);

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
                ((IBooleanListbooleanArray)this).ImportModel(connection, importCollection);
                var models = ((IBooleanListbooleanArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                BooleanbooleanArray2M.AssertModel(models[0],_testData[0], false);
                BooleanbooleanArray2M.AssertModel(models[1],_testData[1], false);
                BooleanbooleanArray2M.AssertModel(models[2],_testData[2], false);
                BooleanbooleanArray2M.AssertModel(models[3],_testData[3], false);
                BooleanbooleanArray2M.AssertModel(models[4],_testData[4], false);
                BooleanbooleanArray2M.AssertModel(models[5],_testData[5], false);
                BooleanbooleanArray2M.AssertModel(models[6],_testData[6], false);
                BooleanbooleanArray2M.AssertModel(models[7],_testData[7], false);
                BooleanbooleanArray2M.AssertModel(models[8],_testData[8], false);
                BooleanbooleanArray2M.AssertModel(models[9],_testData[9], false);
                BooleanbooleanArray2M.AssertModel(models[10],_testData[10], false);
                BooleanbooleanArray2M.AssertModel(models[11],_testData[11], false);
                BooleanbooleanArray2M.AssertModel(models[12],_testData[12], false);
                BooleanbooleanArray2M.AssertModel(models[13],_testData[13], false);
                BooleanbooleanArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((IBooleanListbooleanArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IBooleanListbooleanArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                BooleanbooleanArray2M.AssertModel(models[0],_testData[0], false);
                BooleanbooleanArray2M.AssertModel(models[1],_testData[1], false);
                BooleanbooleanArray2M.AssertModel(models[2],_testData[2], false);
                BooleanbooleanArray2M.AssertModel(models[3],_testData[3], false);
                BooleanbooleanArray2M.AssertModel(models[4],_testData[4], false);
                BooleanbooleanArray2M.AssertModel(models[5],_testData[5], false);
                BooleanbooleanArray2M.AssertModel(models[6],_testData[6], false);
                BooleanbooleanArray2M.AssertModel(models[7],_testData[7], false);
                BooleanbooleanArray2M.AssertModel(models[8],_testData[8], false);
                BooleanbooleanArray2M.AssertModel(models[9],_testData[9], false);
                BooleanbooleanArray2M.AssertModel(models[10],_testData[10], false);
                BooleanbooleanArray2M.AssertModel(models[11],_testData[11], false);
                BooleanbooleanArray2M.AssertModel(models[12],_testData[12], false);
                BooleanbooleanArray2M.AssertModel(models[13],_testData[13], false);
                BooleanbooleanArray2M.AssertModel(models[14],_testData[14], false);
                BooleanbooleanArray2M.AssertModel(models[15],_testData[15], false);
                BooleanbooleanArray2M.AssertModel(models[16],_testData[16], false);
                BooleanbooleanArray2M.AssertModel(models[17],_testData[17], false);
                BooleanbooleanArray2M.AssertModel(models[18],_testData[18], false);
                BooleanbooleanArray2M.AssertModel(models[19],_testData[19], false);
                BooleanbooleanArray2M.AssertModel(models[20],_testData[20], false);
                BooleanbooleanArray2M.AssertModel(models[21],_testData[21], false);
                BooleanbooleanArray2M.AssertModel(models[22],_testData[22], false);
                BooleanbooleanArray2M.AssertModel(models[23],_testData[23], false);
                BooleanbooleanArray2M.AssertModel(models[24],_testData[24], false);
                BooleanbooleanArray2M.AssertModel(models[25],_testData[25], false);
                BooleanbooleanArray2M.AssertModel(models[26],_testData[26], false);
                BooleanbooleanArray2M.AssertModel(models[27],_testData[27], false);
                BooleanbooleanArray2M.AssertModel(models[28],_testData[28], false);
                BooleanbooleanArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_booleanbooleanarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    booleanbooleanarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BooleanbooleanArray2M)],
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
            asPartInterface: typeof(IBooleanListbooleanArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IBooleanListbooleanArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BooleanbooleanArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBooleanListbooleanArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BooleanbooleanArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_booleanbooleanarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BooleanbooleanArray2MI)],
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
            asPartInterface: typeof(IBooleanListbooleanArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IBooleanListbooleanArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BooleanbooleanArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBooleanListbooleanArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BooleanbooleanArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

