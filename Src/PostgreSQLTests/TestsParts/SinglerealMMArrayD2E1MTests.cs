

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
    internal partial interface ISingleMArrayrealMMArrayD2
    {
    }
    
    internal partial class SingleMArrayrealMMArrayD2 : ISingleMArrayrealMMArrayD2
    {


#region TestData

        private readonly SinglerealMMArrayD2E1M[] _testData = new SinglerealMMArrayD2E1M[]
        {
            new SinglerealMMArrayD2E1M
{
    Id = 5,
    Value = 
new System.Single[,] { { 0.73829365f, 0.8331927f, }, { 0.22586268f, 0.93030655f, }, },
    ModelInner = null,
    NullableValue = 
new System.Single[,] { { 0.93235916f, 0.8043202f, }, { 0.6437911f, 0.31545419f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 12,
    Value = 
new System.Single[,] { { 0.9699117f, 0.4878909f, }, { 0.59062284f, 0.71227765f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 2,
    Value = 
new System.Single[,] { { 0.11797929f, 0.12778866f, }, { 0.7836322f, 0.46655697f, }, },
    NullableValue = 
new System.Single[,] { { 0.2038269f, 0.5268149f, }, { 0.020561218f, 0.90666306f, }, },
},
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 18,
    Value = 
new System.Single[,] { { 0.39742708f, 0.057312906f, }, { 0.010379314f, 0.42015368f, }, },
    ModelInner = null,
    NullableValue = 
new System.Single[,] { { 0.70780075f, 0.13305622f, }, { 0.97433937f, 0.72070485f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 24,
    Value = 
new System.Single[,] { { 0.7799113f, 0.007245302f, }, { 0.032500565f, 0.26096433f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 3,
    Value = 
new System.Single[,] { { 0.0136117935f, 0.67742074f, }, { 0.35586017f, 0.98104763f, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 27,
    Value = 
new System.Single[,] { { 0.6194022f, 0.5434494f, }, { 0.6299524f, 0.63235384f, }, },
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 33,
    Value = 
new System.Single[,] { { 0.97325623f, 0.71221155f, }, { 0.97803324f, 0.8707715f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 4,
    Value = 
new System.Single[,] { { 0.5739049f, 0.17273188f, }, { 0.87031615f, 0.001577735f, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Single[,] { { 0.9374238f, 0.014777005f, }, { 0.039283216f, 0.52272284f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 41,
    Value = 
new System.Single[,] { { 0.28777987f, 0.1886394f, }, { 0.8082714f, 0.19607872f, }, },
    ModelInner = null,
    NullableValue = 
new System.Single[,] { { 0.7486719f, 0.94627815f, }, { 0.37318677f, 0.8511869f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 46,
    Value = 
new System.Single[,] { { 0.9871409f, 0.4901755f, }, { 0.9611008f, 0.6447419f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 10,
    Value = 
new System.Single[,] { { 0.8364593f, 0.4943552f, }, { 0.05269301f, 0.49423236f, }, },
    NullableValue = 
new System.Single[,] { { 0.87297875f, 0.8115649f, }, { 0.93550575f, 0.20595491f, }, },
},
    NullableValue = 
new System.Single[,] { { 0.030724168f, 0.40003777f, }, { 0.42249262f, 0.6659029f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 51,
    Value = 
new System.Single[,] { { 0.6396378f, 0.9647095f, }, { 0.24564505f, 0.89377046f, }, },
    ModelInner = null,
    NullableValue = 
new System.Single[,] { { 0.46076673f, 0.121240616f, }, { 0.6953568f, 0.96371263f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 56,
    Value = 
new System.Single[,] { { 0.063152134f, 0.7621218f, }, { 0.8089793f, 0.60530376f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 12,
    Value = 
new System.Single[,] { { 0.08735871f, 0.9001729f, }, { 0.6962095f, 0.24228722f, }, },
    NullableValue = 
new System.Single[,] { { 0.08412367f, 0.95009637f, }, { 0.053304613f, 0.28427643f, }, },
},
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 61,
    Value = 
new System.Single[,] { { 0.84518725f, 0.877353f, }, { 0.050284326f, 0.40410125f, }, },
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 68,
    Value = 
new System.Single[,] { { 0.86641246f, 0.29931927f, }, { 0.6771056f, 0.973842f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 14,
    Value = 
new System.Single[,] { { 0.34663093f, 0.2747069f, }, { 0.26633638f, 0.5966659f, }, },
    NullableValue = 
new System.Single[,] { { 0.26098454f, 0.16050154f, }, { 0.82032126f, 0.5085229f, }, },
},
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 72,
    Value = 
new System.Single[,] { { 0.43291384f, 0.5046211f, }, { 0.6162598f, 0.49953127f, }, },
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 76,
    Value = 
new System.Single[,] { { 0.3191365f, 0.04849589f, }, { 0.048963726f, 0.6952446f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 23,
    Value = 
new System.Single[,] { { 0.8432799f, 0.6009332f, }, { 0.2846058f, 0.72514814f, }, },
    NullableValue = 
new System.Single[,] { { 0.3742274f, 0.912798f, }, { 0.31941658f, 0.012500107f, }, },
},
    NullableValue = 
new System.Single[,] { { 0.037555277f, 0.66859984f, }, { 0.30196536f, 0.924217f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 83,
    Value = 
new System.Single[,] { { 0.3095898f, 0.9121698f, }, { 0.08627176f, 0.9868774f, }, },
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 85,
    Value = 
new System.Single[,] { { 0.33890736f, 0.6442602f, }, { 0.12770092f, 0.44602036f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 31,
    Value = 
new System.Single[,] { { 0.8950498f, 0.5102803f, }, { 0.7711836f, 0.45500118f, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Single[,] { { 0.2720431f, 0.32468718f, }, { 0.82266754f, 0.59018296f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 92,
    Value = 
new System.Single[,] { { 0.069309115f, 0.35774463f, }, { 0.3872379f, 0.50214326f, }, },
    ModelInner = null,
    NullableValue = 
new System.Single[,] { { 0.95497274f, 0.46411723f, }, { 0.45916605f, 0.15612519f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 98,
    Value = 
new System.Single[,] { { 0.008479953f, 0.039627254f, }, { 0.575379f, 0.07296622f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 37,
    Value = 
new System.Single[,] { { 0.12417239f, 0.8189967f, }, { 0.7675887f, 0.91333216f, }, },
    NullableValue = 
new System.Single[,] { { 0.6387584f, 0.41939354f, }, { 0.73609936f, 0.632883f, }, },
},
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 101,
    Value = 
new System.Single[,] { { 0.3443877f, 0.050551414f, }, { 0.15260053f, 0.80319583f, }, },
    ModelInner = null,
    NullableValue = 
new System.Single[,] { { 0.45849305f, 0.60622615f, }, { 0.22310013f, 0.3229882f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 104,
    Value = 
new System.Single[,] { { 0.82519215f, 0.5749919f, }, { 0.73495317f, 0.26108563f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 43,
    Value = 
new System.Single[,] { { 0.044262648f, 0.8001799f, }, { 0.575182f, 0.38254726f, }, },
    NullableValue = 
new System.Single[,] { { 0.868871f, 0.2737965f, }, { 0.5435214f, 0.14082074f, }, },
},
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 106,
    Value = 
new System.Single[,] { { 0.19716549f, 0.98496467f, }, { 0.9916163f, 0.410641f, }, },
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 107,
    Value = 
new System.Single[,] { { 0.76793885f, 0.6704213f, }, { 0.99672437f, 0.19971591f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 51,
    Value = 
new System.Single[,] { { 0.8608353f, 0.684174f, }, { 0.5892674f, 0.97683656f, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Single[,] { { 0.2510432f, 0.27363753f, }, { 0.12175995f, 0.8042575f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 111,
    Value = 
new System.Single[,] { { 0.5079834f, 0.9634231f, }, { 0.21503115f, 0.41738093f, }, },
    ModelInner = null,
    NullableValue = 
new System.Single[,] { { 0.3757484f, 0.21798342f, }, { 0.24555445f, 0.07796663f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 120,
    Value = 
new System.Single[,] { { 0.30843616f, 0.7891124f, }, { 0.4704789f, 0.72925025f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 58,
    Value = 
new System.Single[,] { { 0.97823507f, 0.5083373f, }, { 0.76849246f, 0.7624214f, }, },
    NullableValue = 
new System.Single[,] { { 0.36422437f, 0.8784012f, }, { 0.00044727325f, 0.16578013f, }, },
},
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 122,
    Value = 
new System.Single[,] { { 0.4907974f, 0.13215548f, }, { 0.7002167f, 0.40442562f, }, },
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 126,
    Value = 
new System.Single[,] { { 0.3256513f, 0.76774806f, }, { 0.81001514f, 0.86211073f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 65,
    Value = 
new System.Single[,] { { 0.5534132f, 0.6453383f, }, { 0.619226f, 0.97543186f, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 134,
    Value = 
new System.Single[,] { { 0.7366729f, 0.96006674f, }, { 0.37079197f, 0.54363143f, }, },
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 143,
    Value = 
new System.Single[,] { { 0.08919495f, 0.72925407f, }, { 0.27578026f, 0.5955714f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 71,
    Value = 
new System.Single[,] { { 0.49069726f, 0.5683412f, }, { 0.6945176f, 0.7570648f, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Single[,] { { 0.18503588f, 0.31871796f, }, { 0.22268784f, 0.8629705f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 149,
    Value = 
new System.Single[,] { { 0.5627446f, 0.9436064f, }, { 0.68456507f, 0.72470886f, }, },
    ModelInner = null,
    NullableValue = 
new System.Single[,] { { 0.51977754f, 0.9857194f, }, { 0.598439f, 0.18741596f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 153,
    Value = 
new System.Single[,] { { 0.75711364f, 0.09012514f, }, { 0.6392945f, 0.8837198f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 77,
    Value = 
new System.Single[,] { { 0.76305765f, 0.048762262f, }, { 0.44067007f, 0.48808277f, }, },
    NullableValue = 
new System.Single[,] { { 0.38497674f, 0.28657717f, }, { 0.5335389f, 0.1958012f, }, },
},
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 154,
    Value = 
new System.Single[,] { { 0.3665712f, 0.12817979f, }, { 0.4536299f, 0.15045518f, }, },
    ModelInner = null,
    NullableValue = 
new System.Single[,] { { 0.87656265f, 0.4694792f, }, { 0.50428337f, 0.12360817f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 156,
    Value = 
new System.Single[,] { { 0.58303237f, 0.471636f, }, { 0.22184372f, 0.56777275f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 84,
    Value = 
new System.Single[,] { { 0.9050631f, 0.5127268f, }, { 0.26365948f, 0.5627805f, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 164,
    Value = 
new System.Single[,] { { 0.20985812f, 0.5716482f, }, { 0.84454906f, 0.8112433f, }, },
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 169,
    Value = 
new System.Single[,] { { 0.2733159f, 0.63733315f, }, { 0.3102281f, 0.28573972f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 93,
    Value = 
new System.Single[,] { { 0.8602596f, 0.11702728f, }, { 0.06244099f, 0.28490013f, }, },
    NullableValue = 
new System.Single[,] { { 0.79369396f, 0.8182171f, }, { 0.8622823f, 0.29213315f, }, },
},
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 177,
    Value = 
new System.Single[,] { { 0.82022804f, 0.37022877f, }, { 0.11840427f, 0.7050552f, }, },
    ModelInner = null,
    NullableValue = 
new System.Single[,] { { 0.34178066f, 0.93694884f, }, { 0.96201766f, 0.9567112f, }, },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealmmarrayd2e1mi(
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealmmarrayd2e1mi(
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
            queryMapTypes: [typeof(SinglerealMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[,]), 
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

                changedRows =  ((ISingleMArrayrealMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISingleMArrayrealMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ISingleMArrayrealMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleMArrayrealMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ISingleMArrayrealMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ISingleMArrayrealMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ISingleMArrayrealMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ISingleMArrayrealMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((ISingleMArrayrealMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((ISingleMArrayrealMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((ISingleMArrayrealMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((ISingleMArrayrealMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((ISingleMArrayrealMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((ISingleMArrayrealMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((ISingleMArrayrealMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((ISingleMArrayrealMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((ISingleMArrayrealMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    singlerealmmarrayd2e1mi_id
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "singlerealmmarrayd2e1mi_id", 
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
                changedRows =  ((ISingleMArrayrealMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ISingleMArrayrealMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ISingleMArrayrealMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ISingleMArrayrealMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    singlerealmmarrayd2e1mi_id
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
    singlerealmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
                System.Single[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Single[,]>();
                    ((NpgsqlParameter<System.Single[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483631);
                    ((NpgsqlParameter<System.Single[,]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((ISingleMArrayrealMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Single[,]>();
                    ((NpgsqlParameter<System.Single[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483631);
                    ((NpgsqlParameter<System.Single[,]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((ISingleMArrayrealMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[,] { { 0.9374238f, 0.014777005f, }, { 0.039283216f, 0.52272284f, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Single[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Single[,]>();
                    ((NpgsqlParameter<System.Single[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483631);
                    ((NpgsqlParameter<System.Single[,]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((ISingleMArrayrealMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[,] { { 0.7486719f, 0.94627815f, }, { 0.37318677f, 0.8511869f, }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Single[,]>();
                    ((NpgsqlParameter<System.Single[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483631);
                    ((NpgsqlParameter<System.Single[,]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((ISingleMArrayrealMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[,] { { 0.030724168f, 0.40003777f, }, { 0.42249262f, 0.6659029f, }, }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    singlerealmmarrayd2e1mi_id
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
    singlerealmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "singlerealmmarrayd2e1mi_id", 
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
                System.Single[,] nullable = null;
                nullable =  ((ISingleMArrayrealMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[,] { { 0.46076673f, 0.121240616f, }, { 0.6953568f, 0.96371263f, }, }));
                nullable =  ((ISingleMArrayrealMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Single[,] nullable = null;
                nullable = await ((ISingleMArrayrealMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((ISingleMArrayrealMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<SinglerealMMArrayD2E1M> models = null;

                models =  ((ISingleMArrayrealMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((ISingleMArrayrealMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((ISingleMArrayrealMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((ISingleMArrayrealMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<SinglerealMMArrayD2E1M> models = null;

                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealMMArrayD2E1M), typeof(FlatSinglerealMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
FROM public.singlerealmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSinglerealMMArrayD2E1M>();
                var models2 = new List<FlatSinglerealMMArrayD2E1M>();
                await ((ISingleMArrayrealMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSinglerealMMArrayD2E1M>();
                var models2 = new List<FlatSinglerealMMArrayD2E1M>();
                ((ISingleMArrayrealMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
FROM public.singlerealmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ISingleMArrayrealMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ISingleMArrayrealMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealmmarrayd2e1m m
LEFT JOIN public.singlerealmmarrayd2e1mi mi ON mi.id = m.singlerealmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
                var models = await ((ISingleMArrayrealMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ISingleMArrayrealMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealMMArrayD2E1M), typeof(FlatSinglerealMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
FROM public.singlerealmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealMMArrayD2E1M>();
                var models2 = new List<FlatSinglerealMMArrayD2E1M>();
                await ((ISingleMArrayrealMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealMMArrayD2E1M>();
                var models2 = new List<FlatSinglerealMMArrayD2E1M>();
                ((ISingleMArrayrealMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
FROM public.singlerealmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ISingleMArrayrealMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ISingleMArrayrealMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealmmarrayd2e1m m
LEFT JOIN public.singlerealmmarrayd2e1mi mi ON mi.id = m.singlerealmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
                var models = await ((ISingleMArrayrealMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ISingleMArrayrealMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealMMArrayD2E1M), typeof(FlatSinglerealMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglerealMMArrayD2E1M>();
                var models2 = new List<FlatSinglerealMMArrayD2E1M>();
                await((ISingleMArrayrealMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 120;
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
FROM public.singlerealmmarrayd2e1m m
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var firstItems2 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems2 = new List<FlatSinglerealMMArrayD2E1M>();
                await ((ISingleMArrayrealMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
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
FROM public.singlerealmmarrayd2e1m m
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var firstItems2 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                await ((ISingleMArrayrealMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglerealMMArrayD2E1M>();
                var models2 = new List<FlatSinglerealMMArrayD2E1M>();
                ((ISingleMArrayrealMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
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
FROM public.singlerealmmarrayd2e1m m
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var firstItems2 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems2 = new List<FlatSinglerealMMArrayD2E1M>();
                 ((ISingleMArrayrealMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 164;
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
FROM public.singlerealmmarrayd2e1m m
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var firstItems2 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                 ((ISingleMArrayrealMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ISingleMArrayrealMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 92;
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
FROM public.singlerealmmarrayd2e1m m
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleMArrayrealMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatSinglerealMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatSinglerealMMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 51;
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
FROM public.singlerealmmarrayd2e1m m
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems2 = new List<FlatSinglerealMMArrayD2E1M>();
                await ((ISingleMArrayrealMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ISingleMArrayrealMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 164;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealmmarrayd2e1m m
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleMArrayrealMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatSinglerealMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatSinglerealMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 156;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealmmarrayd2e1m m
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems2 = new List<FlatSinglerealMMArrayD2E1M>();
                 ((ISingleMArrayrealMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.singlerealmmarrayd2e1m m
LEFT JOIN public.singlerealmmarrayd2e1mi mi ON mi.id = m.singlerealmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
                var models = await((ISingleMArrayrealMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleMArrayrealMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
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
                var models = ((ISingleMArrayrealMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleMArrayrealMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealMMArrayD2E1M), typeof(FlatSinglerealMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealMMArrayD2E1M>();
                var models2 = new List<FlatSinglerealMMArrayD2E1M>();
                await((ISingleMArrayrealMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealmmarrayd2e1m m
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var firstItems2 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems2 = new List<FlatSinglerealMMArrayD2E1M>();
                await ((ISingleMArrayrealMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 18, query1, 51, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.singlerealmmarrayd2e1m m
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var firstItems2 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                await ((ISingleMArrayrealMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 101, query1, 153, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[4],_testData[34], false);
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealMMArrayD2E1M>();
                var models2 = new List<FlatSinglerealMMArrayD2E1M>();
                ((ISingleMArrayrealMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealmmarrayd2e1m m
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var firstItems2 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems2 = new List<FlatSinglerealMMArrayD2E1M>();
                 ((ISingleMArrayrealMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 61, query1, 12, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.singlerealmmarrayd2e1m m
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var firstItems2 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                 ((ISingleMArrayrealMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 134, query1, 106, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ISingleMArrayrealMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealmmarrayd2e1m m
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleMArrayrealMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 27, query1, 122, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatSinglerealMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatSinglerealMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
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
FROM public.singlerealmmarrayd2e1m m
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems2 = new List<FlatSinglerealMMArrayD2E1M>();
                await ((ISingleMArrayrealMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 104, query1, 18, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ISingleMArrayrealMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealmmarrayd2e1m m
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleMArrayrealMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 12, query1, 106, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatSinglerealMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatSinglerealMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
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
FROM public.singlerealmmarrayd2e1m m
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems2 = new List<FlatSinglerealMMArrayD2E1M>();
                 ((ISingleMArrayrealMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 149, query1, 92, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.singlerealmmarrayd2e1m m
LEFT JOIN public.singlerealmmarrayd2e1mi mi ON mi.id = m.singlerealmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
                var models = await((ISingleMArrayrealMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ISingleMArrayrealMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 101, 12))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
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
                var models = ((ISingleMArrayrealMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ISingleMArrayrealMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 56, 156))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
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
                await using var cmd = await ((ISingleMArrayrealMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ISingleMArrayrealMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 134);
                var models = await ((ISingleMArrayrealMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                SinglerealMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                SinglerealMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                SinglerealMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                SinglerealMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                SinglerealMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                SinglerealMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                SinglerealMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleMArrayrealMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleMArrayrealMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 5);
                var models =  ((ISingleMArrayrealMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                SinglerealMMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                SinglerealMMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                SinglerealMMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                SinglerealMMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                SinglerealMMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                SinglerealMMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                SinglerealMMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                SinglerealMMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                SinglerealMMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                SinglerealMMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                SinglerealMMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                SinglerealMMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                SinglerealMMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                SinglerealMMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                SinglerealMMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                SinglerealMMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                SinglerealMMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                SinglerealMMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                SinglerealMMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                SinglerealMMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                SinglerealMMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                SinglerealMMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                SinglerealMMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                SinglerealMMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                SinglerealMMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                SinglerealMMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                SinglerealMMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                SinglerealMMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                SinglerealMMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                SinglerealMMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                SinglerealMMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                SinglerealMMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                SinglerealMMArrayD2E1M.AssertModel(models[33],_testData[34], false);
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
FROM public.binary_singlerealmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(SinglerealMMArrayD2E1MIWA),
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISingleMArrayrealMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_singlerealmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISingleMArrayrealMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISingleMArrayrealMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_singlerealmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISingleMArrayrealMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_singlerealmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(SinglerealMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISingleMArrayrealMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_singlerealmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISingleMArrayrealMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISingleMArrayrealMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_singlerealmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISingleMArrayrealMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_singlerealmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlerealmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(SinglerealMMArrayD2E1MI),
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ISingleMArrayrealMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((ISingleMArrayrealMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ISingleMArrayrealMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((ISingleMArrayrealMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_singlerealmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlerealmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(SinglerealMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISingleMArrayrealMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ISingleMArrayrealMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISingleMArrayrealMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((ISingleMArrayrealMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlerealmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
singlerealmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(SinglerealMMArrayD2E1M),
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2))]
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
FROM public.binary_singlerealmmarrayd2e1m m
LEFT JOIN public.binary_singlerealmmarrayd2e1mi mi ON mi.id = m.singlerealmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((ISingleMArrayrealMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((ISingleMArrayrealMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    SinglerealMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((ISingleMArrayrealMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((ISingleMArrayrealMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    SinglerealMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    singlerealmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
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
                var models =  ((ISingleMArrayrealMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SinglerealMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleMArrayrealMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SinglerealMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1MIWA), typeof(SinglerealMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
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
                var models1 = new List<SinglerealMMArrayD2E1MIWA>();
                var models2 = new List<SinglerealMMArrayD2E1MIWA>();
                await ((ISingleMArrayrealMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealMMArrayD2E1MIWA>();
                var models2 = new List<SinglerealMMArrayD2E1MIWA>();
                ((ISingleMArrayrealMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
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
                var models = await ((ISingleMArrayrealMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_singlerealmmarrayd2e1mi
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
                    SinglerealMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleMArrayrealMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_singlerealmmarrayd2e1mi
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
                    SinglerealMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1MIWA), typeof(SinglerealMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2))]
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
                var models1 = new List<SinglerealMMArrayD2E1MIWA>();
                var models2 = new List<SinglerealMMArrayD2E1MIWA>();
                await ((ISingleMArrayrealMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealMMArrayD2E1MIWA>();
                var models2 = new List<SinglerealMMArrayD2E1MIWA>();
                ((ISingleMArrayrealMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2))]
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
                var models = await ((ISingleMArrayrealMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_singlerealmmarrayd2e1mi
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
                    SinglerealMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleMArrayrealMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_singlerealmmarrayd2e1mi
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
                    SinglerealMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_singlerealmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1MI), typeof(SinglerealMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
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
                var models1 = new List<SinglerealMMArrayD2E1MI>();
                var models2 = new List<SinglerealMMArrayD2E1MI>();
                await ((ISingleMArrayrealMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealMMArrayD2E1MI>();
                var models2 = new List<SinglerealMMArrayD2E1MI>();
                ((ISingleMArrayrealMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631),
                (NpgsqlTypes.NpgsqlDbType)(-2147483631)
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
                var models = await ((ISingleMArrayrealMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleMArrayrealMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_singlerealmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1MIWA), typeof(SinglerealMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2))]
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
                var models1 = new List<SinglerealMMArrayD2E1MIWA>();
                var models2 = new List<SinglerealMMArrayD2E1MIWA>();
                await ((ISingleMArrayrealMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealMMArrayD2E1MIWA>();
                var models2 = new List<SinglerealMMArrayD2E1MIWA>();
                ((ISingleMArrayrealMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2))]
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
                var models = await ((ISingleMArrayrealMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleMArrayrealMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

