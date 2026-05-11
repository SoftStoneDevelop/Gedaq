

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
    internal partial interface ISingleMArrayrealMArrayD1
    {
    }
    
    internal partial class SingleMArrayrealMArrayD1 : ISingleMArrayrealMArrayD1
    {


#region TestData

        private readonly SinglerealMArrayD1E1M[] _testData = new SinglerealMArrayD1E1M[]
        {
            new SinglerealMArrayD1E1M
{
    Id = 3,
    Value = 
new System.Single[3]
{
0.9270738f,
0.87586975f,
0.8876241f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.8319208f,
0.23244905f,
0.9012749f,
0.19137383f,
},
},
            new SinglerealMArrayD1E1M
{
    Id = 6,
    Value = 
new System.Single[3]
{
0.075516105f,
0.7477389f,
0.11909616f,
},
    ModelInner = new SinglerealMArrayD11MI
{
    Id = 9,
    Value = 
new System.Single[4]
{
0.482782f,
0.13200122f,
0.9520743f,
0.87933296f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.5578724f,
0.5935545f,
0.7957905f,
0.87503713f,
},
},
            new SinglerealMArrayD1E1M
{
    Id = 8,
    Value = 
new System.Single[3]
{
0.6366948f,
0.9472157f,
0.93857247f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.38260674f,
0.75553846f,
0.5371421f,
0.44797403f,
},
},
            new SinglerealMArrayD1E1M
{
    Id = 13,
    Value = 
new System.Single[4]
{
0.44103086f,
0.5000142f,
0.03750801f,
0.71446216f,
},
    ModelInner = new SinglerealMArrayD11MI
{
    Id = 10,
    Value = 
new System.Single[4]
{
0.54643846f,
0.4768799f,
0.30557948f,
0.27094954f,
},
    NullableValue = 
new System.Single[3]
{
0.99490976f,
0.22438538f,
0.24200833f,
},
},
    NullableValue = 
new System.Single[4]
{
0.036434174f,
0.92519087f,
0.21364635f,
0.21519959f,
},
},
            new SinglerealMArrayD1E1M
{
    Id = 20,
    Value = 
new System.Single[3]
{
0.046406448f,
0.08998382f,
0.34204686f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.13760662f,
0.8042036f,
0.9591784f,
},
},
            new SinglerealMArrayD1E1M
{
    Id = 23,
    Value = 
new System.Single[4]
{
0.9671156f,
0.71654236f,
0.6675699f,
0.63035315f,
},
    ModelInner = new SinglerealMArrayD11MI
{
    Id = 18,
    Value = 
new System.Single[4]
{
0.6259892f,
0.7372863f,
0.39070696f,
0.030965924f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealMArrayD1E1M
{
    Id = 25,
    Value = 
new System.Single[4]
{
0.44542366f,
0.8995505f,
0.41135418f,
0.11709845f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMArrayD1E1M
{
    Id = 29,
    Value = 
new System.Single[4]
{
0.5928426f,
0.5062447f,
0.67601067f,
0.73547995f,
},
    ModelInner = new SinglerealMArrayD11MI
{
    Id = 21,
    Value = 
new System.Single[3]
{
0.794407f,
0.4412037f,
0.9419268f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[3]
{
0.41844577f,
0.16272396f,
0.9567444f,
},
},
            new SinglerealMArrayD1E1M
{
    Id = 35,
    Value = 
new System.Single[4]
{
0.5573102f,
0.59226865f,
0.739962f,
0.74974006f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMArrayD1E1M
{
    Id = 38,
    Value = 
new System.Single[3]
{
0.60918814f,
0.6281374f,
0.5786027f,
},
    ModelInner = new SinglerealMArrayD11MI
{
    Id = 30,
    Value = 
new System.Single[4]
{
0.43734682f,
0.449242f,
0.34301215f,
0.6735798f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[3]
{
0.776524f,
0.3737725f,
0.036565483f,
},
},
            new SinglerealMArrayD1E1M
{
    Id = 42,
    Value = 
new System.Single[3]
{
0.45239037f,
0.8654513f,
0.7316045f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.54704756f,
0.6211056f,
0.018936396f,
},
},
            new SinglerealMArrayD1E1M
{
    Id = 45,
    Value = 
new System.Single[3]
{
0.6418507f,
0.23342139f,
0.71365434f,
},
    ModelInner = new SinglerealMArrayD11MI
{
    Id = 39,
    Value = 
new System.Single[4]
{
0.690127f,
0.96338165f,
0.8508672f,
0.37603974f,
},
    NullableValue = 
new System.Single[3]
{
0.665509f,
0.044201553f,
0.85712355f,
},
},
    NullableValue = 
new System.Single[3]
{
0.55441403f,
0.6078649f,
0.33840775f,
},
},
            new SinglerealMArrayD1E1M
{
    Id = 46,
    Value = 
new System.Single[3]
{
0.94043964f,
0.84167135f,
0.73330045f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.014013827f,
0.61741406f,
0.7420845f,
0.27091318f,
},
},
            new SinglerealMArrayD1E1M
{
    Id = 49,
    Value = 
new System.Single[4]
{
0.31207007f,
0.57835466f,
0.07991046f,
0.63942724f,
},
    ModelInner = new SinglerealMArrayD11MI
{
    Id = 43,
    Value = 
new System.Single[4]
{
0.24550617f,
0.46939397f,
0.07616371f,
0.9200161f,
},
    NullableValue = 
new System.Single[3]
{
0.91364485f,
0.49451983f,
0.15284878f,
},
},
    NullableValue = null,
},
            new SinglerealMArrayD1E1M
{
    Id = 58,
    Value = 
new System.Single[3]
{
0.5653079f,
0.06819302f,
0.6677614f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.26101023f,
0.15300328f,
0.008603573f,
0.06906152f,
},
},
            new SinglerealMArrayD1E1M
{
    Id = 63,
    Value = 
new System.Single[3]
{
0.04573345f,
0.76714885f,
0.5983395f,
},
    ModelInner = new SinglerealMArrayD11MI
{
    Id = 50,
    Value = 
new System.Single[4]
{
0.89420897f,
0.3199891f,
0.19974059f,
0.32981914f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[3]
{
0.35639638f,
0.8664534f,
0.5429434f,
},
},
            new SinglerealMArrayD1E1M
{
    Id = 67,
    Value = 
new System.Single[4]
{
0.41171217f,
0.8223936f,
0.6611923f,
0.4172297f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMArrayD1E1M
{
    Id = 70,
    Value = 
new System.Single[4]
{
0.07313627f,
0.8527779f,
0.5762041f,
0.61470455f,
},
    ModelInner = new SinglerealMArrayD11MI
{
    Id = 51,
    Value = 
new System.Single[3]
{
0.6500911f,
0.4973936f,
0.0015301108f,
},
    NullableValue = 
new System.Single[4]
{
0.8958114f,
0.09862453f,
0.87279004f,
0.34582245f,
},
},
    NullableValue = 
new System.Single[3]
{
0.8640964f,
0.69350904f,
0.31400436f,
},
},
            new SinglerealMArrayD1E1M
{
    Id = 71,
    Value = 
new System.Single[4]
{
0.28717983f,
0.331761f,
0.4914788f,
0.017088473f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.42820352f,
0.5627391f,
0.08624321f,
},
},
            new SinglerealMArrayD1E1M
{
    Id = 73,
    Value = 
new System.Single[3]
{
0.44458443f,
0.16196525f,
0.76728714f,
},
    ModelInner = new SinglerealMArrayD11MI
{
    Id = 60,
    Value = 
new System.Single[3]
{
0.7361956f,
0.7519983f,
0.98911595f,
},
    NullableValue = 
new System.Single[3]
{
0.34298784f,
0.06454599f,
0.57164836f,
},
},
    NullableValue = null,
},
            new SinglerealMArrayD1E1M
{
    Id = 80,
    Value = 
new System.Single[4]
{
0.8669998f,
0.7168177f,
0.9421357f,
0.78130096f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMArrayD1E1M
{
    Id = 86,
    Value = 
new System.Single[3]
{
0.31555092f,
0.07851517f,
0.23209494f,
},
    ModelInner = new SinglerealMArrayD11MI
{
    Id = 66,
    Value = 
new System.Single[4]
{
0.11500132f,
0.59442145f,
0.8632739f,
0.8424581f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.97155297f,
0.10064459f,
0.41100007f,
0.2563479f,
},
},
            new SinglerealMArrayD1E1M
{
    Id = 91,
    Value = 
new System.Single[3]
{
0.69417f,
0.18876398f,
0.16623932f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.5080235f,
0.6069307f,
0.9277713f,
0.069622874f,
},
},
            new SinglerealMArrayD1E1M
{
    Id = 96,
    Value = 
new System.Single[4]
{
0.78889805f,
0.18015301f,
0.3476014f,
0.7356707f,
},
    ModelInner = new SinglerealMArrayD11MI
{
    Id = 67,
    Value = 
new System.Single[3]
{
0.77739143f,
0.8938966f,
0.3091787f,
},
    NullableValue = 
new System.Single[4]
{
0.96503395f,
0.27112323f,
0.6145381f,
0.33546132f,
},
},
    NullableValue = null,
},
            new SinglerealMArrayD1E1M
{
    Id = 98,
    Value = 
new System.Single[3]
{
0.27755845f,
0.9950628f,
0.34764773f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.87614876f,
0.93581915f,
0.2693373f,
0.81242627f,
},
},
            new SinglerealMArrayD1E1M
{
    Id = 107,
    Value = 
new System.Single[3]
{
0.6734829f,
0.6226789f,
0.26848084f,
},
    ModelInner = new SinglerealMArrayD11MI
{
    Id = 68,
    Value = 
new System.Single[4]
{
0.79833025f,
0.063222945f,
0.38239467f,
0.44634837f,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealMArrayD1E1M
{
    Id = 109,
    Value = 
new System.Single[3]
{
0.38703632f,
0.5402955f,
0.69605505f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.76204526f,
0.079446256f,
0.6160031f,
},
},
            new SinglerealMArrayD1E1M
{
    Id = 113,
    Value = 
new System.Single[4]
{
0.056505144f,
0.2535296f,
0.7053546f,
0.6199966f,
},
    ModelInner = new SinglerealMArrayD11MI
{
    Id = 76,
    Value = 
new System.Single[4]
{
0.49514437f,
0.33748525f,
0.42702335f,
0.88739836f,
},
    NullableValue = 
new System.Single[3]
{
0.22649342f,
0.70618606f,
0.8166774f,
},
},
    NullableValue = null,
},
            new SinglerealMArrayD1E1M
{
    Id = 121,
    Value = 
new System.Single[3]
{
0.8825413f,
0.04698503f,
0.08583158f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.28563964f,
0.70203125f,
0.85971636f,
0.19668597f,
},
},
            new SinglerealMArrayD1E1M
{
    Id = 122,
    Value = 
new System.Single[3]
{
0.70018345f,
0.39138055f,
0.2411601f,
},
    ModelInner = new SinglerealMArrayD11MI
{
    Id = 77,
    Value = 
new System.Single[3]
{
0.55038923f,
0.36495543f,
0.41469264f,
},
    NullableValue = 
new System.Single[3]
{
0.9672492f,
0.54511f,
0.32148623f,
},
},
    NullableValue = 
new System.Single[3]
{
0.38948482f,
0.3266682f,
0.8868201f,
},
},
            new SinglerealMArrayD1E1M
{
    Id = 126,
    Value = 
new System.Single[4]
{
0.119513094f,
0.9067801f,
0.27660406f,
0.49546403f,
},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMArrayD1E1M
{
    Id = 128,
    Value = 
new System.Single[4]
{
0.9419976f,
0.89904207f,
0.57652926f,
0.34326178f,
},
    ModelInner = new SinglerealMArrayD11MI
{
    Id = 85,
    Value = 
new System.Single[3]
{
0.95074123f,
0.5705107f,
0.83141196f,
},
    NullableValue = 
new System.Single[3]
{
0.44390666f,
0.92326087f,
0.25893402f,
},
},
    NullableValue = 
new System.Single[4]
{
0.5848948f,
0.3332566f,
0.3012058f,
0.2943887f,
},
},
            new SinglerealMArrayD1E1M
{
    Id = 132,
    Value = 
new System.Single[4]
{
0.73383707f,
0.6708725f,
0.9847353f,
0.43310237f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[3]
{
0.48169982f,
0.5008188f,
0.74171275f,
},
},
            new SinglerealMArrayD1E1M
{
    Id = 140,
    Value = 
new System.Single[3]
{
0.92700154f,
0.031931162f,
0.080406725f,
},
    ModelInner = new SinglerealMArrayD11MI
{
    Id = 91,
    Value = 
new System.Single[3]
{
0.97494835f,
0.21037483f,
0.8389931f,
},
    NullableValue = null,
},
    NullableValue = 
new System.Single[4]
{
0.29863006f,
0.55671036f,
0.47092283f,
0.3458662f,
},
},
            new SinglerealMArrayD1E1M
{
    Id = 146,
    Value = 
new System.Single[4]
{
0.42208725f,
0.5404395f,
0.30520713f,
0.09617716f,
},
    ModelInner = null,
    NullableValue = 
new System.Single[4]
{
0.16437095f,
0.3023535f,
0.85084426f,
0.28251576f,
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealmarrayd11mi(
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
            asPartInterface: typeof(ISingleMArrayrealMArrayD1)),
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
INSERT INTO public.singlerealmarrayd11mi(
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
            queryMapTypes: [typeof(SinglerealMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1)),
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

                changedRows =  ((ISingleMArrayrealMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISingleMArrayrealMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ISingleMArrayrealMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleMArrayrealMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ISingleMArrayrealMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ISingleMArrayrealMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ISingleMArrayrealMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ISingleMArrayrealMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((ISingleMArrayrealMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((ISingleMArrayrealMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((ISingleMArrayrealMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((ISingleMArrayrealMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((ISingleMArrayrealMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((ISingleMArrayrealMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((ISingleMArrayrealMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((ISingleMArrayrealMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((ISingleMArrayrealMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealmarrayd1e1m(
	id,
    value,
    nullablevalue,
    singlerealmarrayd11mi_id
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
            asPartInterface: typeof(ISingleMArrayrealMArrayD1)), 
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
                methodParametrName: "singlerealmarrayd11mi_id", 
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
                changedRows =  ((ISingleMArrayrealMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ISingleMArrayrealMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ISingleMArrayrealMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ISingleMArrayrealMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealmarrayd1e1m(
	id,
    value,
    nullablevalue,
    singlerealmarrayd11mi_id
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
    singlerealmarrayd11mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(SinglerealMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1)),
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

                    nullable =  ((ISingleMArrayrealMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[3]
{
0.13760662f,
0.8042036f,
0.9591784f,
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

                    nullable =  ((ISingleMArrayrealMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable = await ((ISingleMArrayrealMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
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

                    nullable = await ((ISingleMArrayrealMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[3]
{
0.41844577f,
0.16272396f,
0.9567444f,
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealmarrayd1e1m(
	id,
    value,
    nullablevalue,
    singlerealmarrayd11mi_id
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
    singlerealmarrayd11mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(SinglerealMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1)),
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
                methodParametrName: "singlerealmarrayd11mi_id", 
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
                nullable =  ((ISingleMArrayrealMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((ISingleMArrayrealMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[3]
{
0.776524f,
0.3737725f,
0.036565483f,
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
                nullable = await ((ISingleMArrayrealMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[3]
{
0.54704756f,
0.6211056f,
0.018936396f,
}));
                nullable = await ((ISingleMArrayrealMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[3]
{
0.55441403f,
0.6078649f,
0.33840775f,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<SinglerealMArrayD1E1M> models = null;

                models =  ((ISingleMArrayrealMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((ISingleMArrayrealMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((ISingleMArrayrealMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((ISingleMArrayrealMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<SinglerealMArrayD1E1M> models = null;

                models = await ((ISingleMArrayrealMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((ISingleMArrayrealMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((ISingleMArrayrealMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((ISingleMArrayrealMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((ISingleMArrayrealMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((ISingleMArrayrealMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((ISingleMArrayrealMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((ISingleMArrayrealMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((ISingleMArrayrealMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((ISingleMArrayrealMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((ISingleMArrayrealMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((ISingleMArrayrealMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((ISingleMArrayrealMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((ISingleMArrayrealMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((ISingleMArrayrealMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((ISingleMArrayrealMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((ISingleMArrayrealMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((ISingleMArrayrealMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((ISingleMArrayrealMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealMArrayD1E1M), typeof(FlatSinglerealMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1)),
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
FROM public.singlerealmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSinglerealMArrayD1E1M>();
                var models2 = new List<FlatSinglerealMArrayD1E1M>();
                await ((ISingleMArrayrealMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSinglerealMArrayD1E1M>();
                var models2 = new List<FlatSinglerealMArrayD1E1M>();
                ((ISingleMArrayrealMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1)),
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
FROM public.singlerealmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ISingleMArrayrealMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ISingleMArrayrealMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealmarrayd1e1m m
LEFT JOIN public.singlerealmarrayd11mi mi ON mi.id = m.singlerealmarrayd11mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(SinglerealMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1)),
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
                var models = await ((ISingleMArrayrealMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ISingleMArrayrealMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealMArrayD1E1M), typeof(FlatSinglerealMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1)),
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
FROM public.singlerealmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealMArrayD1E1M>();
                var models2 = new List<FlatSinglerealMArrayD1E1M>();
                await ((ISingleMArrayrealMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealMArrayD1E1M>();
                var models2 = new List<FlatSinglerealMArrayD1E1M>();
                ((ISingleMArrayrealMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1)),
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
FROM public.singlerealmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ISingleMArrayrealMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ISingleMArrayrealMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealmarrayd1e1m m
LEFT JOIN public.singlerealmarrayd11mi mi ON mi.id = m.singlerealmarrayd11mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(SinglerealMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1)),
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
                var models = await ((ISingleMArrayrealMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ISingleMArrayrealMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealMArrayD1E1M), typeof(FlatSinglerealMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1)),
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
            asPartInterface: typeof(ISingleMArrayrealMArrayD1)),
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
FROM public.singlerealmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglerealMArrayD1E1M>();
                var models2 = new List<FlatSinglerealMArrayD1E1M>();
                await((ISingleMArrayrealMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
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
FROM public.singlerealmarrayd1e1m m
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
FROM public.singlerealmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMArrayD1E1M>();
                var firstItems2 = new List<FlatSinglerealMArrayD1E1M>();
                var secondItems1 = new List<FlatSinglerealMArrayD1E1M>();
                var secondItems2 = new List<FlatSinglerealMArrayD1E1M>();
                await ((ISingleMArrayrealMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
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
FROM public.singlerealmarrayd1e1m m
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
FROM public.singlerealmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMArrayD1E1M>();
                var firstItems2 = new List<FlatSinglerealMArrayD1E1M>();
                var secondItems1 = new List<FlatSinglerealMArrayD1E1M>();
                await ((ISingleMArrayrealMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[15],_testData[34], false);
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
FROM public.singlerealmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglerealMArrayD1E1M>();
                var models2 = new List<FlatSinglerealMArrayD1E1M>();
                ((ISingleMArrayrealMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
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
FROM public.singlerealmarrayd1e1m m
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
FROM public.singlerealmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMArrayD1E1M>();
                var firstItems2 = new List<FlatSinglerealMArrayD1E1M>();
                var secondItems1 = new List<FlatSinglerealMArrayD1E1M>();
                var secondItems2 = new List<FlatSinglerealMArrayD1E1M>();
                 ((ISingleMArrayrealMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
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
FROM public.singlerealmarrayd1e1m m
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
FROM public.singlerealmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMArrayD1E1M>();
                var firstItems2 = new List<FlatSinglerealMArrayD1E1M>();
                var secondItems1 = new List<FlatSinglerealMArrayD1E1M>();
                 ((ISingleMArrayrealMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[15],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1)),
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
            asPartInterface: typeof(ISingleMArrayrealMArrayD1)),
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
FROM public.singlerealmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ISingleMArrayrealMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 29;
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
FROM public.singlerealmarrayd1e1m m
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
FROM public.singlerealmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleMArrayrealMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatSinglerealMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatSinglerealMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealmarrayd1e1m m
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
FROM public.singlerealmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMArrayD1E1M>();
                var secondItems1 = new List<FlatSinglerealMArrayD1E1M>();
                var secondItems2 = new List<FlatSinglerealMArrayD1E1M>();
                await ((ISingleMArrayrealMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.singlerealmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ISingleMArrayrealMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealmarrayd1e1m m
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
FROM public.singlerealmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleMArrayrealMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatSinglerealMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatSinglerealMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 25;
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
FROM public.singlerealmarrayd1e1m m
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
FROM public.singlerealmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMArrayD1E1M>();
                var secondItems1 = new List<FlatSinglerealMArrayD1E1M>();
                var secondItems2 = new List<FlatSinglerealMArrayD1E1M>();
                 ((ISingleMArrayrealMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.singlerealmarrayd1e1m m
LEFT JOIN public.singlerealmarrayd11mi mi ON mi.id = m.singlerealmarrayd11mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(SinglerealMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1)),
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
                var models = await((ISingleMArrayrealMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleMArrayrealMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        SinglerealMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        SinglerealMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        SinglerealMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        SinglerealMArrayD1E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        SinglerealMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        SinglerealMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        SinglerealMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        SinglerealMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        SinglerealMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        SinglerealMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        SinglerealMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        SinglerealMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        SinglerealMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        SinglerealMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        SinglerealMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        SinglerealMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        SinglerealMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        SinglerealMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        SinglerealMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        SinglerealMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        SinglerealMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        SinglerealMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        SinglerealMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        SinglerealMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        SinglerealMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        SinglerealMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        SinglerealMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        SinglerealMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        SinglerealMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        SinglerealMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        SinglerealMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        SinglerealMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        SinglerealMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        SinglerealMArrayD1E1M.AssertModel(models[29],_testData[34], false);
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
                var models = ((ISingleMArrayrealMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleMArrayrealMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        SinglerealMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        SinglerealMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        SinglerealMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        SinglerealMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        SinglerealMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        SinglerealMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        SinglerealMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        SinglerealMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        SinglerealMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        SinglerealMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        SinglerealMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        SinglerealMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        SinglerealMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        SinglerealMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        SinglerealMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        SinglerealMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        SinglerealMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        SinglerealMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        SinglerealMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        SinglerealMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        SinglerealMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        SinglerealMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        SinglerealMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        SinglerealMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        SinglerealMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        SinglerealMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        SinglerealMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        SinglerealMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        SinglerealMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        SinglerealMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        SinglerealMArrayD1E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        SinglerealMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        SinglerealMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        SinglerealMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        SinglerealMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        SinglerealMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        SinglerealMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        SinglerealMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        SinglerealMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        SinglerealMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        SinglerealMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        SinglerealMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        SinglerealMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        SinglerealMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        SinglerealMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        SinglerealMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        SinglerealMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        SinglerealMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        SinglerealMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        SinglerealMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        SinglerealMArrayD1E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealMArrayD1E1M), typeof(FlatSinglerealMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1)),
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
            asPartInterface: typeof(ISingleMArrayrealMArrayD1)),
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
            asPartInterface: typeof(ISingleMArrayrealMArrayD1)),
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
FROM public.singlerealmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealMArrayD1E1M>();
                var models2 = new List<FlatSinglerealMArrayD1E1M>();
                await((ISingleMArrayrealMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealmarrayd1e1m m
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
FROM public.singlerealmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMArrayD1E1M>();
                var firstItems2 = new List<FlatSinglerealMArrayD1E1M>();
                var secondItems1 = new List<FlatSinglerealMArrayD1E1M>();
                var secondItems2 = new List<FlatSinglerealMArrayD1E1M>();
                await ((ISingleMArrayrealMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 70, query1, 73, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.singlerealmarrayd1e1m m
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
FROM public.singlerealmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMArrayD1E1M>();
                var firstItems2 = new List<FlatSinglerealMArrayD1E1M>();
                var secondItems1 = new List<FlatSinglerealMArrayD1E1M>();
                await ((ISingleMArrayrealMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 42, query1, 3, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM public.singlerealmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealMArrayD1E1M>();
                var models2 = new List<FlatSinglerealMArrayD1E1M>();
                ((ISingleMArrayrealMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealmarrayd1e1m m
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
FROM public.singlerealmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMArrayD1E1M>();
                var firstItems2 = new List<FlatSinglerealMArrayD1E1M>();
                var secondItems1 = new List<FlatSinglerealMArrayD1E1M>();
                var secondItems2 = new List<FlatSinglerealMArrayD1E1M>();
                 ((ISingleMArrayrealMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 121, query1, 29, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.singlerealmarrayd1e1m m
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
FROM public.singlerealmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMArrayD1E1M>();
                var firstItems2 = new List<FlatSinglerealMArrayD1E1M>();
                var secondItems1 = new List<FlatSinglerealMArrayD1E1M>();
                 ((ISingleMArrayrealMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 35, query1, 46, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1)),
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
            asPartInterface: typeof(ISingleMArrayrealMArrayD1)),
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
            asPartInterface: typeof(ISingleMArrayrealMArrayD1)),
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
FROM public.singlerealmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ISingleMArrayrealMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealmarrayd1e1m m
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
FROM public.singlerealmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleMArrayrealMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 113, query1, 113, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatSinglerealMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatSinglerealMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[6],_testData[34], false);
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
FROM public.singlerealmarrayd1e1m m
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
FROM public.singlerealmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMArrayD1E1M>();
                var secondItems1 = new List<FlatSinglerealMArrayD1E1M>();
                var secondItems2 = new List<FlatSinglerealMArrayD1E1M>();
                await ((ISingleMArrayrealMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 35, query1, 122, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.singlerealmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ISingleMArrayrealMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealmarrayd1e1m m
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
FROM public.singlerealmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleMArrayrealMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 71, query1, 8, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatSinglerealMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatSinglerealMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(models[31],_testData[34], false);
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
FROM public.singlerealmarrayd1e1m m
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
FROM public.singlerealmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMArrayD1E1M>();
                var secondItems1 = new List<FlatSinglerealMArrayD1E1M>();
                var secondItems2 = new List<FlatSinglerealMArrayD1E1M>();
                 ((ISingleMArrayrealMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 20, query1, 96, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatSinglerealMArrayD1E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.singlerealmarrayd1e1m m
LEFT JOIN public.singlerealmarrayd11mi mi ON mi.id = m.singlerealmarrayd11mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(SinglerealMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1)),
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
            asPartInterface: typeof(ISingleMArrayrealMArrayD1)),
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
                var models = await((ISingleMArrayrealMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ISingleMArrayrealMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 8, 86))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        SinglerealMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        SinglerealMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        SinglerealMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        SinglerealMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        SinglerealMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        SinglerealMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        SinglerealMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        SinglerealMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        SinglerealMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        SinglerealMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        SinglerealMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        SinglerealMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        SinglerealMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        SinglerealMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        SinglerealMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        SinglerealMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        SinglerealMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        SinglerealMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        SinglerealMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        SinglerealMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        SinglerealMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        SinglerealMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        SinglerealMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        SinglerealMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        SinglerealMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        SinglerealMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        SinglerealMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        SinglerealMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        SinglerealMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        SinglerealMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        SinglerealMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        SinglerealMArrayD1E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        SinglerealMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                        SinglerealMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                        SinglerealMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                        SinglerealMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                        SinglerealMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                        SinglerealMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                        SinglerealMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                        SinglerealMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                        SinglerealMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                        SinglerealMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                        SinglerealMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                        SinglerealMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                        SinglerealMArrayD1E1M.AssertModel(models[12],_testData[34], false);
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
                var models = ((ISingleMArrayrealMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ISingleMArrayrealMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 80, 58))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        SinglerealMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        SinglerealMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        SinglerealMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        SinglerealMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        SinglerealMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        SinglerealMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        SinglerealMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        SinglerealMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        SinglerealMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        SinglerealMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        SinglerealMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        SinglerealMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        SinglerealMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        SinglerealMArrayD1E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        SinglerealMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        SinglerealMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        SinglerealMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        SinglerealMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        SinglerealMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        SinglerealMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        SinglerealMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        SinglerealMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        SinglerealMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        SinglerealMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        SinglerealMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        SinglerealMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        SinglerealMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        SinglerealMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        SinglerealMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        SinglerealMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        SinglerealMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        SinglerealMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        SinglerealMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        SinglerealMArrayD1E1M.AssertModel(models[19],_testData[34], false);
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
                await using var cmd = await ((ISingleMArrayrealMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ISingleMArrayrealMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 29);
                var models = await ((ISingleMArrayrealMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                SinglerealMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                SinglerealMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                SinglerealMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                SinglerealMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                SinglerealMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                SinglerealMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                SinglerealMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                SinglerealMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                SinglerealMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                SinglerealMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                SinglerealMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                SinglerealMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                SinglerealMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                SinglerealMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                SinglerealMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                SinglerealMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                SinglerealMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                SinglerealMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                SinglerealMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                SinglerealMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                SinglerealMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                SinglerealMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                SinglerealMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                SinglerealMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                SinglerealMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                SinglerealMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                SinglerealMArrayD1E1M.AssertModel(models[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleMArrayrealMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleMArrayrealMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 113);
                var models =  ((ISingleMArrayrealMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                SinglerealMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                SinglerealMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                SinglerealMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                SinglerealMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                SinglerealMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                SinglerealMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                SinglerealMArrayD1E1M.AssertModel(models[6],_testData[34], false);
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
FROM public.binary_singlerealmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(SinglerealMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(SinglerealMArrayD11MIWA),
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
            asPartInterface: typeof(ISingleMArrayrealMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealMArrayD11MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISingleMArrayrealMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_singlerealmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISingleMArrayrealMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealMArrayD11MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISingleMArrayrealMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_singlerealmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISingleMArrayrealMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealMArrayD11MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_singlerealmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(SinglerealMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(SinglerealMArrayD11MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealMArrayD11MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISingleMArrayrealMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_singlerealmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISingleMArrayrealMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealMArrayD11MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISingleMArrayrealMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_singlerealmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISingleMArrayrealMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealMArrayD11MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_singlerealmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(SinglerealMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlerealmarrayd11mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(SinglerealMArrayD11MI),
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
            asPartInterface: typeof(ISingleMArrayrealMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealMArrayD11MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ISingleMArrayrealMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((ISingleMArrayrealMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealMArrayD11MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealMArrayD11MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ISingleMArrayrealMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((ISingleMArrayrealMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealMArrayD11MI.AssertModel(actual, expect, false);
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
FROM public.binary_singlerealmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(SinglerealMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlerealmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(SinglerealMArrayD11MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealMArrayD11MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISingleMArrayrealMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ISingleMArrayrealMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealMArrayD11MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISingleMArrayrealMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((ISingleMArrayrealMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealMArrayD11MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlerealmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
singlerealmarrayd11mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(SinglerealMArrayD1E1M),
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
            asPartInterface: typeof(ISingleMArrayrealMArrayD1))]
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
FROM public.binary_singlerealmarrayd1e1m m
LEFT JOIN public.binary_singlerealmarrayd11mi mi ON mi.id = m.singlerealmarrayd11mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(SinglerealMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((ISingleMArrayrealMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((ISingleMArrayrealMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    SinglerealMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((ISingleMArrayrealMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((ISingleMArrayrealMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    SinglerealMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    singlerealmarrayd11mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(SinglerealMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1)),
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
                var models =  ((ISingleMArrayrealMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SinglerealMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleMArrayrealMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SinglerealMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(SinglerealMArrayD11MIWA), typeof(SinglerealMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1)),
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
                var models1 = new List<SinglerealMArrayD11MIWA>();
                var models2 = new List<SinglerealMArrayD11MIWA>();
                await ((ISingleMArrayrealMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealMArrayD11MIWA>();
                var models2 = new List<SinglerealMArrayD11MIWA>();
                ((ISingleMArrayrealMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(SinglerealMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1)),
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
                var models = await ((ISingleMArrayrealMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_singlerealmarrayd11mi
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
                    SinglerealMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleMArrayrealMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_singlerealmarrayd11mi
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
                    SinglerealMArrayD11MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(SinglerealMArrayD11MIWA), typeof(SinglerealMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1))]
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
                var models1 = new List<SinglerealMArrayD11MIWA>();
                var models2 = new List<SinglerealMArrayD11MIWA>();
                await ((ISingleMArrayrealMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealMArrayD11MIWA>();
                var models2 = new List<SinglerealMArrayD11MIWA>();
                ((ISingleMArrayrealMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(SinglerealMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1))]
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
                var models = await ((ISingleMArrayrealMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_singlerealmarrayd11mi
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
                    SinglerealMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleMArrayrealMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_singlerealmarrayd11mi
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
                    SinglerealMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_singlerealmarrayd11mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(SinglerealMArrayD11MI), typeof(SinglerealMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1)),
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
                var models1 = new List<SinglerealMArrayD11MI>();
                var models2 = new List<SinglerealMArrayD11MI>();
                await ((ISingleMArrayrealMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealMArrayD11MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealMArrayD11MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealMArrayD11MI>();
                var models2 = new List<SinglerealMArrayD11MI>();
                ((ISingleMArrayrealMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealMArrayD11MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealMArrayD11MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealmarrayd11mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(SinglerealMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1)),
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
                var models = await ((ISingleMArrayrealMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealMArrayD11MI.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleMArrayrealMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealMArrayD11MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_singlerealmarrayd11mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(SinglerealMArrayD11MIWA), typeof(SinglerealMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1))]
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
                var models1 = new List<SinglerealMArrayD11MIWA>();
                var models2 = new List<SinglerealMArrayD11MIWA>();
                await ((ISingleMArrayrealMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealMArrayD11MIWA>();
                var models2 = new List<SinglerealMArrayD11MIWA>();
                ((ISingleMArrayrealMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealmarrayd11mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(SinglerealMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMArrayD1))]
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
                var models = await ((ISingleMArrayrealMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleMArrayrealMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealMArrayD11MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

