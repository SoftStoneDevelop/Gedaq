

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
    internal partial interface ISingleListrealListD1
    {
    }
    
    internal partial class SingleListrealListD1 : ISingleListrealListD1
    {


#region TestData

        private readonly SinglerealListD1E2M[] _testData = new SinglerealListD1E2M[]
        {
            new SinglerealListD1E2M
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.028134525f,

0.6362017f,

0.8829612f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7894667f,

0.7021256f,

0.85401064f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6181028f,

0.3758645f,

0.23446131f,

0.6192076f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9653231f,

0.40527236f,

0.8689884f,

0.088600755f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.5180591f,

0.52420217f,

0.7754022f,

},
},
            new SinglerealListD1E2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.16040677f,

0.7704674f,

0.605093f,

0.52555543f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.014724314f,

0.04768032f,

0.5419921f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.23215848f,

0.9904685f,

0.06547904f,

0.5875863f,

},
},
            new SinglerealListD1E2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.12178975f,

0.5481963f,

0.7636203f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.69981724f,

0.3665133f,

0.31219006f,

0.4781835f,

},
},
            new SinglerealListD1E2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.08573961f,

0.9661618f,

0.2515961f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.59379494f,

0.28467655f,

0.54205203f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7310614f,

0.5846733f,

0.0014767051f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.7252896f,

0.9098347f,

0.0017105341f,

0.11809999f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.07873368f,

0.06800872f,

0.5719637f,

0.8768059f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.33438087f,

0.2999246f,

0.2163837f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7220951f,

0.54158837f,

0.37427884f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.15982819f,

0.2828989f,

0.5005777f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.26643836f,

0.2574156f,

0.9306409f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.82816976f,

0.52117467f,

0.5957538f,

0.40366656f,

},
},
            new SinglerealListD1E2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.68886423f,

0.38689154f,

0.28141296f,

0.7622668f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.02162379f,

0.2517615f,

0.6717912f,

0.8742968f,

},
},
            new SinglerealListD1E2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.3665673f,

0.045316696f,

0.58564883f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8726441f,

0.122208476f,

0.3890211f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.010650814f,

0.0874449f,

0.111246884f,

0.26061738f,

},
},
            new SinglerealListD1E2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.69216865f,

0.08169776f,

0.11263698f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.79841304f,

0.27489412f,

0.08236128f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.91974074f,

0.8958893f,

0.19913042f,

0.5873724f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.4482969f,

0.25768787f,

0.008599699f,

},
},
            new SinglerealListD1E2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.2128337f,

0.7463891f,

0.71861386f,

0.9629425f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.17419517f,

0.5325076f,

0.5274241f,

0.85836965f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.043440223f,

0.634627f,

0.76890177f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.96823376f,

0.511752f,

0.3624285f,

},
},
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8056035f,

0.24288434f,

0.82411087f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.9940179f,

0.5546571f,

0.17010456f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8805731f,

0.099009275f,

0.1545552f,

0.5160959f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.010306478f,

0.8421167f,

0.4166835f,

0.036994338f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.10732132f,

0.64707714f,

0.1616512f,

0.370629f,

},
},
            new SinglerealListD1E2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6918548f,

0.490712f,

0.08750665f,

0.8528686f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9654702f,

0.23788059f,

0.28493762f,

0.44473392f,

},
},
            new SinglerealListD1E2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.4146014f,

0.02259326f,

0.4886502f,

0.7272455f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.675027f,

0.4265834f,

0.1078102f,

0.3333907f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.44593477f,

0.35146904f,

0.59079844f,

0.26008058f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.82927394f,

0.7855582f,

0.73866194f,

},
},
            new SinglerealListD1E2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.6757345f,

0.3491549f,

0.30058765f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.056052268f,

0.646875f,

0.16855758f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.86307067f,

0.97998405f,

0.06978905f,

0.9606687f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6760168f,

0.799092f,

0.77547926f,

0.38985455f,

},
},
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8916829f,

0.9525511f,

0.09929049f,

0.44501567f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3871655f,

0.33289957f,

0.7619471f,

0.054262638f,

},
},
            new SinglerealListD1E2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.96162456f,

0.13356364f,

0.8558551f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.86456597f,

0.8483127f,

0.7070872f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8961889f,

0.7533374f,

0.5057341f,

0.6901214f,

},
},
            new SinglerealListD1E2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.65233076f,

0.60950613f,

0.6785658f,

0.618065f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.106148005f,

0.8219432f,

0.23524368f,

},
},
            new SinglerealListD1E2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.0052313805f,

0.8581154f,

0.0012972355f,

0.9131969f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.21305907f,

0.42797077f,

0.3348478f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.51704454f,

0.5288753f,

0.36772078f,

},
},
            new SinglerealListD1E2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.9507632f,

0.1141904f,

0.46642208f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.39111048f,

0.61582756f,

0.62867135f,

0.30908918f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5525699f,

0.17766523f,

0.12754887f,

0.37781256f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.01941228f,

0.21390617f,

0.37783122f,

0.6407107f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8578302f,

0.06606293f,

0.10032052f,

0.44507933f,

},
},
            new SinglerealListD1E2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.314354f,

0.6846642f,

0.19303018f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6227273f,

0.6394306f,

0.6960256f,

0.8900922f,

},
},
            new SinglerealListD1E2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.12601233f,

0.55425644f,

0.53821564f,

0.9926471f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.2583676f,

0.6537324f,

0.11791861f,

0.74130255f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.43203884f,

0.8483171f,

0.45031244f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.34071445f,

0.12163848f,

0.27719152f,

0.42996973f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8532573f,

0.89845645f,

0.7465029f,

0.25129193f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.34034348f,

0.59202313f,

0.16973823f,

},
},
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.63287455f,

0.5465671f,

0.49305904f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5970114f,

0.19683069f,

0.1292432f,

0.0752123f,

},
},
            new SinglerealListD1E2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.34099537f,

0.3294111f,

0.3753183f,

0.64677805f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.526334f,

0.10481244f,

0.044518173f,

0.6751027f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7065875f,

0.6398203f,

0.24366015f,

},
},
            new SinglerealListD1E2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5860064f,

0.25780058f,

0.0720585f,

0.4044559f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8543553f,

0.4525469f,

0.35384625f,

0.7954122f,

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlereallistd1e2mi(
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
            asPartInterface: typeof(ISingleListrealListD1)),
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
INSERT INTO public.singlereallistd1e2mi(
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
            queryMapTypes: [typeof(SinglerealListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1)),
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

                changedRows =  ((ISingleListrealListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISingleListrealListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ISingleListrealListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleListrealListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ISingleListrealListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ISingleListrealListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ISingleListrealListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ISingleListrealListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((ISingleListrealListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((ISingleListrealListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((ISingleListrealListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((ISingleListrealListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((ISingleListrealListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((ISingleListrealListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((ISingleListrealListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((ISingleListrealListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((ISingleListrealListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlereallistd1e2m(
	id,
    value,
    nullablevalue,
    singlereallistd1e2mi_id
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
            asPartInterface: typeof(ISingleListrealListD1)), 
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
                methodParametrName: "singlereallistd1e2mi_id", 
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
                changedRows =  ((ISingleListrealListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ISingleListrealListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ISingleListrealListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ISingleListrealListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlereallistd1e2m(
	id,
    value,
    nullablevalue,
    singlereallistd1e2mi_id
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
    singlereallistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(SinglerealListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlereallistd1e2m(
	id,
    value,
    nullablevalue,
    singlereallistd1e2mi_id
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
    singlereallistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(SinglerealListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1)),
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
                methodParametrName: "singlereallistd1e2mi_id", 
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
                List<SinglerealListD1E2M> models = null;

                models =  ((ISingleListrealListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((ISingleListrealListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((ISingleListrealListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((ISingleListrealListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<SinglerealListD1E2M> models = null;

                models = await ((ISingleListrealListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((ISingleListrealListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((ISingleListrealListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((ISingleListrealListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((ISingleListrealListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((ISingleListrealListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((ISingleListrealListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((ISingleListrealListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((ISingleListrealListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((ISingleListrealListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((ISingleListrealListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((ISingleListrealListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((ISingleListrealListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((ISingleListrealListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((ISingleListrealListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((ISingleListrealListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((ISingleListrealListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((ISingleListrealListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((ISingleListrealListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((ISingleListrealListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((ISingleListrealListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((ISingleListrealListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((ISingleListrealListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((ISingleListrealListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((ISingleListrealListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((ISingleListrealListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((ISingleListrealListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealListD1E2M), typeof(FlatSinglerealListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1)),
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
FROM public.singlereallistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSinglerealListD1E2M>();
                var models2 = new List<FlatSinglerealListD1E2M>();
                await ((ISingleListrealListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlereallistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSinglerealListD1E2M>();
                var models2 = new List<FlatSinglerealListD1E2M>();
                ((ISingleListrealListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1)),
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
FROM public.singlereallistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ISingleListrealListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlereallistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ISingleListrealListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlereallistd1e2m m
LEFT JOIN public.singlereallistd1e2mi mi ON mi.id = m.singlereallistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(SinglerealListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1)),
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
                var models = await ((ISingleListrealListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ISingleListrealListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealListD1E2M), typeof(FlatSinglerealListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1)),
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
FROM public.singlereallistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealListD1E2M>();
                var models2 = new List<FlatSinglerealListD1E2M>();
                await ((ISingleListrealListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlereallistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealListD1E2M>();
                var models2 = new List<FlatSinglerealListD1E2M>();
                ((ISingleListrealListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1)),
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
FROM public.singlereallistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ISingleListrealListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlereallistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ISingleListrealListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlereallistd1e2m m
LEFT JOIN public.singlereallistd1e2mi mi ON mi.id = m.singlereallistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(SinglerealListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1)),
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
                var models = await ((ISingleListrealListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ISingleListrealListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealListD1E2M), typeof(FlatSinglerealListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1)),
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
            asPartInterface: typeof(ISingleListrealListD1)),
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
FROM public.singlereallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglerealListD1E2M>();
                var models2 = new List<FlatSinglerealListD1E2M>();
                await((ISingleListrealListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 1;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
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
FROM public.singlereallistd1e2m m
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
FROM public.singlereallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealListD1E2M>();
                var firstItems2 = new List<FlatSinglerealListD1E2M>();
                var secondItems1 = new List<FlatSinglerealListD1E2M>();
                var secondItems2 = new List<FlatSinglerealListD1E2M>();
                await ((ISingleListrealListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 137;
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
FROM public.singlereallistd1e2m m
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
FROM public.singlereallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealListD1E2M>();
                var firstItems2 = new List<FlatSinglerealListD1E2M>();
                var secondItems1 = new List<FlatSinglerealListD1E2M>();
                await ((ISingleListrealListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
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
FROM public.singlereallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglerealListD1E2M>();
                var models2 = new List<FlatSinglerealListD1E2M>();
                ((ISingleListrealListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
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
FROM public.singlereallistd1e2m m
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
FROM public.singlereallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealListD1E2M>();
                var firstItems2 = new List<FlatSinglerealListD1E2M>();
                var secondItems1 = new List<FlatSinglerealListD1E2M>();
                var secondItems2 = new List<FlatSinglerealListD1E2M>();
                 ((ISingleListrealListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
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
FROM public.singlereallistd1e2m m
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
FROM public.singlereallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealListD1E2M>();
                var firstItems2 = new List<FlatSinglerealListD1E2M>();
                var secondItems1 = new List<FlatSinglerealListD1E2M>();
                 ((ISingleListrealListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1)),
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
            asPartInterface: typeof(ISingleListrealListD1)),
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
FROM public.singlereallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ISingleListrealListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlereallistd1e2m m
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
FROM public.singlereallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleListrealListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatSinglerealListD1E2M.AssertModel(models[0],_testData[7], false);
                        FlatSinglerealListD1E2M.AssertModel(models[1],_testData[8], false);
                        FlatSinglerealListD1E2M.AssertModel(models[2],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(models[3],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(models[4],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(models[5],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(models[6],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(models[7],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(models[8],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(models[9],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(models[10],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(models[11],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(models[12],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(models[13],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(models[14],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(models[15],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(models[16],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(models[17],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(models[18],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(models[19],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(models[20],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(models[21],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(models[22],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(models[23],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(models[24],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(models[25],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(models[26],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatSinglerealListD1E2M.AssertModel(models[0],_testData[3], false);
                        FlatSinglerealListD1E2M.AssertModel(models[1],_testData[4], false);
                        FlatSinglerealListD1E2M.AssertModel(models[2],_testData[5], false);
                        FlatSinglerealListD1E2M.AssertModel(models[3],_testData[6], false);
                        FlatSinglerealListD1E2M.AssertModel(models[4],_testData[7], false);
                        FlatSinglerealListD1E2M.AssertModel(models[5],_testData[8], false);
                        FlatSinglerealListD1E2M.AssertModel(models[6],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(models[7],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(models[8],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(models[9],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(models[10],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(models[11],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(models[12],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(models[13],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(models[14],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(models[15],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(models[16],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(models[17],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(models[18],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(models[19],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(models[20],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(models[21],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(models[22],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(models[23],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(models[24],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(models[25],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(models[26],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(models[27],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(models[28],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(models[29],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(models[30],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlereallistd1e2m m
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
FROM public.singlereallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealListD1E2M>();
                var secondItems1 = new List<FlatSinglerealListD1E2M>();
                var secondItems2 = new List<FlatSinglerealListD1E2M>();
                await ((ISingleListrealListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.singlereallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ISingleListrealListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlereallistd1e2m m
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
FROM public.singlereallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleListrealListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatSinglerealListD1E2M.AssertModel(models[0],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(models[1],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(models[2],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(models[3],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(models[4],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(models[5],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(models[6],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(models[7],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(models[8],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(models[9],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(models[10],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(models[11],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(models[12],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(models[13],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(models[14],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatSinglerealListD1E2M.AssertModel(models[0],_testData[8], false);
                        FlatSinglerealListD1E2M.AssertModel(models[1],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(models[2],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(models[3],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(models[4],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(models[5],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(models[6],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(models[7],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(models[8],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(models[9],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(models[10],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(models[11],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(models[12],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(models[13],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(models[14],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(models[15],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(models[16],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(models[17],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(models[18],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(models[19],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(models[20],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(models[21],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(models[22],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(models[23],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(models[24],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(models[25],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlereallistd1e2m m
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
FROM public.singlereallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealListD1E2M>();
                var secondItems1 = new List<FlatSinglerealListD1E2M>();
                var secondItems2 = new List<FlatSinglerealListD1E2M>();
                 ((ISingleListrealListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.singlereallistd1e2m m
LEFT JOIN public.singlereallistd1e2mi mi ON mi.id = m.singlereallistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(SinglerealListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1)),
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
                var models = await((ISingleListrealListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleListrealListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        SinglerealListD1E2M.AssertModel(models[0],_testData[21], false);
                        SinglerealListD1E2M.AssertModel(models[1],_testData[22], false);
                        SinglerealListD1E2M.AssertModel(models[2],_testData[23], false);
                        SinglerealListD1E2M.AssertModel(models[3],_testData[24], false);
                        SinglerealListD1E2M.AssertModel(models[4],_testData[25], false);
                        SinglerealListD1E2M.AssertModel(models[5],_testData[26], false);
                        SinglerealListD1E2M.AssertModel(models[6],_testData[27], false);
                        SinglerealListD1E2M.AssertModel(models[7],_testData[28], false);
                        SinglerealListD1E2M.AssertModel(models[8],_testData[29], false);
                        SinglerealListD1E2M.AssertModel(models[9],_testData[30], false);
                        SinglerealListD1E2M.AssertModel(models[10],_testData[31], false);
                        SinglerealListD1E2M.AssertModel(models[11],_testData[32], false);
                        SinglerealListD1E2M.AssertModel(models[12],_testData[33], false);
                        SinglerealListD1E2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        SinglerealListD1E2M.AssertModel(models[0],_testData[21], false);
                        SinglerealListD1E2M.AssertModel(models[1],_testData[22], false);
                        SinglerealListD1E2M.AssertModel(models[2],_testData[23], false);
                        SinglerealListD1E2M.AssertModel(models[3],_testData[24], false);
                        SinglerealListD1E2M.AssertModel(models[4],_testData[25], false);
                        SinglerealListD1E2M.AssertModel(models[5],_testData[26], false);
                        SinglerealListD1E2M.AssertModel(models[6],_testData[27], false);
                        SinglerealListD1E2M.AssertModel(models[7],_testData[28], false);
                        SinglerealListD1E2M.AssertModel(models[8],_testData[29], false);
                        SinglerealListD1E2M.AssertModel(models[9],_testData[30], false);
                        SinglerealListD1E2M.AssertModel(models[10],_testData[31], false);
                        SinglerealListD1E2M.AssertModel(models[11],_testData[32], false);
                        SinglerealListD1E2M.AssertModel(models[12],_testData[33], false);
                        SinglerealListD1E2M.AssertModel(models[13],_testData[34], false);
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
                var models = ((ISingleListrealListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleListrealListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        SinglerealListD1E2M.AssertModel(models[0],_testData[32], false);
                        SinglerealListD1E2M.AssertModel(models[1],_testData[33], false);
                        SinglerealListD1E2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        SinglerealListD1E2M.AssertModel(models[0],_testData[21], false);
                        SinglerealListD1E2M.AssertModel(models[1],_testData[22], false);
                        SinglerealListD1E2M.AssertModel(models[2],_testData[23], false);
                        SinglerealListD1E2M.AssertModel(models[3],_testData[24], false);
                        SinglerealListD1E2M.AssertModel(models[4],_testData[25], false);
                        SinglerealListD1E2M.AssertModel(models[5],_testData[26], false);
                        SinglerealListD1E2M.AssertModel(models[6],_testData[27], false);
                        SinglerealListD1E2M.AssertModel(models[7],_testData[28], false);
                        SinglerealListD1E2M.AssertModel(models[8],_testData[29], false);
                        SinglerealListD1E2M.AssertModel(models[9],_testData[30], false);
                        SinglerealListD1E2M.AssertModel(models[10],_testData[31], false);
                        SinglerealListD1E2M.AssertModel(models[11],_testData[32], false);
                        SinglerealListD1E2M.AssertModel(models[12],_testData[33], false);
                        SinglerealListD1E2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealListD1E2M), typeof(FlatSinglerealListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1)),
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
            asPartInterface: typeof(ISingleListrealListD1)),
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
            asPartInterface: typeof(ISingleListrealListD1)),
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
FROM public.singlereallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealListD1E2M>();
                var models2 = new List<FlatSinglerealListD1E2M>();
                await((ISingleListrealListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlereallistd1e2m m
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
FROM public.singlereallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealListD1E2M>();
                var firstItems2 = new List<FlatSinglerealListD1E2M>();
                var secondItems1 = new List<FlatSinglerealListD1E2M>();
                var secondItems2 = new List<FlatSinglerealListD1E2M>();
                await ((ISingleListrealListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 31, query1, 93, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.singlereallistd1e2m m
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
FROM public.singlereallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealListD1E2M>();
                var firstItems2 = new List<FlatSinglerealListD1E2M>();
                var secondItems1 = new List<FlatSinglerealListD1E2M>();
                await ((ISingleListrealListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 110, query1, 83, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[16],_testData[34], false);
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
FROM public.singlereallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealListD1E2M>();
                var models2 = new List<FlatSinglerealListD1E2M>();
                ((ISingleListrealListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlereallistd1e2m m
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
FROM public.singlereallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealListD1E2M>();
                var firstItems2 = new List<FlatSinglerealListD1E2M>();
                var secondItems1 = new List<FlatSinglerealListD1E2M>();
                var secondItems2 = new List<FlatSinglerealListD1E2M>();
                 ((ISingleListrealListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 81, query1, 93, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.singlereallistd1e2m m
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
FROM public.singlereallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealListD1E2M>();
                var firstItems2 = new List<FlatSinglerealListD1E2M>();
                var secondItems1 = new List<FlatSinglerealListD1E2M>();
                 ((ISingleListrealListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 17, query1, 86, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1)),
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
            asPartInterface: typeof(ISingleListrealListD1)),
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
            asPartInterface: typeof(ISingleListrealListD1)),
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
FROM public.singlereallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ISingleListrealListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlereallistd1e2m m
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
FROM public.singlereallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleListrealListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 5, query1, 113, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatSinglerealListD1E2M.AssertModel(models[0],_testData[2], false);
                        FlatSinglerealListD1E2M.AssertModel(models[1],_testData[3], false);
                        FlatSinglerealListD1E2M.AssertModel(models[2],_testData[4], false);
                        FlatSinglerealListD1E2M.AssertModel(models[3],_testData[5], false);
                        FlatSinglerealListD1E2M.AssertModel(models[4],_testData[6], false);
                        FlatSinglerealListD1E2M.AssertModel(models[5],_testData[7], false);
                        FlatSinglerealListD1E2M.AssertModel(models[6],_testData[8], false);
                        FlatSinglerealListD1E2M.AssertModel(models[7],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(models[8],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(models[9],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(models[10],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(models[11],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(models[12],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(models[13],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(models[14],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(models[15],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(models[16],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(models[17],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(models[18],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(models[19],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(models[20],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(models[21],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(models[22],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(models[23],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(models[24],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(models[25],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(models[26],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(models[27],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(models[28],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(models[29],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(models[30],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(models[31],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatSinglerealListD1E2M.AssertModel(models[0],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(models[1],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(models[2],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(models[3],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(models[4],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(models[5],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(models[6],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(models[7],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(models[8],_testData[34], false);
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
FROM public.singlereallistd1e2m m
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
FROM public.singlereallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealListD1E2M>();
                var secondItems1 = new List<FlatSinglerealListD1E2M>();
                var secondItems2 = new List<FlatSinglerealListD1E2M>();
                await ((ISingleListrealListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 120, query1, 137, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.singlereallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ISingleListrealListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlereallistd1e2m m
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
FROM public.singlereallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleListrealListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 53, query1, 140, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatSinglerealListD1E2M.AssertModel(models[0],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(models[1],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(models[2],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(models[3],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(models[4],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(models[5],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(models[6],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(models[7],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(models[8],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(models[9],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(models[10],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(models[11],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(models[12],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(models[13],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(models[14],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(models[15],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(models[16],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(models[17],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(models[18],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(models[19],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(models[20],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(models[21],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(models[22],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatSinglerealListD1E2M.AssertModel(models[0],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(models[1],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(models[2],_testData[34], false);
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
FROM public.singlereallistd1e2m m
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
FROM public.singlereallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealListD1E2M>();
                var secondItems1 = new List<FlatSinglerealListD1E2M>();
                var secondItems2 = new List<FlatSinglerealListD1E2M>();
                 ((ISingleListrealListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 120, query1, 110, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.singlereallistd1e2m m
LEFT JOIN public.singlereallistd1e2mi mi ON mi.id = m.singlereallistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(SinglerealListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1)),
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
            asPartInterface: typeof(ISingleListrealListD1)),
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
                var models = await((ISingleListrealListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ISingleListrealListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 46, 31))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        SinglerealListD1E2M.AssertModel(models[0],_testData[10], false);
                        SinglerealListD1E2M.AssertModel(models[1],_testData[11], false);
                        SinglerealListD1E2M.AssertModel(models[2],_testData[12], false);
                        SinglerealListD1E2M.AssertModel(models[3],_testData[13], false);
                        SinglerealListD1E2M.AssertModel(models[4],_testData[14], false);
                        SinglerealListD1E2M.AssertModel(models[5],_testData[15], false);
                        SinglerealListD1E2M.AssertModel(models[6],_testData[16], false);
                        SinglerealListD1E2M.AssertModel(models[7],_testData[17], false);
                        SinglerealListD1E2M.AssertModel(models[8],_testData[18], false);
                        SinglerealListD1E2M.AssertModel(models[9],_testData[19], false);
                        SinglerealListD1E2M.AssertModel(models[10],_testData[20], false);
                        SinglerealListD1E2M.AssertModel(models[11],_testData[21], false);
                        SinglerealListD1E2M.AssertModel(models[12],_testData[22], false);
                        SinglerealListD1E2M.AssertModel(models[13],_testData[23], false);
                        SinglerealListD1E2M.AssertModel(models[14],_testData[24], false);
                        SinglerealListD1E2M.AssertModel(models[15],_testData[25], false);
                        SinglerealListD1E2M.AssertModel(models[16],_testData[26], false);
                        SinglerealListD1E2M.AssertModel(models[17],_testData[27], false);
                        SinglerealListD1E2M.AssertModel(models[18],_testData[28], false);
                        SinglerealListD1E2M.AssertModel(models[19],_testData[29], false);
                        SinglerealListD1E2M.AssertModel(models[20],_testData[30], false);
                        SinglerealListD1E2M.AssertModel(models[21],_testData[31], false);
                        SinglerealListD1E2M.AssertModel(models[22],_testData[32], false);
                        SinglerealListD1E2M.AssertModel(models[23],_testData[33], false);
                        SinglerealListD1E2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        SinglerealListD1E2M.AssertModel(models[0],_testData[7], false);
                        SinglerealListD1E2M.AssertModel(models[1],_testData[8], false);
                        SinglerealListD1E2M.AssertModel(models[2],_testData[9], false);
                        SinglerealListD1E2M.AssertModel(models[3],_testData[10], false);
                        SinglerealListD1E2M.AssertModel(models[4],_testData[11], false);
                        SinglerealListD1E2M.AssertModel(models[5],_testData[12], false);
                        SinglerealListD1E2M.AssertModel(models[6],_testData[13], false);
                        SinglerealListD1E2M.AssertModel(models[7],_testData[14], false);
                        SinglerealListD1E2M.AssertModel(models[8],_testData[15], false);
                        SinglerealListD1E2M.AssertModel(models[9],_testData[16], false);
                        SinglerealListD1E2M.AssertModel(models[10],_testData[17], false);
                        SinglerealListD1E2M.AssertModel(models[11],_testData[18], false);
                        SinglerealListD1E2M.AssertModel(models[12],_testData[19], false);
                        SinglerealListD1E2M.AssertModel(models[13],_testData[20], false);
                        SinglerealListD1E2M.AssertModel(models[14],_testData[21], false);
                        SinglerealListD1E2M.AssertModel(models[15],_testData[22], false);
                        SinglerealListD1E2M.AssertModel(models[16],_testData[23], false);
                        SinglerealListD1E2M.AssertModel(models[17],_testData[24], false);
                        SinglerealListD1E2M.AssertModel(models[18],_testData[25], false);
                        SinglerealListD1E2M.AssertModel(models[19],_testData[26], false);
                        SinglerealListD1E2M.AssertModel(models[20],_testData[27], false);
                        SinglerealListD1E2M.AssertModel(models[21],_testData[28], false);
                        SinglerealListD1E2M.AssertModel(models[22],_testData[29], false);
                        SinglerealListD1E2M.AssertModel(models[23],_testData[30], false);
                        SinglerealListD1E2M.AssertModel(models[24],_testData[31], false);
                        SinglerealListD1E2M.AssertModel(models[25],_testData[32], false);
                        SinglerealListD1E2M.AssertModel(models[26],_testData[33], false);
                        SinglerealListD1E2M.AssertModel(models[27],_testData[34], false);
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
                var models = ((ISingleListrealListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ISingleListrealListD1)this).DbConnectionSTSelectModelBatch(connection, 61, 113))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        SinglerealListD1E2M.AssertModel(models[0],_testData[13], false);
                        SinglerealListD1E2M.AssertModel(models[1],_testData[14], false);
                        SinglerealListD1E2M.AssertModel(models[2],_testData[15], false);
                        SinglerealListD1E2M.AssertModel(models[3],_testData[16], false);
                        SinglerealListD1E2M.AssertModel(models[4],_testData[17], false);
                        SinglerealListD1E2M.AssertModel(models[5],_testData[18], false);
                        SinglerealListD1E2M.AssertModel(models[6],_testData[19], false);
                        SinglerealListD1E2M.AssertModel(models[7],_testData[20], false);
                        SinglerealListD1E2M.AssertModel(models[8],_testData[21], false);
                        SinglerealListD1E2M.AssertModel(models[9],_testData[22], false);
                        SinglerealListD1E2M.AssertModel(models[10],_testData[23], false);
                        SinglerealListD1E2M.AssertModel(models[11],_testData[24], false);
                        SinglerealListD1E2M.AssertModel(models[12],_testData[25], false);
                        SinglerealListD1E2M.AssertModel(models[13],_testData[26], false);
                        SinglerealListD1E2M.AssertModel(models[14],_testData[27], false);
                        SinglerealListD1E2M.AssertModel(models[15],_testData[28], false);
                        SinglerealListD1E2M.AssertModel(models[16],_testData[29], false);
                        SinglerealListD1E2M.AssertModel(models[17],_testData[30], false);
                        SinglerealListD1E2M.AssertModel(models[18],_testData[31], false);
                        SinglerealListD1E2M.AssertModel(models[19],_testData[32], false);
                        SinglerealListD1E2M.AssertModel(models[20],_testData[33], false);
                        SinglerealListD1E2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        SinglerealListD1E2M.AssertModel(models[0],_testData[26], false);
                        SinglerealListD1E2M.AssertModel(models[1],_testData[27], false);
                        SinglerealListD1E2M.AssertModel(models[2],_testData[28], false);
                        SinglerealListD1E2M.AssertModel(models[3],_testData[29], false);
                        SinglerealListD1E2M.AssertModel(models[4],_testData[30], false);
                        SinglerealListD1E2M.AssertModel(models[5],_testData[31], false);
                        SinglerealListD1E2M.AssertModel(models[6],_testData[32], false);
                        SinglerealListD1E2M.AssertModel(models[7],_testData[33], false);
                        SinglerealListD1E2M.AssertModel(models[8],_testData[34], false);
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
                await using var cmd = await ((ISingleListrealListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ISingleListrealListD1)this).SetDbConnectionSelectModelParametrs(cmd, 81);
                var models = await ((ISingleListrealListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

                SinglerealListD1E2M.AssertModel(models[0],_testData[17], false);
                SinglerealListD1E2M.AssertModel(models[1],_testData[18], false);
                SinglerealListD1E2M.AssertModel(models[2],_testData[19], false);
                SinglerealListD1E2M.AssertModel(models[3],_testData[20], false);
                SinglerealListD1E2M.AssertModel(models[4],_testData[21], false);
                SinglerealListD1E2M.AssertModel(models[5],_testData[22], false);
                SinglerealListD1E2M.AssertModel(models[6],_testData[23], false);
                SinglerealListD1E2M.AssertModel(models[7],_testData[24], false);
                SinglerealListD1E2M.AssertModel(models[8],_testData[25], false);
                SinglerealListD1E2M.AssertModel(models[9],_testData[26], false);
                SinglerealListD1E2M.AssertModel(models[10],_testData[27], false);
                SinglerealListD1E2M.AssertModel(models[11],_testData[28], false);
                SinglerealListD1E2M.AssertModel(models[12],_testData[29], false);
                SinglerealListD1E2M.AssertModel(models[13],_testData[30], false);
                SinglerealListD1E2M.AssertModel(models[14],_testData[31], false);
                SinglerealListD1E2M.AssertModel(models[15],_testData[32], false);
                SinglerealListD1E2M.AssertModel(models[16],_testData[33], false);
                SinglerealListD1E2M.AssertModel(models[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleListrealListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleListrealListD1)this).SetDbConnectionSelectModelParametrs(cmd, 11);
                var models =  ((ISingleListrealListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(32));

                SinglerealListD1E2M.AssertModel(models[0],_testData[3], false);
                SinglerealListD1E2M.AssertModel(models[1],_testData[4], false);
                SinglerealListD1E2M.AssertModel(models[2],_testData[5], false);
                SinglerealListD1E2M.AssertModel(models[3],_testData[6], false);
                SinglerealListD1E2M.AssertModel(models[4],_testData[7], false);
                SinglerealListD1E2M.AssertModel(models[5],_testData[8], false);
                SinglerealListD1E2M.AssertModel(models[6],_testData[9], false);
                SinglerealListD1E2M.AssertModel(models[7],_testData[10], false);
                SinglerealListD1E2M.AssertModel(models[8],_testData[11], false);
                SinglerealListD1E2M.AssertModel(models[9],_testData[12], false);
                SinglerealListD1E2M.AssertModel(models[10],_testData[13], false);
                SinglerealListD1E2M.AssertModel(models[11],_testData[14], false);
                SinglerealListD1E2M.AssertModel(models[12],_testData[15], false);
                SinglerealListD1E2M.AssertModel(models[13],_testData[16], false);
                SinglerealListD1E2M.AssertModel(models[14],_testData[17], false);
                SinglerealListD1E2M.AssertModel(models[15],_testData[18], false);
                SinglerealListD1E2M.AssertModel(models[16],_testData[19], false);
                SinglerealListD1E2M.AssertModel(models[17],_testData[20], false);
                SinglerealListD1E2M.AssertModel(models[18],_testData[21], false);
                SinglerealListD1E2M.AssertModel(models[19],_testData[22], false);
                SinglerealListD1E2M.AssertModel(models[20],_testData[23], false);
                SinglerealListD1E2M.AssertModel(models[21],_testData[24], false);
                SinglerealListD1E2M.AssertModel(models[22],_testData[25], false);
                SinglerealListD1E2M.AssertModel(models[23],_testData[26], false);
                SinglerealListD1E2M.AssertModel(models[24],_testData[27], false);
                SinglerealListD1E2M.AssertModel(models[25],_testData[28], false);
                SinglerealListD1E2M.AssertModel(models[26],_testData[29], false);
                SinglerealListD1E2M.AssertModel(models[27],_testData[30], false);
                SinglerealListD1E2M.AssertModel(models[28],_testData[31], false);
                SinglerealListD1E2M.AssertModel(models[29],_testData[32], false);
                SinglerealListD1E2M.AssertModel(models[30],_testData[33], false);
                SinglerealListD1E2M.AssertModel(models[31],_testData[34], false);
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
FROM public.binary_singlereallistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(SinglerealListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(SinglerealListD1E2MIWA),
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
            asPartInterface: typeof(ISingleListrealListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISingleListrealListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_singlereallistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISingleListrealListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISingleListrealListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_singlereallistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISingleListrealListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_singlereallistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(SinglerealListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(SinglerealListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISingleListrealListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_singlereallistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISingleListrealListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISingleListrealListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_singlereallistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISingleListrealListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_singlereallistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(SinglerealListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlereallistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(SinglerealListD1E2MI),
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
            asPartInterface: typeof(ISingleListrealListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ISingleListrealListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((ISingleListrealListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ISingleListrealListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((ISingleListrealListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_singlereallistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(SinglerealListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlereallistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(SinglerealListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISingleListrealListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ISingleListrealListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISingleListrealListD1)this).ImportModelInner(connection, importCollection);
                var models = ((ISingleListrealListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlereallistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
singlereallistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(SinglerealListD1E2M),
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
            asPartInterface: typeof(ISingleListrealListD1))]
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
FROM public.binary_singlereallistd1e2m m
LEFT JOIN public.binary_singlereallistd1e2mi mi ON mi.id = m.singlereallistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(SinglerealListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((ISingleListrealListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((ISingleListrealListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    SinglerealListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((ISingleListrealListD1)this).ImportModel(connection, importCollection);
                var models = ((ISingleListrealListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    SinglerealListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlereallistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    singlereallistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(SinglerealListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1)),
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
                var models =  ((ISingleListrealListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SinglerealListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleListrealListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SinglerealListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(SinglerealListD1E2MIWA), typeof(SinglerealListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1)),
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
                var models1 = new List<SinglerealListD1E2MIWA>();
                var models2 = new List<SinglerealListD1E2MIWA>();
                await ((ISingleListrealListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlereallistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealListD1E2MIWA>();
                var models2 = new List<SinglerealListD1E2MIWA>();
                ((ISingleListrealListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlereallistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(SinglerealListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1)),
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
                var models = await ((ISingleListrealListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_singlereallistd1e2mi
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
                    SinglerealListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleListrealListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_singlereallistd1e2mi
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
                    SinglerealListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(SinglerealListD1E2MIWA), typeof(SinglerealListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1))]
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
                var models1 = new List<SinglerealListD1E2MIWA>();
                var models2 = new List<SinglerealListD1E2MIWA>();
                await ((ISingleListrealListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlereallistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealListD1E2MIWA>();
                var models2 = new List<SinglerealListD1E2MIWA>();
                ((ISingleListrealListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlereallistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(SinglerealListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1))]
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
                var models = await ((ISingleListrealListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_singlereallistd1e2mi
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
                    SinglerealListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleListrealListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_singlereallistd1e2mi
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
                    SinglerealListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_singlereallistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(SinglerealListD1E2MI), typeof(SinglerealListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1)),
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
                var models1 = new List<SinglerealListD1E2MI>();
                var models2 = new List<SinglerealListD1E2MI>();
                await ((ISingleListrealListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealListD1E2MI>();
                var models2 = new List<SinglerealListD1E2MI>();
                ((ISingleListrealListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlereallistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(SinglerealListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1)),
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
                var models = await ((ISingleListrealListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleListrealListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_singlereallistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(SinglerealListD1E2MIWA), typeof(SinglerealListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1))]
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
                var models1 = new List<SinglerealListD1E2MIWA>();
                var models2 = new List<SinglerealListD1E2MIWA>();
                await ((ISingleListrealListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealListD1E2MIWA>();
                var models2 = new List<SinglerealListD1E2MIWA>();
                ((ISingleListrealListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlereallistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(SinglerealListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealListD1))]
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
                var models = await ((ISingleListrealListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleListrealListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

