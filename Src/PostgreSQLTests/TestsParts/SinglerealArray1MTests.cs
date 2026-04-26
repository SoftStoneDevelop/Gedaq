

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
    internal partial interface ISingleArrayrealArray
    {
    }
    
    internal partial class SingleArrayrealArray : ISingleArrayrealArray
    {


#region TestData

        private readonly SinglerealArray1M[] _testData = new SinglerealArray1M[]
        {
            new SinglerealArray1M
{
    Id = 3,
    Value = 
new System.Single[3]
{
0.005705476f,
0.569426f,
0.21817333f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 5,
    Value = 
new System.Single[3]
{
0.82185334f,
0.4241975f,
0.4600261f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 5,
    Value = 
new System.Single[3]
{
0.2197234f,
0.88815075f,
0.16112298f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 12,
    Value = 
new System.Single[3]
{
0.965817f,
0.59485954f,
0.98905593f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.12774771f,
0.90315443f,
0.06285107f,
},
},
            new SinglerealArray1M
{
    Id = 16,
    Value = 
new System.Single[4]
{
0.6307264f,
0.33583683f,
0.07030451f,
0.73824036f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 13,
    Value = 
new System.Single[4]
{
0.5679771f,
0.37014163f,
0.8089814f,
0.024626553f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[3]
{
0.23921233f,
0.47121602f,
0.1732338f,
},
},
            new SinglerealArray1M
{
    Id = 18,
    Value = 
new System.Single[4]
{
0.8367553f,
0.61454016f,
0.074195445f,
0.085779846f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 24,
    Value = 
new System.Single[4]
{
0.19765604f,
0.3800559f,
0.20041198f,
0.94990855f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 17,
    Value = 
new System.Single[4]
{
0.32571363f,
0.38187957f,
0.27151817f,
0.84145296f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.60351694f,
0.8762014f,
0.79455805f,
0.9150372f,
},
},
            new SinglerealArray1M
{
    Id = 26,
    Value = 
new System.Single[4]
{
0.5492551f,
0.44385105f,
0.3964929f,
0.58718544f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 32,
    Value = 
new System.Single[4]
{
0.6632057f,
0.40112317f,
0.75101525f,
0.6734567f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 23,
    Value = 
new System.Single[4]
{
0.68480694f,
0.53956246f,
0.9017072f,
0.48274106f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.6580779f,
0.6677875f,
0.30826175f,
0.68749505f,
},
},
            new SinglerealArray1M
{
    Id = 34,
    Value = 
new System.Single[4]
{
0.99186975f,
0.78833926f,
0.28298676f,
0.1254254f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.8956919f,
0.027551115f,
0.2586921f,
0.004504144f,
},
},
            new SinglerealArray1M
{
    Id = 41,
    Value = 
new System.Single[3]
{
0.83078575f,
0.117938936f,
0.6269956f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 27,
    Value = 
new System.Single[4]
{
0.5901707f,
0.50652623f,
0.08210391f,
0.031651855f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 48,
    Value = 
new System.Single[3]
{
0.023963213f,
0.9902852f,
0.24283636f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.75789964f,
0.10209125f,
0.7305011f,
0.93559325f,
},
},
            new SinglerealArray1M
{
    Id = 55,
    Value = 
new System.Single[3]
{
0.20191795f,
0.44476247f,
0.6207166f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 30,
    Value = 
new System.Single[4]
{
0.5651932f,
0.7771171f,
0.5748173f,
0.19046324f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.061745405f,
0.5129841f,
0.9667569f,
0.60063416f,
},
},
            new SinglerealArray1M
{
    Id = 63,
    Value = 
new System.Single[3]
{
0.37381124f,
0.9621707f,
0.059588492f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 70,
    Value = 
new System.Single[3]
{
0.043115437f,
0.82768905f,
0.5978756f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 33,
    Value = 
new System.Single[3]
{
0.0007660389f,
0.046829402f,
0.3068775f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[3]
{
0.96328634f,
0.80854654f,
0.2964152f,
},
},
            new SinglerealArray1M
{
    Id = 76,
    Value = 
new System.Single[3]
{
0.6484569f,
0.8598316f,
0.80119395f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.5036771f,
0.27701563f,
0.9494019f,
},
},
            new SinglerealArray1M
{
    Id = 80,
    Value = 
new System.Single[3]
{
0.99169266f,
0.6840643f,
0.28208125f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 41,
    Value = 
new System.Single[3]
{
0.7963641f,
0.86195344f,
0.45271003f,
},
    NullableValue = 
new System.Single[4]
{
0.9255724f,
0.11212993f,
0.67916363f,
0.22109175f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 84,
    Value = 
new System.Single[4]
{
0.48596215f,
0.5613122f,
0.591026f,
0.9183472f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.14071542f,
0.41361076f,
0.63004154f,
0.9596212f,
},
},
            new SinglerealArray1M
{
    Id = 89,
    Value = 
new System.Single[3]
{
0.36315268f,
0.5450949f,
0.9824174f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 46,
    Value = 
new System.Single[3]
{
0.8693222f,
0.7695909f,
0.7438913f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 96,
    Value = 
new System.Single[4]
{
0.042111278f,
0.53955257f,
0.46879953f,
0.87008196f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.5047855f,
0.4133274f,
0.7970965f,
0.31526542f,
},
},
            new SinglerealArray1M
{
    Id = 98,
    Value = 
new System.Single[4]
{
0.68459195f,
0.9471798f,
0.47067416f,
0.6289868f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 50,
    Value = 
new System.Single[3]
{
0.95469505f,
0.5869543f,
0.2942326f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 107,
    Value = 
new System.Single[3]
{
0.10595423f,
0.96853375f,
0.02738589f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.36682564f,
0.6092773f,
0.67117023f,
0.4272555f,
},
},
            new SinglerealArray1M
{
    Id = 109,
    Value = 
new System.Single[3]
{
0.79353017f,
0.6784543f,
0.8217066f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 58,
    Value = 
new System.Single[4]
{
0.6023175f,
0.43988383f,
0.19702488f,
0.52812964f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 111,
    Value = 
new System.Single[4]
{
0.79282284f,
0.19212931f,
0.44404316f,
0.36497504f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 113,
    Value = 
new System.Single[3]
{
0.6826312f,
0.33395243f,
0.20091784f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 60,
    Value = 
new System.Single[3]
{
0.33637756f,
0.8684314f,
0.48231995f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 122,
    Value = 
new System.Single[4]
{
0.3129679f,
0.2539569f,
0.89733917f,
0.17805946f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 128,
    Value = 
new System.Single[3]
{
0.8545895f,
0.85733134f,
0.28459704f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 65,
    Value = 
new System.Single[4]
{
0.5699006f,
0.2792415f,
0.085235596f,
0.57823366f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.3054412f,
0.9532032f,
0.31858802f,
0.800353f,
},
},
            new SinglerealArray1M
{
    Id = 136,
    Value = 
new System.Single[3]
{
0.9304132f,
0.8456057f,
0.9067271f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 142,
    Value = 
new System.Single[4]
{
0.7782529f,
0.81743926f,
0.76965904f,
0.39706022f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 69,
    Value = 
new System.Single[3]
{
0.36993963f,
0.030914664f,
0.26697755f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 149,
    Value = 
new System.Single[3]
{
0.7617519f,
0.15950161f,
0.9227485f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.51568204f,
0.8752589f,
0.022531867f,
},
},
            new SinglerealArray1M
{
    Id = 154,
    Value = 
new System.Single[4]
{
0.12124121f,
0.32887667f,
0.14445525f,
0.00044751167f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 72,
    Value = 
new System.Single[3]
{
0.58232754f,
0.5042748f,
0.4725365f,
},
    NullableValue = 
new System.Single[3]
{
0.19986922f,
0.5139365f,
0.5284529f,
},
},
    NullableValue = 
new System.Single[3]
{
0.46173608f,
0.04183185f,
0.22717762f,
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray1mi(
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
            asPartInterface: typeof(ISingleArrayrealArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray1mi(
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
            queryMapTypes: [typeof(SinglerealArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631))]
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

                changedRows =  ((ISingleArrayrealArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISingleArrayrealArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ISingleArrayrealArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleArrayrealArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ISingleArrayrealArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ISingleArrayrealArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray1m(
	id,
    value,
    nullablevalue,
    singlerealarray1mi_id
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
            asPartInterface: typeof(ISingleArrayrealArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "singlerealarray1mi_id", 
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
                changedRows =  ((ISingleArrayrealArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ISingleArrayrealArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ISingleArrayrealArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ISingleArrayrealArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray1m(
	id,
    value,
    nullablevalue,
    singlerealarray1mi_id
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
    singlerealarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(SinglerealArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
                System.Single[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Single[]>();
                    ((NpgsqlParameter<System.Single[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483631);
                    ((NpgsqlParameter<System.Single[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483631);
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

                    nullable =  ((ISingleArrayrealArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Single[]>();
                    ((NpgsqlParameter<System.Single[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483631);
                    ((NpgsqlParameter<System.Single[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483631);
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

                    nullable =  ((ISingleArrayrealArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[4]
{
0.60351694f,
0.8762014f,
0.79455805f,
0.9150372f,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Single[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Single[]>();
                    ((NpgsqlParameter<System.Single[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483631);
                    ((NpgsqlParameter<System.Single[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483631);
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

                    nullable = await ((ISingleArrayrealArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Single[]>();
                    ((NpgsqlParameter<System.Single[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483631);
                    ((NpgsqlParameter<System.Single[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483631);
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

                    nullable = await ((ISingleArrayrealArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[4]
{
0.6580779f,
0.6677875f,
0.30826175f,
0.68749505f,
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray1m(
	id,
    value,
    nullablevalue,
    singlerealarray1mi_id
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
    singlerealarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(SinglerealArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "singlerealarray1mi_id", 
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
                System.Single[] nullable = null;
                nullable =  ((ISingleArrayrealArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[4]
{
0.8956919f,
0.027551115f,
0.2586921f,
0.004504144f,
}));
                nullable =  ((ISingleArrayrealArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Single[] nullable = null;
                nullable = await ((ISingleArrayrealArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[4]
{
0.75789964f,
0.10209125f,
0.7305011f,
0.93559325f,
}));
                nullable = await ((ISingleArrayrealArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[4]
{
0.061745405f,
0.5129841f,
0.9667569f,
0.60063416f,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<SinglerealArray1M> models = null;

                models =  ((ISingleArrayrealArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((ISingleArrayrealArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((ISingleArrayrealArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((ISingleArrayrealArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<SinglerealArray1M> models = null;

                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
FROM public.singlerealarray1m m
LEFT JOIN public.singlerealarray1mi mi ON mi.id = m.singlerealarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((ISingleArrayrealArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray1m m
LEFT JOIN public.singlerealarray1mi mi ON mi.id = m.singlerealarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((ISingleArrayrealArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray1m m
LEFT JOIN public.singlerealarray1mi mi ON mi.id = m.singlerealarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(SinglerealArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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

                var models = await ((ISingleArrayrealArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray1M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((ISingleArrayrealArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
FROM public.singlerealarray1m m
LEFT JOIN public.singlerealarray1mi mi ON mi.id = m.singlerealarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ISingleArrayrealArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray1m m
LEFT JOIN public.singlerealarray1mi mi ON mi.id = m.singlerealarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((ISingleArrayrealArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray1m m
LEFT JOIN public.singlerealarray1mi mi ON mi.id = m.singlerealarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(SinglerealArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
                var models = await ((ISingleArrayrealArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ISingleArrayrealArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
FROM public.singlerealarray1m m
LEFT JOIN public.singlerealarray1mi mi ON mi.id = m.singlerealarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 76;
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
FROM public.singlerealarray1m m
LEFT JOIN public.singlerealarray1mi mi ON mi.id = m.singlerealarray1mi_id
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
FROM public.singlerealarray1m m
LEFT JOIN public.singlerealarray1mi mi ON mi.id = m.singlerealarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatSinglerealArray1M.AssertModel(models[0],_testData[15], false);FlatSinglerealArray1M.AssertModel(models[1],_testData[16], false);FlatSinglerealArray1M.AssertModel(models[2],_testData[17], false);FlatSinglerealArray1M.AssertModel(models[3],_testData[18], false);FlatSinglerealArray1M.AssertModel(models[4],_testData[19], false);FlatSinglerealArray1M.AssertModel(models[5],_testData[20], false);FlatSinglerealArray1M.AssertModel(models[6],_testData[21], false);FlatSinglerealArray1M.AssertModel(models[7],_testData[22], false);FlatSinglerealArray1M.AssertModel(models[8],_testData[23], false);FlatSinglerealArray1M.AssertModel(models[9],_testData[24], false);FlatSinglerealArray1M.AssertModel(models[10],_testData[25], false);FlatSinglerealArray1M.AssertModel(models[11],_testData[26], false);FlatSinglerealArray1M.AssertModel(models[12],_testData[27], false);FlatSinglerealArray1M.AssertModel(models[13],_testData[28], false);FlatSinglerealArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
FlatSinglerealArray1M.AssertModel(models[0],_testData[18], false);FlatSinglerealArray1M.AssertModel(models[1],_testData[19], false);FlatSinglerealArray1M.AssertModel(models[2],_testData[20], false);FlatSinglerealArray1M.AssertModel(models[3],_testData[21], false);FlatSinglerealArray1M.AssertModel(models[4],_testData[22], false);FlatSinglerealArray1M.AssertModel(models[5],_testData[23], false);FlatSinglerealArray1M.AssertModel(models[6],_testData[24], false);FlatSinglerealArray1M.AssertModel(models[7],_testData[25], false);FlatSinglerealArray1M.AssertModel(models[8],_testData[26], false);FlatSinglerealArray1M.AssertModel(models[9],_testData[27], false);FlatSinglerealArray1M.AssertModel(models[10],_testData[28], false);FlatSinglerealArray1M.AssertModel(models[11],_testData[29], false);
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
FROM public.singlerealarray1m m
LEFT JOIN public.singlerealarray1mi mi ON mi.id = m.singlerealarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealarray1m m
LEFT JOIN public.singlerealarray1mi mi ON mi.id = m.singlerealarray1mi_id
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
FROM public.singlerealarray1m m
LEFT JOIN public.singlerealarray1mi mi ON mi.id = m.singlerealarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatSinglerealArray1M.AssertModel(models[0],_testData[19], false);FlatSinglerealArray1M.AssertModel(models[1],_testData[20], false);FlatSinglerealArray1M.AssertModel(models[2],_testData[21], false);FlatSinglerealArray1M.AssertModel(models[3],_testData[22], false);FlatSinglerealArray1M.AssertModel(models[4],_testData[23], false);FlatSinglerealArray1M.AssertModel(models[5],_testData[24], false);FlatSinglerealArray1M.AssertModel(models[6],_testData[25], false);FlatSinglerealArray1M.AssertModel(models[7],_testData[26], false);FlatSinglerealArray1M.AssertModel(models[8],_testData[27], false);FlatSinglerealArray1M.AssertModel(models[9],_testData[28], false);FlatSinglerealArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatSinglerealArray1M.AssertModel(models[0],_testData[25], false);FlatSinglerealArray1M.AssertModel(models[1],_testData[26], false);FlatSinglerealArray1M.AssertModel(models[2],_testData[27], false);FlatSinglerealArray1M.AssertModel(models[3],_testData[28], false);FlatSinglerealArray1M.AssertModel(models[4],_testData[29], false);
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
FROM public.singlerealarray1m m
LEFT JOIN public.singlerealarray1mi mi ON mi.id = m.singlerealarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(SinglerealArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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

                var models = await ((ISingleArrayrealArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
SinglerealArray1M.AssertModel(models[0],_testData[3], false);SinglerealArray1M.AssertModel(models[1],_testData[4], false);SinglerealArray1M.AssertModel(models[2],_testData[5], false);SinglerealArray1M.AssertModel(models[3],_testData[6], false);SinglerealArray1M.AssertModel(models[4],_testData[7], false);SinglerealArray1M.AssertModel(models[5],_testData[8], false);SinglerealArray1M.AssertModel(models[6],_testData[9], false);SinglerealArray1M.AssertModel(models[7],_testData[10], false);SinglerealArray1M.AssertModel(models[8],_testData[11], false);SinglerealArray1M.AssertModel(models[9],_testData[12], false);SinglerealArray1M.AssertModel(models[10],_testData[13], false);SinglerealArray1M.AssertModel(models[11],_testData[14], false);SinglerealArray1M.AssertModel(models[12],_testData[15], false);SinglerealArray1M.AssertModel(models[13],_testData[16], false);SinglerealArray1M.AssertModel(models[14],_testData[17], false);SinglerealArray1M.AssertModel(models[15],_testData[18], false);SinglerealArray1M.AssertModel(models[16],_testData[19], false);SinglerealArray1M.AssertModel(models[17],_testData[20], false);SinglerealArray1M.AssertModel(models[18],_testData[21], false);SinglerealArray1M.AssertModel(models[19],_testData[22], false);SinglerealArray1M.AssertModel(models[20],_testData[23], false);SinglerealArray1M.AssertModel(models[21],_testData[24], false);SinglerealArray1M.AssertModel(models[22],_testData[25], false);SinglerealArray1M.AssertModel(models[23],_testData[26], false);SinglerealArray1M.AssertModel(models[24],_testData[27], false);SinglerealArray1M.AssertModel(models[25],_testData[28], false);SinglerealArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
SinglerealArray1M.AssertModel(models[0],_testData[26], false);SinglerealArray1M.AssertModel(models[1],_testData[27], false);SinglerealArray1M.AssertModel(models[2],_testData[28], false);SinglerealArray1M.AssertModel(models[3],_testData[29], false);
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

                var models =  ((ISingleArrayrealArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
SinglerealArray1M.AssertModel(models[0],_testData[16], false);SinglerealArray1M.AssertModel(models[1],_testData[17], false);SinglerealArray1M.AssertModel(models[2],_testData[18], false);SinglerealArray1M.AssertModel(models[3],_testData[19], false);SinglerealArray1M.AssertModel(models[4],_testData[20], false);SinglerealArray1M.AssertModel(models[5],_testData[21], false);SinglerealArray1M.AssertModel(models[6],_testData[22], false);SinglerealArray1M.AssertModel(models[7],_testData[23], false);SinglerealArray1M.AssertModel(models[8],_testData[24], false);SinglerealArray1M.AssertModel(models[9],_testData[25], false);SinglerealArray1M.AssertModel(models[10],_testData[26], false);SinglerealArray1M.AssertModel(models[11],_testData[27], false);SinglerealArray1M.AssertModel(models[12],_testData[28], false);SinglerealArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
SinglerealArray1M.AssertModel(models[0],_testData[6], false);SinglerealArray1M.AssertModel(models[1],_testData[7], false);SinglerealArray1M.AssertModel(models[2],_testData[8], false);SinglerealArray1M.AssertModel(models[3],_testData[9], false);SinglerealArray1M.AssertModel(models[4],_testData[10], false);SinglerealArray1M.AssertModel(models[5],_testData[11], false);SinglerealArray1M.AssertModel(models[6],_testData[12], false);SinglerealArray1M.AssertModel(models[7],_testData[13], false);SinglerealArray1M.AssertModel(models[8],_testData[14], false);SinglerealArray1M.AssertModel(models[9],_testData[15], false);SinglerealArray1M.AssertModel(models[10],_testData[16], false);SinglerealArray1M.AssertModel(models[11],_testData[17], false);SinglerealArray1M.AssertModel(models[12],_testData[18], false);SinglerealArray1M.AssertModel(models[13],_testData[19], false);SinglerealArray1M.AssertModel(models[14],_testData[20], false);SinglerealArray1M.AssertModel(models[15],_testData[21], false);SinglerealArray1M.AssertModel(models[16],_testData[22], false);SinglerealArray1M.AssertModel(models[17],_testData[23], false);SinglerealArray1M.AssertModel(models[18],_testData[24], false);SinglerealArray1M.AssertModel(models[19],_testData[25], false);SinglerealArray1M.AssertModel(models[20],_testData[26], false);SinglerealArray1M.AssertModel(models[21],_testData[27], false);SinglerealArray1M.AssertModel(models[22],_testData[28], false);SinglerealArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
            asPartInterface: typeof(ISingleArrayrealArray)),
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
FROM public.singlerealarray1m m
LEFT JOIN public.singlerealarray1mi mi ON mi.id = m.singlerealarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray1m m
LEFT JOIN public.singlerealarray1mi mi ON mi.id = m.singlerealarray1mi_id
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
FROM public.singlerealarray1m m
LEFT JOIN public.singlerealarray1mi mi ON mi.id = m.singlerealarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 5, query1, 55, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatSinglerealArray1M.AssertModel(models[0],_testData[2], false);FlatSinglerealArray1M.AssertModel(models[1],_testData[3], false);FlatSinglerealArray1M.AssertModel(models[2],_testData[4], false);FlatSinglerealArray1M.AssertModel(models[3],_testData[5], false);FlatSinglerealArray1M.AssertModel(models[4],_testData[6], false);FlatSinglerealArray1M.AssertModel(models[5],_testData[7], false);FlatSinglerealArray1M.AssertModel(models[6],_testData[8], false);FlatSinglerealArray1M.AssertModel(models[7],_testData[9], false);FlatSinglerealArray1M.AssertModel(models[8],_testData[10], false);FlatSinglerealArray1M.AssertModel(models[9],_testData[11], false);FlatSinglerealArray1M.AssertModel(models[10],_testData[12], false);FlatSinglerealArray1M.AssertModel(models[11],_testData[13], false);FlatSinglerealArray1M.AssertModel(models[12],_testData[14], false);FlatSinglerealArray1M.AssertModel(models[13],_testData[15], false);FlatSinglerealArray1M.AssertModel(models[14],_testData[16], false);FlatSinglerealArray1M.AssertModel(models[15],_testData[17], false);FlatSinglerealArray1M.AssertModel(models[16],_testData[18], false);FlatSinglerealArray1M.AssertModel(models[17],_testData[19], false);FlatSinglerealArray1M.AssertModel(models[18],_testData[20], false);FlatSinglerealArray1M.AssertModel(models[19],_testData[21], false);FlatSinglerealArray1M.AssertModel(models[20],_testData[22], false);FlatSinglerealArray1M.AssertModel(models[21],_testData[23], false);FlatSinglerealArray1M.AssertModel(models[22],_testData[24], false);FlatSinglerealArray1M.AssertModel(models[23],_testData[25], false);FlatSinglerealArray1M.AssertModel(models[24],_testData[26], false);FlatSinglerealArray1M.AssertModel(models[25],_testData[27], false);FlatSinglerealArray1M.AssertModel(models[26],_testData[28], false);FlatSinglerealArray1M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatSinglerealArray1M.AssertModel(models[0],_testData[12], false);FlatSinglerealArray1M.AssertModel(models[1],_testData[13], false);FlatSinglerealArray1M.AssertModel(models[2],_testData[14], false);FlatSinglerealArray1M.AssertModel(models[3],_testData[15], false);FlatSinglerealArray1M.AssertModel(models[4],_testData[16], false);FlatSinglerealArray1M.AssertModel(models[5],_testData[17], false);FlatSinglerealArray1M.AssertModel(models[6],_testData[18], false);FlatSinglerealArray1M.AssertModel(models[7],_testData[19], false);FlatSinglerealArray1M.AssertModel(models[8],_testData[20], false);FlatSinglerealArray1M.AssertModel(models[9],_testData[21], false);FlatSinglerealArray1M.AssertModel(models[10],_testData[22], false);FlatSinglerealArray1M.AssertModel(models[11],_testData[23], false);FlatSinglerealArray1M.AssertModel(models[12],_testData[24], false);FlatSinglerealArray1M.AssertModel(models[13],_testData[25], false);FlatSinglerealArray1M.AssertModel(models[14],_testData[26], false);FlatSinglerealArray1M.AssertModel(models[15],_testData[27], false);FlatSinglerealArray1M.AssertModel(models[16],_testData[28], false);FlatSinglerealArray1M.AssertModel(models[17],_testData[29], false);
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
FROM public.singlerealarray1m m
LEFT JOIN public.singlerealarray1mi mi ON mi.id = m.singlerealarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray1m m
LEFT JOIN public.singlerealarray1mi mi ON mi.id = m.singlerealarray1mi_id
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
FROM public.singlerealarray1m m
LEFT JOIN public.singlerealarray1mi mi ON mi.id = m.singlerealarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelBatch(connection, 111, query1, 98, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatSinglerealArray1M.AssertModel(models[0],_testData[23], false);FlatSinglerealArray1M.AssertModel(models[1],_testData[24], false);FlatSinglerealArray1M.AssertModel(models[2],_testData[25], false);FlatSinglerealArray1M.AssertModel(models[3],_testData[26], false);FlatSinglerealArray1M.AssertModel(models[4],_testData[27], false);FlatSinglerealArray1M.AssertModel(models[5],_testData[28], false);FlatSinglerealArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatSinglerealArray1M.AssertModel(models[0],_testData[20], false);FlatSinglerealArray1M.AssertModel(models[1],_testData[21], false);FlatSinglerealArray1M.AssertModel(models[2],_testData[22], false);FlatSinglerealArray1M.AssertModel(models[3],_testData[23], false);FlatSinglerealArray1M.AssertModel(models[4],_testData[24], false);FlatSinglerealArray1M.AssertModel(models[5],_testData[25], false);FlatSinglerealArray1M.AssertModel(models[6],_testData[26], false);FlatSinglerealArray1M.AssertModel(models[7],_testData[27], false);FlatSinglerealArray1M.AssertModel(models[8],_testData[28], false);FlatSinglerealArray1M.AssertModel(models[9],_testData[29], false);
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
FROM public.singlerealarray1m m
LEFT JOIN public.singlerealarray1mi mi ON mi.id = m.singlerealarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(SinglerealArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
            asPartInterface: typeof(ISingleArrayrealArray)),
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
                var models = await ((ISingleArrayrealArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSelectModelBatchAsync(connection, 84, 5))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
SinglerealArray1M.AssertModel(models[0],_testData[17], false);SinglerealArray1M.AssertModel(models[1],_testData[18], false);SinglerealArray1M.AssertModel(models[2],_testData[19], false);SinglerealArray1M.AssertModel(models[3],_testData[20], false);SinglerealArray1M.AssertModel(models[4],_testData[21], false);SinglerealArray1M.AssertModel(models[5],_testData[22], false);SinglerealArray1M.AssertModel(models[6],_testData[23], false);SinglerealArray1M.AssertModel(models[7],_testData[24], false);SinglerealArray1M.AssertModel(models[8],_testData[25], false);SinglerealArray1M.AssertModel(models[9],_testData[26], false);SinglerealArray1M.AssertModel(models[10],_testData[27], false);SinglerealArray1M.AssertModel(models[11],_testData[28], false);SinglerealArray1M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
SinglerealArray1M.AssertModel(models[0],_testData[2], false);SinglerealArray1M.AssertModel(models[1],_testData[3], false);SinglerealArray1M.AssertModel(models[2],_testData[4], false);SinglerealArray1M.AssertModel(models[3],_testData[5], false);SinglerealArray1M.AssertModel(models[4],_testData[6], false);SinglerealArray1M.AssertModel(models[5],_testData[7], false);SinglerealArray1M.AssertModel(models[6],_testData[8], false);SinglerealArray1M.AssertModel(models[7],_testData[9], false);SinglerealArray1M.AssertModel(models[8],_testData[10], false);SinglerealArray1M.AssertModel(models[9],_testData[11], false);SinglerealArray1M.AssertModel(models[10],_testData[12], false);SinglerealArray1M.AssertModel(models[11],_testData[13], false);SinglerealArray1M.AssertModel(models[12],_testData[14], false);SinglerealArray1M.AssertModel(models[13],_testData[15], false);SinglerealArray1M.AssertModel(models[14],_testData[16], false);SinglerealArray1M.AssertModel(models[15],_testData[17], false);SinglerealArray1M.AssertModel(models[16],_testData[18], false);SinglerealArray1M.AssertModel(models[17],_testData[19], false);SinglerealArray1M.AssertModel(models[18],_testData[20], false);SinglerealArray1M.AssertModel(models[19],_testData[21], false);SinglerealArray1M.AssertModel(models[20],_testData[22], false);SinglerealArray1M.AssertModel(models[21],_testData[23], false);SinglerealArray1M.AssertModel(models[22],_testData[24], false);SinglerealArray1M.AssertModel(models[23],_testData[25], false);SinglerealArray1M.AssertModel(models[24],_testData[26], false);SinglerealArray1M.AssertModel(models[25],_testData[27], false);SinglerealArray1M.AssertModel(models[26],_testData[28], false);SinglerealArray1M.AssertModel(models[27],_testData[29], false);
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
                var models =  ((ISingleArrayrealArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSelectModelBatch(connection, 12, 5))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
SinglerealArray1M.AssertModel(models[0],_testData[3], false);SinglerealArray1M.AssertModel(models[1],_testData[4], false);SinglerealArray1M.AssertModel(models[2],_testData[5], false);SinglerealArray1M.AssertModel(models[3],_testData[6], false);SinglerealArray1M.AssertModel(models[4],_testData[7], false);SinglerealArray1M.AssertModel(models[5],_testData[8], false);SinglerealArray1M.AssertModel(models[6],_testData[9], false);SinglerealArray1M.AssertModel(models[7],_testData[10], false);SinglerealArray1M.AssertModel(models[8],_testData[11], false);SinglerealArray1M.AssertModel(models[9],_testData[12], false);SinglerealArray1M.AssertModel(models[10],_testData[13], false);SinglerealArray1M.AssertModel(models[11],_testData[14], false);SinglerealArray1M.AssertModel(models[12],_testData[15], false);SinglerealArray1M.AssertModel(models[13],_testData[16], false);SinglerealArray1M.AssertModel(models[14],_testData[17], false);SinglerealArray1M.AssertModel(models[15],_testData[18], false);SinglerealArray1M.AssertModel(models[16],_testData[19], false);SinglerealArray1M.AssertModel(models[17],_testData[20], false);SinglerealArray1M.AssertModel(models[18],_testData[21], false);SinglerealArray1M.AssertModel(models[19],_testData[22], false);SinglerealArray1M.AssertModel(models[20],_testData[23], false);SinglerealArray1M.AssertModel(models[21],_testData[24], false);SinglerealArray1M.AssertModel(models[22],_testData[25], false);SinglerealArray1M.AssertModel(models[23],_testData[26], false);SinglerealArray1M.AssertModel(models[24],_testData[27], false);SinglerealArray1M.AssertModel(models[25],_testData[28], false);SinglerealArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
SinglerealArray1M.AssertModel(models[0],_testData[2], false);SinglerealArray1M.AssertModel(models[1],_testData[3], false);SinglerealArray1M.AssertModel(models[2],_testData[4], false);SinglerealArray1M.AssertModel(models[3],_testData[5], false);SinglerealArray1M.AssertModel(models[4],_testData[6], false);SinglerealArray1M.AssertModel(models[5],_testData[7], false);SinglerealArray1M.AssertModel(models[6],_testData[8], false);SinglerealArray1M.AssertModel(models[7],_testData[9], false);SinglerealArray1M.AssertModel(models[8],_testData[10], false);SinglerealArray1M.AssertModel(models[9],_testData[11], false);SinglerealArray1M.AssertModel(models[10],_testData[12], false);SinglerealArray1M.AssertModel(models[11],_testData[13], false);SinglerealArray1M.AssertModel(models[12],_testData[14], false);SinglerealArray1M.AssertModel(models[13],_testData[15], false);SinglerealArray1M.AssertModel(models[14],_testData[16], false);SinglerealArray1M.AssertModel(models[15],_testData[17], false);SinglerealArray1M.AssertModel(models[16],_testData[18], false);SinglerealArray1M.AssertModel(models[17],_testData[19], false);SinglerealArray1M.AssertModel(models[18],_testData[20], false);SinglerealArray1M.AssertModel(models[19],_testData[21], false);SinglerealArray1M.AssertModel(models[20],_testData[22], false);SinglerealArray1M.AssertModel(models[21],_testData[23], false);SinglerealArray1M.AssertModel(models[22],_testData[24], false);SinglerealArray1M.AssertModel(models[23],_testData[25], false);SinglerealArray1M.AssertModel(models[24],_testData[26], false);SinglerealArray1M.AssertModel(models[25],_testData[27], false);SinglerealArray1M.AssertModel(models[26],_testData[28], false);SinglerealArray1M.AssertModel(models[27],_testData[29], false);
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
                await using var cmd = await ((ISingleArrayrealArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ISingleArrayrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 12);
                var models = await ((ISingleArrayrealArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
SinglerealArray1M.AssertModel(models[0],_testData[3], false);SinglerealArray1M.AssertModel(models[1],_testData[4], false);SinglerealArray1M.AssertModel(models[2],_testData[5], false);SinglerealArray1M.AssertModel(models[3],_testData[6], false);SinglerealArray1M.AssertModel(models[4],_testData[7], false);SinglerealArray1M.AssertModel(models[5],_testData[8], false);SinglerealArray1M.AssertModel(models[6],_testData[9], false);SinglerealArray1M.AssertModel(models[7],_testData[10], false);SinglerealArray1M.AssertModel(models[8],_testData[11], false);SinglerealArray1M.AssertModel(models[9],_testData[12], false);SinglerealArray1M.AssertModel(models[10],_testData[13], false);SinglerealArray1M.AssertModel(models[11],_testData[14], false);SinglerealArray1M.AssertModel(models[12],_testData[15], false);SinglerealArray1M.AssertModel(models[13],_testData[16], false);SinglerealArray1M.AssertModel(models[14],_testData[17], false);SinglerealArray1M.AssertModel(models[15],_testData[18], false);SinglerealArray1M.AssertModel(models[16],_testData[19], false);SinglerealArray1M.AssertModel(models[17],_testData[20], false);SinglerealArray1M.AssertModel(models[18],_testData[21], false);SinglerealArray1M.AssertModel(models[19],_testData[22], false);SinglerealArray1M.AssertModel(models[20],_testData[23], false);SinglerealArray1M.AssertModel(models[21],_testData[24], false);SinglerealArray1M.AssertModel(models[22],_testData[25], false);SinglerealArray1M.AssertModel(models[23],_testData[26], false);SinglerealArray1M.AssertModel(models[24],_testData[27], false);SinglerealArray1M.AssertModel(models[25],_testData[28], false);SinglerealArray1M.AssertModel(models[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleArrayrealArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleArrayrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 41);
                var models =  ((ISingleArrayrealArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
SinglerealArray1M.AssertModel(models[0],_testData[10], false);SinglerealArray1M.AssertModel(models[1],_testData[11], false);SinglerealArray1M.AssertModel(models[2],_testData[12], false);SinglerealArray1M.AssertModel(models[3],_testData[13], false);SinglerealArray1M.AssertModel(models[4],_testData[14], false);SinglerealArray1M.AssertModel(models[5],_testData[15], false);SinglerealArray1M.AssertModel(models[6],_testData[16], false);SinglerealArray1M.AssertModel(models[7],_testData[17], false);SinglerealArray1M.AssertModel(models[8],_testData[18], false);SinglerealArray1M.AssertModel(models[9],_testData[19], false);SinglerealArray1M.AssertModel(models[10],_testData[20], false);SinglerealArray1M.AssertModel(models[11],_testData[21], false);SinglerealArray1M.AssertModel(models[12],_testData[22], false);SinglerealArray1M.AssertModel(models[13],_testData[23], false);SinglerealArray1M.AssertModel(models[14],_testData[24], false);SinglerealArray1M.AssertModel(models[15],_testData[25], false);SinglerealArray1M.AssertModel(models[16],_testData[26], false);SinglerealArray1M.AssertModel(models[17],_testData[27], false);SinglerealArray1M.AssertModel(models[18],_testData[28], false);SinglerealArray1M.AssertModel(models[19],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlerealarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
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
FROM public.binary_singlerealarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<SinglerealArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((ISingleArrayrealArray)this).ImportModelInner(connection, importCollection);
                var models = ((ISingleArrayrealArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(actual, expect, false);
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
                await ((ISingleArrayrealArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((ISingleArrayrealArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlerealarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
singlerealarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(SinglerealArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
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
FROM public.binary_singlerealarray1m m
LEFT JOIN public.binary_singlerealarray1mi mi ON mi.id = m.singlerealarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(SinglerealArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<SinglerealArray1M>(15);

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
                ((ISingleArrayrealArray)this).ImportModel(connection, importCollection);
                var models = ((ISingleArrayrealArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                SinglerealArray1M.AssertModel(models[0],_testData[0], false);
                SinglerealArray1M.AssertModel(models[1],_testData[1], false);
                SinglerealArray1M.AssertModel(models[2],_testData[2], false);
                SinglerealArray1M.AssertModel(models[3],_testData[3], false);
                SinglerealArray1M.AssertModel(models[4],_testData[4], false);
                SinglerealArray1M.AssertModel(models[5],_testData[5], false);
                SinglerealArray1M.AssertModel(models[6],_testData[6], false);
                SinglerealArray1M.AssertModel(models[7],_testData[7], false);
                SinglerealArray1M.AssertModel(models[8],_testData[8], false);
                SinglerealArray1M.AssertModel(models[9],_testData[9], false);
                SinglerealArray1M.AssertModel(models[10],_testData[10], false);
                SinglerealArray1M.AssertModel(models[11],_testData[11], false);
                SinglerealArray1M.AssertModel(models[12],_testData[12], false);
                SinglerealArray1M.AssertModel(models[13],_testData[13], false);
                SinglerealArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((ISingleArrayrealArray)this).ImportModelAsync(connection, importCollection);
                models = await ((ISingleArrayrealArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                SinglerealArray1M.AssertModel(models[0],_testData[0], false);
                SinglerealArray1M.AssertModel(models[1],_testData[1], false);
                SinglerealArray1M.AssertModel(models[2],_testData[2], false);
                SinglerealArray1M.AssertModel(models[3],_testData[3], false);
                SinglerealArray1M.AssertModel(models[4],_testData[4], false);
                SinglerealArray1M.AssertModel(models[5],_testData[5], false);
                SinglerealArray1M.AssertModel(models[6],_testData[6], false);
                SinglerealArray1M.AssertModel(models[7],_testData[7], false);
                SinglerealArray1M.AssertModel(models[8],_testData[8], false);
                SinglerealArray1M.AssertModel(models[9],_testData[9], false);
                SinglerealArray1M.AssertModel(models[10],_testData[10], false);
                SinglerealArray1M.AssertModel(models[11],_testData[11], false);
                SinglerealArray1M.AssertModel(models[12],_testData[12], false);
                SinglerealArray1M.AssertModel(models[13],_testData[13], false);
                SinglerealArray1M.AssertModel(models[14],_testData[14], false);
                SinglerealArray1M.AssertModel(models[15],_testData[15], false);
                SinglerealArray1M.AssertModel(models[16],_testData[16], false);
                SinglerealArray1M.AssertModel(models[17],_testData[17], false);
                SinglerealArray1M.AssertModel(models[18],_testData[18], false);
                SinglerealArray1M.AssertModel(models[19],_testData[19], false);
                SinglerealArray1M.AssertModel(models[20],_testData[20], false);
                SinglerealArray1M.AssertModel(models[21],_testData[21], false);
                SinglerealArray1M.AssertModel(models[22],_testData[22], false);
                SinglerealArray1M.AssertModel(models[23],_testData[23], false);
                SinglerealArray1M.AssertModel(models[24],_testData[24], false);
                SinglerealArray1M.AssertModel(models[25],_testData[25], false);
                SinglerealArray1M.AssertModel(models[26],_testData[26], false);
                SinglerealArray1M.AssertModel(models[27],_testData[27], false);
                SinglerealArray1M.AssertModel(models[28],_testData[28], false);
                SinglerealArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    singlerealarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(SinglerealArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ISingleArrayrealArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SinglerealArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleArrayrealArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SinglerealArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ISingleArrayrealArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleArrayrealArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

