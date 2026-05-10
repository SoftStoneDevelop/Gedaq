

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
    Id = 2,
    Value = 
new System.Single[4]
{
0.08968419f,
0.7557507f,
0.27468282f,
0.38149345f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.28023523f,
0.637863f,
0.64549583f,
0.055697978f,
},
},
            new SinglerealArray1M
{
    Id = 5,
    Value = 
new System.Single[3]
{
0.5579523f,
0.7220555f,
0.52602786f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 1,
    Value = 
new System.Single[3]
{
0.96192914f,
0.998273f,
0.33107936f,
},
    NullableValue = 
new System.Single[4]
{
0.5442803f,
0.030033767f,
0.92811674f,
0.66737396f,
},
},
    NullableValue = 
new System.Single[4]
{
0.6566703f,
0.59088916f,
0.71931124f,
0.44431847f,
},
},
            new SinglerealArray1M
{
    Id = 8,
    Value = 
new System.Single[4]
{
0.37133127f,
0.7919561f,
0.8594747f,
0.49416006f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 13,
    Value = 
new System.Single[4]
{
0.87636423f,
0.3006178f,
0.19492853f,
0.35201883f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 5,
    Value = 
new System.Single[3]
{
0.28587526f,
0.5890732f,
0.838019f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.34393704f,
0.38684648f,
0.8369093f,
0.6334255f,
},
},
            new SinglerealArray1M
{
    Id = 14,
    Value = 
new System.Single[4]
{
0.32757652f,
0.022845864f,
0.7724078f,
0.93608963f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.9199059f,
0.31931478f,
0.20977634f,
0.3504176f,
},
},
            new SinglerealArray1M
{
    Id = 16,
    Value = 
new System.Single[4]
{
0.99110234f,
0.29465312f,
0.2828682f,
0.49444902f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 12,
    Value = 
new System.Single[4]
{
0.6574467f,
0.86928844f,
0.8592934f,
0.9511476f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.8535109f,
0.88974315f,
0.15864229f,
0.33512193f,
},
},
            new SinglerealArray1M
{
    Id = 22,
    Value = 
new System.Single[3]
{
0.2058667f,
0.07928085f,
0.41566986f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 27,
    Value = 
new System.Single[3]
{
0.61174285f,
0.017459512f,
0.07139212f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 19,
    Value = 
new System.Single[3]
{
0.6324702f,
0.49387956f,
0.6684173f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[3]
{
0.060938656f,
0.9671312f,
0.88768387f,
},
},
            new SinglerealArray1M
{
    Id = 32,
    Value = 
new System.Single[4]
{
0.21685624f,
0.365299f,
0.26291722f,
0.34813225f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.4787593f,
0.30140537f,
0.94855267f,
0.34806705f,
},
},
            new SinglerealArray1M
{
    Id = 34,
    Value = 
new System.Single[3]
{
0.019563913f,
0.181148f,
0.018213034f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 22,
    Value = 
new System.Single[4]
{
0.62162745f,
0.7983151f,
0.8597733f,
0.3789826f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 43,
    Value = 
new System.Single[4]
{
0.9286698f,
0.004085183f,
0.38958693f,
0.27143222f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 51,
    Value = 
new System.Single[4]
{
0.7926598f,
0.71125466f,
0.65688205f,
0.08304083f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 23,
    Value = 
new System.Single[3]
{
0.675138f,
0.098091364f,
0.47706383f,
},
    NullableValue = 
new System.Single[3]
{
0.9843418f,
0.2507934f,
0.8064594f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 55,
    Value = 
new System.Single[4]
{
0.84309137f,
0.117055535f,
0.5679239f,
0.2751662f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.27610612f,
0.8890186f,
0.5834803f,
},
},
            new SinglerealArray1M
{
    Id = 61,
    Value = 
new System.Single[3]
{
0.12547612f,
0.19008589f,
0.73848164f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 32,
    Value = 
new System.Single[3]
{
0.34652716f,
0.33465958f,
0.23365957f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.62233037f,
0.7915799f,
0.51780546f,
0.47771305f,
},
},
            new SinglerealArray1M
{
    Id = 64,
    Value = 
new System.Single[4]
{
0.5951506f,
0.43705124f,
0.56660587f,
0.6393104f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.40916508f,
0.102843046f,
0.5440873f,
0.5758684f,
},
},
            new SinglerealArray1M
{
    Id = 73,
    Value = 
new System.Single[4]
{
0.7589359f,
0.97218585f,
0.2725879f,
0.12107426f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 41,
    Value = 
new System.Single[3]
{
0.43598557f,
0.8010459f,
0.33338016f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[3]
{
0.0662207f,
0.2804783f,
0.7925397f,
},
},
            new SinglerealArray1M
{
    Id = 82,
    Value = 
new System.Single[3]
{
0.19261205f,
0.62482804f,
0.9331558f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 90,
    Value = 
new System.Single[4]
{
0.91880727f,
0.034262896f,
0.7670176f,
0.020429194f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 48,
    Value = 
new System.Single[3]
{
0.62490124f,
0.015805125f,
0.84170324f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 96,
    Value = 
new System.Single[3]
{
0.012364864f,
0.26884305f,
0.04542905f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 103,
    Value = 
new System.Single[3]
{
0.3318652f,
0.5721575f,
0.32653958f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 57,
    Value = 
new System.Single[3]
{
0.64568436f,
0.6579076f,
0.8200055f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 110,
    Value = 
new System.Single[3]
{
0.85420483f,
0.19678396f,
0.23461366f,
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
0.65368813f,
0.85344076f,
0.28590757f,
0.7495953f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 61,
    Value = 
new System.Single[3]
{
0.62800604f,
0.54074836f,
0.7748215f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.41470677f,
0.051394105f,
0.9065487f,
0.42434263f,
},
},
            new SinglerealArray1M
{
    Id = 122,
    Value = 
new System.Single[4]
{
0.80655706f,
0.36695367f,
0.37560058f,
0.69431275f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 124,
    Value = 
new System.Single[4]
{
0.56078166f,
0.04583925f,
0.0093688965f,
0.8550411f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 69,
    Value = 
new System.Single[3]
{
0.84825754f,
0.9755608f,
0.84508705f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 131,
    Value = 
new System.Single[3]
{
0.7428811f,
0.98334646f,
0.13087738f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.44531208f,
0.77388835f,
0.8566258f,
},
},
            new SinglerealArray1M
{
    Id = 138,
    Value = 
new System.Single[3]
{
0.5245736f,
0.87225074f,
0.6987225f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 71,
    Value = 
new System.Single[3]
{
0.761718f,
0.30669183f,
0.51486737f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.19912434f,
0.20620996f,
0.8170042f,
0.33324093f,
},
},
            new SinglerealArray1M
{
    Id = 139,
    Value = 
new System.Single[3]
{
0.20862663f,
0.05809474f,
0.19464093f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.42707032f,
0.8234152f,
0.65582f,
0.9785072f,
},
},
            new SinglerealArray1M
{
    Id = 141,
    Value = 
new System.Single[4]
{
0.5705221f,
0.13844252f,
0.59053266f,
0.41098648f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 75,
    Value = 
new System.Single[4]
{
0.08943176f,
0.23602825f,
0.0960992f,
0.6316856f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 143,
    Value = 
new System.Single[3]
{
0.48275447f,
0.6532349f,
0.64408237f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 148,
    Value = 
new System.Single[4]
{
0.43658513f,
0.52183115f,
0.8716663f,
0.944777f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 80,
    Value = 
new System.Single[4]
{
0.2038958f,
0.7569443f,
0.38923812f,
0.6200228f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 151,
    Value = 
new System.Single[3]
{
0.40214837f,
0.28713048f,
0.9606278f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.5474632f,
0.30742443f,
0.35449612f,
0.016649544f,
},
},
            new SinglerealArray1M
{
    Id = 154,
    Value = 
new System.Single[3]
{
0.01236707f,
0.85850817f,
0.581316f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 88,
    Value = 
new System.Single[4]
{
0.46815455f,
0.9886007f,
0.025170565f,
0.6958812f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 156,
    Value = 
new System.Single[4]
{
0.5693763f,
0.80505455f,
0.15735292f,
0.5973993f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 160,
    Value = 
new System.Single[3]
{
0.9528252f,
0.8374937f,
0.8315874f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 95,
    Value = 
new System.Single[3]
{
0.28351605f,
0.34940386f,
0.3648271f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[3]
{
0.84765595f,
0.2233308f,
0.5619034f,
},
},
            new SinglerealArray1M
{
    Id = 169,
    Value = 
new System.Single[3]
{
0.1737389f,
0.18095767f,
0.8857822f,
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
new System.Single[4]
{
0.9199059f,
0.31931478f,
0.20977634f,
0.3504176f,
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
0.8535109f,
0.88974315f,
0.15864229f,
0.33512193f,
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
new System.Single[3]
{
0.060938656f,
0.9671312f,
0.88768387f,
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
0.4787593f,
0.30140537f,
0.94855267f,
0.34806705f,
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
                Assert.That(nullable, Is.Null);
                nullable = await ((ISingleArrayrealArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[34], false);
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
                parametr2.Value = 13;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[30],_testData[34], false);
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
                parametr1.Value = 156;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
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
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[34], false);
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
                parametr1.Value = 138;
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
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[18],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[19],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(models[20],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(models[21],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(models[22],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[23],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[34], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(models[18],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[19],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(models[18],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(models[19],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[20],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
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
                        FlatSinglerealArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[31],_testData[34], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 154;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        SinglerealArray1M.AssertModel(models[0],_testData[32], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[33], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                await ((ISingleArrayrealArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 16, query1, 13, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                await ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 103, query1, 16, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[28],_testData[34], false);
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
                 ((ISingleArrayrealArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 151, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[24],_testData[34], false);
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
                 ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 154, query1, 82, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[34], false);
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
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 43, query1, 64, query2))
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[18],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[19],_testData[34], false);
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
                await ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 122, query1, 141, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[34], false);
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
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 154, query1, 27, query2))
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[18],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[19],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[20],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[21],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(models[22],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(models[23],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(models[24],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(models[25],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(models[26],_testData[34], false);
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
                 ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelBatch(connection, 110, query1, 138, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[34], false);
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
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTSelectModelBatchAsync(connection, 34, 156))
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        SinglerealArray1M.AssertModel(models[0],_testData[33], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[34], false);
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
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTSelectModelBatch(connection, 131, 90))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        SinglerealArray1M.AssertModel(models[0],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[29], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[30], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[31], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[32], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[33], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                ((ISingleArrayrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 116);
                var models = await ((ISingleArrayrealArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                SinglerealArray1M.AssertModel(models[0],_testData[22], false);
                SinglerealArray1M.AssertModel(models[1],_testData[23], false);
                SinglerealArray1M.AssertModel(models[2],_testData[24], false);
                SinglerealArray1M.AssertModel(models[3],_testData[25], false);
                SinglerealArray1M.AssertModel(models[4],_testData[26], false);
                SinglerealArray1M.AssertModel(models[5],_testData[27], false);
                SinglerealArray1M.AssertModel(models[6],_testData[28], false);
                SinglerealArray1M.AssertModel(models[7],_testData[29], false);
                SinglerealArray1M.AssertModel(models[8],_testData[30], false);
                SinglerealArray1M.AssertModel(models[9],_testData[31], false);
                SinglerealArray1M.AssertModel(models[10],_testData[32], false);
                SinglerealArray1M.AssertModel(models[11],_testData[33], false);
                SinglerealArray1M.AssertModel(models[12],_testData[34], false);
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

