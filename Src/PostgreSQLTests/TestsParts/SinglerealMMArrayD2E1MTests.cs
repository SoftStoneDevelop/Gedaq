

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
    internal partial interface ISingleMArrayrealMMArrayD2
    {
    }
    
    internal partial class SingleMArrayrealMMArrayD2 : ISingleMArrayrealMMArrayD2
    {


#region TestData

        private readonly SinglerealMMArrayD2E1M[] _testData = new SinglerealMMArrayD2E1M[]
        {
            new SinglerealMMArrayD2E1M
{
    Id = 3,
    Value = 
new System.Single[,] { { 0.75478685f, 0.6693737f, }, { 0.72201145f, 0.45970565f, }, },
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 5,
    Value = 
new System.Single[,] { { 0.3884107f, 0.9132015f, }, { 0.64881057f, 0.46522123f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 3,
    Value = 
new System.Single[,] { { 0.5375753f, 0.4153561f, }, { 0.9724285f, 0.18032277f, }, },
    NullableValue = 
new System.Single[,] { { 0.9000309f, 0.38763052f, }, { 0.10985339f, 0.04031223f, }, },
},
    NullableValue = 
new System.Single[,] { { 0.9164713f, 0.51880413f, }, { 0.7948655f, 0.59573215f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 12,
    Value = 
new System.Single[,] { { 0.7034282f, 0.5658322f, }, { 0.29274327f, 0.56398875f, }, },
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 20,
    Value = 
new System.Single[,] { { 0.68517715f, 0.020041645f, }, { 0.21202981f, 0.73559016f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 8,
    Value = 
new System.Single[,] { { 0.5173988f, 0.9029131f, }, { 0.36924094f, 0.95177156f, }, },
    NullableValue = 
new System.Single[,] { { 0.16289592f, 0.040602863f, }, { 0.9698007f, 0.40631074f, }, },
},
    NullableValue = 
new System.Single[,] { { 0.7875048f, 0.7949542f, }, { 0.789863f, 0.48936003f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 23,
    Value = 
new System.Single[,] { { 0.04030037f, 0.78622663f, }, { 0.92048013f, 0.47662216f, }, },
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 24,
    Value = 
new System.Single[,] { { 0.5198212f, 0.071150064f, }, { 0.3965214f, 0.13607794f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 16,
    Value = 
new System.Single[,] { { 0.35556042f, 0.047446847f, }, { 0.7744743f, 0.3377623f, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 31,
    Value = 
new System.Single[,] { { 0.5257258f, 0.95061636f, }, { 0.28546995f, 0.8931678f, }, },
    ModelInner = null,
    NullableValue = 
new System.Single[,] { { 0.165757f, 0.7053415f, }, { 0.30301386f, 0.54470366f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 34,
    Value = 
new System.Single[,] { { 0.8596603f, 0.8807993f, }, { 0.41841775f, 0.74636096f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 25,
    Value = 
new System.Single[,] { { 0.6224366f, 0.39193058f, }, { 0.24467373f, 0.0013284087f, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 40,
    Value = 
new System.Single[,] { { 0.43405908f, 0.53849155f, }, { 0.5337193f, 0.84725636f, }, },
    ModelInner = null,
    NullableValue = 
new System.Single[,] { { 0.8564515f, 0.8931524f, }, { 0.17052317f, 0.019462526f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 47,
    Value = 
new System.Single[,] { { 0.24043167f, 0.12337625f, }, { 0.73342496f, 0.017023861f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 30,
    Value = 
new System.Single[,] { { 0.29508275f, 0.3115124f, }, { 0.36814755f, 0.6993732f, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Single[,] { { 0.34929752f, 0.9129128f, }, { 0.32750434f, 0.04806429f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 53,
    Value = 
new System.Single[,] { { 0.7103895f, 0.59877527f, }, { 0.3520295f, 0.9949513f, }, },
    ModelInner = null,
    NullableValue = 
new System.Single[,] { { 0.3463984f, 0.46332377f, }, { 0.6606963f, 0.36146474f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 60,
    Value = 
new System.Single[,] { { 0.051717162f, 0.09306133f, }, { 0.8625717f, 0.64685136f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 34,
    Value = 
new System.Single[,] { { 0.65433884f, 0.3936835f, }, { 0.08353686f, 0.67292595f, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Single[,] { { 0.30769277f, 0.5608424f, }, { 0.9247845f, 0.6390092f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 69,
    Value = 
new System.Single[,] { { 0.28302604f, 0.1943804f, }, { 0.6590475f, 0.4180529f, }, },
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 77,
    Value = 
new System.Single[,] { { 0.29242003f, 0.6179516f, }, { 0.2334441f, 0.6638935f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 38,
    Value = 
new System.Single[,] { { 0.8988106f, 0.51128095f, }, { 0.89130044f, 0.106847644f, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Single[,] { { 0.3240118f, 0.28638786f, }, { 0.8287276f, 0.5969644f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 86,
    Value = 
new System.Single[,] { { 0.17395014f, 0.8812132f, }, { 0.012570202f, 0.38408607f, }, },
    ModelInner = null,
    NullableValue = 
new System.Single[,] { { 0.39252305f, 0.24825251f, }, { 0.56412965f, 0.75670695f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 91,
    Value = 
new System.Single[,] { { 0.96453977f, 0.5806335f, }, { 0.09638494f, 0.4536702f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 46,
    Value = 
new System.Single[,] { { 0.24217165f, 0.83737105f, }, { 0.92039925f, 0.4047175f, }, },
    NullableValue = 
new System.Single[,] { { 0.68953377f, 0.8971825f, }, { 0.89926f, 0.8286114f, }, },
},
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 93,
    Value = 
new System.Single[,] { { 0.48502207f, 0.54485756f, }, { 0.12422866f, 0.2664019f, }, },
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 94,
    Value = 
new System.Single[,] { { 0.06296432f, 0.59156877f, }, { 0.38922626f, 0.75956935f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 52,
    Value = 
new System.Single[,] { { 0.9156592f, 0.49359685f, }, { 0.6184836f, 0.61245626f, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 97,
    Value = 
new System.Single[,] { { 0.22642463f, 0.13934523f, }, { 0.13319045f, 0.7417093f, }, },
    ModelInner = null,
    NullableValue = 
new System.Single[,] { { 0.24312592f, 0.7253984f, }, { 0.55902046f, 0.15034878f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 104,
    Value = 
new System.Single[,] { { 0.3116101f, 0.9722015f, }, { 0.49082774f, 0.7273026f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 55,
    Value = 
new System.Single[,] { { 0.3920986f, 0.30735338f, }, { 0.79124796f, 0.9769082f, }, },
    NullableValue = 
new System.Single[,] { { 0.7418725f, 0.36712015f, }, { 0.6788978f, 0.4359498f, }, },
},
    NullableValue = 
new System.Single[,] { { 0.6948921f, 0.37266344f, }, { 0.210626f, 0.027098238f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 111,
    Value = 
new System.Single[,] { { 0.3335421f, 0.051665723f, }, { 0.013589323f, 0.939491f, }, },
    ModelInner = null,
    NullableValue = 
new System.Single[,] { { 0.19588912f, 0.30849653f, }, { 0.75476897f, 0.9064809f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 114,
    Value = 
new System.Single[,] { { 0.95543665f, 0.48365492f, }, { 0.7832488f, 0.7315359f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 61,
    Value = 
new System.Single[,] { { 0.8245726f, 0.19005007f, }, { 0.9591397f, 0.7416053f, }, },
    NullableValue = 
new System.Single[,] { { 0.13196027f, 0.48116064f, }, { 0.9870955f, 0.41664743f, }, },
},
    NullableValue = 
new System.Single[,] { { 0.1646688f, 0.19316179f, }, { 0.7268745f, 0.15179807f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 120,
    Value = 
new System.Single[,] { { 0.74139804f, 0.16988063f, }, { 0.033748627f, 0.49190253f, }, },
    ModelInner = null,
    NullableValue = 
new System.Single[,] { { 0.15622795f, 0.5792138f, }, { 0.30368745f, 0.9424941f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 124,
    Value = 
new System.Single[,] { { 0.7787543f, 0.05511093f, }, { 0.191428f, 0.3409205f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 70,
    Value = 
new System.Single[,] { { 0.5658791f, 0.5016892f, }, { 0.0046010613f, 0.0632779f, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Single[,] { { 0.6190681f, 0.59293205f, }, { 0.58088547f, 0.20946616f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 126,
    Value = 
new System.Single[,] { { 0.108124614f, 0.62349516f, }, { 0.75138706f, 0.8234102f, }, },
    ModelInner = null,
    NullableValue = 
new System.Single[,] { { 0.14353973f, 0.3892436f, }, { 0.15720582f, 0.6854292f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 132,
    Value = 
new System.Single[,] { { 0.08410889f, 0.5941727f, }, { 0.21057051f, 0.22860545f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 76,
    Value = 
new System.Single[,] { { 0.06180942f, 0.68444276f, }, { 0.27750695f, 0.19873917f, }, },
    NullableValue = 
new System.Single[,] { { 0.4830644f, 0.85247904f, }, { 0.83946013f, 0.5707628f, }, },
},
    NullableValue = 
new System.Single[,] { { 0.62451404f, 0.21395022f, }, { 0.74291253f, 0.95547754f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 140,
    Value = 
new System.Single[,] { { 0.31925774f, 0.2898497f, }, { 0.30385536f, 0.54074067f, }, },
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 141,
    Value = 
new System.Single[,] { { 0.36218423f, 0.6935656f, }, { 0.23766881f, 0.024781644f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 80,
    Value = 
new System.Single[,] { { 0.43120074f, 0.030002832f, }, { 0.69244486f, 0.24409002f, }, },
    NullableValue = 
new System.Single[,] { { 0.30603427f, 0.10008502f, }, { 0.30744755f, 0.45615894f, }, },
},
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 148,
    Value = 
new System.Single[,] { { 0.47979265f, 0.59651613f, }, { 0.931797f, 0.37428057f, }, },
    ModelInner = null,
    NullableValue = 
new System.Single[,] { { 0.453874f, 0.49533153f, }, { 0.5889576f, 0.3098836f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 154,
    Value = 
new System.Single[,] { { 0.63396096f, 0.43331742f, }, { 0.12539172f, 0.95496964f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 83,
    Value = 
new System.Single[,] { { 0.84912914f, 0.52019113f, }, { 0.7825285f, 0.13947117f, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 155,
    Value = 
new System.Single[,] { { 0.87281173f, 0.3195849f, }, { 0.124114275f, 0.38696134f, }, },
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 162,
    Value = 
new System.Single[,] { { 0.5022037f, 0.02332306f, }, { 0.090106726f, 0.38358784f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 86,
    Value = 
new System.Single[,] { { 0.41387975f, 0.07857746f, }, { 0.4771241f, 0.30985826f, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealMMArrayD2E1M
{
    Id = 167,
    Value = 
new System.Single[,] { { 0.25587314f, 0.94213295f, }, { 0.501238f, 0.012408018f, }, },
    ModelInner = null,
    NullableValue = 
new System.Single[,] { { 0.45439398f, 0.3805427f, }, { 0.70298326f, 0.9889207f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 169,
    Value = 
new System.Single[,] { { 0.69602764f, 0.9932211f, }, { 0.17109787f, 0.49424058f, }, },
    ModelInner = new SinglerealMMArrayD2E1MI
{
    Id = 89,
    Value = 
new System.Single[,] { { 0.616598f, 0.38981593f, }, { 0.72946227f, 0.45708066f, }, },
    NullableValue = 
new System.Single[,] { { 0.85422325f, 0.1907351f, }, { 0.75167304f, 0.2207517f, }, },
},
    NullableValue = 
new System.Single[,] { { 0.057727933f, 0.8815105f, }, { 0.8805145f, 0.6002061f, }, },
},
            new SinglerealMMArrayD2E1M
{
    Id = 172,
    Value = 
new System.Single[,] { { 0.90294045f, 0.43604517f, }, { 0.16137922f, 0.83190876f, }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealmmarrayd2e1mi(
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealmmarrayd2e1mi(
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
            queryMapTypes: [typeof(SinglerealMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[,]), 
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

                changedRows =  ((ISingleMArrayrealMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISingleMArrayrealMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ISingleMArrayrealMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleMArrayrealMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ISingleMArrayrealMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ISingleMArrayrealMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ISingleMArrayrealMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ISingleMArrayrealMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((ISingleMArrayrealMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((ISingleMArrayrealMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((ISingleMArrayrealMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((ISingleMArrayrealMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((ISingleMArrayrealMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((ISingleMArrayrealMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((ISingleMArrayrealMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((ISingleMArrayrealMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((ISingleMArrayrealMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    singlerealmmarrayd2e1mi_id
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "singlerealmmarrayd2e1mi_id", 
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
                changedRows =  ((ISingleMArrayrealMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ISingleMArrayrealMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ISingleMArrayrealMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ISingleMArrayrealMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    singlerealmmarrayd2e1mi_id
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
    singlerealmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
                System.Single[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Single[,]>();
                    ((NpgsqlParameter<System.Single[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483631);
                    ((NpgsqlParameter<System.Single[,]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((ISingleMArrayrealMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Single[,]>();
                    ((NpgsqlParameter<System.Single[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483631);
                    ((NpgsqlParameter<System.Single[,]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((ISingleMArrayrealMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.Single[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Single[,]>();
                    ((NpgsqlParameter<System.Single[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483631);
                    ((NpgsqlParameter<System.Single[,]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((ISingleMArrayrealMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[,] { { 0.165757f, 0.7053415f, }, { 0.30301386f, 0.54470366f, }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Single[,]>();
                    ((NpgsqlParameter<System.Single[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483631);
                    ((NpgsqlParameter<System.Single[,]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((ISingleMArrayrealMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlerealmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    singlerealmmarrayd2e1mi_id
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
    singlerealmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483631)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "singlerealmmarrayd2e1mi_id", 
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
                System.Single[,] nullable = null;
                nullable =  ((ISingleMArrayrealMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[,] { { 0.8564515f, 0.8931524f, }, { 0.17052317f, 0.019462526f, }, }));
                nullable =  ((ISingleMArrayrealMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[,] { { 0.34929752f, 0.9129128f, }, { 0.32750434f, 0.04806429f, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Single[,] nullable = null;
                nullable = await ((ISingleMArrayrealMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[,] { { 0.3463984f, 0.46332377f, }, { 0.6606963f, 0.36146474f, }, }));
                nullable = await ((ISingleMArrayrealMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Single[,] { { 0.30769277f, 0.5608424f, }, { 0.9247845f, 0.6390092f, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<SinglerealMMArrayD2E1M> models = null;

                models =  ((ISingleMArrayrealMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((ISingleMArrayrealMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((ISingleMArrayrealMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((ISingleMArrayrealMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<SinglerealMMArrayD2E1M> models = null;

                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((ISingleMArrayrealMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealMMArrayD2E1M), typeof(FlatSinglerealMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
FROM public.singlerealmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSinglerealMMArrayD2E1M>();
                var models2 = new List<FlatSinglerealMMArrayD2E1M>();
                await ((ISingleMArrayrealMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSinglerealMMArrayD2E1M>();
                var models2 = new List<FlatSinglerealMMArrayD2E1M>();
                ((ISingleMArrayrealMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
FROM public.singlerealmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ISingleMArrayrealMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ISingleMArrayrealMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealmmarrayd2e1m m
LEFT JOIN public.singlerealmmarrayd2e1mi mi ON mi.id = m.singlerealmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
                var models = await ((ISingleMArrayrealMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ISingleMArrayrealMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealMMArrayD2E1M), typeof(FlatSinglerealMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
FROM public.singlerealmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealMMArrayD2E1M>();
                var models2 = new List<FlatSinglerealMMArrayD2E1M>();
                await ((ISingleMArrayrealMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealMMArrayD2E1M>();
                var models2 = new List<FlatSinglerealMMArrayD2E1M>();
                ((ISingleMArrayrealMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
FROM public.singlerealmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ISingleMArrayrealMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ISingleMArrayrealMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealmmarrayd2e1m m
LEFT JOIN public.singlerealmmarrayd2e1mi mi ON mi.id = m.singlerealmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
                var models = await ((ISingleMArrayrealMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ISingleMArrayrealMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealMMArrayD2E1M), typeof(FlatSinglerealMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglerealMMArrayD2E1M>();
                var models2 = new List<FlatSinglerealMMArrayD2E1M>();
                await((ISingleMArrayrealMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
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
FROM public.singlerealmmarrayd2e1m m
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var firstItems2 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems2 = new List<FlatSinglerealMMArrayD2E1M>();
                await ((ISingleMArrayrealMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
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
FROM public.singlerealmmarrayd2e1m m
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var firstItems2 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                await ((ISingleMArrayrealMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglerealMMArrayD2E1M>();
                var models2 = new List<FlatSinglerealMMArrayD2E1M>();
                ((ISingleMArrayrealMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
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
FROM public.singlerealmmarrayd2e1m m
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var firstItems2 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems2 = new List<FlatSinglerealMMArrayD2E1M>();
                 ((ISingleMArrayrealMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 167;
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
FROM public.singlerealmmarrayd2e1m m
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var firstItems2 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                 ((ISingleMArrayrealMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ISingleMArrayrealMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealmmarrayd2e1m m
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleMArrayrealMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatSinglerealMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatSinglerealMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
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
                parametr2.Value = 3;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealmmarrayd2e1m m
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems2 = new List<FlatSinglerealMMArrayD2E1M>();
                await ((ISingleMArrayrealMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ISingleMArrayrealMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 69;
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
FROM public.singlerealmmarrayd2e1m m
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleMArrayrealMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatSinglerealMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatSinglerealMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 141;
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
FROM public.singlerealmmarrayd2e1m m
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems2 = new List<FlatSinglerealMMArrayD2E1M>();
                 ((ISingleMArrayrealMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.singlerealmmarrayd2e1m m
LEFT JOIN public.singlerealmmarrayd2e1mi mi ON mi.id = m.singlerealmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
                var models = await((ISingleMArrayrealMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleMArrayrealMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
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
                var models = ((ISingleMArrayrealMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 154;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleMArrayrealMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealMMArrayD2E1M), typeof(FlatSinglerealMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealMMArrayD2E1M>();
                var models2 = new List<FlatSinglerealMMArrayD2E1M>();
                await((ISingleMArrayrealMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealmmarrayd2e1m m
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var firstItems2 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems2 = new List<FlatSinglerealMMArrayD2E1M>();
                await ((ISingleMArrayrealMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 91, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.singlerealmmarrayd2e1m m
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var firstItems2 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                await ((ISingleMArrayrealMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 20, query1, 53, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[23],_testData[34], false);
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglerealMMArrayD2E1M>();
                var models2 = new List<FlatSinglerealMMArrayD2E1M>();
                ((ISingleMArrayrealMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatSinglerealMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlerealmmarrayd2e1m m
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var firstItems2 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems2 = new List<FlatSinglerealMMArrayD2E1M>();
                 ((ISingleMArrayrealMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 155, query1, 5, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.singlerealmmarrayd2e1m m
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var firstItems2 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                 ((ISingleMArrayrealMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 86, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[24],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ISingleMArrayrealMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealmmarrayd2e1m m
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleMArrayrealMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 77, query1, 24, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatSinglerealMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatSinglerealMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
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
FROM public.singlerealmmarrayd2e1m m
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems2 = new List<FlatSinglerealMMArrayD2E1M>();
                await ((ISingleMArrayrealMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 114, query1, 124, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ISingleMArrayrealMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatSinglerealMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlerealmmarrayd2e1m m
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleMArrayrealMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 93, query1, 141, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatSinglerealMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatSinglerealMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
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
FROM public.singlerealmmarrayd2e1m m
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
FROM public.singlerealmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems1 = new List<FlatSinglerealMMArrayD2E1M>();
                var secondItems2 = new List<FlatSinglerealMMArrayD2E1M>();
                 ((ISingleMArrayrealMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 167, query1, 104, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatSinglerealMMArrayD2E1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.singlerealmmarrayd2e1m m
LEFT JOIN public.singlerealmmarrayd2e1mi mi ON mi.id = m.singlerealmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
                var models = await((ISingleMArrayrealMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ISingleMArrayrealMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 40, 53))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
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
                var models = ((ISingleMArrayrealMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    SinglerealMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ISingleMArrayrealMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 111, 12))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        SinglerealMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
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
                await using var cmd = await ((ISingleMArrayrealMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ISingleMArrayrealMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 20);
                var models = await ((ISingleMArrayrealMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(31));

                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                SinglerealMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                SinglerealMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                SinglerealMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                SinglerealMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                SinglerealMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                SinglerealMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                SinglerealMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                SinglerealMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                SinglerealMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                SinglerealMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                SinglerealMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                SinglerealMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                SinglerealMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                SinglerealMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                SinglerealMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                SinglerealMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                SinglerealMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                SinglerealMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                SinglerealMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                SinglerealMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                SinglerealMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                SinglerealMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                SinglerealMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                SinglerealMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                SinglerealMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                SinglerealMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                SinglerealMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                SinglerealMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                SinglerealMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                SinglerealMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleMArrayrealMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleMArrayrealMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 53);
                var models =  ((ISingleMArrayrealMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                SinglerealMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                SinglerealMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                SinglerealMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                SinglerealMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                SinglerealMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                SinglerealMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                SinglerealMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                SinglerealMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                SinglerealMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                SinglerealMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                SinglerealMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                SinglerealMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                SinglerealMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                SinglerealMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                SinglerealMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                SinglerealMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                SinglerealMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                SinglerealMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                SinglerealMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                SinglerealMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                SinglerealMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                SinglerealMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                SinglerealMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                SinglerealMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
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
FROM public.binary_singlerealmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(SinglerealMMArrayD2E1MIWA),
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISingleMArrayrealMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_singlerealmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISingleMArrayrealMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISingleMArrayrealMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_singlerealmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISingleMArrayrealMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_singlerealmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(SinglerealMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISingleMArrayrealMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_singlerealmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ISingleMArrayrealMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISingleMArrayrealMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_singlerealmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISingleMArrayrealMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_singlerealmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlerealmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(SinglerealMMArrayD2E1MI),
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ISingleMArrayrealMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((ISingleMArrayrealMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ISingleMArrayrealMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((ISingleMArrayrealMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_singlerealmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlerealmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(SinglerealMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISingleMArrayrealMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ISingleMArrayrealMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISingleMArrayrealMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((ISingleMArrayrealMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlerealmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
singlerealmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(SinglerealMMArrayD2E1M),
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
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2))]
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
FROM public.binary_singlerealmmarrayd2e1m m
LEFT JOIN public.binary_singlerealmmarrayd2e1mi mi ON mi.id = m.singlerealmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<SinglerealMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((ISingleMArrayrealMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((ISingleMArrayrealMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    SinglerealMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((ISingleMArrayrealMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((ISingleMArrayrealMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    SinglerealMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    singlerealmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
                var models =  ((ISingleMArrayrealMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SinglerealMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleMArrayrealMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    SinglerealMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1MIWA), typeof(SinglerealMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
                var models1 = new List<SinglerealMMArrayD2E1MIWA>();
                var models2 = new List<SinglerealMMArrayD2E1MIWA>();
                await ((ISingleMArrayrealMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealMMArrayD2E1MIWA>();
                var models2 = new List<SinglerealMMArrayD2E1MIWA>();
                ((ISingleMArrayrealMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
                var models = await ((ISingleMArrayrealMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_singlerealmmarrayd2e1mi
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
                    SinglerealMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleMArrayrealMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_singlerealmmarrayd2e1mi
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
                    SinglerealMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1MIWA), typeof(SinglerealMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2))]
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
                var models1 = new List<SinglerealMMArrayD2E1MIWA>();
                var models2 = new List<SinglerealMMArrayD2E1MIWA>();
                await ((ISingleMArrayrealMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealMMArrayD2E1MIWA>();
                var models2 = new List<SinglerealMMArrayD2E1MIWA>();
                ((ISingleMArrayrealMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_singlerealmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2))]
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
                var models = await ((ISingleMArrayrealMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_singlerealmmarrayd2e1mi
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
                    SinglerealMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleMArrayrealMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_singlerealmmarrayd2e1mi
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
                    SinglerealMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_singlerealmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1MI), typeof(SinglerealMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
                var models1 = new List<SinglerealMMArrayD2E1MI>();
                var models2 = new List<SinglerealMMArrayD2E1MI>();
                await ((ISingleMArrayrealMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealMMArrayD2E1MI>();
                var models2 = new List<SinglerealMMArrayD2E1MI>();
                ((ISingleMArrayrealMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2)),
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
                var models = await ((ISingleMArrayrealMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleMArrayrealMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_singlerealmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1MIWA), typeof(SinglerealMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2))]
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
                var models1 = new List<SinglerealMMArrayD2E1MIWA>();
                var models2 = new List<SinglerealMMArrayD2E1MIWA>();
                await ((ISingleMArrayrealMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealMMArrayD2E1MIWA>();
                var models2 = new List<SinglerealMMArrayD2E1MIWA>();
                ((ISingleMArrayrealMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlerealmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(SinglerealMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleMArrayrealMMArrayD2))]
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
                var models = await ((ISingleMArrayrealMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ISingleMArrayrealMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    SinglerealMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

