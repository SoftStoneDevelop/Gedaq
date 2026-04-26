

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
    internal partial interface ISingleListrealArray
    {
    }
    
    internal partial class SingleListrealArray : ISingleListrealArray
    {


#region TestData

        private readonly SinglerealArray2M[] _testData = new SinglerealArray2M[]
        {
            new SinglerealArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.17251277f,

0.12759334f,

0.80081356f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8774448f,

0.38868988f,

0.2645154f,

0.4588989f,

},
},
            new SinglerealArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.5334258f,

0.3168401f,

0.07448745f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.17496306f,

0.6265146f,

0.22749841f,

0.32351297f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.15657914f,

0.3392483f,

0.08589798f,

0.15479982f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.83323014f,

0.4581409f,

0.2841835f,

0.47674388f,

},
},
            new SinglerealArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.14806002f,

0.9678508f,

0.28912657f,

0.17813748f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.672961f,

0.948073f,

0.9847458f,

0.047277868f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.9713704f,

0.6593887f,

0.11332214f,

},
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.68244153f,

0.4139049f,

0.97351426f,

0.98797107f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.0902763f,

0.8028899f,

0.9020073f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.59740925f,

0.9796004f,

0.28897053f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.7346494f,

0.46581423f,

0.66437113f,

0.13461578f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.35454005f,

0.65890104f,

0.44778496f,

},
},
            new SinglerealArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.64925474f,

0.98649037f,

0.8195517f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.4277625f,

0.780638f,

0.36390734f,

0.19789076f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.32534778f,

0.9905847f,

0.43681312f,

0.07719976f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.4300865f,

0.39614803f,

0.9071598f,

0.08007741f,

},
},
            new SinglerealArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.123336494f,

0.53175616f,

0.13222438f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.5238839f,

0.66717243f,

0.22585481f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.019817948f,

0.30793697f,

0.06905687f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.21653491f,

0.42663234f,

0.12092286f,

},
},
            new SinglerealArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.20483744f,

0.10087407f,

0.5209894f,

0.9308883f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6500946f,

0.78330266f,

0.119445086f,

0.6955103f,

},
},
            new SinglerealArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.52837807f,

0.76481014f,

0.86758006f,

0.37765592f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.99264693f,

0.54238254f,

0.80136484f,

0.5582333f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5333152f,

0.406471f,

0.7460734f,

0.1015389f,

},
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.32899255f,

0.6034844f,

0.81116855f,

0.33409536f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.043696165f,

0.13059646f,

0.6629266f,

0.22881436f,

},
},
            new SinglerealArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7058885f,

0.14525557f,

0.6673375f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.911639f,

0.44886208f,

0.6451246f,

0.5458434f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.07272869f,

0.38043058f,

0.14040577f,

0.73123366f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.81113213f,

0.39196324f,

0.03817886f,

},
},
            new SinglerealArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.26837826f,

0.12359357f,

0.8113166f,

0.1560266f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.21407545f,

0.72357756f,

0.5750564f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.13377976f,

0.7656622f,

0.21452743f,

0.37430143f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.6421599f,

0.6559794f,

0.97302836f,

},
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.6693789f,

0.38840705f,

0.6140494f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.15324879f,

0.6589397f,

0.3772633f,

0.2494244f,

},
},
            new SinglerealArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.42546475f,

0.83092445f,

0.92335033f,

0.41903394f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5957503f,

0.87760764f,

0.64012504f,

0.9533927f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.81290513f,

0.10482687f,

0.0009531975f,

0.057241857f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3722381f,

0.2970947f,

0.02764666f,

0.69774514f,

},
},
            new SinglerealArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.20739007f,

0.029254079f,

0.8672623f,

0.42754012f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.24984556f,

0.4614259f,

0.07121551f,

0.12518859f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.29608965f,

0.96466243f,

0.24596578f,

0.11285001f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9948076f,

0.29248345f,

0.22347105f,

0.92823505f,

},
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.23181325f,

0.31347722f,

0.89444035f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.5759202f,

0.8501278f,

0.34351945f,

},
},
            new SinglerealArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.59282917f,

0.76341206f,

0.784553f,

0.9289469f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.71993196f,

0.28197002f,

0.4119575f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.77310896f,

0.11015844f,

0.10996491f,

0.850953f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.37282228f,

0.073829055f,

0.1738413f,

},
},
            new SinglerealArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.41156566f,

0.99777704f,

0.41872627f,

0.6515712f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.13256496f,

0.011896849f,

0.30893463f,

0.26971704f,

},
},
            new SinglerealArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.35202217f,

0.23799396f,

0.09783292f,

0.8816538f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.60110986f,

0.3231172f,

0.85795754f,

0.90206575f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7035659f,

0.9112329f,

0.905774f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8255193f,

0.19917601f,

0.24404949f,

},
},
            new SinglerealArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8617824f,

0.5429428f,

0.14892262f,

0.55811644f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.24708271f,

0.2767579f,

0.6281911f,

0.5278227f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.69018656f,

0.7700205f,

0.6820689f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.9846135f,

0.85632354f,

0.6574367f,

},
},
            new SinglerealArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9871066f,

0.8307719f,

0.9491782f,

0.5938276f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.9285861f,

0.12293631f,

0.6990933f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.010884166f,

0.6904259f,

0.8130063f,

0.88752985f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.47392577f,

0.4354238f,

0.7897204f,

0.08099747f,

},
},
            new SinglerealArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.22139776f,

0.6965833f,

0.41488147f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.70097405f,

0.085871994f,

0.18317056f,

0.68418616f,

},
},
            new SinglerealArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.45612526f,

0.9146767f,

0.44377673f,

0.15288383f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.23955905f,

0.36964154f,

0.6219178f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.36123747f,

0.7074939f,

0.09692788f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.88609844f,

0.24756962f,

0.3077976f,

0.05109805f,

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray2mi(
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
            asPartInterface: typeof(ISingleListrealArray)),
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
INSERT INTO public.singlerealarray2mi(
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
            queryMapTypes: [typeof(SinglerealArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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

                changedRows =  ((ISingleListrealArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISingleListrealArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ISingleListrealArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleListrealArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ISingleListrealArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ISingleListrealArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray2m(
	id,
    value,
    nullablevalue,
    singlerealarray2mi_id
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
            asPartInterface: typeof(ISingleListrealArray)), 
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
                methodParametrName: "singlerealarray2mi_id", 
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
                changedRows =  ((ISingleListrealArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ISingleListrealArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ISingleListrealArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ISingleListrealArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray2m(
	id,
    value,
    nullablevalue,
    singlerealarray2mi_id
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
    singlerealarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(SinglerealArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealarray2m(
	id,
    value,
    nullablevalue,
    singlerealarray2mi_id
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
    singlerealarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(SinglerealArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
                methodParametrName: "singlerealarray2mi_id", 
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
                List<SinglerealArray2M> models = null;

                models =  ((ISingleListrealArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((ISingleListrealArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((ISingleListrealArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((ISingleListrealArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<SinglerealArray2M> models = null;

                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealArray2M), typeof(FlatSinglerealArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
FROM public.singlerealarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSinglerealArray2M>();
                var models2 = new List<FlatSinglerealArray2M>();
                await ((ISingleListrealArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSinglerealArray2M>();
                var models2 = new List<FlatSinglerealArray2M>();
                ((ISingleListrealArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
FROM public.singlerealarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ISingleListrealArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ISingleListrealArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray2m m
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(SinglerealArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
                var models = await ((ISingleListrealArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ISingleListrealArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealArray2M), typeof(FlatSinglerealArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
FROM public.singlerealarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealArray2M>();
                var models2 = new List<FlatSinglerealArray2M>();
                await ((ISingleListrealArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealArray2M>();
                var models2 = new List<FlatSinglerealArray2M>();
                ((ISingleListrealArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
FROM public.singlerealarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ISingleListrealArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ISingleListrealArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealarray2m m
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(SinglerealArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
                var models = await ((ISingleListrealArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ISingleListrealArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealArray2M), typeof(FlatSinglerealArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
            asPartInterface: typeof(ISingleListrealArray)),
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglerealArray2M>();
                var models2 = new List<FlatSinglerealArray2M>();
                await((ISingleListrealArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var firstItems2 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                var secondItems2 = new List<FlatSinglerealArray2M>();
                await ((ISingleListrealArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[28],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
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
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var firstItems2 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                await ((ISingleListrealArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[29], false);
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglerealArray2M>();
                var models2 = new List<FlatSinglerealArray2M>();
                ((ISingleListrealArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
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
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var firstItems2 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                var secondItems2 = new List<FlatSinglerealArray2M>();
                 ((ISingleListrealArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[27],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var firstItems2 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                 ((ISingleListrealArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
            asPartInterface: typeof(ISingleListrealArray)),
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ISingleListrealArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ISingleListrealArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[7],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[8],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[9],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[10],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[11],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[3], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(models[7],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(models[8],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(models[9],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(models[10],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(models[11],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(models[12],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(models[13],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(models[14],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(models[15],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(models[16],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(models[17],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(models[18],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(models[19],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(models[20],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[21],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[22],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[23],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[24],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[25],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[26],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                var secondItems2 = new List<FlatSinglerealArray2M>();
                await ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[30], false);
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((ISingleListrealArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(models[7],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(models[8],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(models[9],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(models[10],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(models[11],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(models[12],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(models[13],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[14],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[15],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[16],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[17],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[18],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(models[7],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(models[8],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(models[9],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(models[10],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(models[11],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(models[12],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(models[13],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(models[14],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(models[15],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(models[16],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(models[17],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(models[18],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(models[19],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[20],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[21],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[22],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[23],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[24],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[25],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                var secondItems2 = new List<FlatSinglerealArray2M>();
                 ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[17],_testData[30], false);
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
FROM public.singlerealarray2m m
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(SinglerealArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
                var models = await((ISingleListrealArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((ISingleListrealArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        SinglerealArray2M.AssertModel(models[0],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        SinglerealArray2M.AssertModel(models[0],_testData[1], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[2], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[3], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[4], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[5], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[6], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[7], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[8], false);
                        SinglerealArray2M.AssertModel(models[8],_testData[9], false);
                        SinglerealArray2M.AssertModel(models[9],_testData[10], false);
                        SinglerealArray2M.AssertModel(models[10],_testData[11], false);
                        SinglerealArray2M.AssertModel(models[11],_testData[12], false);
                        SinglerealArray2M.AssertModel(models[12],_testData[13], false);
                        SinglerealArray2M.AssertModel(models[13],_testData[14], false);
                        SinglerealArray2M.AssertModel(models[14],_testData[15], false);
                        SinglerealArray2M.AssertModel(models[15],_testData[16], false);
                        SinglerealArray2M.AssertModel(models[16],_testData[17], false);
                        SinglerealArray2M.AssertModel(models[17],_testData[18], false);
                        SinglerealArray2M.AssertModel(models[18],_testData[19], false);
                        SinglerealArray2M.AssertModel(models[19],_testData[20], false);
                        SinglerealArray2M.AssertModel(models[20],_testData[21], false);
                        SinglerealArray2M.AssertModel(models[21],_testData[22], false);
                        SinglerealArray2M.AssertModel(models[22],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[23],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[24],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[25],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[26],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[27],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[28],_testData[29], false);
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
                var models = ((ISingleListrealArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((ISingleListrealArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        SinglerealArray2M.AssertModel(models[0],_testData[6], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[7], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[8], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[9], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[10], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[11], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[12], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[13], false);
                        SinglerealArray2M.AssertModel(models[8],_testData[14], false);
                        SinglerealArray2M.AssertModel(models[9],_testData[15], false);
                        SinglerealArray2M.AssertModel(models[10],_testData[16], false);
                        SinglerealArray2M.AssertModel(models[11],_testData[17], false);
                        SinglerealArray2M.AssertModel(models[12],_testData[18], false);
                        SinglerealArray2M.AssertModel(models[13],_testData[19], false);
                        SinglerealArray2M.AssertModel(models[14],_testData[20], false);
                        SinglerealArray2M.AssertModel(models[15],_testData[21], false);
                        SinglerealArray2M.AssertModel(models[16],_testData[22], false);
                        SinglerealArray2M.AssertModel(models[17],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[18],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[19],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[20],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[21],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[22],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        SinglerealArray2M.AssertModel(models[0],_testData[16], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[17], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[18], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[19], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[20], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[21], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[22], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[8],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[9],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[10],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[11],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[12],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealArray2M), typeof(FlatSinglerealArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
            asPartInterface: typeof(ISingleListrealArray)),
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
            asPartInterface: typeof(ISingleListrealArray)),
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealArray2M>();
                var models2 = new List<FlatSinglerealArray2M>();
                await((ISingleListrealArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var firstItems2 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                var secondItems2 = new List<FlatSinglerealArray2M>();
                await ((ISingleListrealArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 97, query1, 55, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[19],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var firstItems2 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                await ((ISingleListrealArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 73, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[29], false);
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealArray2M>();
                var models2 = new List<FlatSinglerealArray2M>();
                ((ISingleListrealArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var firstItems2 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                var secondItems2 = new List<FlatSinglerealArray2M>();
                 ((ISingleListrealArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 110, query1, 132, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var firstItems2 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                 ((ISingleListrealArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 59, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[28],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
            asPartInterface: typeof(ISingleListrealArray)),
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
            asPartInterface: typeof(ISingleListrealArray)),
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ISingleListrealArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ISingleListrealArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 37, query1, 55, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(models[7],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(models[8],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(models[9],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(models[10],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(models[11],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(models[12],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(models[13],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(models[14],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(models[15],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(models[16],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(models[17],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(models[18],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[19],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[20],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[21],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[22],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[23],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(models[7],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(models[8],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(models[9],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(models[10],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(models[11],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(models[12],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(models[13],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[14],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[15],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[16],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[17],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[18],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[19],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                var secondItems2 = new List<FlatSinglerealArray2M>();
                await ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 110, query1, 129, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[30], false);
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ISingleListrealArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((ISingleListrealArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 88, query1, 22, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[7],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[8],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[9],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[10],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[11],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[3], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(models[7],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(models[8],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(models[9],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(models[10],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(models[11],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(models[12],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(models[13],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(models[14],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(models[15],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(models[16],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(models[17],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(models[18],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(models[19],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(models[20],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[21],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[22],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[23],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[24],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[25],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[26],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealarray2m m
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
FROM public.singlerealarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealArray2M>();
                var secondItems1 = new List<FlatSinglerealArray2M>();
                var secondItems2 = new List<FlatSinglerealArray2M>();
                 ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelBatch(connection, 9, query1, 31, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[25],_testData[30], false);
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
FROM public.singlerealarray2m m
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(SinglerealArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
            asPartInterface: typeof(ISingleListrealArray)),
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
                var models = await((ISingleListrealArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ISingleListrealArray)this).DbConnectionSTSelectModelBatchAsync(connection, 112, 37))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        SinglerealArray2M.AssertModel(models[0],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        SinglerealArray2M.AssertModel(models[0],_testData[5], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[6], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[7], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[8], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[9], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[10], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[11], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[12], false);
                        SinglerealArray2M.AssertModel(models[8],_testData[13], false);
                        SinglerealArray2M.AssertModel(models[9],_testData[14], false);
                        SinglerealArray2M.AssertModel(models[10],_testData[15], false);
                        SinglerealArray2M.AssertModel(models[11],_testData[16], false);
                        SinglerealArray2M.AssertModel(models[12],_testData[17], false);
                        SinglerealArray2M.AssertModel(models[13],_testData[18], false);
                        SinglerealArray2M.AssertModel(models[14],_testData[19], false);
                        SinglerealArray2M.AssertModel(models[15],_testData[20], false);
                        SinglerealArray2M.AssertModel(models[16],_testData[21], false);
                        SinglerealArray2M.AssertModel(models[17],_testData[22], false);
                        SinglerealArray2M.AssertModel(models[18],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[19],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[20],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[21],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[22],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[23],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[24],_testData[29], false);
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
                var models = ((ISingleListrealArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ISingleListrealArray)this).DbConnectionSTSelectModelBatch(connection, 133, 63))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        SinglerealArray2M.AssertModel(models[0],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        SinglerealArray2M.AssertModel(models[0],_testData[12], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[13], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[14], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[15], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[16], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[17], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[18], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[19], false);
                        SinglerealArray2M.AssertModel(models[8],_testData[20], false);
                        SinglerealArray2M.AssertModel(models[9],_testData[21], false);
                        SinglerealArray2M.AssertModel(models[10],_testData[22], false);
                        SinglerealArray2M.AssertModel(models[11],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[12],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[13],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[14],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[15],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[16],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[17],_testData[29], false);
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
                await using var cmd = await ((ISingleListrealArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ISingleListrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 51);
                var models = await ((ISingleListrealArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
SinglerealArray2M.AssertModel(models[0],_testData[8], false);SinglerealArray2M.AssertModel(models[1],_testData[9], false);SinglerealArray2M.AssertModel(models[2],_testData[10], false);SinglerealArray2M.AssertModel(models[3],_testData[11], false);SinglerealArray2M.AssertModel(models[4],_testData[12], false);SinglerealArray2M.AssertModel(models[5],_testData[13], false);SinglerealArray2M.AssertModel(models[6],_testData[14], false);SinglerealArray2M.AssertModel(models[7],_testData[15], false);SinglerealArray2M.AssertModel(models[8],_testData[16], false);SinglerealArray2M.AssertModel(models[9],_testData[17], false);SinglerealArray2M.AssertModel(models[10],_testData[18], false);SinglerealArray2M.AssertModel(models[11],_testData[19], false);SinglerealArray2M.AssertModel(models[12],_testData[20], false);SinglerealArray2M.AssertModel(models[13],_testData[21], false);SinglerealArray2M.AssertModel(models[14],_testData[22], false);SinglerealArray2M.AssertModel(models[15],_testData[23], false);SinglerealArray2M.AssertModel(models[16],_testData[24], false);SinglerealArray2M.AssertModel(models[17],_testData[25], false);SinglerealArray2M.AssertModel(models[18],_testData[26], false);SinglerealArray2M.AssertModel(models[19],_testData[27], false);SinglerealArray2M.AssertModel(models[20],_testData[28], false);SinglerealArray2M.AssertModel(models[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleListrealArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleListrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 74);
                var models =  ((ISingleListrealArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(15));
SinglerealArray2M.AssertModel(models[0],_testData[15], false);SinglerealArray2M.AssertModel(models[1],_testData[16], false);SinglerealArray2M.AssertModel(models[2],_testData[17], false);SinglerealArray2M.AssertModel(models[3],_testData[18], false);SinglerealArray2M.AssertModel(models[4],_testData[19], false);SinglerealArray2M.AssertModel(models[5],_testData[20], false);SinglerealArray2M.AssertModel(models[6],_testData[21], false);SinglerealArray2M.AssertModel(models[7],_testData[22], false);SinglerealArray2M.AssertModel(models[8],_testData[23], false);SinglerealArray2M.AssertModel(models[9],_testData[24], false);SinglerealArray2M.AssertModel(models[10],_testData[25], false);SinglerealArray2M.AssertModel(models[11],_testData[26], false);SinglerealArray2M.AssertModel(models[12],_testData[27], false);SinglerealArray2M.AssertModel(models[13],_testData[28], false);SinglerealArray2M.AssertModel(models[14],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlerealarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(SinglerealArray2MI)],
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
            asPartInterface: typeof(ISingleListrealArray))]
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
FROM public.binary_singlerealarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(SinglerealArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<SinglerealArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((ISingleListrealArray)this).ImportModelInner(connection, importCollection);
                var models = ((ISingleListrealArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray2MI.AssertModel(actual, expect, false);
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
                await ((ISingleListrealArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((ISingleListrealArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlerealarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
singlerealarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(SinglerealArray2M)],
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
            asPartInterface: typeof(ISingleListrealArray))]
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
FROM public.binary_singlerealarray2m m
LEFT JOIN public.binary_singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(SinglerealArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<SinglerealArray2M>(15);

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
                ((ISingleListrealArray)this).ImportModel(connection, importCollection);
                var models = ((ISingleListrealArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                SinglerealArray2M.AssertModel(models[0],_testData[0], false);
                SinglerealArray2M.AssertModel(models[1],_testData[1], false);
                SinglerealArray2M.AssertModel(models[2],_testData[2], false);
                SinglerealArray2M.AssertModel(models[3],_testData[3], false);
                SinglerealArray2M.AssertModel(models[4],_testData[4], false);
                SinglerealArray2M.AssertModel(models[5],_testData[5], false);
                SinglerealArray2M.AssertModel(models[6],_testData[6], false);
                SinglerealArray2M.AssertModel(models[7],_testData[7], false);
                SinglerealArray2M.AssertModel(models[8],_testData[8], false);
                SinglerealArray2M.AssertModel(models[9],_testData[9], false);
                SinglerealArray2M.AssertModel(models[10],_testData[10], false);
                SinglerealArray2M.AssertModel(models[11],_testData[11], false);
                SinglerealArray2M.AssertModel(models[12],_testData[12], false);
                SinglerealArray2M.AssertModel(models[13],_testData[13], false);
                SinglerealArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((ISingleListrealArray)this).ImportModelAsync(connection, importCollection);
                models = await ((ISingleListrealArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                SinglerealArray2M.AssertModel(models[0],_testData[0], false);
                SinglerealArray2M.AssertModel(models[1],_testData[1], false);
                SinglerealArray2M.AssertModel(models[2],_testData[2], false);
                SinglerealArray2M.AssertModel(models[3],_testData[3], false);
                SinglerealArray2M.AssertModel(models[4],_testData[4], false);
                SinglerealArray2M.AssertModel(models[5],_testData[5], false);
                SinglerealArray2M.AssertModel(models[6],_testData[6], false);
                SinglerealArray2M.AssertModel(models[7],_testData[7], false);
                SinglerealArray2M.AssertModel(models[8],_testData[8], false);
                SinglerealArray2M.AssertModel(models[9],_testData[9], false);
                SinglerealArray2M.AssertModel(models[10],_testData[10], false);
                SinglerealArray2M.AssertModel(models[11],_testData[11], false);
                SinglerealArray2M.AssertModel(models[12],_testData[12], false);
                SinglerealArray2M.AssertModel(models[13],_testData[13], false);
                SinglerealArray2M.AssertModel(models[14],_testData[14], false);
                SinglerealArray2M.AssertModel(models[15],_testData[15], false);
                SinglerealArray2M.AssertModel(models[16],_testData[16], false);
                SinglerealArray2M.AssertModel(models[17],_testData[17], false);
                SinglerealArray2M.AssertModel(models[18],_testData[18], false);
                SinglerealArray2M.AssertModel(models[19],_testData[19], false);
                SinglerealArray2M.AssertModel(models[20],_testData[20], false);
                SinglerealArray2M.AssertModel(models[21],_testData[21], false);
                SinglerealArray2M.AssertModel(models[22],_testData[22], false);
                SinglerealArray2M.AssertModel(models[23],_testData[23], false);
                SinglerealArray2M.AssertModel(models[24],_testData[24], false);
                SinglerealArray2M.AssertModel(models[25],_testData[25], false);
                SinglerealArray2M.AssertModel(models[26],_testData[26], false);
                SinglerealArray2M.AssertModel(models[27],_testData[27], false);
                SinglerealArray2M.AssertModel(models[28],_testData[28], false);
                SinglerealArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    singlerealarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(SinglerealArray2M)],
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
            asPartInterface: typeof(ISingleListrealArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ISingleListrealArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SinglerealArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleListrealArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SinglerealArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(SinglerealArray2MI)],
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
            asPartInterface: typeof(ISingleListrealArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ISingleListrealArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleListrealArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

