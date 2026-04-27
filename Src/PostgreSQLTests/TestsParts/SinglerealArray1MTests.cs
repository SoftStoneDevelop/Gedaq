

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
0.111050785f,
0.9375659f,
0.9013146f,
0.31209874f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 6,
    Value = 
new System.Single[3]
{
0.3136534f,
0.6943449f,
0.41390955f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 5,
    Value = 
new System.Single[4]
{
0.6138293f,
0.80898744f,
0.33620006f,
0.10258508f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 15,
    Value = 
new System.Single[4]
{
0.19811922f,
0.03682697f,
0.746114f,
0.9509747f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 16,
    Value = 
new System.Single[3]
{
0.88413435f,
0.7661353f,
0.17634118f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 13,
    Value = 
new System.Single[3]
{
0.60733515f,
0.6908067f,
0.6626981f,
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
0.28025264f,
0.7180054f,
0.3542841f,
0.71835786f,
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
0.49347633f,
0.12769586f,
0.7024925f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 17,
    Value = 
new System.Single[3]
{
0.30473572f,
0.413606f,
0.7391007f,
},
    NullableValue = 
new System.Single[3]
{
0.79803944f,
0.3758976f,
0.91737425f,
},
},
    NullableValue = 
new System.Single[3]
{
0.639464f,
0.73895824f,
0.076773465f,
},
},
            new SinglerealArray1M
{
    Id = 29,
    Value = 
new System.Single[3]
{
0.8465702f,
0.037462115f,
0.37798792f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 33,
    Value = 
new System.Single[4]
{
0.8370171f,
0.33155584f,
0.6305556f,
0.505438f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 22,
    Value = 
new System.Single[4]
{
0.88041806f,
0.86835325f,
0.33162218f,
0.88641405f,
},
    NullableValue = 
new System.Single[4]
{
0.5740483f,
0.7766088f,
0.11183953f,
0.95410216f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 39,
    Value = 
new System.Single[3]
{
0.05547607f,
0.6010369f,
0.033162773f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 40,
    Value = 
new System.Single[4]
{
0.037388086f,
0.119078815f,
0.3526948f,
0.25200045f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 23,
    Value = 
new System.Single[3]
{
0.11344588f,
0.66992575f,
0.9524182f,
},
    NullableValue = 
new System.Single[3]
{
0.2613982f,
0.8958766f,
0.6031814f,
},
},
    NullableValue = 
new System.Single[4]
{
0.018592894f,
0.27385533f,
0.6852624f,
0.8665219f,
},
},
            new SinglerealArray1M
{
    Id = 48,
    Value = 
new System.Single[3]
{
0.5230993f,
0.06596005f,
0.7366149f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 54,
    Value = 
new System.Single[4]
{
0.009733319f,
0.950739f,
0.93260264f,
0.1448685f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 31,
    Value = 
new System.Single[4]
{
0.32640666f,
0.35307634f,
0.13344407f,
0.36316395f,
},
    NullableValue = 
new System.Single[3]
{
0.46772724f,
0.5561584f,
0.93885267f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 59,
    Value = 
new System.Single[4]
{
0.11128366f,
0.4104172f,
0.7386344f,
0.6024808f,
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
0.9730481f,
0.005254984f,
0.87590533f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 38,
    Value = 
new System.Single[3]
{
0.41260546f,
0.8350099f,
0.5910958f,
},
    NullableValue = 
new System.Single[4]
{
0.019695759f,
0.09449047f,
0.6710309f,
0.48402256f,
},
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 67,
    Value = 
new System.Single[4]
{
0.05886364f,
0.72320944f,
0.7117573f,
0.9234745f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.13861382f,
0.71997255f,
0.17989212f,
0.971413f,
},
},
            new SinglerealArray1M
{
    Id = 70,
    Value = 
new System.Single[3]
{
0.45987886f,
0.0182333f,
0.3442793f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 40,
    Value = 
new System.Single[4]
{
0.73270655f,
0.8714341f,
0.9973668f,
0.23990566f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 77,
    Value = 
new System.Single[3]
{
0.6120115f,
0.3466165f,
0.43388116f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.61779416f,
0.31929898f,
0.06474286f,
0.38222653f,
},
},
            new SinglerealArray1M
{
    Id = 84,
    Value = 
new System.Single[4]
{
0.13065511f,
0.43214118f,
0.23692983f,
0.37361205f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 45,
    Value = 
new System.Single[3]
{
0.06512952f,
0.783799f,
0.24896461f,
},
    NullableValue = 
new System.Single[4]
{
0.9498779f,
0.01832354f,
0.6290976f,
0.51791525f,
},
},
    NullableValue = 
new System.Single[4]
{
0.7541813f,
0.31945783f,
0.41720623f,
0.14781862f,
},
},
            new SinglerealArray1M
{
    Id = 85,
    Value = 
new System.Single[3]
{
0.4803031f,
0.04085791f,
0.39730114f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 88,
    Value = 
new System.Single[4]
{
0.121646285f,
0.5536786f,
0.20251459f,
0.8663006f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 49,
    Value = 
new System.Single[3]
{
0.88982946f,
0.7132509f,
0.64243776f,
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
0.57727325f,
0.4886092f,
0.7998983f,
0.5686158f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 94,
    Value = 
new System.Single[4]
{
0.05626768f,
0.7111774f,
0.7870892f,
0.026943803f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 50,
    Value = 
new System.Single[3]
{
0.41237962f,
0.90137833f,
0.95831627f,
},
    NullableValue = 
new System.Single[4]
{
0.18227392f,
0.06847113f,
0.84062076f,
0.14265728f,
},
},
    NullableValue = 
new System.Single[4]
{
0.91418225f,
0.095219135f,
0.6608999f,
0.9754542f,
},
},
            new SinglerealArray1M
{
    Id = 102,
    Value = 
new System.Single[3]
{
0.42116302f,
0.27064204f,
0.40539473f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 106,
    Value = 
new System.Single[3]
{
0.47209883f,
0.16730338f,
0.23779768f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 54,
    Value = 
new System.Single[4]
{
0.26609433f,
0.24283332f,
0.35284328f,
0.6835164f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.52128303f,
0.65151745f,
0.8652828f,
0.90783113f,
},
},
            new SinglerealArray1M
{
    Id = 107,
    Value = 
new System.Single[3]
{
0.15130478f,
0.7786871f,
0.20757776f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 115,
    Value = 
new System.Single[4]
{
0.6899373f,
0.33798718f,
0.0697481f,
0.5355645f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 61,
    Value = 
new System.Single[3]
{
0.2537043f,
0.6481802f,
0.030059457f,
},
    NullableValue = 
new System.Single[3]
{
0.69462955f,
0.58550453f,
0.70746315f,
},
},
    NullableValue = 
new System.Single[4]
{
0.7826379f,
0.12485385f,
0.21962458f,
0.7964528f,
},
},
            new SinglerealArray1M
{
    Id = 118,
    Value = 
new System.Single[4]
{
0.90568084f,
0.344469f,
0.19943315f,
0.5829643f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 127,
    Value = 
new System.Single[4]
{
0.3731041f,
0.9421518f,
0.40068847f,
0.087109625f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 63,
    Value = 
new System.Single[3]
{
0.9779819f,
0.3275137f,
0.9973541f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray1M
{
    Id = 128,
    Value = 
new System.Single[4]
{
0.33657068f,
0.9130745f,
0.51155025f,
0.40494466f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.5918963f,
0.8897501f,
0.72544634f,
0.16316676f,
},
},
            new SinglerealArray1M
{
    Id = 134,
    Value = 
new System.Single[3]
{
0.50424725f,
0.9614031f,
0.8215759f,
},
    ModelInner = new SinglerealArray1MI
{
    Id = 65,
    Value = 
new System.Single[4]
{
0.6473f,
0.8715893f,
0.0770967f,
0.10022575f,
},
    NullableValue = null,
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
0.639464f,
0.73895824f,
0.076773465f,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[4]
{
0.018592894f,
0.27385533f,
0.6852624f,
0.8665219f,
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[29], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
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
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[28],_testData[29], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
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
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[29], false);
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
                parametr1.Value = 77;
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        SinglerealArray1M.AssertModel(models[0],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[29], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                await ((ISingleArrayrealArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 16, query1, 40, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
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
                await ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 39, query1, 54, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(18));
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
                 ((ISingleArrayrealArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 67, query1, 67, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatSinglerealArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
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
                 ((ISingleArrayrealArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 48, query1, 39, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[20],_testData[29], false);
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
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 84, query1, 107, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 33, query1, 65, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[15],_testData[29], false);
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
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 4, query1, 65, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

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
                 ((ISingleArrayrealArray)this).DbConnectionDynQuerySelectModelBatch(connection, 48, query1, 107, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatSinglerealArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatSinglerealArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatSinglerealArray1M.AssertModel(secondItems2[4],_testData[29], false);
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
                foreach(var batchResult in await ((ISingleArrayrealArray)this).DbConnectionSTSelectModelBatchAsync(connection, 59, 28))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((ISingleArrayrealArray)this).DbConnectionSTSelectModelBatch(connection, 29, 54))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        SinglerealArray1M.AssertModel(models[0],_testData[7], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[8], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[9], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[10], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[11], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[12], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[13], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[14], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[17],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[18],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[19],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[20],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[21],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        SinglerealArray1M.AssertModel(models[0],_testData[12], false);
                        SinglerealArray1M.AssertModel(models[1],_testData[13], false);
                        SinglerealArray1M.AssertModel(models[2],_testData[14], false);
                        SinglerealArray1M.AssertModel(models[3],_testData[15], false);
                        SinglerealArray1M.AssertModel(models[4],_testData[16], false);
                        SinglerealArray1M.AssertModel(models[5],_testData[17], false);
                        SinglerealArray1M.AssertModel(models[6],_testData[18], false);
                        SinglerealArray1M.AssertModel(models[7],_testData[19], false);
                        SinglerealArray1M.AssertModel(models[8],_testData[20], false);
                        SinglerealArray1M.AssertModel(models[9],_testData[21], false);
                        SinglerealArray1M.AssertModel(models[10],_testData[22], false);
                        SinglerealArray1M.AssertModel(models[11],_testData[23], false);
                        SinglerealArray1M.AssertModel(models[12],_testData[24], false);
                        SinglerealArray1M.AssertModel(models[13],_testData[25], false);
                        SinglerealArray1M.AssertModel(models[14],_testData[26], false);
                        SinglerealArray1M.AssertModel(models[15],_testData[27], false);
                        SinglerealArray1M.AssertModel(models[16],_testData[28], false);
                        SinglerealArray1M.AssertModel(models[17],_testData[29], false);
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
                ((ISingleArrayrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 65);
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
                ((ISingleArrayrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 40);
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

