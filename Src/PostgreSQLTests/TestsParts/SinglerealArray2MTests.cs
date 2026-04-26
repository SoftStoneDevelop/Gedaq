

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
    internal partial interface ISingleListrealArray
    {
    }
    
    internal partial class SingleListrealArray : ISingleListrealArray
    {


#region TestData

        private readonly SinglerealArray2M[] _testData = new SinglerealArray2M[]
        {
            new SinglerealArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.09375602f,

0.54385763f,

0.16098112f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.48577207f,

0.5299612f,

0.9905805f,

},
},
            new SinglerealArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8888459f,

0.06201774f,

0.62207156f,

0.91328746f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.94586945f,

0.25400984f,

0.36358547f,

0.22477841f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.21533787f,

0.15237027f,

0.22685444f,

0.20210284f,

},
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.55634236f,

0.22829765f,

0.6288643f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.40629423f,

0.13740444f,

0.27447826f,

0.1377073f,

},
},
            new SinglerealArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.25431645f,

0.22237802f,

0.18475616f,

0.39076346f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.0358845f,

0.5263097f,

0.98848885f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.48817074f,

0.34876555f,

0.8378263f,

0.68452203f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.51043767f,

0.501687f,

0.90409595f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8402178f,

0.8474789f,

0.19948322f,

0.35258985f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.46398383f,

0.40555614f,

0.85967296f,

0.19584048f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.15925735f,

0.9586332f,

0.67182356f,

0.3316071f,

},
},
            new SinglerealArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.9739456f,

0.30587482f,

0.5029822f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.48065555f,

0.551545f,

0.31858677f,

0.3367374f,

},
},
            new SinglerealArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.18769193f,

0.26338822f,

0.29332f,

0.751308f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.43955314f,

0.9596628f,

0.79386485f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7975199f,

0.043884695f,

0.39462394f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.87567484f,

0.7960737f,

0.5953349f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8872675f,

0.6140386f,

0.7575999f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.59297025f,

0.5716231f,

0.06874174f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.15716499f,

0.39181316f,

0.005533159f,

},
},
            new SinglerealArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8308109f,

0.26852477f,

0.7588613f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.1702525f,

0.6804956f,

0.20438468f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8992983f,

0.3790478f,

0.32572109f,

0.3968712f,

},
},
            new SinglerealArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.109202325f,

0.6112625f,

0.09018499f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.19409889f,

0.9190323f,

0.13039112f,

},
},
            new SinglerealArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.07002312f,

0.018585324f,

0.013734162f,

0.31904697f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.32133013f,

0.40283376f,

0.8479836f,

0.33520222f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3772552f,

0.44089502f,

0.6225298f,

0.72425705f,

},
},
            new SinglerealArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.20113987f,

0.43173438f,

0.7012973f,

0.081151724f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.7465577f,

0.986423f,

0.87505805f,

0.8744096f,

},
},
            new SinglerealArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8370133f,

0.7930807f,

0.96187395f,

0.5559701f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.29078352f,

0.6094788f,

0.53452206f,

0.63193625f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.20322686f,

0.26204348f,

0.54639333f,

0.9997769f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.83758587f,

0.17362422f,

0.51661325f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.18377453f,

0.8113613f,

0.10766119f,

0.43385166f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.75688237f,

0.3224299f,

0.10665196f,

0.26705408f,

},
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6342924f,

0.34593332f,

0.83328784f,

0.46942353f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.743938f,

0.52440923f,

0.60078853f,

0.34280485f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.29721236f,

0.53957945f,

0.36518896f,

0.42930478f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.025922239f,

0.42509085f,

0.22855133f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.2360071f,

0.64288294f,

0.83015347f,

0.8448821f,

},
},
            new SinglerealArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.38975644f,

0.34973413f,

0.15072268f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.62383544f,

0.76139253f,

0.4664731f,

0.6402201f,

},
},
            new SinglerealArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.80771697f,

0.99260384f,

0.39960247f,

0.7317922f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.59034395f,

0.09274316f,

0.7748496f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.10446447f,

0.37840366f,

0.6704164f,

0.39429075f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.6926479f,

0.330535f,

0.20700651f,

},
},
            new SinglerealArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.38323826f,

0.7163403f,

0.6514074f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.1474598f,

0.6387824f,

0.78070617f,

0.9023447f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.70145917f,

0.5976917f,

0.104058266f,

0.94346744f,

},
},
            new SinglerealArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.37148297f,

0.52831525f,

0.7555722f,

0.75266075f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.18743902f,

0.02937162f,

0.13258213f,

0.55392617f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8356894f,

0.04427576f,

0.66913605f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7302783f,

0.29187065f,

0.319454f,

},
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.12761426f,

0.4230851f,

0.44301242f,

0.30784166f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.3058855f,

0.23269457f,

0.8172926f,

},
},
            new SinglerealArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.93352056f,

0.76066244f,

0.5272692f,

0.79427123f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.27244502f,

0.2079199f,

0.14329058f,

0.503259f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.17232329f,

0.6301408f,

0.58182305f,

},
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.49101f,

0.23182738f,

0.4571523f,

0.7198549f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.57046527f,

0.43771046f,

0.7701994f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.76442665f,

0.58995855f,

0.9341902f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.33847052f,

0.46993446f,

0.47496575f,

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray2mi(
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
            asPartInterface: typeof(ISingleListrealArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Single>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Single>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray2mi(
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
            queryMapTypes: [typeof(SinglerealArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Single>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Single>), 
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

                changedRows =  ((ISingleListrealArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISingleListrealArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ISingleListrealArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleListrealArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ISingleListrealArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ISingleListrealArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray2m(
	id,
    value,
    nullablevalue,
    singlerealarray2mi_id
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
            asPartInterface: typeof(ISingleListrealArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Single>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Single>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "singlerealarray2mi_id", 
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
                changedRows =  ((ISingleListrealArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ISingleListrealArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ISingleListrealArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ISingleListrealArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray2m(
	id,
    value,
    nullablevalue,
    singlerealarray2mi_id
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
    singlerealarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(SinglerealArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray2m(
	id,
    value,
    nullablevalue,
    singlerealarray2mi_id
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
    singlerealarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(SinglerealArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Single>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Single>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "singlerealarray2mi_id", 
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
                List<SinglerealArray2M> models = null;

                models =  ((ISingleListrealArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((ISingleListrealArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((ISingleListrealArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((ISingleListrealArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<SinglerealArray2M> models = null;

                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealArray2M), typeof(FlatSinglerealArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
FROM public.singlerealarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSinglerealArray2M>();
                var models2 = new List<FlatSinglerealArray2M>();
                await ((ISingleListrealArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSinglerealArray2M>();
                var models2 = new List<FlatSinglerealArray2M>();
                ((ISingleListrealArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
FROM public.singlerealarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ISingleListrealArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ISingleListrealArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray2m m
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(SinglerealArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
                var models = await ((ISingleListrealArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ISingleListrealArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealArray2M), typeof(FlatSinglerealArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
FROM public.singlerealarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealArray2M>();
                var models2 = new List<FlatSinglerealArray2M>();
                await ((ISingleListrealArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealArray2M>();
                var models2 = new List<FlatSinglerealArray2M>();
                ((ISingleListrealArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
FROM public.singlerealarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ISingleListrealArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ISingleListrealArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray2m m
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(SinglerealArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
                var models = await ((ISingleListrealArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ISingleListrealArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealArray2M), typeof(FlatSinglerealArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
            asPartInterface: typeof(ISingleListrealArray)),
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglerealArray2M>();
                var models2 = new List<FlatSinglerealArray2M>();
                await((ISingleListrealArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
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
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var firstItems2 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                var secondItems2 = new List<FlatSinglerealArray2M>();
                await ((ISingleListrealArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[14],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 23;
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
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var firstItems2 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                await ((ISingleListrealArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[20],_testData[29], false);
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglerealArray2M>();
                var models2 = new List<FlatSinglerealArray2M>();
                ((ISingleListrealArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
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
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var firstItems2 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                var secondItems2 = new List<FlatSinglerealArray2M>();
                 ((ISingleListrealArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[18],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
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
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var firstItems2 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                 ((ISingleListrealArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
            asPartInterface: typeof(ISingleListrealArray)),
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ISingleListrealArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleListrealArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(models[7],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(models[8],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(models[9],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(models[10],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(models[11],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(models[12],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(models[13],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(models[14],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(models[15],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(models[16],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(models[17],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(models[18],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[19],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[20],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[21],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[22],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[23],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[29], false);
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
                parametr1.Value = 79;
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
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                var secondItems2 = new List<FlatSinglerealArray2M>();
                await ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[18],_testData[29], false);
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 126;
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
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleListrealArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(models[7],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(models[8],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(models[9],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(models[10],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(models[11],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(models[12],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[13],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[14],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[15],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[16],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[17],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[18],_testData[29], false);
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
                parametr1.Value = 66;
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
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                var secondItems2 = new List<FlatSinglerealArray2M>();
                 ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[22],_testData[29], false);
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
FROM public.singlerealarray2m m
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(SinglerealArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
                var models = await((ISingleListrealArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleListrealArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        SinglerealArray2M.AssertModel(models[0],_testData[19], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[20], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[21], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[22], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[8],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[9],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        SinglerealArray2M.AssertModel(models[0],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[29], false);
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
                var models = ((ISingleListrealArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleListrealArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        SinglerealArray2M.AssertModel(models[0],_testData[11], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[12], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[13], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[14], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[15], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[16], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[17], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[18], false);
                        SinglerealArray2M.AssertModel(models[8],_testData[19], false);
                        SinglerealArray2M.AssertModel(models[9],_testData[20], false);
                        SinglerealArray2M.AssertModel(models[10],_testData[21], false);
                        SinglerealArray2M.AssertModel(models[11],_testData[22], false);
                        SinglerealArray2M.AssertModel(models[12],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[13],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[14],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[15],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[16],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[17],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        SinglerealArray2M.AssertModel(models[0],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealArray2M), typeof(FlatSinglerealArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
            asPartInterface: typeof(ISingleListrealArray)),
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
            asPartInterface: typeof(ISingleListrealArray)),
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealArray2M>();
                var models2 = new List<FlatSinglerealArray2M>();
                await((ISingleListrealArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var firstItems2 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                var secondItems2 = new List<FlatSinglerealArray2M>();
                await ((ISingleListrealArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 72, query1, 69, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[18],_testData[29], false);
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
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var firstItems2 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                await ((ISingleListrealArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 23, query1, 111, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[29], false);
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealArray2M>();
                var models2 = new List<FlatSinglerealArray2M>();
                ((ISingleListrealArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var firstItems2 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                var secondItems2 = new List<FlatSinglerealArray2M>();
                 ((ISingleListrealArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 127, query1, 71, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[16],_testData[29], false);
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
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var firstItems2 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                 ((ISingleListrealArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 111, query1, 115, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
            asPartInterface: typeof(ISingleListrealArray)),
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
            asPartInterface: typeof(ISingleListrealArray)),
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ISingleListrealArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleListrealArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 79, query1, 115, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(models[7],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(models[8],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[9],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[10],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[11],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[12],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[13],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[29], false);
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
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                var secondItems2 = new List<FlatSinglerealArray2M>();
                await ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 7, query1, 71, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[16],_testData[29], false);
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ISingleListrealArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleListrealArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 102, query1, 18, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[7],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[8],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[3], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(models[7],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(models[8],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(models[9],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(models[10],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(models[11],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(models[12],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(models[13],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(models[14],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(models[15],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(models[16],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(models[17],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(models[18],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(models[19],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(models[20],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[21],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[22],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[23],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[24],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[25],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[26],_testData[29], false);
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
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                var secondItems2 = new List<FlatSinglerealArray2M>();
                 ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelBatch(connection, 111, query1, 129, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[29], false);
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
FROM public.singlerealarray2m m
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(SinglerealArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
            asPartInterface: typeof(ISingleListrealArray)),
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
                var models = await((ISingleListrealArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ISingleListrealArray)this).DbConnectionSTSelectModelBatchAsync(connection, 36, 95))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        SinglerealArray2M.AssertModel(models[0],_testData[6], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[7], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[8], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[9], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[10], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[11], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[12], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[13], false);
                        SinglerealArray2M.AssertModel(models[8],_testData[14], false);
                        SinglerealArray2M.AssertModel(models[9],_testData[15], false);
                        SinglerealArray2M.AssertModel(models[10],_testData[16], false);
                        SinglerealArray2M.AssertModel(models[11],_testData[17], false);
                        SinglerealArray2M.AssertModel(models[12],_testData[18], false);
                        SinglerealArray2M.AssertModel(models[13],_testData[19], false);
                        SinglerealArray2M.AssertModel(models[14],_testData[20], false);
                        SinglerealArray2M.AssertModel(models[15],_testData[21], false);
                        SinglerealArray2M.AssertModel(models[16],_testData[22], false);
                        SinglerealArray2M.AssertModel(models[17],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[18],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[19],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[20],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[21],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[22],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        SinglerealArray2M.AssertModel(models[0],_testData[18], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[19], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[20], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[21], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[22], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[8],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[9],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[10],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[11],_testData[29], false);
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
                var models = ((ISingleListrealArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ISingleListrealArray)this).DbConnectionSTSelectModelBatch(connection, 59, 126))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        SinglerealArray2M.AssertModel(models[0],_testData[9], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[10], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[11], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[12], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[13], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[14], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[15], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[16], false);
                        SinglerealArray2M.AssertModel(models[8],_testData[17], false);
                        SinglerealArray2M.AssertModel(models[9],_testData[18], false);
                        SinglerealArray2M.AssertModel(models[10],_testData[19], false);
                        SinglerealArray2M.AssertModel(models[11],_testData[20], false);
                        SinglerealArray2M.AssertModel(models[12],_testData[21], false);
                        SinglerealArray2M.AssertModel(models[13],_testData[22], false);
                        SinglerealArray2M.AssertModel(models[14],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[15],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[16],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[17],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[18],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[19],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        SinglerealArray2M.AssertModel(models[0],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[29], false);
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
                await using var cmd = await ((ISingleListrealArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ISingleListrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 95);
                var models = await ((ISingleListrealArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
SinglerealArray2M.AssertModel(models[0],_testData[18], false);SinglerealArray2M.AssertModel(models[1],_testData[19], false);SinglerealArray2M.AssertModel(models[2],_testData[20], false);SinglerealArray2M.AssertModel(models[3],_testData[21], false);SinglerealArray2M.AssertModel(models[4],_testData[22], false);SinglerealArray2M.AssertModel(models[5],_testData[23], false);SinglerealArray2M.AssertModel(models[6],_testData[24], false);SinglerealArray2M.AssertModel(models[7],_testData[25], false);SinglerealArray2M.AssertModel(models[8],_testData[26], false);SinglerealArray2M.AssertModel(models[9],_testData[27], false);SinglerealArray2M.AssertModel(models[10],_testData[28], false);SinglerealArray2M.AssertModel(models[11],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleListrealArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleListrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 23);
                var models =  ((ISingleListrealArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(26));
SinglerealArray2M.AssertModel(models[0],_testData[4], false);SinglerealArray2M.AssertModel(models[1],_testData[5], false);SinglerealArray2M.AssertModel(models[2],_testData[6], false);SinglerealArray2M.AssertModel(models[3],_testData[7], false);SinglerealArray2M.AssertModel(models[4],_testData[8], false);SinglerealArray2M.AssertModel(models[5],_testData[9], false);SinglerealArray2M.AssertModel(models[6],_testData[10], false);SinglerealArray2M.AssertModel(models[7],_testData[11], false);SinglerealArray2M.AssertModel(models[8],_testData[12], false);SinglerealArray2M.AssertModel(models[9],_testData[13], false);SinglerealArray2M.AssertModel(models[10],_testData[14], false);SinglerealArray2M.AssertModel(models[11],_testData[15], false);SinglerealArray2M.AssertModel(models[12],_testData[16], false);SinglerealArray2M.AssertModel(models[13],_testData[17], false);SinglerealArray2M.AssertModel(models[14],_testData[18], false);SinglerealArray2M.AssertModel(models[15],_testData[19], false);SinglerealArray2M.AssertModel(models[16],_testData[20], false);SinglerealArray2M.AssertModel(models[17],_testData[21], false);SinglerealArray2M.AssertModel(models[18],_testData[22], false);SinglerealArray2M.AssertModel(models[19],_testData[23], false);SinglerealArray2M.AssertModel(models[20],_testData[24], false);SinglerealArray2M.AssertModel(models[21],_testData[25], false);SinglerealArray2M.AssertModel(models[22],_testData[26], false);SinglerealArray2M.AssertModel(models[23],_testData[27], false);SinglerealArray2M.AssertModel(models[24],_testData[28], false);SinglerealArray2M.AssertModel(models[25],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlerealarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(SinglerealArray2MI)],
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
            asPartInterface: typeof(ISingleListrealArray))]
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
FROM public.binary_singlerealarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(SinglerealArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<SinglerealArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((ISingleListrealArray)this).ImportModelInner(connection, importCollection);
                var models = ((ISingleListrealArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray2MI.AssertModel(actual, expect, false);
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
                await ((ISingleListrealArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((ISingleListrealArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlerealarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
singlerealarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(SinglerealArray2M)],
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
            asPartInterface: typeof(ISingleListrealArray))]
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
FROM public.binary_singlerealarray2m m
LEFT JOIN public.binary_singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(SinglerealArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<SinglerealArray2M>(15);

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
                ((ISingleListrealArray)this).ImportModel(connection, importCollection);
                var models = ((ISingleListrealArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                SinglerealArray2M.AssertModel(models[0],_testData[0], false);
                SinglerealArray2M.AssertModel(models[1],_testData[1], false);
                SinglerealArray2M.AssertModel(models[2],_testData[2], false);
                SinglerealArray2M.AssertModel(models[3],_testData[3], false);
                SinglerealArray2M.AssertModel(models[4],_testData[4], false);
                SinglerealArray2M.AssertModel(models[5],_testData[5], false);
                SinglerealArray2M.AssertModel(models[6],_testData[6], false);
                SinglerealArray2M.AssertModel(models[7],_testData[7], false);
                SinglerealArray2M.AssertModel(models[8],_testData[8], false);
                SinglerealArray2M.AssertModel(models[9],_testData[9], false);
                SinglerealArray2M.AssertModel(models[10],_testData[10], false);
                SinglerealArray2M.AssertModel(models[11],_testData[11], false);
                SinglerealArray2M.AssertModel(models[12],_testData[12], false);
                SinglerealArray2M.AssertModel(models[13],_testData[13], false);
                SinglerealArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((ISingleListrealArray)this).ImportModelAsync(connection, importCollection);
                models = await ((ISingleListrealArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                SinglerealArray2M.AssertModel(models[0],_testData[0], false);
                SinglerealArray2M.AssertModel(models[1],_testData[1], false);
                SinglerealArray2M.AssertModel(models[2],_testData[2], false);
                SinglerealArray2M.AssertModel(models[3],_testData[3], false);
                SinglerealArray2M.AssertModel(models[4],_testData[4], false);
                SinglerealArray2M.AssertModel(models[5],_testData[5], false);
                SinglerealArray2M.AssertModel(models[6],_testData[6], false);
                SinglerealArray2M.AssertModel(models[7],_testData[7], false);
                SinglerealArray2M.AssertModel(models[8],_testData[8], false);
                SinglerealArray2M.AssertModel(models[9],_testData[9], false);
                SinglerealArray2M.AssertModel(models[10],_testData[10], false);
                SinglerealArray2M.AssertModel(models[11],_testData[11], false);
                SinglerealArray2M.AssertModel(models[12],_testData[12], false);
                SinglerealArray2M.AssertModel(models[13],_testData[13], false);
                SinglerealArray2M.AssertModel(models[14],_testData[14], false);
                SinglerealArray2M.AssertModel(models[15],_testData[15], false);
                SinglerealArray2M.AssertModel(models[16],_testData[16], false);
                SinglerealArray2M.AssertModel(models[17],_testData[17], false);
                SinglerealArray2M.AssertModel(models[18],_testData[18], false);
                SinglerealArray2M.AssertModel(models[19],_testData[19], false);
                SinglerealArray2M.AssertModel(models[20],_testData[20], false);
                SinglerealArray2M.AssertModel(models[21],_testData[21], false);
                SinglerealArray2M.AssertModel(models[22],_testData[22], false);
                SinglerealArray2M.AssertModel(models[23],_testData[23], false);
                SinglerealArray2M.AssertModel(models[24],_testData[24], false);
                SinglerealArray2M.AssertModel(models[25],_testData[25], false);
                SinglerealArray2M.AssertModel(models[26],_testData[26], false);
                SinglerealArray2M.AssertModel(models[27],_testData[27], false);
                SinglerealArray2M.AssertModel(models[28],_testData[28], false);
                SinglerealArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    singlerealarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(SinglerealArray2M)],
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
            asPartInterface: typeof(ISingleListrealArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ISingleListrealArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SinglerealArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleListrealArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SinglerealArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(SinglerealArray2MI)],
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
            asPartInterface: typeof(ISingleListrealArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ISingleListrealArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleListrealArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

