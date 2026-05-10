

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
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.9151162f,

0.56548923f,

0.80127114f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.481784f,

0.8142241f,

0.026043177f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.4444071f,

0.553805f,

0.963882f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.98551744f,

0.54705364f,

0.080958545f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5560745f,

0.52667433f,

0.7687217f,

0.6079671f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6470693f,

0.6575375f,

0.9954586f,

0.64363724f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.036854982f,

0.3075294f,

0.6866249f,

},
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.0048182607f,

0.7139309f,

0.6661692f,

0.8464327f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3065021f,

0.16806889f,

0.4327827f,

0.31233424f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8828749f,

0.79593366f,

0.4945107f,

0.51690245f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.7721981f,

0.5766758f,

0.4060945f,

0.6102833f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.2063834f,

0.16506112f,

0.5888364f,

},
},
            new SinglerealArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.12799186f,

0.23765653f,

0.5969151f,

0.61587447f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.6168613f,

0.69411564f,

0.19017345f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.46472055f,

0.63834125f,

0.82140326f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.73243886f,

0.022915125f,

0.25963664f,

0.23129767f,

},
},
            new SinglerealArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.12566537f,

0.0008890629f,

0.5259969f,

0.73871607f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.6732007f,

0.117117286f,

0.89515156f,

},
},
            new SinglerealArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.22308594f,

0.3203562f,

0.942677f,

0.75632155f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.41420603f,

0.28008264f,

0.34629172f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.047456324f,

0.23190558f,

0.96551985f,

0.18500155f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.22829098f,

0.26173794f,

0.55520314f,

},
},
            new SinglerealArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5622073f,

0.43501192f,

0.7821542f,

0.7166611f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.4878294f,

0.28237092f,

0.005769551f,

},
},
            new SinglerealArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6851046f,

0.87785184f,

0.6061787f,

0.9236226f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.063702226f,

0.5204092f,

0.7212398f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.054596484f,

0.13503611f,

0.5836925f,

0.28623688f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.44187176f,

0.5402217f,

0.13049614f,

0.090177596f,

},
},
            new SinglerealArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.2182228f,

0.9850302f,

0.6819605f,

0.21473849f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.36753154f,

0.654736f,

0.18209076f,

0.84778076f,

},
},
            new SinglerealArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.27424115f,

0.55844563f,

0.38510644f,

0.8451207f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.9898488f,

0.90547645f,

0.34636235f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.29776305f,

0.076699376f,

0.81188387f,

0.3516823f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.91225284f,

0.675234f,

0.989372f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.76359576f,

0.24144274f,

0.941986f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3659922f,

0.5810644f,

0.16828078f,

0.76315415f,

},
},
            new SinglerealArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7153066f,

0.037207186f,

0.86120534f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.39643514f,

0.30559152f,

0.23950559f,

0.51518023f,

},
},
            new SinglerealArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.85260975f,

0.11103302f,

0.4855795f,

0.59105f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.27783638f,

0.69243467f,

0.5636598f,

0.49872428f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.37836355f,

0.5879475f,

0.6842314f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.27566624f,

0.8527358f,

0.6294351f,

0.67882574f,

},
},
            new SinglerealArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.39036864f,

0.04698068f,

0.6820641f,

0.9646001f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7112212f,

0.74200684f,

0.0018473864f,

},
},
            new SinglerealArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.6103821f,

0.122344434f,

0.4712597f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.12862521f,

0.28568763f,

0.55718774f,

0.7621146f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.5637738f,

0.76927435f,

0.20856142f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.38718063f,

0.6306053f,

0.97947025f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.22403395f,

0.9711291f,

0.51179504f,

0.11609584f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5949592f,

0.48439008f,

0.91816574f,

0.7138439f,

},
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.7647727f,

0.33657712f,

0.3206095f,

0.8051309f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7933957f,

0.886404f,

0.5551661f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9077417f,

0.11764234f,

0.67989135f,

0.7352097f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5957757f,

0.5060311f,

0.8432005f,

0.8732323f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.89993304f,

0.46497846f,

0.29681295f,

0.3708436f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.14183253f,

0.7214481f,

0.16584814f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.11684835f,

0.014755189f,

0.68636966f,

},
},
            new SinglerealArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.4583745f,

0.7247169f,

0.03511542f,

0.9434713f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.46409726f,

0.34914362f,

0.602666f,

0.8755599f,

},
},
            new SinglerealArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.6555246f,

0.6515827f,

0.6262182f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.63872945f,

0.44690508f,

0.38261604f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.39454436f,

0.07483262f,

0.012386978f,

0.87660044f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.16122967f,

0.39793938f,

0.54140294f,

},
},
            new SinglerealArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.3104571f,

0.84535176f,

0.72411996f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.82163656f,

0.6838128f,

0.08593273f,

0.17894518f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.09125012f,

0.4520895f,

0.7769431f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.89380217f,

0.721852f,

0.4571877f,

0.16693443f,

},
},
            new SinglerealArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.20737249f,

0.89244986f,

0.8638076f,

0.34806114f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8701061f,

0.94787604f,

0.8431567f,

0.6306083f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.3791265f,

0.22467548f,

0.3056401f,

0.7111573f,

},
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.7553121f,

0.9520506f,

0.43020618f,

0.5291952f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.878015f,

0.8121083f,

0.8712215f,

},
},
            new SinglerealArray2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.57030666f,

0.5914503f,

0.32104343f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.11240357f,

0.07151437f,

0.83160114f,

0.13191575f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8145474f,

0.19816965f,

0.27330202f,

0.17126006f,

},
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.011948943f,

0.7232815f,

0.49803215f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.32909f,

0.076361775f,

0.24128091f,

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

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((ISingleListrealArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((ISingleListrealArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealArray2M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
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
                        FlatSinglerealArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[17],_testData[34], false);
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
                parametr2.Value = 21;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[29],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
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
                        FlatSinglerealArray2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleListrealArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[7],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[8],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[9],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(models[10],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(models[11],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(models[12],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(models[13],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleListrealArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(models[7],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(models[8],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(models[9],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[10],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[11],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[12],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[13],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[14],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[15],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(models[16],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(models[17],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(models[18],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(models[19],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
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
                        FlatSinglerealArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[13],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleListrealArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        SinglerealArray2M.AssertModel(models[0],_testData[3], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[4], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[5], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[6], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[7], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[8], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[9], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[10], false);
                        SinglerealArray2M.AssertModel(models[8],_testData[11], false);
                        SinglerealArray2M.AssertModel(models[9],_testData[12], false);
                        SinglerealArray2M.AssertModel(models[10],_testData[13], false);
                        SinglerealArray2M.AssertModel(models[11],_testData[14], false);
                        SinglerealArray2M.AssertModel(models[12],_testData[15], false);
                        SinglerealArray2M.AssertModel(models[13],_testData[16], false);
                        SinglerealArray2M.AssertModel(models[14],_testData[17], false);
                        SinglerealArray2M.AssertModel(models[15],_testData[18], false);
                        SinglerealArray2M.AssertModel(models[16],_testData[19], false);
                        SinglerealArray2M.AssertModel(models[17],_testData[20], false);
                        SinglerealArray2M.AssertModel(models[18],_testData[21], false);
                        SinglerealArray2M.AssertModel(models[19],_testData[22], false);
                        SinglerealArray2M.AssertModel(models[20],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[21],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[22],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[23],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[24],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[25],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[26],_testData[29], false);
                        SinglerealArray2M.AssertModel(models[27],_testData[30], false);
                        SinglerealArray2M.AssertModel(models[28],_testData[31], false);
                        SinglerealArray2M.AssertModel(models[29],_testData[32], false);
                        SinglerealArray2M.AssertModel(models[30],_testData[33], false);
                        SinglerealArray2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        SinglerealArray2M.AssertModel(models[0],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[29], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[30], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[31], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[32], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[33], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleListrealArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

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
                        SinglerealArray2M.AssertModel(models[18],_testData[30], false);
                        SinglerealArray2M.AssertModel(models[19],_testData[31], false);
                        SinglerealArray2M.AssertModel(models[20],_testData[32], false);
                        SinglerealArray2M.AssertModel(models[21],_testData[33], false);
                        SinglerealArray2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        SinglerealArray2M.AssertModel(models[0],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[29], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[30], false);
                        SinglerealArray2M.AssertModel(models[8],_testData[31], false);
                        SinglerealArray2M.AssertModel(models[9],_testData[32], false);
                        SinglerealArray2M.AssertModel(models[10],_testData[33], false);
                        SinglerealArray2M.AssertModel(models[11],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
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
                await ((ISingleListrealArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 108, query1, 21, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
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
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[29],_testData[34], false);
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
                await ((ISingleListrealArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 74, query1, 42, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
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
                        FlatSinglerealArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[25],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models1[i],_testData[i], false);
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
                 ((ISingleListrealArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 10, query1, 67, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[21],_testData[34], false);
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
                 ((ISingleListrealArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 67, query1, 123, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatSinglerealArray2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleListrealArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 108, query1, 108, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[7],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(models[8],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(models[9],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(models[10],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(models[11],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[7],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(models[8],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(models[9],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(models[10],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(models[11],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(models[12],_testData[34], false);
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
                await ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 42, query1, 160, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleListrealArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 15, query1, 101, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

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
                        FlatSinglerealArray2M.AssertModel(models[26],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(models[27],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(models[28],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(models[29],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatSinglerealArray2M.AssertModel(models[0],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(models[1],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(models[2],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(models[3],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(models[4],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(models[5],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(models[6],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(models[7],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(models[8],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(models[9],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(models[10],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(models[11],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(models[12],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(models[13],_testData[34], false);
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
                 ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelBatch(connection, 160, query1, 42, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatSinglerealArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatSinglerealArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatSinglerealArray2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatSinglerealArray2M.AssertModel(secondItems2[25],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((ISingleListrealArray)this).DbConnectionSTSelectModelBatchAsync(connection, 59, 95))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

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
                        SinglerealArray2M.AssertModel(models[18],_testData[30], false);
                        SinglerealArray2M.AssertModel(models[19],_testData[31], false);
                        SinglerealArray2M.AssertModel(models[20],_testData[32], false);
                        SinglerealArray2M.AssertModel(models[21],_testData[33], false);
                        SinglerealArray2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        SinglerealArray2M.AssertModel(models[0],_testData[20], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[21], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[22], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[8],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[9],_testData[29], false);
                        SinglerealArray2M.AssertModel(models[10],_testData[30], false);
                        SinglerealArray2M.AssertModel(models[11],_testData[31], false);
                        SinglerealArray2M.AssertModel(models[12],_testData[32], false);
                        SinglerealArray2M.AssertModel(models[13],_testData[33], false);
                        SinglerealArray2M.AssertModel(models[14],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((ISingleListrealArray)this).DbConnectionSTSelectModelBatch(connection, 8, 92))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        SinglerealArray2M.AssertModel(models[0],_testData[2], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[3], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[4], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[5], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[6], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[7], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[8], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[9], false);
                        SinglerealArray2M.AssertModel(models[8],_testData[10], false);
                        SinglerealArray2M.AssertModel(models[9],_testData[11], false);
                        SinglerealArray2M.AssertModel(models[10],_testData[12], false);
                        SinglerealArray2M.AssertModel(models[11],_testData[13], false);
                        SinglerealArray2M.AssertModel(models[12],_testData[14], false);
                        SinglerealArray2M.AssertModel(models[13],_testData[15], false);
                        SinglerealArray2M.AssertModel(models[14],_testData[16], false);
                        SinglerealArray2M.AssertModel(models[15],_testData[17], false);
                        SinglerealArray2M.AssertModel(models[16],_testData[18], false);
                        SinglerealArray2M.AssertModel(models[17],_testData[19], false);
                        SinglerealArray2M.AssertModel(models[18],_testData[20], false);
                        SinglerealArray2M.AssertModel(models[19],_testData[21], false);
                        SinglerealArray2M.AssertModel(models[20],_testData[22], false);
                        SinglerealArray2M.AssertModel(models[21],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[22],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[23],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[24],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[25],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[26],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[27],_testData[29], false);
                        SinglerealArray2M.AssertModel(models[28],_testData[30], false);
                        SinglerealArray2M.AssertModel(models[29],_testData[31], false);
                        SinglerealArray2M.AssertModel(models[30],_testData[32], false);
                        SinglerealArray2M.AssertModel(models[31],_testData[33], false);
                        SinglerealArray2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        SinglerealArray2M.AssertModel(models[0],_testData[19], false);
                        SinglerealArray2M.AssertModel(models[1],_testData[20], false);
                        SinglerealArray2M.AssertModel(models[2],_testData[21], false);
                        SinglerealArray2M.AssertModel(models[3],_testData[22], false);
                        SinglerealArray2M.AssertModel(models[4],_testData[23], false);
                        SinglerealArray2M.AssertModel(models[5],_testData[24], false);
                        SinglerealArray2M.AssertModel(models[6],_testData[25], false);
                        SinglerealArray2M.AssertModel(models[7],_testData[26], false);
                        SinglerealArray2M.AssertModel(models[8],_testData[27], false);
                        SinglerealArray2M.AssertModel(models[9],_testData[28], false);
                        SinglerealArray2M.AssertModel(models[10],_testData[29], false);
                        SinglerealArray2M.AssertModel(models[11],_testData[30], false);
                        SinglerealArray2M.AssertModel(models[12],_testData[31], false);
                        SinglerealArray2M.AssertModel(models[13],_testData[32], false);
                        SinglerealArray2M.AssertModel(models[14],_testData[33], false);
                        SinglerealArray2M.AssertModel(models[15],_testData[34], false);
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
                ((ISingleListrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 21);
                var models = await ((ISingleListrealArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

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
                SinglerealArray2M.AssertModel(models[25],_testData[30], false);
                SinglerealArray2M.AssertModel(models[26],_testData[31], false);
                SinglerealArray2M.AssertModel(models[27],_testData[32], false);
                SinglerealArray2M.AssertModel(models[28],_testData[33], false);
                SinglerealArray2M.AssertModel(models[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleListrealArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleListrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 10);
                var models =  ((ISingleListrealArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(32));

                SinglerealArray2M.AssertModel(models[0],_testData[3], false);
                SinglerealArray2M.AssertModel(models[1],_testData[4], false);
                SinglerealArray2M.AssertModel(models[2],_testData[5], false);
                SinglerealArray2M.AssertModel(models[3],_testData[6], false);
                SinglerealArray2M.AssertModel(models[4],_testData[7], false);
                SinglerealArray2M.AssertModel(models[5],_testData[8], false);
                SinglerealArray2M.AssertModel(models[6],_testData[9], false);
                SinglerealArray2M.AssertModel(models[7],_testData[10], false);
                SinglerealArray2M.AssertModel(models[8],_testData[11], false);
                SinglerealArray2M.AssertModel(models[9],_testData[12], false);
                SinglerealArray2M.AssertModel(models[10],_testData[13], false);
                SinglerealArray2M.AssertModel(models[11],_testData[14], false);
                SinglerealArray2M.AssertModel(models[12],_testData[15], false);
                SinglerealArray2M.AssertModel(models[13],_testData[16], false);
                SinglerealArray2M.AssertModel(models[14],_testData[17], false);
                SinglerealArray2M.AssertModel(models[15],_testData[18], false);
                SinglerealArray2M.AssertModel(models[16],_testData[19], false);
                SinglerealArray2M.AssertModel(models[17],_testData[20], false);
                SinglerealArray2M.AssertModel(models[18],_testData[21], false);
                SinglerealArray2M.AssertModel(models[19],_testData[22], false);
                SinglerealArray2M.AssertModel(models[20],_testData[23], false);
                SinglerealArray2M.AssertModel(models[21],_testData[24], false);
                SinglerealArray2M.AssertModel(models[22],_testData[25], false);
                SinglerealArray2M.AssertModel(models[23],_testData[26], false);
                SinglerealArray2M.AssertModel(models[24],_testData[27], false);
                SinglerealArray2M.AssertModel(models[25],_testData[28], false);
                SinglerealArray2M.AssertModel(models[26],_testData[29], false);
                SinglerealArray2M.AssertModel(models[27],_testData[30], false);
                SinglerealArray2M.AssertModel(models[28],_testData[31], false);
                SinglerealArray2M.AssertModel(models[29],_testData[32], false);
                SinglerealArray2M.AssertModel(models[30],_testData[33], false);
                SinglerealArray2M.AssertModel(models[31],_testData[34], false);
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
FROM public.binary_singlerealarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(SinglerealArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(SinglerealArray2MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISingleListrealArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_singlerealarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISingleListrealArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISingleListrealArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_singlerealarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISingleListrealArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_singlerealarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(SinglerealArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(SinglerealArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISingleListrealArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_singlerealarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISingleListrealArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISingleListrealArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_singlerealarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISingleListrealArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_singlerealarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(SinglerealArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

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
            methodName:"WAImportModelInner",
            queryMapType: typeof(SinglerealArray2MI),
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ISingleListrealArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((ISingleListrealArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ISingleListrealArray)this).WAImportModelInner(connection, importCollection);
                var models = ((ISingleListrealArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_singlerealarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(SinglerealArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlerealarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(SinglerealArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISingleListrealArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ISingleListrealArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISingleListrealArray)this).ImportModelInner(connection, importCollection);
                var models = ((ISingleListrealArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(SinglerealArray2M),
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((ISingleListrealArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((ISingleListrealArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    SinglerealArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((ISingleListrealArray)this).ImportModel(connection, importCollection);
                var models = ((ISingleListrealArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    SinglerealArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(SinglerealArray2MIWA), typeof(SinglerealArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
                var models1 = new List<SinglerealArray2MIWA>();
                var models2 = new List<SinglerealArray2MIWA>();
                await ((ISingleListrealArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealArray2MIWA>();
                var models2 = new List<SinglerealArray2MIWA>();
                ((ISingleListrealArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(SinglerealArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
                var models = await ((ISingleListrealArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_singlerealarray2mi
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
                    SinglerealArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleListrealArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_singlerealarray2mi
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
                    SinglerealArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(SinglerealArray2MIWA), typeof(SinglerealArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray))]
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
                var models1 = new List<SinglerealArray2MIWA>();
                var models2 = new List<SinglerealArray2MIWA>();
                await ((ISingleListrealArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealArray2MIWA>();
                var models2 = new List<SinglerealArray2MIWA>();
                ((ISingleListrealArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(SinglerealArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray))]
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
                var models = await ((ISingleListrealArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_singlerealarray2mi
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
                    SinglerealArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleListrealArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_singlerealarray2mi
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
                    SinglerealArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_singlerealarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(SinglerealArray2MI), typeof(SinglerealArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
                var models1 = new List<SinglerealArray2MI>();
                var models2 = new List<SinglerealArray2MI>();
                await ((ISingleListrealArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealArray2MI>();
                var models2 = new List<SinglerealArray2MI>();
                ((ISingleListrealArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(SinglerealArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray)),
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
                var models = await ((ISingleListrealArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleListrealArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_singlerealarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(SinglerealArray2MIWA), typeof(SinglerealArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray))]
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
                var models1 = new List<SinglerealArray2MIWA>();
                var models2 = new List<SinglerealArray2MIWA>();
                await ((ISingleListrealArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealArray2MIWA>();
                var models2 = new List<SinglerealArray2MIWA>();
                ((ISingleListrealArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(SinglerealArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleListrealArray))]
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
                var models = await ((ISingleListrealArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleListrealArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

