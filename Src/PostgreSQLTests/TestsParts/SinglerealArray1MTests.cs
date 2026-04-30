

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
    Id = 9,
    Value = 
new System.Single[3]
{
0.65771246f,
0.006426871f,
0.79156f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.6020355f,
0.9483327f,
0.3340153f,
0.9909997f,
},
},
            new SinglerealArray1M
{
    Id = 17,
    Value = 
new System.Single[4]
{
0.16568881f,
0.41054112f,
0.252128f,
0.82544756f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 3,
    Value = 
new System.Single[3]
{
0.84355295f,
0.6359344f,
0.21215904f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 20,
    Value = 
new System.Single[4]
{
0.4703465f,
0.21525723f,
0.6973076f,
0.9048254f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 28,
    Value = 
new System.Single[3]
{
0.24466187f,
0.5815197f,
0.5250879f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 9,
    Value = 
new System.Single[3]
{
0.10842097f,
0.6742391f,
0.21930903f,
},
    NullableValue = 
new System.Single[4]
{
0.44447458f,
0.46708775f,
0.659691f,
0.2544492f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 34,
    Value = 
new System.Single[4]
{
0.038064837f,
0.94381905f,
0.8826264f,
0.5158131f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 36,
    Value = 
new System.Single[4]
{
0.30037737f,
0.79994404f,
0.6166219f,
0.80859977f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 11,
    Value = 
new System.Single[3]
{
0.842603f,
0.46348655f,
0.62295777f,
},
    NullableValue = 
new System.Single[4]
{
0.77173734f,
0.8151581f,
0.70037866f,
0.3302883f,
},
},
    NullableValue = 
new System.Single[3]
{
0.34139556f,
0.6640172f,
0.12993336f,
},
},
            new SinglerealArray1M
{
    Id = 38,
    Value = 
new System.Single[3]
{
0.3394112f,
0.6126482f,
0.94258374f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 39,
    Value = 
new System.Single[3]
{
0.1765477f,
0.7037601f,
0.9812626f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 19,
    Value = 
new System.Single[4]
{
0.773287f,
0.2505054f,
0.9430637f,
0.15726817f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.7020155f,
0.6611786f,
0.79219097f,
0.9203756f,
},
},
            new SinglerealArray1M
{
    Id = 45,
    Value = 
new System.Single[3]
{
0.35907412f,
0.6002122f,
0.23616475f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 50,
    Value = 
new System.Single[3]
{
0.772803f,
0.71029866f,
0.2781387f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 25,
    Value = 
new System.Single[3]
{
0.89833045f,
0.7740931f,
0.7893265f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 58,
    Value = 
new System.Single[3]
{
0.99071217f,
0.53352606f,
0.1089012f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 65,
    Value = 
new System.Single[3]
{
0.722054f,
0.8816848f,
0.27885443f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 32,
    Value = 
new System.Single[4]
{
0.47808206f,
0.07217896f,
0.4892829f,
0.53294283f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[3]
{
0.59690595f,
0.5252275f,
0.009189427f,
},
},
            new SinglerealArray1M
{
    Id = 72,
    Value = 
new System.Single[3]
{
0.027198493f,
0.7740073f,
0.47641647f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.013354123f,
0.09858894f,
0.023450017f,
},
},
            new SinglerealArray1M
{
    Id = 80,
    Value = 
new System.Single[3]
{
0.8070736f,
0.29140687f,
0.24026024f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 38,
    Value = 
new System.Single[3]
{
0.45346653f,
0.66569704f,
0.19952846f,
},
    NullableValue = 
new System.Single[4]
{
0.40884894f,
0.22197503f,
0.828555f,
0.6855343f,
},
},
    NullableValue = 
new System.Single[3]
{
0.9532789f,
0.24354112f,
0.15123427f,
},
},
            new SinglerealArray1M
{
    Id = 85,
    Value = 
new System.Single[4]
{
0.97039914f,
0.99775034f,
0.038746417f,
0.92888397f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.9258758f,
0.5412417f,
0.62310135f,
},
},
            new SinglerealArray1M
{
    Id = 93,
    Value = 
new System.Single[3]
{
0.48345125f,
0.54591435f,
0.39292562f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 42,
    Value = 
new System.Single[4]
{
0.8532939f,
0.41674256f,
0.53596234f,
0.92642903f,
},
    NullableValue = 
new System.Single[4]
{
0.30637932f,
0.52873516f,
0.98118776f,
0.15516818f,
},
},
    NullableValue = 
new System.Single[4]
{
0.39909428f,
0.76530653f,
0.24068165f,
0.27351588f,
},
},
            new SinglerealArray1M
{
    Id = 96,
    Value = 
new System.Single[4]
{
0.04085797f,
0.21568567f,
0.36462444f,
0.67387044f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 97,
    Value = 
new System.Single[4]
{
0.9164519f,
0.7761236f,
0.24119455f,
0.89693797f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 51,
    Value = 
new System.Single[3]
{
0.8178629f,
0.89019436f,
0.09161234f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 102,
    Value = 
new System.Single[4]
{
0.2023583f,
0.74296f,
0.35771513f,
0.3408931f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.058854043f,
0.7855398f,
0.32206577f,
},
},
            new SinglerealArray1M
{
    Id = 103,
    Value = 
new System.Single[4]
{
0.34878606f,
0.20385587f,
0.9815698f,
0.12272f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 54,
    Value = 
new System.Single[4]
{
0.6773452f,
0.57777697f,
0.2538262f,
0.376561f,
},
    NullableValue = 
new System.Single[3]
{
0.0909912f,
0.52128386f,
0.74276835f,
},
},
    NullableValue = 
new System.Single[4]
{
0.8394259f,
0.72552633f,
0.2714609f,
0.12020129f,
},
},
            new SinglerealArray1M
{
    Id = 110,
    Value = 
new System.Single[3]
{
0.047144234f,
0.35423613f,
0.97417116f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 116,
    Value = 
new System.Single[4]
{
0.44415164f,
0.17256278f,
0.67960167f,
0.45663768f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 59,
    Value = 
new System.Single[4]
{
0.29297543f,
0.69132483f,
0.6364288f,
0.6839732f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[3]
{
0.7684694f,
0.18600428f,
0.9745934f,
},
},
            new SinglerealArray1M
{
    Id = 118,
    Value = 
new System.Single[4]
{
0.78426653f,
0.09871441f,
0.48508495f,
0.23948073f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 121,
    Value = 
new System.Single[4]
{
0.7754319f,
0.6392049f,
0.42400742f,
0.21088254f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 65,
    Value = 
new System.Single[3]
{
0.80514073f,
0.039250016f,
0.9557389f,
},
    NullableValue = 
new System.Single[3]
{
0.029326797f,
0.8710409f,
0.47609693f,
},
},
    NullableValue = 
new System.Single[4]
{
0.4504285f,
0.48594075f,
0.15627569f,
0.64980924f,
},
},
            new SinglerealArray1M
{
    Id = 122,
    Value = 
new System.Single[3]
{
0.447237f,
0.03745979f,
0.62129813f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 125,
    Value = 
new System.Single[4]
{
0.15428448f,
0.15291762f,
0.980686f,
0.33139384f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 66,
    Value = 
new System.Single[3]
{
0.25220865f,
0.2349996f,
0.32213348f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.2835338f,
0.89497316f,
0.5175174f,
0.65083134f,
},
},
            new SinglerealArray1M
{
    Id = 126,
    Value = 
new System.Single[3]
{
0.21506345f,
0.71962905f,
0.95399857f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 128,
    Value = 
new System.Single[4]
{
0.5466633f,
0.3770883f,
0.47780186f,
0.7007955f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 70,
    Value = 
new System.Single[4]
{
0.83498377f,
0.11174166f,
0.044804513f,
0.37917107f,
},
    NullableValue = 
new System.Single[4]
{
0.68482083f,
0.90369487f,
0.7001077f,
0.5697756f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 129,
    Value = 
new System.Single[4]
{
0.70746654f,
0.06648296f,
0.8719483f,
0.38196707f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.57339764f,
0.5580056f,
0.053765535f,
0.35275024f,
},
},
            new SinglerealArray1M
{
    Id = 136,
    Value = 
new System.Single[4]
{
0.69636184f,
0.21989584f,
0.6789177f,
0.77332425f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 71,
    Value = 
new System.Single[3]
{
0.42163604f,
0.92679834f,
0.34285814f,
},
    NullableValue = 
new System.Single[3]
{
0.8696815f,
0.38573855f,
0.8409933f,
},
},
    NullableValue = null,
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
new System.Single[3]
{
0.34139556f,
0.6640172f,
0.12993336f,
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
0.7020155f,
0.6611786f,
0.79219097f,
0.9203756f,
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
                nullable = await ((ISingleArrayrealArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[3]
{
0.59690595f,
0.5252275f,
0.009189427f,
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
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealArray1M), typeof(FlatSinglerealArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
FROM public.singlerealarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSinglerealArray1M>();
                var models2 = new List<FlatSinglerealArray1M>();
                await ((ISingleArrayrealArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSinglerealArray1M>();
                var models2 = new List<FlatSinglerealArray1M>();
                ((ISingleArrayrealArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealArray1M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ISingleArrayrealArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
            overrideAliasPrefixs: null,
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
                var models = ((ISingleArrayrealArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealArray1M), typeof(FlatSinglerealArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
FROM public.singlerealarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealArray1M>();
                var models2 = new List<FlatSinglerealArray1M>();
                await ((ISingleArrayrealArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealArray1M>();
                var models2 = new List<FlatSinglerealArray1M>();
                ((ISingleArrayrealArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealArray1M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ISingleArrayrealArray)this).DynQuerySelectModel(connection,  query, 0);
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
            overrideAliasPrefixs: null,
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
                var models = ((ISingleArrayrealArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealArray1M), typeof(FlatSinglerealArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
            asPartInterface: typeof(ISingleArrayrealArray)),
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglerealArray1M>();
                var models2 = new List<FlatSinglerealArray1M>();
                await((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var firstItems2 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                var secondItems2 = new List<FlatSinglerealArray1M>();
                await ((ISingleArrayrealArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
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
FROM public.singlerealarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var firstItems2 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                await ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[29], false);
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglerealArray1M>();
                var models2 = new List<FlatSinglerealArray1M>();
                ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var firstItems2 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                var secondItems2 = new List<FlatSinglerealArray1M>();
                 ((ISingleArrayrealArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 93;
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
FROM public.singlerealarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var firstItems2 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                 ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealArray1M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 38;
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
FROM public.singlerealarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[18],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[19],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[20],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[21],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[1], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[2], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[18],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[19],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[20],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[21],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[22],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[23],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[24],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[25],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[26],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[27],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[28],_testData[29], false);
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
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                var secondItems2 = new List<FlatSinglerealArray1M>();
                await ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[18],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[19],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[20],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[21],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[22],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[23],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[24],_testData[29], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                var secondItems2 = new List<FlatSinglerealArray1M>();
                 ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[26],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((ISingleArrayrealArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        SinglerealArray1M.AssertModel(models[0],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        SinglerealArray1M.AssertModel(models[0],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[29], false);
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
                var models = ((ISingleArrayrealArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        SinglerealArray1M.AssertModel(models[0],_testData[5], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[6], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[7], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[8], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[9], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[10], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[11], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[12], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[13], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[14], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[17],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[18],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[19],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[20],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[21],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[22],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[23],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        SinglerealArray1M.AssertModel(models[0],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealArray1M), typeof(FlatSinglerealArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
            asPartInterface: typeof(ISingleArrayrealArray)),
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealArray1M>();
                var models2 = new List<FlatSinglerealArray1M>();
                await((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var firstItems2 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                var secondItems2 = new List<FlatSinglerealArray1M>();
                await ((ISingleArrayrealArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 121, query1, 121, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[29], false);
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
FROM public.singlerealarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var firstItems2 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                await ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 17, query1, 17, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[27],_testData[29], false);
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealArray1M>();
                var models2 = new List<FlatSinglerealArray1M>();
                ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var firstItems2 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                var secondItems2 = new List<FlatSinglerealArray1M>();
                 ((ISingleArrayrealArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 45, query1, 93, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[29], false);
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
FROM public.singlerealarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var firstItems2 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                 ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 9, query1, 39, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealArray1M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 96, query1, 93, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[29], false);
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                var secondItems2 = new List<FlatSinglerealArray1M>();
                await ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 58, query1, 128, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 122, query1, 17, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[2], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[18],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[19],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[20],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[21],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[22],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[23],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[24],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[25],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[26],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[27],_testData[29], false);
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
FROM public.singlerealarray1m m
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
FROM public.singlerealarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray1M>();
                var secondItems1 = new List<FlatSinglerealArray1M>();
                var secondItems2 = new List<FlatSinglerealArray1M>();
                 ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelBatch(connection, 20, query1, 103, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((ISingleArrayrealArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTSelectModelBatchAsync(connection, 58, 102))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        SinglerealArray1M.AssertModel(models[0],_testData[11], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[12], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[13], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[14], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[17],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        SinglerealArray1M.AssertModel(models[0],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[29], false);
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
                var models = ((ISingleArrayrealArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTSelectModelBatch(connection, 96, 85))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        SinglerealArray1M.AssertModel(models[0],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        SinglerealArray1M.AssertModel(models[0],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[29], false);
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
                ((ISingleArrayrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 80);
                var models = await ((ISingleArrayrealArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
SinglerealArray1M.AssertModel(models[0],_testData[14], false);SinglerealArray1M.AssertModel(models[1],_testData[15], false);SinglerealArray1M.AssertModel(models[2],_testData[16], false);SinglerealArray1M.AssertModel(models[3],_testData[17], false);SinglerealArray1M.AssertModel(models[4],_testData[18], false);SinglerealArray1M.AssertModel(models[5],_testData[19], false);SinglerealArray1M.AssertModel(models[6],_testData[20], false);SinglerealArray1M.AssertModel(models[7],_testData[21], false);SinglerealArray1M.AssertModel(models[8],_testData[22], false);SinglerealArray1M.AssertModel(models[9],_testData[23], false);SinglerealArray1M.AssertModel(models[10],_testData[24], false);SinglerealArray1M.AssertModel(models[11],_testData[25], false);SinglerealArray1M.AssertModel(models[12],_testData[26], false);SinglerealArray1M.AssertModel(models[13],_testData[27], false);SinglerealArray1M.AssertModel(models[14],_testData[28], false);SinglerealArray1M.AssertModel(models[15],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleArrayrealArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleArrayrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 122);
                var models =  ((ISingleArrayrealArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
SinglerealArray1M.AssertModel(models[0],_testData[25], false);SinglerealArray1M.AssertModel(models[1],_testData[26], false);SinglerealArray1M.AssertModel(models[2],_testData[27], false);SinglerealArray1M.AssertModel(models[3],_testData[28], false);SinglerealArray1M.AssertModel(models[4],_testData[29], false);
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
FROM public.binary_singlerealarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(SinglerealArray1MIWA),
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealArray1MIWA>(2);
                for (int i = 0; i < 6; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISingleArrayrealArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_singlerealarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISingleArrayrealArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealArray1MIWA>(2);
                for (int i = 4; i < 10; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISingleArrayrealArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_singlerealarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISingleArrayrealArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(actual, expect, false);
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
            queryMapType: typeof(SinglerealArray1MI),
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

        [Test, Order(0)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealArray1MI>(2);
                for (int i = 8; i < 14; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ISingleArrayrealArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ISingleArrayrealArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealArray1MI>(2);
                for (int i = 12; i < 18; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ISingleArrayrealArray)this).ImportModelInner(connection, importCollection);
                var models = ((ISingleArrayrealArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(SinglerealArray1M),
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

