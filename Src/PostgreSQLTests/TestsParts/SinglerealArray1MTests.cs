

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
new System.Single[3]
{
0.042913437f,
0.18266428f,
0.23584533f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.6520914f,
0.66057366f,
0.68451214f,
0.22322965f,
},
},
            new SinglerealArray1M
{
    Id = 7,
    Value = 
new System.Single[3]
{
0.7108286f,
0.3325048f,
0.797292f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 4,
    Value = 
new System.Single[4]
{
0.14230078f,
0.3385402f,
0.39332414f,
0.83577365f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 15,
    Value = 
new System.Single[3]
{
0.45729423f,
0.026692033f,
0.7264234f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.017058909f,
0.54060525f,
0.95712507f,
},
},
            new SinglerealArray1M
{
    Id = 23,
    Value = 
new System.Single[4]
{
0.64563215f,
0.5628398f,
0.42226946f,
0.0032640696f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 7,
    Value = 
new System.Single[3]
{
0.66707504f,
0.6178202f,
0.18694961f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.53209424f,
0.850404f,
0.41970378f,
0.6779289f,
},
},
            new SinglerealArray1M
{
    Id = 31,
    Value = 
new System.Single[4]
{
0.30363774f,
0.5546817f,
0.345038f,
0.8216265f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 38,
    Value = 
new System.Single[3]
{
0.8286919f,
0.6422522f,
0.39165223f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 14,
    Value = 
new System.Single[4]
{
0.70564264f,
0.6207363f,
0.17357004f,
0.39027226f,
},
    NullableValue = 
new System.Single[4]
{
0.42993826f,
0.6829529f,
0.27084404f,
0.85953015f,
},
},
    NullableValue = 
new System.Single[4]
{
0.028452456f,
0.343206f,
0.40784174f,
0.86272514f,
},
},
            new SinglerealArray1M
{
    Id = 44,
    Value = 
new System.Single[4]
{
0.785924f,
0.48397684f,
0.95908135f,
0.4567225f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 49,
    Value = 
new System.Single[3]
{
0.585898f,
0.01233995f,
0.5667662f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 21,
    Value = 
new System.Single[4]
{
0.31290638f,
0.5859687f,
0.6881523f,
0.8470325f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[3]
{
0.69374216f,
0.83985555f,
0.91326964f,
},
},
            new SinglerealArray1M
{
    Id = 58,
    Value = 
new System.Single[3]
{
0.56871736f,
0.58258736f,
0.35130852f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 59,
    Value = 
new System.Single[3]
{
0.4475593f,
0.9052813f,
0.44392657f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 30,
    Value = 
new System.Single[4]
{
0.77918833f,
0.5491774f,
0.28526103f,
0.5241307f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 64,
    Value = 
new System.Single[3]
{
0.8607112f,
0.22770512f,
0.4089958f,
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
0.66266835f,
0.8656077f,
0.33051407f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 36,
    Value = 
new System.Single[4]
{
0.57344407f,
0.98607546f,
0.6403112f,
0.59285086f,
},
    NullableValue = 
new System.Single[3]
{
0.9104175f,
0.99038196f,
0.7075776f,
},
},
    NullableValue = 
new System.Single[4]
{
0.4317991f,
0.07819301f,
0.5221825f,
0.10325372f,
},
},
            new SinglerealArray1M
{
    Id = 78,
    Value = 
new System.Single[3]
{
0.7158375f,
0.3642282f,
0.97021f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 84,
    Value = 
new System.Single[3]
{
0.13896078f,
0.20709866f,
0.08736467f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 39,
    Value = 
new System.Single[3]
{
0.016961396f,
0.7111701f,
0.9862798f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[3]
{
0.97049445f,
0.8965537f,
0.11190009f,
},
},
            new SinglerealArray1M
{
    Id = 91,
    Value = 
new System.Single[3]
{
0.6083956f,
0.07171595f,
0.7918055f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 94,
    Value = 
new System.Single[3]
{
0.77327114f,
0.05178976f,
0.7272146f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 41,
    Value = 
new System.Single[3]
{
0.33663636f,
0.48184836f,
0.8120857f,
},
    NullableValue = 
new System.Single[3]
{
0.20077348f,
0.63448983f,
0.9395259f,
},
},
    NullableValue = 
new System.Single[3]
{
0.9578616f,
0.8623575f,
0.9656547f,
},
},
            new SinglerealArray1M
{
    Id = 103,
    Value = 
new System.Single[4]
{
0.1499961f,
0.33474183f,
0.20616573f,
0.96301955f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.1776334f,
0.07847476f,
0.9569599f,
},
},
            new SinglerealArray1M
{
    Id = 108,
    Value = 
new System.Single[3]
{
0.6202065f,
0.6745076f,
0.5323867f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 43,
    Value = 
new System.Single[4]
{
0.04275906f,
0.7539555f,
0.43538302f,
0.64319927f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.81546736f,
0.59698796f,
0.16157365f,
0.84356177f,
},
},
            new SinglerealArray1M
{
    Id = 115,
    Value = 
new System.Single[3]
{
0.38871515f,
0.14960188f,
0.059880733f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.3316763f,
0.72699547f,
0.8215338f,
},
},
            new SinglerealArray1M
{
    Id = 119,
    Value = 
new System.Single[3]
{
0.729823f,
0.98400635f,
0.2513798f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 50,
    Value = 
new System.Single[3]
{
0.28025407f,
0.62413496f,
0.31834644f,
},
    NullableValue = 
new System.Single[4]
{
0.58726466f,
0.278934f,
0.24276298f,
0.29355103f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 124,
    Value = 
new System.Single[3]
{
0.48387557f,
0.34049487f,
0.6930528f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.96323377f,
0.4698202f,
0.024052262f,
},
},
            new SinglerealArray1M
{
    Id = 128,
    Value = 
new System.Single[3]
{
0.7894048f,
0.41973895f,
0.810484f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 59,
    Value = 
new System.Single[4]
{
0.22886616f,
0.68684894f,
0.5636822f,
0.7729005f,
},
    NullableValue = 
new System.Single[4]
{
0.6618869f,
0.60637254f,
0.8621831f,
0.8174275f,
},
},
    NullableValue = 
new System.Single[3]
{
0.6118234f,
0.20264238f,
0.69644034f,
},
},
            new SinglerealArray1M
{
    Id = 129,
    Value = 
new System.Single[4]
{
0.5620796f,
0.18202919f,
0.97390616f,
0.08150911f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.22946608f,
0.43127817f,
0.012630463f,
0.2785892f,
},
},
            new SinglerealArray1M
{
    Id = 134,
    Value = 
new System.Single[4]
{
0.9894424f,
0.68188226f,
0.32092482f,
0.5542479f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 66,
    Value = 
new System.Single[4]
{
0.8187428f,
0.57526124f,
0.7879519f,
0.8159914f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.2362783f,
0.9234225f,
0.85589373f,
0.88236964f,
},
},
            new SinglerealArray1M
{
    Id = 136,
    Value = 
new System.Single[3]
{
0.9999273f,
0.73472077f,
0.38967693f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.9252813f,
0.56002223f,
0.9607464f,
},
},
            new SinglerealArray1M
{
    Id = 142,
    Value = 
new System.Single[4]
{
0.15651554f,
0.9081123f,
0.37004167f,
0.31705397f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 68,
    Value = 
new System.Single[4]
{
0.3786047f,
0.5621929f,
0.5684609f,
0.97328633f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[3]
{
0.32209766f,
0.33443505f,
0.3992855f,
},
},
            new SinglerealArray1M
{
    Id = 143,
    Value = 
new System.Single[4]
{
0.9708025f,
0.04584223f,
0.65459543f,
0.77390975f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.5862371f,
0.38897604f,
0.0675084f,
0.9327878f,
},
},
            new SinglerealArray1M
{
    Id = 149,
    Value = 
new System.Single[4]
{
0.88580394f,
0.30938923f,
0.25333142f,
0.7466264f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 72,
    Value = 
new System.Single[3]
{
0.56386083f,
0.5719455f,
0.228185f,
},
    NullableValue = 
new System.Single[4]
{
0.6666626f,
0.35305917f,
0.20009553f,
0.8956584f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 153,
    Value = 
new System.Single[4]
{
0.9910743f,
0.3740368f,
0.81799865f,
0.9111253f,
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
0.6332546f,
0.0586403f,
0.927928f,
0.62811756f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 76,
    Value = 
new System.Single[3]
{
0.45615286f,
0.99700516f,
0.5715303f,
},
    NullableValue = 
new System.Single[3]
{
0.23864377f,
0.34695715f,
0.7893744f,
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
new System.Single[4]
{
0.028452456f,
0.343206f,
0.40784174f,
0.86272514f,
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
0.69374216f,
0.83985555f,
0.91326964f,
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
new System.Single[4]
{
0.4317991f,
0.07819301f,
0.5221825f,
0.10325372f,
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[29], false);
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
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
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[25],_testData[29], false);
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
                parametr2.Value = 149;
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
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[18],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[19],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[20],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[21],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[22],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[29], false);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[29], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
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
                        Assert.That(models, Has.Count.EqualTo(10));

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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[29], false);
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        SinglerealArray1M.AssertModel(models[0],_testData[6], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[7], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[8], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[9], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[10], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[11], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[12], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[13], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[14], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[17],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[18],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[19],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[20],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[21],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[22],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        SinglerealArray1M.AssertModel(models[0],_testData[1], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[2], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[3], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[4], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[5], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[6], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[7], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[8], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[9], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[10], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[11], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[12], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[13], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[14], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[17],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[18],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[19],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[20],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[21],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[22],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[23],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[24],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[25],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[26],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[27],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[28],_testData[29], false);
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
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        SinglerealArray1M.AssertModel(models[0],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

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
                await ((ISingleArrayrealArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 49, query1, 128, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
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
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[29], false);
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
                await ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 44, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
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
                 ((ISingleArrayrealArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 59, query1, 115, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[29], false);
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
                 ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 49, query1, 142, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
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
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[29], false);
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
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 58, query1, 128, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[18],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[19],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[29], false);
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
                await ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 94, query1, 129, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[29], false);
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
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 38, query1, 58, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[18],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[19],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[20],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[21],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[22],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatSinglerealArray1M.AssertModel(models[0],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(models[1],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(models[2],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(models[3],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(models[4],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(models[5],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(models[6],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(models[7],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(models[8],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(models[9],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(models[10],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(models[11],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(models[12],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(models[13],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(models[14],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(models[15],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(models[16],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(models[17],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(models[18],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(models[19],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(models[20],_testData[29], false);
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
                 ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelBatch(connection, 103, query1, 49, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[21],_testData[29], false);
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
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTSelectModelBatchAsync(connection, 94, 94))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

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
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTSelectModelBatch(connection, 149, 15))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        SinglerealArray1M.AssertModel(models[0],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

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
                ((ISingleArrayrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 7);
                var models = await ((ISingleArrayrealArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
SinglerealArray1M.AssertModel(models[0],_testData[2], false);SinglerealArray1M.AssertModel(models[1],_testData[3], false);SinglerealArray1M.AssertModel(models[2],_testData[4], false);SinglerealArray1M.AssertModel(models[3],_testData[5], false);SinglerealArray1M.AssertModel(models[4],_testData[6], false);SinglerealArray1M.AssertModel(models[5],_testData[7], false);SinglerealArray1M.AssertModel(models[6],_testData[8], false);SinglerealArray1M.AssertModel(models[7],_testData[9], false);SinglerealArray1M.AssertModel(models[8],_testData[10], false);SinglerealArray1M.AssertModel(models[9],_testData[11], false);SinglerealArray1M.AssertModel(models[10],_testData[12], false);SinglerealArray1M.AssertModel(models[11],_testData[13], false);SinglerealArray1M.AssertModel(models[12],_testData[14], false);SinglerealArray1M.AssertModel(models[13],_testData[15], false);SinglerealArray1M.AssertModel(models[14],_testData[16], false);SinglerealArray1M.AssertModel(models[15],_testData[17], false);SinglerealArray1M.AssertModel(models[16],_testData[18], false);SinglerealArray1M.AssertModel(models[17],_testData[19], false);SinglerealArray1M.AssertModel(models[18],_testData[20], false);SinglerealArray1M.AssertModel(models[19],_testData[21], false);SinglerealArray1M.AssertModel(models[20],_testData[22], false);SinglerealArray1M.AssertModel(models[21],_testData[23], false);SinglerealArray1M.AssertModel(models[22],_testData[24], false);SinglerealArray1M.AssertModel(models[23],_testData[25], false);SinglerealArray1M.AssertModel(models[24],_testData[26], false);SinglerealArray1M.AssertModel(models[25],_testData[27], false);SinglerealArray1M.AssertModel(models[26],_testData[28], false);SinglerealArray1M.AssertModel(models[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleArrayrealArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleArrayrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 59);
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

