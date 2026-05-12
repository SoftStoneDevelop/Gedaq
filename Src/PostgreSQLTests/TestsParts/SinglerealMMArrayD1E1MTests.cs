

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
    internal partial interface ISingleMArrayrealMMArrayD1
    {
    }
    
    internal partial class SingleMArrayrealMMArrayD1 : ISingleMArrayrealMMArrayD1
    {


#region TestData

        private readonly SinglerealMMArrayD1E1M[] _testData = new SinglerealMMArrayD1E1M[]
        {
            new SinglerealMMArrayD1E1M
{
    Id = 2,
    Value = 
new System.Single[3]
{
0.5996559f,
0.4622665f,
0.14908987f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.56888825f,
0.92471164f,
0.9614342f,
0.46464878f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 10,
    Value = 
new System.Single[4]
{
0.93272287f,
0.022884548f,
0.080642104f,
0.16768783f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 1,
    Value = 
new System.Single[4]
{
0.8377906f,
0.0408113f,
0.96101445f,
0.08900523f,
},
    NullableValue = 
new System.Single[3]
{
0.4531958f,
0.23829913f,
0.7282029f,
},
},
    NullableValue = 
new System.Single[3]
{
0.9517614f,
0.83589375f,
0.121096015f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 16,
    Value = 
new System.Single[3]
{
0.53930855f,
0.6216769f,
0.17769653f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.2047348f,
0.0111426115f,
0.4311992f,
0.24350226f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 19,
    Value = 
new System.Single[4]
{
0.714586f,
0.090821266f,
0.2577926f,
0.8104001f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 9,
    Value = 
new System.Single[3]
{
0.7533274f,
0.0605132f,
0.8953886f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 25,
    Value = 
new System.Single[3]
{
0.73897225f,
0.6812721f,
0.7954706f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.21035731f,
0.22707611f,
0.48724598f,
0.45265865f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 33,
    Value = 
new System.Single[4]
{
0.24059612f,
0.55397314f,
0.47005808f,
0.7856304f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 12,
    Value = 
new System.Single[4]
{
0.32459003f,
0.58918244f,
0.50389326f,
0.48130602f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 34,
    Value = 
new System.Single[4]
{
0.6703778f,
0.32519287f,
0.36141336f,
0.52938217f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 43,
    Value = 
new System.Single[3]
{
0.6979765f,
0.16652238f,
0.16943759f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 17,
    Value = 
new System.Single[3]
{
0.9705711f,
0.6236663f,
0.84057206f,
},
    NullableValue = 
new System.Single[4]
{
0.6688806f,
0.16026706f,
0.3156041f,
0.50280523f,
},
},
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 50,
    Value = 
new System.Single[4]
{
0.09122151f,
0.56603134f,
0.71076465f,
0.02909273f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.960134f,
0.21981299f,
0.026233613f,
0.62078416f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 57,
    Value = 
new System.Single[3]
{
0.69890296f,
0.7001714f,
0.13210016f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 22,
    Value = 
new System.Single[4]
{
0.45222735f,
0.31027085f,
0.5307994f,
0.52543944f,
},
    NullableValue = 
new System.Single[3]
{
0.9078063f,
0.103061795f,
0.8109268f,
},
},
    NullableValue = 
new System.Single[3]
{
0.4511333f,
0.6666572f,
0.59898806f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 66,
    Value = 
new System.Single[3]
{
0.71490157f,
0.72343343f,
0.83723855f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 75,
    Value = 
new System.Single[4]
{
0.64095354f,
0.2616151f,
0.38540947f,
0.9642278f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 30,
    Value = 
new System.Single[4]
{
0.98146373f,
0.1184625f,
0.98280054f,
0.038588524f,
},
    NullableValue = 
new System.Single[3]
{
0.6806068f,
0.85903984f,
0.9948551f,
},
},
    NullableValue = 
new System.Single[3]
{
0.20914263f,
0.7866544f,
0.6744151f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 83,
    Value = 
new System.Single[4]
{
0.49994892f,
0.33120567f,
0.922814f,
0.047113955f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 88,
    Value = 
new System.Single[3]
{
0.97862846f,
0.08546692f,
0.84222263f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 37,
    Value = 
new System.Single[4]
{
0.42525578f,
0.79535204f,
0.88003063f,
0.016792953f,
},
    NullableValue = 
new System.Single[3]
{
0.19967312f,
0.053625822f,
0.31569272f,
},
},
    NullableValue = 
new System.Single[3]
{
0.45494783f,
0.5770916f,
0.50367606f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 89,
    Value = 
new System.Single[3]
{
0.79123014f,
0.703783f,
0.9989936f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.21199095f,
0.82298034f,
0.16675544f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 92,
    Value = 
new System.Single[3]
{
0.9385824f,
0.6364164f,
0.50741f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 40,
    Value = 
new System.Single[4]
{
0.056755245f,
0.15243375f,
0.8500049f,
0.0731976f,
},
    NullableValue = 
new System.Single[4]
{
0.83369523f,
0.3055271f,
0.93074447f,
0.5760112f,
},
},
    NullableValue = 
new System.Single[4]
{
0.6402973f,
0.6138939f,
0.30782008f,
0.21073109f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 98,
    Value = 
new System.Single[3]
{
0.3060277f,
0.83458596f,
0.9058943f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 105,
    Value = 
new System.Single[4]
{
0.2573809f,
0.19784182f,
0.8787931f,
0.3806175f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 46,
    Value = 
new System.Single[4]
{
0.6632488f,
0.8819378f,
0.17524266f,
0.9436469f,
},
    NullableValue = 
new System.Single[4]
{
0.87516445f,
0.6697847f,
0.9758338f,
0.10190189f,
},
},
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 111,
    Value = 
new System.Single[3]
{
0.74615866f,
0.21344614f,
0.78022754f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 119,
    Value = 
new System.Single[4]
{
0.8127701f,
0.90708f,
0.8937376f,
0.28870654f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 48,
    Value = 
new System.Single[4]
{
0.69015074f,
0.32342494f,
0.030119896f,
0.40326428f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.25423878f,
0.2153858f,
0.7875879f,
0.08661932f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 124,
    Value = 
new System.Single[4]
{
0.67654425f,
0.89193714f,
0.8521128f,
0.75104296f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 133,
    Value = 
new System.Single[3]
{
0.17199963f,
0.8171533f,
0.46735078f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 52,
    Value = 
new System.Single[4]
{
0.32063806f,
0.12533045f,
0.75998056f,
0.8206406f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 137,
    Value = 
new System.Single[3]
{
0.18434584f,
0.41364324f,
0.179995f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 145,
    Value = 
new System.Single[4]
{
0.44222677f,
0.2509697f,
0.38231677f,
0.52566904f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 54,
    Value = 
new System.Single[3]
{
0.6938826f,
0.656602f,
0.65453017f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[3]
{
0.54609793f,
0.6868448f,
0.5617924f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 151,
    Value = 
new System.Single[4]
{
0.24430615f,
0.252577f,
0.49098563f,
0.40789413f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.78043014f,
0.8444026f,
0.3782102f,
0.32772815f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 152,
    Value = 
new System.Single[4]
{
0.29564458f,
0.91103905f,
0.4742124f,
0.5693251f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 62,
    Value = 
new System.Single[3]
{
0.11564833f,
0.121897876f,
0.70789176f,
},
    NullableValue = 
new System.Single[3]
{
0.8413186f,
0.07626903f,
0.19663376f,
},
},
    NullableValue = 
new System.Single[3]
{
0.45643592f,
0.026738226f,
0.10201675f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 160,
    Value = 
new System.Single[4]
{
0.76954645f,
0.29404724f,
0.4724853f,
0.82307833f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 168,
    Value = 
new System.Single[3]
{
0.10486221f,
0.36929476f,
0.07556689f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 65,
    Value = 
new System.Single[3]
{
0.42815882f,
0.8899659f,
0.46136588f,
},
    NullableValue = 
new System.Single[3]
{
0.73040915f,
0.9022545f,
0.13411683f,
},
},
    NullableValue = 
new System.Single[4]
{
0.99205214f,
0.44277924f,
0.92181826f,
0.4421684f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 169,
    Value = 
new System.Single[3]
{
0.40407997f,
0.6559366f,
0.34953195f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.8828587f,
0.82979596f,
0.41134953f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 170,
    Value = 
new System.Single[3]
{
0.5409413f,
0.32300436f,
0.3220135f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 69,
    Value = 
new System.Single[3]
{
0.75242f,
0.72796965f,
0.6787379f,
},
    NullableValue = 
new System.Single[3]
{
0.77492815f,
0.4920017f,
0.108244f,
},
},
    NullableValue = 
new System.Single[3]
{
0.023099065f,
0.8110714f,
0.101760864f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 179,
    Value = 
new System.Single[4]
{
0.92107975f,
0.64481336f,
0.1692416f,
0.71920794f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 187,
    Value = 
new System.Single[4]
{
0.9377543f,
0.93429697f,
0.09945029f,
0.24124771f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 78,
    Value = 
new System.Single[3]
{
0.10063338f,
0.62746936f,
0.6002363f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.71776074f,
0.91336226f,
0.014341176f,
0.8538672f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 196,
    Value = 
new System.Single[4]
{
0.8682437f,
0.68337965f,
0.81064874f,
0.7051727f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 200,
    Value = 
new System.Single[4]
{
0.7359312f,
0.72117263f,
0.10970515f,
0.4281863f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 85,
    Value = 
new System.Single[4]
{
0.23352271f,
0.039120913f,
0.441804f,
0.9603217f,
},
    NullableValue = 
new System.Single[4]
{
0.67996055f,
0.37574857f,
0.2583261f,
0.30750316f,
},
},
    NullableValue = 
new System.Single[4]
{
0.046583533f,
0.36561692f,
0.5547125f,
0.42683953f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 201,
    Value = 
new System.Single[3]
{
0.7845168f,
0.9950384f,
0.6736883f,
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealmmarrayd1e1mi(
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1)),
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
INSERT INTO public.singlerealmmarrayd1e1mi(
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
            queryMapTypes: [typeof(SinglerealMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1)),
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

                changedRows =  ((ISingleMArrayrealMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISingleMArrayrealMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ISingleMArrayrealMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleMArrayrealMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ISingleMArrayrealMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ISingleMArrayrealMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ISingleMArrayrealMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ISingleMArrayrealMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((ISingleMArrayrealMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((ISingleMArrayrealMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((ISingleMArrayrealMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((ISingleMArrayrealMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((ISingleMArrayrealMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((ISingleMArrayrealMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((ISingleMArrayrealMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((ISingleMArrayrealMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((ISingleMArrayrealMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    singlerealmmarrayd1e1mi_id
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1)), 
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
                methodParametrName: "singlerealmmarrayd1e1mi_id", 
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
                changedRows =  ((ISingleMArrayrealMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ISingleMArrayrealMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ISingleMArrayrealMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ISingleMArrayrealMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    singlerealmmarrayd1e1mi_id
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
    singlerealmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(SinglerealMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1)),
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

                    nullable =  ((ISingleMArrayrealMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[4]
{
0.21035731f,
0.22707611f,
0.48724598f,
0.45265865f,
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

                    nullable =  ((ISingleMArrayrealMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable = await ((ISingleMArrayrealMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
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

                    nullable = await ((ISingleMArrayrealMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    singlerealmmarrayd1e1mi_id
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
    singlerealmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(SinglerealMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1)),
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
                methodParametrName: "singlerealmmarrayd1e1mi_id", 
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
                nullable =  ((ISingleMArrayrealMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[4]
{
0.960134f,
0.21981299f,
0.026233613f,
0.62078416f,
}));
                nullable =  ((ISingleMArrayrealMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[3]
{
0.4511333f,
0.6666572f,
0.59898806f,
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
                nullable = await ((ISingleMArrayrealMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((ISingleMArrayrealMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[3]
{
0.20914263f,
0.7866544f,
0.6744151f,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<SinglerealMMArrayD1E1M> models = null;

                models =  ((ISingleMArrayrealMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((ISingleMArrayrealMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((ISingleMArrayrealMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((ISingleMArrayrealMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<SinglerealMMArrayD1E1M> models = null;

                models = await ((ISingleMArrayrealMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((ISingleMArrayrealMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((ISingleMArrayrealMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((ISingleMArrayrealMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((ISingleMArrayrealMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((ISingleMArrayrealMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((ISingleMArrayrealMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((ISingleMArrayrealMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((ISingleMArrayrealMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((ISingleMArrayrealMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((ISingleMArrayrealMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((ISingleMArrayrealMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((ISingleMArrayrealMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((ISingleMArrayrealMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((ISingleMArrayrealMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((ISingleMArrayrealMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((ISingleMArrayrealMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((ISingleMArrayrealMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((ISingleMArrayrealMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealMMArrayD1E1M), typeof(FlatSinglerealMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1)),
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
FROM public.singlerealmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSinglerealMMArrayD1E1M>();
                var models2 = new List<FlatSinglerealMMArrayD1E1M>();
                await ((ISingleMArrayrealMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSinglerealMMArrayD1E1M>();
                var models2 = new List<FlatSinglerealMMArrayD1E1M>();
                ((ISingleMArrayrealMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1)),
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
FROM public.singlerealmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ISingleMArrayrealMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ISingleMArrayrealMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealmmarrayd1e1m m
LEFT JOIN public.singlerealmmarrayd1e1mi mi ON mi.id = m.singlerealmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(SinglerealMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1)),
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
                var models = await ((ISingleMArrayrealMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ISingleMArrayrealMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealMMArrayD1E1M), typeof(FlatSinglerealMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1)),
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
FROM public.singlerealmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealMMArrayD1E1M>();
                var models2 = new List<FlatSinglerealMMArrayD1E1M>();
                await ((ISingleMArrayrealMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealMMArrayD1E1M>();
                var models2 = new List<FlatSinglerealMMArrayD1E1M>();
                ((ISingleMArrayrealMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1)),
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
FROM public.singlerealmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ISingleMArrayrealMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ISingleMArrayrealMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealmmarrayd1e1m m
LEFT JOIN public.singlerealmmarrayd1e1mi mi ON mi.id = m.singlerealmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(SinglerealMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1)),
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
                var models = await ((ISingleMArrayrealMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ISingleMArrayrealMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealMMArrayD1E1M), typeof(FlatSinglerealMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1)),
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1)),
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
FROM public.singlerealmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglerealMMArrayD1E1M>();
                var models2 = new List<FlatSinglerealMMArrayD1E1M>();
                await((ISingleMArrayrealMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
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
FROM public.singlerealmmarrayd1e1m m
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
FROM public.singlerealmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD1E1M>();
                var firstItems2 = new List<FlatSinglerealMMArrayD1E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD1E1M>();
                var secondItems2 = new List<FlatSinglerealMMArrayD1E1M>();
                await ((ISingleMArrayrealMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 170;
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
FROM public.singlerealmmarrayd1e1m m
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
FROM public.singlerealmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD1E1M>();
                var firstItems2 = new List<FlatSinglerealMMArrayD1E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD1E1M>();
                await ((ISingleMArrayrealMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[4],_testData[34], false);
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
FROM public.singlerealmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglerealMMArrayD1E1M>();
                var models2 = new List<FlatSinglerealMMArrayD1E1M>();
                ((ISingleMArrayrealMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
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
FROM public.singlerealmmarrayd1e1m m
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
FROM public.singlerealmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD1E1M>();
                var firstItems2 = new List<FlatSinglerealMMArrayD1E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD1E1M>();
                var secondItems2 = new List<FlatSinglerealMMArrayD1E1M>();
                 ((ISingleMArrayrealMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
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
FROM public.singlerealmmarrayd1e1m m
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
FROM public.singlerealmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD1E1M>();
                var firstItems2 = new List<FlatSinglerealMMArrayD1E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD1E1M>();
                 ((ISingleMArrayrealMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1)),
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1)),
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
FROM public.singlerealmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ISingleMArrayrealMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 196;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealmmarrayd1e1m m
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
FROM public.singlerealmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleMArrayrealMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatSinglerealMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatSinglerealMMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealmmarrayd1e1m m
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
FROM public.singlerealmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD1E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD1E1M>();
                var secondItems2 = new List<FlatSinglerealMMArrayD1E1M>();
                await ((ISingleMArrayrealMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.singlerealmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ISingleMArrayrealMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealmmarrayd1e1m m
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
FROM public.singlerealmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleMArrayrealMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatSinglerealMMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatSinglerealMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealmmarrayd1e1m m
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
FROM public.singlerealmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD1E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD1E1M>();
                var secondItems2 = new List<FlatSinglerealMMArrayD1E1M>();
                 ((ISingleMArrayrealMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.singlerealmmarrayd1e1m m
LEFT JOIN public.singlerealmmarrayd1e1mi mi ON mi.id = m.singlerealmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(SinglerealMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1)),
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
                var models = await((ISingleMArrayrealMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 2;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleMArrayrealMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
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
                var models = ((ISingleMArrayrealMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleMArrayrealMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealMMArrayD1E1M), typeof(FlatSinglerealMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1)),
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1)),
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1)),
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
FROM public.singlerealmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealMMArrayD1E1M>();
                var models2 = new List<FlatSinglerealMMArrayD1E1M>();
                await((ISingleMArrayrealMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealmmarrayd1e1m m
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
FROM public.singlerealmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD1E1M>();
                var firstItems2 = new List<FlatSinglerealMMArrayD1E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD1E1M>();
                var secondItems2 = new List<FlatSinglerealMMArrayD1E1M>();
                await ((ISingleMArrayrealMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 33, query1, 160, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.singlerealmmarrayd1e1m m
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
FROM public.singlerealmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD1E1M>();
                var firstItems2 = new List<FlatSinglerealMMArrayD1E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD1E1M>();
                await ((ISingleMArrayrealMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 10, query1, 98, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[17],_testData[34], false);
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
FROM public.singlerealmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealMMArrayD1E1M>();
                var models2 = new List<FlatSinglerealMMArrayD1E1M>();
                ((ISingleMArrayrealMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealmmarrayd1e1m m
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
FROM public.singlerealmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD1E1M>();
                var firstItems2 = new List<FlatSinglerealMMArrayD1E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD1E1M>();
                var secondItems2 = new List<FlatSinglerealMMArrayD1E1M>();
                 ((ISingleMArrayrealMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 16, query1, 75, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.singlerealmmarrayd1e1m m
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
FROM public.singlerealmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD1E1M>();
                var firstItems2 = new List<FlatSinglerealMMArrayD1E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD1E1M>();
                 ((ISingleMArrayrealMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 151, query1, 133, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1)),
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1)),
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1)),
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
FROM public.singlerealmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ISingleMArrayrealMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealmmarrayd1e1m m
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
FROM public.singlerealmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleMArrayrealMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 170, query1, 16, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatSinglerealMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatSinglerealMMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[31],_testData[34], false);
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
FROM public.singlerealmmarrayd1e1m m
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
FROM public.singlerealmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD1E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD1E1M>();
                var secondItems2 = new List<FlatSinglerealMMArrayD1E1M>();
                await ((ISingleMArrayrealMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 168, query1, 34, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.singlerealmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ISingleMArrayrealMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealmmarrayd1e1m m
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
FROM public.singlerealmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleMArrayrealMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 196, query1, 89, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatSinglerealMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatSinglerealMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
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
FROM public.singlerealmmarrayd1e1m m
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
FROM public.singlerealmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD1E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD1E1M>();
                var secondItems2 = new List<FlatSinglerealMMArrayD1E1M>();
                 ((ISingleMArrayrealMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 196, query1, 160, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.singlerealmmarrayd1e1m m
LEFT JOIN public.singlerealmmarrayd1e1mi mi ON mi.id = m.singlerealmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(SinglerealMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1)),
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1)),
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
                var models = await((ISingleMArrayrealMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ISingleMArrayrealMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 152, 43))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
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
                var models = ((ISingleMArrayrealMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ISingleMArrayrealMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 92, 50))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
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
                await using var cmd = await ((ISingleMArrayrealMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ISingleMArrayrealMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 105);
                var models = await ((ISingleMArrayrealMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                SinglerealMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                SinglerealMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                SinglerealMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                SinglerealMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                SinglerealMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                SinglerealMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                SinglerealMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                SinglerealMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                SinglerealMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                SinglerealMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                SinglerealMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                SinglerealMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                SinglerealMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                SinglerealMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                SinglerealMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                SinglerealMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleMArrayrealMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleMArrayrealMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 169);
                var models =  ((ISingleMArrayrealMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(6));

                SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                SinglerealMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                SinglerealMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                SinglerealMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                SinglerealMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                SinglerealMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
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
FROM public.binary_singlerealmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(SinglerealMMArrayD1E1MIWA),
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISingleMArrayrealMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_singlerealmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISingleMArrayrealMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISingleMArrayrealMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_singlerealmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISingleMArrayrealMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_singlerealmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(SinglerealMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISingleMArrayrealMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_singlerealmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISingleMArrayrealMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISingleMArrayrealMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_singlerealmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISingleMArrayrealMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_singlerealmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlerealmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(SinglerealMMArrayD1E1MI),
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ISingleMArrayrealMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((ISingleMArrayrealMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ISingleMArrayrealMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((ISingleMArrayrealMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_singlerealmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlerealmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(SinglerealMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISingleMArrayrealMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ISingleMArrayrealMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISingleMArrayrealMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((ISingleMArrayrealMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlerealmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
singlerealmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(SinglerealMMArrayD1E1M),
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1))]
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
FROM public.binary_singlerealmmarrayd1e1m m
LEFT JOIN public.binary_singlerealmmarrayd1e1mi mi ON mi.id = m.singlerealmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(SinglerealMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((ISingleMArrayrealMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((ISingleMArrayrealMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    SinglerealMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((ISingleMArrayrealMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((ISingleMArrayrealMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    SinglerealMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    singlerealmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(SinglerealMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1)),
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
                var models =  ((ISingleMArrayrealMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SinglerealMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleMArrayrealMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SinglerealMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD1E1MIWA), typeof(SinglerealMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1)),
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
                var models1 = new List<SinglerealMMArrayD1E1MIWA>();
                var models2 = new List<SinglerealMMArrayD1E1MIWA>();
                await ((ISingleMArrayrealMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealMMArrayD1E1MIWA>();
                var models2 = new List<SinglerealMMArrayD1E1MIWA>();
                ((ISingleMArrayrealMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1)),
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
                var models = await ((ISingleMArrayrealMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_singlerealmmarrayd1e1mi
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
                    SinglerealMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleMArrayrealMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_singlerealmmarrayd1e1mi
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
                    SinglerealMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD1E1MIWA), typeof(SinglerealMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1))]
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
                var models1 = new List<SinglerealMMArrayD1E1MIWA>();
                var models2 = new List<SinglerealMMArrayD1E1MIWA>();
                await ((ISingleMArrayrealMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealMMArrayD1E1MIWA>();
                var models2 = new List<SinglerealMMArrayD1E1MIWA>();
                ((ISingleMArrayrealMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1))]
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
                var models = await ((ISingleMArrayrealMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_singlerealmmarrayd1e1mi
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
                    SinglerealMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleMArrayrealMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_singlerealmmarrayd1e1mi
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
                    SinglerealMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_singlerealmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD1E1MI), typeof(SinglerealMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1)),
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
                var models1 = new List<SinglerealMMArrayD1E1MI>();
                var models2 = new List<SinglerealMMArrayD1E1MI>();
                await ((ISingleMArrayrealMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealMMArrayD1E1MI>();
                var models2 = new List<SinglerealMMArrayD1E1MI>();
                ((ISingleMArrayrealMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1)),
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
                var models = await ((ISingleMArrayrealMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleMArrayrealMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_singlerealmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD1E1MIWA), typeof(SinglerealMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1))]
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
                var models1 = new List<SinglerealMMArrayD1E1MIWA>();
                var models2 = new List<SinglerealMMArrayD1E1MIWA>();
                await ((ISingleMArrayrealMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealMMArrayD1E1MIWA>();
                var models2 = new List<SinglerealMMArrayD1E1MIWA>();
                ((ISingleMArrayrealMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD1))]
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
                var models = await ((ISingleMArrayrealMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleMArrayrealMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

