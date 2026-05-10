

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
    Id = 4,
    Value = 
new System.Single[4]
{
0.91075826f,
0.39361018f,
0.32790416f,
0.12929988f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.7799929f,
0.053515077f,
0.46149307f,
},
},
            new SinglerealArray1M
{
    Id = 5,
    Value = 
new System.Single[3]
{
0.18812084f,
0.9315798f,
0.6074353f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 6,
    Value = 
new System.Single[3]
{
0.9294303f,
0.92753404f,
0.92709905f,
},
    NullableValue = 
new System.Single[4]
{
0.9152837f,
0.3147683f,
0.6120216f,
0.7366592f,
},
},
    NullableValue = 
new System.Single[3]
{
0.9731588f,
0.4434029f,
0.50693315f,
},
},
            new SinglerealArray1M
{
    Id = 11,
    Value = 
new System.Single[3]
{
0.094284534f,
0.47450233f,
0.39549488f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.43230045f,
0.5739362f,
0.5914365f,
0.5510315f,
},
},
            new SinglerealArray1M
{
    Id = 16,
    Value = 
new System.Single[3]
{
0.105802536f,
0.24559301f,
0.69584435f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 7,
    Value = 
new System.Single[3]
{
0.961274f,
0.6346539f,
0.7516147f,
},
    NullableValue = 
new System.Single[3]
{
0.5312808f,
0.42563772f,
0.9384824f,
},
},
    NullableValue = 
new System.Single[4]
{
0.64786315f,
0.22441185f,
0.83448875f,
0.55606455f,
},
},
            new SinglerealArray1M
{
    Id = 23,
    Value = 
new System.Single[4]
{
0.46160078f,
0.19498718f,
0.95041466f,
0.97963965f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 31,
    Value = 
new System.Single[4]
{
0.13460314f,
0.97204113f,
0.44987762f,
0.16337347f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 16,
    Value = 
new System.Single[3]
{
0.05653715f,
0.19094223f,
0.30982316f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 39,
    Value = 
new System.Single[3]
{
0.95292014f,
0.88745904f,
0.22881275f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.30653572f,
0.9369464f,
0.20346552f,
},
},
            new SinglerealArray1M
{
    Id = 47,
    Value = 
new System.Single[3]
{
0.85966724f,
0.70355946f,
0.65648323f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 22,
    Value = 
new System.Single[4]
{
0.17370713f,
0.29694712f,
0.3236091f,
0.06569904f,
},
    NullableValue = 
new System.Single[4]
{
0.04769504f,
0.022231102f,
0.76327443f,
0.9850365f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 51,
    Value = 
new System.Single[4]
{
0.9171925f,
0.75351447f,
0.024986684f,
0.6046983f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 56,
    Value = 
new System.Single[3]
{
0.90992326f,
0.72644293f,
0.030744016f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 29,
    Value = 
new System.Single[3]
{
0.13340586f,
0.40732187f,
0.70541316f,
},
    NullableValue = 
new System.Single[3]
{
0.10710603f,
0.7470707f,
0.43227434f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 65,
    Value = 
new System.Single[4]
{
0.7166023f,
0.3197562f,
0.36479837f,
0.33478725f,
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
0.32803982f,
0.560729f,
0.28424525f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 34,
    Value = 
new System.Single[3]
{
0.24682176f,
0.9802085f,
0.45915347f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[3]
{
0.5873283f,
0.12565607f,
0.2912137f,
},
},
            new SinglerealArray1M
{
    Id = 79,
    Value = 
new System.Single[3]
{
0.03663826f,
0.9405454f,
0.20678014f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.44206315f,
0.2676075f,
0.23170948f,
0.27370262f,
},
},
            new SinglerealArray1M
{
    Id = 82,
    Value = 
new System.Single[4]
{
0.20462978f,
0.8020173f,
0.51505935f,
0.8863014f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 40,
    Value = 
new System.Single[4]
{
0.25135761f,
0.17449492f,
0.67578435f,
0.40786612f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.28462112f,
0.61392957f,
0.47997504f,
0.24431205f,
},
},
            new SinglerealArray1M
{
    Id = 88,
    Value = 
new System.Single[4]
{
0.71710616f,
0.06976718f,
0.2867282f,
0.29569018f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.13713568f,
0.831016f,
0.09706658f,
},
},
            new SinglerealArray1M
{
    Id = 92,
    Value = 
new System.Single[3]
{
0.25559556f,
0.7858252f,
0.52670985f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 44,
    Value = 
new System.Single[3]
{
0.9810652f,
0.43449873f,
0.9616981f,
},
    NullableValue = 
new System.Single[4]
{
0.46680754f,
0.49830902f,
0.9534246f,
0.057142854f,
},
},
    NullableValue = 
new System.Single[4]
{
0.5371781f,
0.0041409135f,
0.33304244f,
0.5742067f,
},
},
            new SinglerealArray1M
{
    Id = 100,
    Value = 
new System.Single[3]
{
0.9839449f,
0.5474128f,
0.33426207f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 108,
    Value = 
new System.Single[3]
{
0.9553826f,
0.79155827f,
0.16015267f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 52,
    Value = 
new System.Single[3]
{
0.43348593f,
0.85770136f,
0.2623183f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 109,
    Value = 
new System.Single[3]
{
0.84907544f,
0.45203513f,
0.70140463f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 113,
    Value = 
new System.Single[4]
{
0.63119394f,
0.1320883f,
0.5777233f,
0.24754757f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 55,
    Value = 
new System.Single[3]
{
0.40323824f,
0.7731411f,
0.56303066f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.7359133f,
0.5215548f,
0.5578746f,
0.2707001f,
},
},
            new SinglerealArray1M
{
    Id = 122,
    Value = 
new System.Single[4]
{
0.64919305f,
0.04848826f,
0.58902323f,
0.380521f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.33504122f,
0.37362546f,
0.45222002f,
},
},
            new SinglerealArray1M
{
    Id = 131,
    Value = 
new System.Single[3]
{
0.14490068f,
0.36218452f,
0.691347f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 56,
    Value = 
new System.Single[4]
{
0.56068194f,
0.42840862f,
0.90527713f,
0.7891338f,
},
    NullableValue = 
new System.Single[4]
{
0.0054284334f,
0.14872271f,
0.68435884f,
0.79119664f,
},
},
    NullableValue = 
new System.Single[4]
{
0.59073484f,
0.45819765f,
0.4678712f,
0.58632076f,
},
},
            new SinglerealArray1M
{
    Id = 133,
    Value = 
new System.Single[3]
{
0.6928408f,
0.7114981f,
0.13723534f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 141,
    Value = 
new System.Single[3]
{
0.5044625f,
0.6130819f,
0.59420085f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 65,
    Value = 
new System.Single[4]
{
0.4324547f,
0.5605371f,
0.8344643f,
0.42382854f,
},
    NullableValue = 
new System.Single[4]
{
0.8722744f,
0.5900891f,
0.20443451f,
0.64304674f,
},
},
    NullableValue = 
new System.Single[3]
{
0.75831264f,
0.85593307f,
0.86863333f,
},
},
            new SinglerealArray1M
{
    Id = 147,
    Value = 
new System.Single[3]
{
0.001440227f,
0.87089777f,
0.093642175f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.5880605f,
0.6096361f,
0.6645745f,
0.08659172f,
},
},
            new SinglerealArray1M
{
    Id = 149,
    Value = 
new System.Single[4]
{
0.30677205f,
0.32148534f,
0.49165446f,
0.074986815f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 72,
    Value = 
new System.Single[3]
{
0.18147248f,
0.3370955f,
0.9471744f,
},
    NullableValue = 
new System.Single[3]
{
0.90154296f,
0.66704035f,
0.22994345f,
},
},
    NullableValue = 
new System.Single[4]
{
0.57814544f,
0.11403382f,
0.50215065f,
0.6735032f,
},
},
            new SinglerealArray1M
{
    Id = 156,
    Value = 
new System.Single[4]
{
0.9538653f,
0.9366127f,
0.8179131f,
0.2027719f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 161,
    Value = 
new System.Single[4]
{
0.23428214f,
0.5873458f,
0.8422887f,
0.21481502f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 80,
    Value = 
new System.Single[4]
{
0.49725997f,
0.45589358f,
0.32196313f,
0.3268875f,
},
    NullableValue = 
new System.Single[3]
{
0.53151387f,
0.40016085f,
0.24868083f,
},
},
    NullableValue = 
new System.Single[3]
{
0.8864206f,
0.022268891f,
0.36184192f,
},
},
            new SinglerealArray1M
{
    Id = 165,
    Value = 
new System.Single[4]
{
0.26962018f,
0.115376174f,
0.45082426f,
0.6614058f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.14755297f,
0.8232931f,
0.820848f,
0.105435014f,
},
},
            new SinglerealArray1M
{
    Id = 168,
    Value = 
new System.Single[3]
{
0.9470802f,
0.3535753f,
0.1113981f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 87,
    Value = 
new System.Single[4]
{
0.5120311f,
0.8341653f,
0.7028186f,
0.14521527f,
},
    NullableValue = 
new System.Single[4]
{
0.31188905f,
0.11655027f,
0.099131525f,
0.19241905f,
},
},
    NullableValue = 
new System.Single[3]
{
0.39635414f,
0.18658221f,
0.8075832f,
},
},
            new SinglerealArray1M
{
    Id = 171,
    Value = 
new System.Single[4]
{
0.8108689f,
0.25967932f,
0.82618207f,
0.95522213f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.27268988f,
0.75292814f,
0.9346042f,
0.2501449f,
},
},
            new SinglerealArray1M
{
    Id = 175,
    Value = 
new System.Single[3]
{
0.9830689f,
0.27034676f,
0.6126334f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 89,
    Value = 
new System.Single[4]
{
0.5161707f,
0.5671359f,
0.39927053f,
0.99416405f,
},
    NullableValue = 
new System.Single[3]
{
0.48027682f,
0.9488925f,
0.56385803f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 179,
    Value = 
new System.Single[3]
{
0.30680037f,
0.6048425f,
0.014587104f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 182,
    Value = 
new System.Single[3]
{
0.6028076f,
0.36456645f,
0.6664341f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 96,
    Value = 
new System.Single[3]
{
0.27326673f,
0.828895f,
0.8443678f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 184,
    Value = 
new System.Single[3]
{
0.26747733f,
0.56061476f,
0.76252013f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.6898007f,
0.008400798f,
0.72103375f,
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

                    nullable = await ((ISingleArrayrealArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[3]
{
0.30653572f,
0.9369464f,
0.20346552f,
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
                Assert.That(nullable, Is.Null);
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
0.5873283f,
0.12565607f,
0.2912137f,
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
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
                Assert.That(secondItems1, Has.Count.EqualTo(27));
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
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[26],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 171;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[34], false);
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
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
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
                        Assert.That(models, Has.Count.EqualTo(34));

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
                        FlatSinglerealArray1M.AssertModel(models[29],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(models[30],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(models[31],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[32],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 23;
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[29],_testData[34], false);
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
                parametr1.Value = 175;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 171;
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
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
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[34], false);
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

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
                        SinglerealArray1M.AssertModel(models[12],_testData[30], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[31], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[32], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[33], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        SinglerealArray1M.AssertModel(models[0],_testData[14], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[29], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[30], false);
                        SinglerealArray1M.AssertModel(models[17],_testData[31], false);
                        SinglerealArray1M.AssertModel(models[18],_testData[32], false);
                        SinglerealArray1M.AssertModel(models[19],_testData[33], false);
                        SinglerealArray1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        SinglerealArray1M.AssertModel(models[0],_testData[14], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[29], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[30], false);
                        SinglerealArray1M.AssertModel(models[17],_testData[31], false);
                        SinglerealArray1M.AssertModel(models[18],_testData[32], false);
                        SinglerealArray1M.AssertModel(models[19],_testData[33], false);
                        SinglerealArray1M.AssertModel(models[20],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
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
                await ((ISingleArrayrealArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 156, query1, 113, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
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
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[34], false);
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
                await ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 147, query1, 70, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray1M.AssertModel(models1[i],_testData[i], false);
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
                 ((ISingleArrayrealArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 47, query1, 168, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[34], false);
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
                 ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 141, query1, 156, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
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
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[34], false);
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
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 165, query1, 113, query2))
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
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[34], false);
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
                await ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 141, query1, 113, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
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
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[34], false);
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
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 16, query1, 175, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[18],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[19],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[20],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[21],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[22],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[23],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[24],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[25],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(models[26],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(models[27],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(models[28],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[29],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[34], false);
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
                 ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelBatch(connection, 47, query1, 92, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
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
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[18],_testData[34], false);
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
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTSelectModelBatchAsync(connection, 16, 79))
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        SinglerealArray1M.AssertModel(models[0],_testData[13], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[14], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[29], false);
                        SinglerealArray1M.AssertModel(models[17],_testData[30], false);
                        SinglerealArray1M.AssertModel(models[18],_testData[31], false);
                        SinglerealArray1M.AssertModel(models[19],_testData[32], false);
                        SinglerealArray1M.AssertModel(models[20],_testData[33], false);
                        SinglerealArray1M.AssertModel(models[21],_testData[34], false);
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
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTSelectModelBatch(connection, 133, 16))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        SinglerealArray1M.AssertModel(models[0],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[29], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[30], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[31], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[32], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[33], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                ((ISingleArrayrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 88);
                var models = await ((ISingleArrayrealArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

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
                SinglerealArray1M.AssertModel(models[15],_testData[30], false);
                SinglerealArray1M.AssertModel(models[16],_testData[31], false);
                SinglerealArray1M.AssertModel(models[17],_testData[32], false);
                SinglerealArray1M.AssertModel(models[18],_testData[33], false);
                SinglerealArray1M.AssertModel(models[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleArrayrealArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleArrayrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 149);
                var models =  ((ISingleArrayrealArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                SinglerealArray1M.AssertModel(models[0],_testData[26], false);
                SinglerealArray1M.AssertModel(models[1],_testData[27], false);
                SinglerealArray1M.AssertModel(models[2],_testData[28], false);
                SinglerealArray1M.AssertModel(models[3],_testData[29], false);
                SinglerealArray1M.AssertModel(models[4],_testData[30], false);
                SinglerealArray1M.AssertModel(models[5],_testData[31], false);
                SinglerealArray1M.AssertModel(models[6],_testData[32], false);
                SinglerealArray1M.AssertModel(models[7],_testData[33], false);
                SinglerealArray1M.AssertModel(models[8],_testData[34], false);
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MIWA), typeof(SinglerealArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
                var models1 = new List<SinglerealArray1MIWA>();
                var models2 = new List<SinglerealArray1MIWA>();
                await ((ISingleArrayrealArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealArray1MIWA>();
                var models2 = new List<SinglerealArray1MIWA>();
                ((ISingleArrayrealArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
                var models = await ((ISingleArrayrealArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_singlerealarray1mi
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
                    SinglerealArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleArrayrealArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_singlerealarray1mi
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
                    SinglerealArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MIWA), typeof(SinglerealArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
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
                var models1 = new List<SinglerealArray1MIWA>();
                var models2 = new List<SinglerealArray1MIWA>();
                await ((ISingleArrayrealArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealArray1MIWA>();
                var models2 = new List<SinglerealArray1MIWA>();
                ((ISingleArrayrealArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MIWA)],
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
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((ISingleArrayrealArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_singlerealarray1mi
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
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((ISingleArrayrealArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_singlerealarray1mi
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
                    SinglerealArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_singlerealarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MI), typeof(SinglerealArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
                var models1 = new List<SinglerealArray1MI>();
                var models2 = new List<SinglerealArray1MI>();
                await ((ISingleArrayrealArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealArray1MI>();
                var models2 = new List<SinglerealArray1MI>();
                ((ISingleArrayrealArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(model2, expectedModel, false);
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
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray)),
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
                var models = await ((ISingleArrayrealArray)this).WAExportModelInnerAsync(connection).ToListAsync();
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
        public  void WAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((ISingleArrayrealArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_singlerealarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MIWA), typeof(SinglerealArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleArrayrealArray))]
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
                var models1 = new List<SinglerealArray1MIWA>();
                var models2 = new List<SinglerealArray1MIWA>();
                await ((ISingleArrayrealArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealArray1MIWA>();
                var models2 = new List<SinglerealArray1MIWA>();
                ((ISingleArrayrealArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(SinglerealArray1MIWA)],
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
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((ISingleArrayrealArray)this).ExportModelInnerAsync(connection).ToListAsync();
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
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((ISingleArrayrealArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

