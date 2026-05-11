

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
    Id = 1,
    Value = 
new System.Single[4]
{
0.12664938f,
0.20039392f,
0.21836835f,
0.6774031f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.07761347f,
0.70467913f,
0.64028066f,
0.9576041f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 4,
    Value = 
new System.Single[3]
{
0.9780279f,
0.66962934f,
0.6449452f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 7,
    Value = 
new System.Single[4]
{
0.32669604f,
0.6662979f,
0.4915765f,
0.9249528f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.17269361f,
0.48759156f,
0.28327978f,
0.42548358f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 5,
    Value = 
new System.Single[4]
{
0.86451423f,
0.29335612f,
0.50976974f,
0.6233968f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.905385f,
0.2705757f,
0.7800173f,
0.84013f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 8,
    Value = 
new System.Single[4]
{
0.6115859f,
0.26381344f,
0.031077802f,
0.6809336f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 13,
    Value = 
new System.Single[4]
{
0.47426885f,
0.5899014f,
0.55502135f,
0.13818091f,
},
    NullableValue = 
new System.Single[4]
{
0.5307498f,
0.041661084f,
0.5763673f,
0.98556256f,
},
},
    NullableValue = 
new System.Single[4]
{
0.12765062f,
0.1156767f,
0.042368293f,
0.68918693f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 11,
    Value = 
new System.Single[3]
{
0.31878996f,
0.5444286f,
0.681623f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.19879788f,
0.13547504f,
0.9374967f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 19,
    Value = 
new System.Single[4]
{
0.7670178f,
0.04799503f,
0.3894227f,
0.4458186f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 17,
    Value = 
new System.Single[4]
{
0.2642963f,
0.18032211f,
0.8228422f,
0.08201569f,
},
    NullableValue = 
new System.Single[4]
{
0.6036083f,
0.6999092f,
0.8470181f,
0.3353572f,
},
},
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 22,
    Value = 
new System.Single[3]
{
0.010172427f,
0.9484111f,
0.7140762f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.11715984f,
0.80801445f,
0.6991023f,
0.25124484f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 31,
    Value = 
new System.Single[4]
{
0.12502557f,
0.36034f,
0.59968245f,
0.9686479f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 19,
    Value = 
new System.Single[3]
{
0.78698933f,
0.3480646f,
0.47382486f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[3]
{
0.28885007f,
0.43131375f,
0.7181502f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 37,
    Value = 
new System.Single[4]
{
0.41957515f,
0.58577985f,
0.7285437f,
0.6446234f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.4618644f,
0.07524133f,
0.8948814f,
0.69955546f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 46,
    Value = 
new System.Single[4]
{
0.62437016f,
0.2989629f,
0.8028138f,
0.4685622f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 25,
    Value = 
new System.Single[3]
{
0.81512016f,
0.9940163f,
0.53606725f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 53,
    Value = 
new System.Single[4]
{
0.933347f,
0.8780969f,
0.17190963f,
0.4896834f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 60,
    Value = 
new System.Single[3]
{
0.47715253f,
0.20201313f,
0.27481216f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 31,
    Value = 
new System.Single[3]
{
0.8893778f,
0.96989745f,
0.95941097f,
},
    NullableValue = 
new System.Single[3]
{
0.31810594f,
0.653584f,
0.25389582f,
},
},
    NullableValue = 
new System.Single[4]
{
0.54583526f,
0.3203588f,
0.26417065f,
0.07952416f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 62,
    Value = 
new System.Single[3]
{
0.920591f,
0.51427054f,
0.8393933f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 64,
    Value = 
new System.Single[4]
{
0.004562497f,
0.074118435f,
0.9331706f,
0.82798123f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 32,
    Value = 
new System.Single[3]
{
0.6713688f,
0.22232479f,
0.23714662f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.13462484f,
0.8999503f,
0.00023508072f,
0.5189375f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 66,
    Value = 
new System.Single[3]
{
0.23556429f,
0.6055182f,
0.44247627f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.51268655f,
0.010897815f,
0.43532008f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 67,
    Value = 
new System.Single[4]
{
0.6492679f,
0.66393864f,
0.07978964f,
0.91321373f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 36,
    Value = 
new System.Single[3]
{
0.32792348f,
0.66672134f,
0.21466136f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.6648184f,
0.11977643f,
0.3630461f,
0.11150581f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 76,
    Value = 
new System.Single[3]
{
0.44952095f,
0.14428711f,
0.28700233f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 78,
    Value = 
new System.Single[3]
{
0.97522295f,
0.2882803f,
0.059049785f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 38,
    Value = 
new System.Single[4]
{
0.19536471f,
0.6604387f,
0.80614334f,
0.3566541f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 82,
    Value = 
new System.Single[4]
{
0.07831055f,
0.21768528f,
0.810036f,
0.8907505f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 86,
    Value = 
new System.Single[4]
{
0.58948034f,
0.59554815f,
0.83163434f,
0.91826063f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 47,
    Value = 
new System.Single[4]
{
0.48722613f,
0.21891439f,
0.20721513f,
0.04052317f,
},
    NullableValue = 
new System.Single[3]
{
0.55090857f,
0.5271211f,
0.3646161f,
},
},
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 90,
    Value = 
new System.Single[4]
{
0.06639397f,
0.47014922f,
0.35461116f,
0.53383136f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.2649315f,
0.76677465f,
0.045196652f,
0.40346837f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 98,
    Value = 
new System.Single[4]
{
0.53321147f,
0.6277103f,
0.11074817f,
0.5131135f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 54,
    Value = 
new System.Single[3]
{
0.7027515f,
0.51566f,
0.56666595f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.04663664f,
0.6796444f,
0.99334645f,
0.2121656f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 105,
    Value = 
new System.Single[3]
{
0.87699014f,
0.19489038f,
0.3149194f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 111,
    Value = 
new System.Single[4]
{
0.6663141f,
0.993412f,
0.0031993985f,
0.70169204f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 58,
    Value = 
new System.Single[3]
{
0.10373008f,
0.018628955f,
0.12075579f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 120,
    Value = 
new System.Single[3]
{
0.42762792f,
0.3031264f,
0.9973625f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 122,
    Value = 
new System.Single[3]
{
0.42760485f,
0.8583947f,
0.3298452f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 65,
    Value = 
new System.Single[4]
{
0.93214464f,
0.9156765f,
0.9719872f,
0.72359896f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.46362007f,
0.20094317f,
0.31421173f,
0.99409914f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 128,
    Value = 
new System.Single[3]
{
0.16956931f,
0.48755395f,
0.33241117f,
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
0.7021741f,
0.16847807f,
0.05131823f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 73,
    Value = 
new System.Single[4]
{
0.7195414f,
0.54578876f,
0.13581407f,
0.59588605f,
},
    NullableValue = 
new System.Single[4]
{
0.38632715f,
0.6483745f,
0.60889274f,
0.5460912f,
},
},
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 134,
    Value = 
new System.Single[3]
{
0.8750997f,
0.94143087f,
0.9330055f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.24381477f,
0.047275364f,
0.4551682f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 141,
    Value = 
new System.Single[3]
{
0.28704786f,
0.75994134f,
0.0397982f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 77,
    Value = 
new System.Single[3]
{
0.3616786f,
0.4448976f,
0.48258668f,
},
    NullableValue = 
new System.Single[4]
{
0.34720147f,
0.17815244f,
0.72036403f,
0.89279026f,
},
},
    NullableValue = 
new System.Single[4]
{
0.49528885f,
0.8053961f,
0.9220514f,
0.19833827f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 150,
    Value = 
new System.Single[4]
{
0.89183146f,
0.4741587f,
0.5954972f,
0.66592395f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.8953745f,
0.04630786f,
0.11382425f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 156,
    Value = 
new System.Single[4]
{
0.9266488f,
0.45834762f,
0.14266562f,
0.08131051f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 83,
    Value = 
new System.Single[3]
{
0.6823323f,
0.049556553f,
0.82355636f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 159,
    Value = 
new System.Single[4]
{
0.55268496f,
0.61412203f,
0.00059324503f,
0.46657765f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 163,
    Value = 
new System.Single[3]
{
0.32053447f,
0.20264882f,
0.19271207f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 91,
    Value = 
new System.Single[4]
{
0.5222692f,
0.61072385f,
0.24586517f,
0.82904047f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[3]
{
0.205446f,
0.8894347f,
0.6508653f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 167,
    Value = 
new System.Single[3]
{
0.3717211f,
0.37793553f,
0.13217986f,
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
new System.Single[3]
{
0.19879788f,
0.13547504f,
0.9374967f,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[4]
{
0.11715984f,
0.80801445f,
0.6991023f,
0.25124484f,
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

                    nullable = await ((ISingleMArrayrealMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[3]
{
0.28885007f,
0.43131375f,
0.7181502f,
}));
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
0.4618644f,
0.07524133f,
0.8948814f,
0.69955546f,
}));
                nullable =  ((ISingleMArrayrealMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
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
                nullable = await ((ISingleMArrayrealMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((ISingleMArrayrealMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[4]
{
0.54583526f,
0.3203588f,
0.26417065f,
0.07952416f,
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 156;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[5],_testData[34], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 1;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[33],_testData[34], false);
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
                parametr2.Value = 11;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[29],_testData[34], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
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
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatSinglerealMMArrayD1E1M.AssertModel(models[0],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[1],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[2],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[3],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[4],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[5],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[6],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[7],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[8],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[9],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[10],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[11],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[12],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[13],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[14],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[15],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[16],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatSinglerealMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[17],_testData[34], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 159;
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
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatSinglerealMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatSinglerealMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleMArrayrealMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 156;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleMArrayrealMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
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
                await ((ISingleMArrayrealMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 156, query1, 5, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[31],_testData[34], false);
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
                await ((ISingleMArrayrealMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 60, query1, 46, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[24],_testData[34], false);
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
                 ((ISingleMArrayrealMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 78, query1, 156, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[2],_testData[34], false);
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
                 ((ISingleMArrayrealMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 141, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
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
                foreach(var batchResult in await ((ISingleMArrayrealMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 37, query1, 11, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatSinglerealMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatSinglerealMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
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
                await ((ISingleMArrayrealMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 19, query1, 90, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[28],_testData[34], false);
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
                foreach(var batchResult in  ((ISingleMArrayrealMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 8, query1, 66, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatSinglerealMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
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
                 ((ISingleMArrayrealMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 62, query1, 150, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[3],_testData[34], false);
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
                foreach(var batchResult in await ((ISingleMArrayrealMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 90, 111))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
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
                foreach(var batchResult in  ((ISingleMArrayrealMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 8, 122))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                ((ISingleMArrayrealMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 8);
                var models = await ((ISingleMArrayrealMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(31));

                SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                SinglerealMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                SinglerealMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                SinglerealMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                SinglerealMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                SinglerealMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                SinglerealMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                SinglerealMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                SinglerealMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                SinglerealMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                SinglerealMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                SinglerealMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                SinglerealMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                SinglerealMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                SinglerealMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                SinglerealMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                SinglerealMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                SinglerealMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                SinglerealMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                SinglerealMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                SinglerealMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                SinglerealMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                SinglerealMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                SinglerealMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                SinglerealMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                SinglerealMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                SinglerealMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                SinglerealMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                SinglerealMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                SinglerealMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                SinglerealMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleMArrayrealMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleMArrayrealMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 11);
                var models =  ((ISingleMArrayrealMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

                SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                SinglerealMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                SinglerealMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                SinglerealMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                SinglerealMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                SinglerealMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                SinglerealMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                SinglerealMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                SinglerealMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                SinglerealMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                SinglerealMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                SinglerealMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                SinglerealMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                SinglerealMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                SinglerealMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                SinglerealMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                SinglerealMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                SinglerealMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                SinglerealMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                SinglerealMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                SinglerealMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                SinglerealMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                SinglerealMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                SinglerealMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                SinglerealMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                SinglerealMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                SinglerealMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                SinglerealMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                SinglerealMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                SinglerealMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
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

