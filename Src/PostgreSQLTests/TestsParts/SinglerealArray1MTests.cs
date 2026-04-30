

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
    Id = 7,
    Value = 
new System.Single[4]
{
0.35653704f,
0.3847751f,
0.96388865f,
0.12694299f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 14,
    Value = 
new System.Single[3]
{
0.6999487f,
0.94622713f,
0.7717116f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 2,
    Value = 
new System.Single[4]
{
0.47656506f,
0.017380655f,
0.85365653f,
0.7638949f,
},
    NullableValue = 
new System.Single[3]
{
0.16083968f,
0.96716297f,
0.103118956f,
},
},
    NullableValue = 
new System.Single[4]
{
0.08136052f,
0.08159578f,
0.19694436f,
0.8589067f,
},
},
            new SinglerealArray1M
{
    Id = 17,
    Value = 
new System.Single[3]
{
0.04636526f,
0.99040854f,
0.9308731f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.055553257f,
0.8777555f,
0.89273226f,
0.74217933f,
},
},
            new SinglerealArray1M
{
    Id = 25,
    Value = 
new System.Single[4]
{
0.64346397f,
0.20500964f,
0.5202645f,
0.2937762f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 10,
    Value = 
new System.Single[3]
{
0.4325732f,
0.3335144f,
0.15281558f,
},
    NullableValue = 
new System.Single[3]
{
0.21881425f,
0.33352643f,
0.32750028f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 32,
    Value = 
new System.Single[4]
{
0.36879253f,
0.018633783f,
0.9000957f,
0.28591126f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.12493968f,
0.15481997f,
0.3906893f,
},
},
            new SinglerealArray1M
{
    Id = 34,
    Value = 
new System.Single[4]
{
0.13482648f,
0.35731965f,
0.57086974f,
0.8449963f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 13,
    Value = 
new System.Single[3]
{
0.6368647f,
0.709323f,
0.06273371f,
},
    NullableValue = 
new System.Single[3]
{
0.54314107f,
0.20481938f,
0.07755172f,
},
},
    NullableValue = 
new System.Single[4]
{
0.21949786f,
0.22891134f,
0.5379588f,
0.4179358f,
},
},
            new SinglerealArray1M
{
    Id = 42,
    Value = 
new System.Single[3]
{
0.7720073f,
0.7588327f,
0.24943227f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.6564465f,
0.92527443f,
0.08269215f,
0.04301679f,
},
},
            new SinglerealArray1M
{
    Id = 50,
    Value = 
new System.Single[3]
{
0.65676576f,
0.260929f,
0.23449153f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 17,
    Value = 
new System.Single[4]
{
0.674937f,
0.8234176f,
0.7039678f,
0.26875335f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.3094713f,
0.041166723f,
0.116897285f,
0.9442894f,
},
},
            new SinglerealArray1M
{
    Id = 56,
    Value = 
new System.Single[4]
{
0.6393254f,
0.05352539f,
0.5739011f,
0.33726126f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.7304043f,
0.62534755f,
0.6516198f,
},
},
            new SinglerealArray1M
{
    Id = 61,
    Value = 
new System.Single[3]
{
0.4185357f,
0.5235224f,
0.8646874f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 24,
    Value = 
new System.Single[3]
{
0.66857785f,
0.89943296f,
0.7871416f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.4015575f,
0.7880528f,
0.7539161f,
0.9178416f,
},
},
            new SinglerealArray1M
{
    Id = 64,
    Value = 
new System.Single[4]
{
0.070910454f,
0.43569088f,
0.07318932f,
0.37065f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.7001548f,
0.33213693f,
0.730732f,
},
},
            new SinglerealArray1M
{
    Id = 68,
    Value = 
new System.Single[4]
{
0.26450485f,
0.5241908f,
0.05062425f,
0.43083227f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 30,
    Value = 
new System.Single[3]
{
0.40869313f,
0.8003127f,
0.26001126f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.6447617f,
0.15662694f,
0.21514755f,
0.61640877f,
},
},
            new SinglerealArray1M
{
    Id = 69,
    Value = 
new System.Single[4]
{
0.36290032f,
0.54668444f,
0.4370702f,
0.9690025f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 73,
    Value = 
new System.Single[3]
{
0.70435685f,
0.18144917f,
0.85626185f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 38,
    Value = 
new System.Single[4]
{
0.7957478f,
0.68196857f,
0.87798876f,
0.33431184f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 77,
    Value = 
new System.Single[4]
{
0.12257475f,
0.12856656f,
0.59466076f,
0.75661343f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.14030653f,
0.42151058f,
0.7886576f,
},
},
            new SinglerealArray1M
{
    Id = 85,
    Value = 
new System.Single[3]
{
0.57387483f,
0.8816902f,
0.9228539f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 40,
    Value = 
new System.Single[3]
{
0.8297051f,
0.7547751f,
0.388592f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 89,
    Value = 
new System.Single[4]
{
0.29353333f,
0.08842093f,
0.9130429f,
0.6422067f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.39639723f,
0.56173176f,
0.40470427f,
},
},
            new SinglerealArray1M
{
    Id = 90,
    Value = 
new System.Single[3]
{
0.014036298f,
0.25272876f,
0.632341f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 42,
    Value = 
new System.Single[3]
{
0.40474534f,
0.36545718f,
0.10371393f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[3]
{
0.7365037f,
0.2514217f,
0.6339425f,
},
},
            new SinglerealArray1M
{
    Id = 92,
    Value = 
new System.Single[4]
{
0.6355414f,
0.95020354f,
0.6068214f,
0.5446889f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.22896111f,
0.0739308f,
0.28643376f,
0.70736694f,
},
},
            new SinglerealArray1M
{
    Id = 94,
    Value = 
new System.Single[4]
{
0.90447974f,
0.6343156f,
0.99677515f,
0.67644846f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 46,
    Value = 
new System.Single[4]
{
0.4303289f,
0.05469936f,
0.786389f,
0.3446499f,
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
0.12801707f,
0.9292061f,
0.7548801f,
0.48585337f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.27416873f,
0.50914407f,
0.7132346f,
},
},
            new SinglerealArray1M
{
    Id = 103,
    Value = 
new System.Single[3]
{
0.49851984f,
0.86024535f,
0.49653018f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 55,
    Value = 
new System.Single[4]
{
0.70813984f,
0.21341026f,
0.88554734f,
0.27739024f,
},
    NullableValue = 
new System.Single[4]
{
0.20071614f,
0.6747447f,
0.794709f,
0.34979922f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 104,
    Value = 
new System.Single[3]
{
0.68015325f,
0.07388377f,
0.117589f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.082137525f,
0.6632233f,
0.61594015f,
0.138547f,
},
},
            new SinglerealArray1M
{
    Id = 108,
    Value = 
new System.Single[4]
{
0.27498507f,
0.19672549f,
0.3635767f,
0.4958653f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 61,
    Value = 
new System.Single[4]
{
0.5319877f,
0.27010888f,
0.8104087f,
0.9958158f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 110,
    Value = 
new System.Single[4]
{
0.50261027f,
0.99120325f,
0.66432166f,
0.1896866f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.3755811f,
0.07925218f,
0.59296054f,
},
},
            new SinglerealArray1M
{
    Id = 118,
    Value = 
new System.Single[4]
{
0.28311735f,
0.628788f,
0.9687393f,
0.13606107f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 67,
    Value = 
new System.Single[3]
{
0.6965476f,
0.32839763f,
0.9557043f,
},
    NullableValue = 
new System.Single[4]
{
0.3322087f,
0.5777814f,
0.43162495f,
0.82959247f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 119,
    Value = 
new System.Single[4]
{
0.36588806f,
0.63397616f,
0.9211641f,
0.10059744f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.8291101f,
0.15492988f,
0.31874955f,
0.60355926f,
},
},
            new SinglerealArray1M
{
    Id = 126,
    Value = 
new System.Single[4]
{
0.18486309f,
0.6914907f,
0.8942456f,
0.6130525f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 72,
    Value = 
new System.Single[3]
{
0.44378036f,
0.8349671f,
0.020434141f,
},
    NullableValue = 
new System.Single[4]
{
0.027816832f,
0.09517783f,
0.4465891f,
0.14291286f,
},
},
    NullableValue = 
new System.Single[3]
{
0.7237651f,
0.07828587f,
0.74311626f,
},
},
            new SinglerealArray1M
{
    Id = 127,
    Value = 
new System.Single[3]
{
0.66560477f,
0.85775185f,
0.3716668f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.77011013f,
0.43270648f,
0.22883612f,
},
},
            new SinglerealArray1M
{
    Id = 133,
    Value = 
new System.Single[4]
{
0.9728433f,
0.39140695f,
0.97077453f,
0.14999557f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 74,
    Value = 
new System.Single[3]
{
0.038915217f,
0.83136374f,
0.64102805f,
},
    NullableValue = 
new System.Single[4]
{
0.10716301f,
0.72185934f,
0.1413644f,
0.572813f,
},
},
    NullableValue = 
new System.Single[4]
{
0.6950873f,
0.5563771f,
0.80325806f,
0.030370235f,
},
},
            new SinglerealArray1M
{
    Id = 136,
    Value = 
new System.Single[3]
{
0.25074255f,
0.14593667f,
0.36432415f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 144,
    Value = 
new System.Single[3]
{
0.66034615f,
0.10862982f,
0.31950092f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 79,
    Value = 
new System.Single[3]
{
0.3698051f,
0.963561f,
0.2691092f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[3]
{
0.08276719f,
0.85748875f,
0.94241565f,
},
},
            new SinglerealArray1M
{
    Id = 151,
    Value = 
new System.Single[4]
{
0.9691362f,
0.33527905f,
0.6961343f,
0.4890272f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 160,
    Value = 
new System.Single[4]
{
0.40700877f,
0.1013608f,
0.6618955f,
0.41465783f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 82,
    Value = 
new System.Single[3]
{
0.26533502f,
0.7391924f,
0.7115856f,
},
    NullableValue = 
new System.Single[4]
{
0.8452342f,
0.19968462f,
0.13300973f,
0.10418695f,
},
},
    NullableValue = 
new System.Single[3]
{
0.0655545f,
0.62493527f,
0.5238778f,
},
},
            new SinglerealArray1M
{
    Id = 165,
    Value = 
new System.Single[4]
{
0.71907127f,
0.5555267f,
0.4347117f,
0.5137292f,
},
    ModelInner = null,
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

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((ISingleArrayrealArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[3]
{
0.12493968f,
0.15481997f,
0.3906893f,
}));
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
0.21949786f,
0.22891134f,
0.5379588f,
0.4179358f,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[4]
{
0.6564465f,
0.92527443f,
0.08269215f,
0.04301679f,
}));
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
0.3094713f,
0.041166723f,
0.116897285f,
0.9442894f,
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
new System.Single[3]
{
0.7304043f,
0.62534755f,
0.6516198f,
}));
                nullable =  ((ISingleArrayrealArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[4]
{
0.4015575f,
0.7880528f,
0.7539161f,
0.9178416f,
}));
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
new System.Single[3]
{
0.7001548f,
0.33213693f,
0.730732f,
}));
                nullable = await ((ISingleArrayrealArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[4]
{
0.6447617f,
0.15662694f,
0.21514755f,
0.61640877f,
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
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((ISingleArrayrealArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray1M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
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
                        FlatSinglerealArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[29],_testData[34], false);
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
                parametr2.Value = 32;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[29],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 56;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
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
                        FlatSinglerealArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
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

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(models[18],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(models[19],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(models[20],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[21],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 14;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 64;
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
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[18],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(models[19],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(models[20],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(models[21],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[22],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

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
                        FlatSinglerealArray1M.AssertModel(models[23],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(models[24],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(models[25],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[26],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[27],_testData[34], false);
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[28],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        SinglerealArray1M.AssertModel(models[0],_testData[3], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[4], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[5], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[6], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[7], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[8], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[9], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[10], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[11], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[12], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[13], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[14], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[17],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[18],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[19],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[20],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[21],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[22],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[23],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[24],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[25],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[26],_testData[29], false);
                        SinglerealArray1M.AssertModel(models[27],_testData[30], false);
                        SinglerealArray1M.AssertModel(models[28],_testData[31], false);
                        SinglerealArray1M.AssertModel(models[29],_testData[32], false);
                        SinglerealArray1M.AssertModel(models[30],_testData[33], false);
                        SinglerealArray1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        SinglerealArray1M.AssertModel(models[0],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[29], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[30], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[31], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[32], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[33], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        SinglerealArray1M.AssertModel(models[0],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[29], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[30], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[31], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[32], false);
                        SinglerealArray1M.AssertModel(models[17],_testData[33], false);
                        SinglerealArray1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

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
                        SinglerealArray1M.AssertModel(models[11],_testData[30], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[31], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[32], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[33], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                await ((ISingleArrayrealArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 90, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[19],_testData[34], false);
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
                await ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 92, query1, 64, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[23],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                 ((ISingleArrayrealArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 32, query1, 64, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
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
                        FlatSinglerealArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[23],_testData[34], false);
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
                 ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 92, query1, 119, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 127, query1, 68, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(models[18],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(models[19],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(models[20],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[21],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[22],_testData[34], false);
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
                await ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 118, query1, 7, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[33],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 89, query1, 118, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

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
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[34], false);
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
                 ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelBatch(connection, 96, query1, 136, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTSelectModelBatchAsync(connection, 61, 136))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        SinglerealArray1M.AssertModel(models[0],_testData[10], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[11], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[12], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[13], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[14], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[17],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[18],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[19],_testData[29], false);
                        SinglerealArray1M.AssertModel(models[20],_testData[30], false);
                        SinglerealArray1M.AssertModel(models[21],_testData[31], false);
                        SinglerealArray1M.AssertModel(models[22],_testData[32], false);
                        SinglerealArray1M.AssertModel(models[23],_testData[33], false);
                        SinglerealArray1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        SinglerealArray1M.AssertModel(models[0],_testData[31], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[32], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[33], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTSelectModelBatch(connection, 25, 94))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        SinglerealArray1M.AssertModel(models[0],_testData[4], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[5], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[6], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[7], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[8], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[9], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[10], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[11], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[12], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[13], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[14], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[17],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[18],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[19],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[20],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[21],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[22],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[23],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[24],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[25],_testData[29], false);
                        SinglerealArray1M.AssertModel(models[26],_testData[30], false);
                        SinglerealArray1M.AssertModel(models[27],_testData[31], false);
                        SinglerealArray1M.AssertModel(models[28],_testData[32], false);
                        SinglerealArray1M.AssertModel(models[29],_testData[33], false);
                        SinglerealArray1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        SinglerealArray1M.AssertModel(models[0],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[29], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[30], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[31], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[32], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[33], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[34], false);
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
                ((ISingleArrayrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 73);
                var models = await ((ISingleArrayrealArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
SinglerealArray1M.AssertModel(models[0],_testData[14], false);SinglerealArray1M.AssertModel(models[1],_testData[15], false);SinglerealArray1M.AssertModel(models[2],_testData[16], false);SinglerealArray1M.AssertModel(models[3],_testData[17], false);SinglerealArray1M.AssertModel(models[4],_testData[18], false);SinglerealArray1M.AssertModel(models[5],_testData[19], false);SinglerealArray1M.AssertModel(models[6],_testData[20], false);SinglerealArray1M.AssertModel(models[7],_testData[21], false);SinglerealArray1M.AssertModel(models[8],_testData[22], false);SinglerealArray1M.AssertModel(models[9],_testData[23], false);SinglerealArray1M.AssertModel(models[10],_testData[24], false);SinglerealArray1M.AssertModel(models[11],_testData[25], false);SinglerealArray1M.AssertModel(models[12],_testData[26], false);SinglerealArray1M.AssertModel(models[13],_testData[27], false);SinglerealArray1M.AssertModel(models[14],_testData[28], false);SinglerealArray1M.AssertModel(models[15],_testData[29], false);SinglerealArray1M.AssertModel(models[16],_testData[30], false);SinglerealArray1M.AssertModel(models[17],_testData[31], false);SinglerealArray1M.AssertModel(models[18],_testData[32], false);SinglerealArray1M.AssertModel(models[19],_testData[33], false);SinglerealArray1M.AssertModel(models[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleArrayrealArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleArrayrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 110);
                var models =  ((ISingleArrayrealArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(10));
SinglerealArray1M.AssertModel(models[0],_testData[25], false);SinglerealArray1M.AssertModel(models[1],_testData[26], false);SinglerealArray1M.AssertModel(models[2],_testData[27], false);SinglerealArray1M.AssertModel(models[3],_testData[28], false);SinglerealArray1M.AssertModel(models[4],_testData[29], false);SinglerealArray1M.AssertModel(models[5],_testData[30], false);SinglerealArray1M.AssertModel(models[6],_testData[31], false);SinglerealArray1M.AssertModel(models[7],_testData[32], false);SinglerealArray1M.AssertModel(models[8],_testData[33], false);SinglerealArray1M.AssertModel(models[9],_testData[34], false);
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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
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

                await ((ISingleArrayrealArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_singlerealarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISingleArrayrealArray)this).DynQueryWASelectImportModelInnerAsync(connection);
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

        [Test, Order(1)]
        public  void DynQueryWAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<SinglerealArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
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

                ((ISingleArrayrealArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_singlerealarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISingleArrayrealArray)this).DynQueryWASelectImportModelInner(connection);
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
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISingleArrayrealArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<SinglerealArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISingleArrayrealArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
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
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void WASelectImportModelInnerConfig()
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ISingleArrayrealArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((ISingleArrayrealArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
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

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<SinglerealArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ISingleArrayrealArray)this).WAImportModelInner(connection, importCollection);
                var models = ((ISingleArrayrealArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
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
            queryMapTypes: [typeof(SinglerealArray1MIWA)],
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(SinglerealArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
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

                await ((ISingleArrayrealArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ISingleArrayrealArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
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

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<SinglerealArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
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

                ((ISingleArrayrealArray)this).ImportModelInner(connection, importCollection);
                var models = ((ISingleArrayrealArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((ISingleArrayrealArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((ISingleArrayrealArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    SinglerealArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((ISingleArrayrealArray)this).ImportModel(connection, importCollection);
                var models = ((ISingleArrayrealArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    SinglerealArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(13)]
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

        [Test, Order(13)]
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
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MIWA)],
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
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleArrayrealArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_singlerealarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((ISingleArrayrealArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_singlerealarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

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

        [Test, Order(13)]
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

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((ISingleArrayrealArray)this).ExportModelInner(connection).ToList();
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

