

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
    Id = 7,
    Value = 
new System.Single[3]
{
0.45186484f,
0.2786531f,
0.46849132f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 11,
    Value = 
new System.Single[4]
{
0.72831887f,
0.40858126f,
0.021834731f,
0.73173803f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 4,
    Value = 
new System.Single[4]
{
0.1821636f,
0.39758354f,
0.011144757f,
0.97860664f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 18,
    Value = 
new System.Single[3]
{
0.3131283f,
0.95549333f,
0.5386066f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 25,
    Value = 
new System.Single[4]
{
0.28843206f,
0.4345464f,
0.5429356f,
0.13650846f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 9,
    Value = 
new System.Single[3]
{
0.41528058f,
0.11653656f,
0.58712447f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[3]
{
0.52951336f,
0.7183939f,
0.8098244f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 29,
    Value = 
new System.Single[3]
{
0.64947116f,
0.8873368f,
0.4691577f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 35,
    Value = 
new System.Single[4]
{
0.6708975f,
0.06993258f,
0.9634537f,
0.45097268f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 10,
    Value = 
new System.Single[3]
{
0.5691962f,
0.6460861f,
0.24689043f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.75729984f,
0.6941363f,
0.49065816f,
0.81117433f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 43,
    Value = 
new System.Single[3]
{
0.7461263f,
0.98789924f,
0.62364f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 52,
    Value = 
new System.Single[3]
{
0.8418928f,
0.17386353f,
0.97240007f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 12,
    Value = 
new System.Single[4]
{
0.72732574f,
0.6619871f,
0.009337842f,
0.8723449f,
},
    NullableValue = 
new System.Single[3]
{
0.5416864f,
0.12979615f,
0.69643885f,
},
},
    NullableValue = 
new System.Single[4]
{
0.2405082f,
0.0037879348f,
0.9516567f,
0.12142801f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 59,
    Value = 
new System.Single[3]
{
0.8061286f,
0.6712867f,
0.24116719f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.75838083f,
0.27781343f,
0.74711794f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 62,
    Value = 
new System.Single[4]
{
0.5565652f,
0.5632828f,
0.16120034f,
0.16161281f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 20,
    Value = 
new System.Single[3]
{
0.19795811f,
0.5381386f,
0.77391845f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 65,
    Value = 
new System.Single[3]
{
0.59582585f,
0.804706f,
0.31415045f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.7541237f,
0.40549457f,
0.9689334f,
0.7575334f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 67,
    Value = 
new System.Single[3]
{
0.7990714f,
0.9560698f,
0.6449469f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 26,
    Value = 
new System.Single[3]
{
0.43671125f,
0.68366504f,
0.3265713f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[3]
{
0.20877552f,
0.81817967f,
0.44858253f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 68,
    Value = 
new System.Single[4]
{
0.7362577f,
0.35204422f,
0.3753069f,
0.32237875f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.15412468f,
0.6483086f,
0.059631765f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 77,
    Value = 
new System.Single[4]
{
0.97823703f,
0.31174666f,
0.1989122f,
0.4561385f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 27,
    Value = 
new System.Single[4]
{
0.4061044f,
0.6803006f,
0.6575455f,
0.7441542f,
},
    NullableValue = 
new System.Single[4]
{
0.057309866f,
0.09645772f,
0.04287535f,
0.042603254f,
},
},
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 85,
    Value = 
new System.Single[4]
{
0.060779274f,
0.2012561f,
0.44700688f,
0.51928335f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.28004688f,
0.9764567f,
0.17631614f,
0.991933f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 91,
    Value = 
new System.Single[3]
{
0.16166335f,
0.33948094f,
0.5927575f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 29,
    Value = 
new System.Single[4]
{
0.68204445f,
0.2592404f,
0.6717709f,
0.49758536f,
},
    NullableValue = 
new System.Single[4]
{
0.7766543f,
0.63816494f,
0.21107799f,
0.9170135f,
},
},
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 96,
    Value = 
new System.Single[4]
{
0.15918154f,
0.7254181f,
0.8549155f,
0.29096627f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 101,
    Value = 
new System.Single[3]
{
0.95263755f,
0.40962744f,
0.48868853f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 38,
    Value = 
new System.Single[4]
{
0.44263417f,
0.5893043f,
0.38129807f,
0.25131834f,
},
    NullableValue = 
new System.Single[4]
{
0.48552537f,
0.7083269f,
0.17248017f,
0.19494194f,
},
},
    NullableValue = 
new System.Single[4]
{
0.33350605f,
0.51790476f,
0.51685303f,
0.1242457f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 109,
    Value = 
new System.Single[3]
{
0.61424583f,
0.6446441f,
0.93510777f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.7839925f,
0.7354436f,
0.04371369f,
0.488262f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 116,
    Value = 
new System.Single[3]
{
0.7501305f,
0.3387413f,
0.93503815f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 42,
    Value = 
new System.Single[4]
{
0.577161f,
0.29073524f,
0.6577589f,
0.7511324f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.78973967f,
0.4191466f,
0.06172335f,
0.19310421f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 122,
    Value = 
new System.Single[3]
{
0.8687289f,
0.8724317f,
0.560924f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.18911296f,
0.7996376f,
0.2532828f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 131,
    Value = 
new System.Single[3]
{
0.105504334f,
0.86116976f,
0.3577317f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 51,
    Value = 
new System.Single[4]
{
0.38877076f,
0.32692873f,
0.39437497f,
0.013189733f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.042960644f,
0.790219f,
0.81754667f,
0.13888144f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 132,
    Value = 
new System.Single[4]
{
0.96015996f,
0.7182012f,
0.80138916f,
0.09476113f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 136,
    Value = 
new System.Single[4]
{
0.1337015f,
0.21719676f,
0.2607329f,
0.14329463f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 52,
    Value = 
new System.Single[3]
{
0.008181989f,
0.7555529f,
0.47531885f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 144,
    Value = 
new System.Single[3]
{
0.53756994f,
0.19052035f,
0.40204537f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.13087362f,
0.3689971f,
0.20518959f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 146,
    Value = 
new System.Single[4]
{
0.87756395f,
0.728805f,
0.69694316f,
0.59970915f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 54,
    Value = 
new System.Single[4]
{
0.24038905f,
0.7240038f,
0.32252288f,
0.03729844f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 151,
    Value = 
new System.Single[4]
{
0.16827124f,
0.9770945f,
0.077111304f,
0.66644484f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 157,
    Value = 
new System.Single[4]
{
0.26077753f,
0.15726829f,
0.27790707f,
0.023471355f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 60,
    Value = 
new System.Single[3]
{
0.7833746f,
0.6370899f,
0.44024014f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 162,
    Value = 
new System.Single[3]
{
0.63720626f,
0.96629864f,
0.2319014f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.3636853f,
0.6505807f,
0.6894921f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 164,
    Value = 
new System.Single[4]
{
0.8288559f,
0.5411283f,
0.6771983f,
0.28639424f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 67,
    Value = 
new System.Single[4]
{
0.7841514f,
0.977198f,
0.061644793f,
0.5686627f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.037624f,
0.37208027f,
0.6146622f,
0.3392943f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 172,
    Value = 
new System.Single[3]
{
0.62809575f,
0.79834235f,
0.5516635f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.5540515f,
0.352017f,
0.5081415f,
0.89875066f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 174,
    Value = 
new System.Single[4]
{
0.16366428f,
0.3985442f,
0.63277644f,
0.59374464f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 68,
    Value = 
new System.Single[4]
{
0.5301462f,
0.9214674f,
0.01676935f,
0.9261121f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 179,
    Value = 
new System.Single[4]
{
0.3232714f,
0.0022534728f,
0.20864749f,
0.002263248f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.07817119f,
0.19080162f,
0.52765334f,
0.77267075f,
},
},
            new SinglerealMMArrayD1E1M
{
    Id = 187,
    Value = 
new System.Single[3]
{
0.93062323f,
0.7324862f,
0.963896f,
},
    ModelInner = new SinglerealMMArrayD1E1MI
{
    Id = 71,
    Value = 
new System.Single[4]
{
0.37300342f,
0.8424035f,
0.4734516f,
0.057123125f,
},
    NullableValue = 
new System.Single[3]
{
0.38545418f,
0.16585606f,
0.64008987f,
},
},
    NullableValue = null,
},
            new SinglerealMMArrayD1E1M
{
    Id = 192,
    Value = 
new System.Single[4]
{
0.8049683f,
0.13967896f,
0.7824443f,
0.27376682f,
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

                    nullable =  ((ISingleMArrayrealMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[4]
{
0.75729984f,
0.6941363f,
0.49065816f,
0.81117433f,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[4]
{
0.2405082f,
0.0037879348f,
0.9516567f,
0.12142801f,
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
new System.Single[3]
{
0.75838083f,
0.27781343f,
0.74711794f,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[4]
{
0.7541237f,
0.40549457f,
0.9689334f,
0.7575334f,
}));
                nullable = await ((ISingleMArrayrealMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[3]
{
0.20877552f,
0.81817967f,
0.44858253f,
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
                parametr1.Value = 162;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 157;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 132;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
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
                parametr1.Value = 146;
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
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 174;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
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
                parametr1.Value = 172;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatSinglerealMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatSinglerealMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[12],_testData[34], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
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
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatSinglerealMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[19],_testData[34], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleMArrayrealMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleMArrayrealMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                await ((ISingleMArrayrealMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 67, query1, 18, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                await ((ISingleMArrayrealMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 131, query1, 7, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[33],_testData[34], false);
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
                 ((ISingleMArrayrealMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 52, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[16],_testData[34], false);
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
                 ((ISingleMArrayrealMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 7, query1, 162, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[5],_testData[34], false);
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
                foreach(var batchResult in await ((ISingleMArrayrealMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 101, query1, 29, query2))
                {
                    if(++resultIndex == 1)
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
                await ((ISingleMArrayrealMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 67, query1, 85, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[19],_testData[34], false);
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
                foreach(var batchResult in  ((ISingleMArrayrealMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 157, query1, 77, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatSinglerealMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatSinglerealMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
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
                 ((ISingleMArrayrealMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 164, query1, 52, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatSinglerealMMArrayD1E1M.AssertModel(secondItems2[26],_testData[34], false);
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
                foreach(var batchResult in await ((ISingleMArrayrealMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 85, 174))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
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
                foreach(var batchResult in  ((ISingleMArrayrealMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 96, 96))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[17], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[1],_testData[18], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[2],_testData[19], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[3],_testData[20], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[4],_testData[21], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[5],_testData[22], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[6],_testData[23], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[7],_testData[24], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[8],_testData[25], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[9],_testData[26], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[10],_testData[27], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[11],_testData[28], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[12],_testData[29], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[13],_testData[30], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[14],_testData[31], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[15],_testData[32], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[16],_testData[33], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[17], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[1],_testData[18], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[2],_testData[19], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[3],_testData[20], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[4],_testData[21], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[5],_testData[22], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[6],_testData[23], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[7],_testData[24], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[8],_testData[25], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[9],_testData[26], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[10],_testData[27], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[11],_testData[28], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[12],_testData[29], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[13],_testData[30], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[14],_testData[31], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[15],_testData[32], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[16],_testData[33], false);
                        SinglerealMMArrayD1E1M.AssertModel(models[17],_testData[34], false);
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
                ((ISingleMArrayrealMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 172);
                var models = await ((ISingleMArrayrealMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                SinglerealMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                SinglerealMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                SinglerealMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleMArrayrealMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleMArrayrealMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 35);
                var models =  ((ISingleMArrayrealMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                SinglerealMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                SinglerealMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                SinglerealMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                SinglerealMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                SinglerealMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                SinglerealMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                SinglerealMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                SinglerealMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                SinglerealMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                SinglerealMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                SinglerealMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                SinglerealMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                SinglerealMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                SinglerealMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                SinglerealMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                SinglerealMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                SinglerealMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                SinglerealMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                SinglerealMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                SinglerealMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                SinglerealMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                SinglerealMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                SinglerealMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                SinglerealMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                SinglerealMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                SinglerealMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                SinglerealMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                SinglerealMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                SinglerealMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
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

