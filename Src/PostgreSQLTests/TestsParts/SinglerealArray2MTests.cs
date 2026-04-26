

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
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.55180734f,

0.76805085f,

0.5126074f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.46598327f,

0.45119715f,

0.5786891f,

0.52635896f,

},
},
            new SinglerealArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.6831561f,

0.520682f,

0.03804475f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.15719962f,

0.3221103f,

0.60278404f,

0.5684473f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.5307542f,

0.25530493f,

0.30313432f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.5153945f,

0.019030869f,

0.9992457f,

},
},
            new SinglerealArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8358327f,

0.53618324f,

0.3187837f,

0.55413145f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.77128243f,

0.5974311f,

0.2991748f,

0.35905457f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.5379961f,

0.340019f,

0.735158f,

},
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.18166345f,

0.3384769f,

0.14828074f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.94963115f,

0.94494444f,

0.6413629f,

0.3097232f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.2425406f,

0.5972058f,

0.1967966f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.9761111f,

0.91452473f,

0.08708626f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.790571f,

0.7728622f,

0.7092159f,

0.6222861f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.31166685f,

0.56732744f,

0.9413168f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.13054073f,

0.5224641f,

0.45316207f,

0.17766064f,

},
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6962424f,

0.51325244f,

0.9841232f,

0.23062146f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.37745202f,

0.51317406f,

0.526243f,

},
},
            new SinglerealArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.6553952f,

0.68532926f,

0.2625845f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.14655769f,

0.5843154f,

0.37780744f,

0.7795753f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.51050675f,

0.23112082f,

0.85611814f,

0.12612814f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.7820929f,

0.830264f,

0.012944102f,

0.10346514f,

},
},
            new SinglerealArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.95586437f,

0.6584909f,

0.69612354f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.47964525f,

0.82274294f,

0.899658f,

0.25014907f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8880731f,

0.71389395f,

0.3868894f,

0.13819009f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.119134665f,

0.03791094f,

0.045091093f,

},
},
            new SinglerealArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5790012f,

0.64186054f,

0.8632784f,

0.77085924f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.22328454f,

0.6211569f,

0.0083974f,

0.8655343f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.4486764f,

0.61694807f,

0.441962f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.27935696f,

0.5740604f,

0.85494614f,

},
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.01043421f,

0.9427855f,

0.1718216f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.5652971f,

0.89127356f,

0.08156896f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.36766618f,

0.7711891f,

0.39081305f,

0.8044318f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6556342f,

0.26336932f,

0.15680069f,

0.38692135f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8807557f,

0.075656116f,

0.11224979f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.32210684f,

0.41056418f,

0.53238684f,

0.04252249f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.4700008f,

0.7529733f,

0.41354674f,

0.99552596f,

},
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.90729374f,

0.42095172f,

0.06575173f,

0.17698973f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5060463f,

0.86824346f,

0.31813198f,

0.23687977f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.2469787f,

0.33486724f,

0.8120599f,

0.6910317f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8919896f,

0.8266536f,

0.00038081408f,

0.97433895f,

},
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.39895618f,

0.14722943f,

0.6068295f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.2356081f,

0.94969225f,

0.29194266f,

0.8087504f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.58534855f,

0.7813259f,

0.89000255f,

0.35684013f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.69934136f,

0.77366614f,

0.66005385f,

},
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.16024458f,

0.22771847f,

0.45040095f,

0.35460263f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.013135612f,

0.2796415f,

0.11832452f,

0.63007385f,

},
},
            new SinglerealArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9595994f,

0.51679325f,

0.4679677f,

0.97664165f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.49432635f,

0.83097875f,

0.14173841f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.014968038f,

0.2856902f,

0.5939686f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.40028858f,

0.92749894f,

0.94670236f,

0.52246475f,

},
},
            new SinglerealArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.40962684f,

0.99133515f,

0.2985385f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.23120725f,

0.2829445f,

0.6120395f,

0.9126851f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.46003103f,

0.6481175f,

0.06801206f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.15975285f,

0.16441435f,

0.33003998f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.106898546f,

0.6917855f,

0.6092153f,

0.0061229467f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.16126943f,

0.60473007f,

0.12675428f,

0.5428733f,

},
},
            new SinglerealArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8542224f,

0.46070278f,

0.28677243f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.55776054f,

0.3178287f,

0.70031923f,

0.65831375f,

},
    ModelInner = new SinglerealArray2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.71785825f,

0.074712634f,

0.7818316f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6741561f,

0.4989233f,

0.120126605f,

0.6240701f,

},
},
    NullableValue = null,
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
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealArray2M)],
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
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
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
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((ISingleListrealArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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

                var models =  ((ISingleListrealArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealArray2M)],
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
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
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
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((ISingleListrealArray)this).DynQuerySelectModel(connection,  query, 0);
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
                var models =  ((ISingleListrealArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglerealArray2M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealarray2m m
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
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
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatSinglerealArray2M.AssertModel(models[0],_testData[3], false);FlatSinglerealArray2M.AssertModel(models[1],_testData[4], false);FlatSinglerealArray2M.AssertModel(models[2],_testData[5], false);FlatSinglerealArray2M.AssertModel(models[3],_testData[6], false);FlatSinglerealArray2M.AssertModel(models[4],_testData[7], false);FlatSinglerealArray2M.AssertModel(models[5],_testData[8], false);FlatSinglerealArray2M.AssertModel(models[6],_testData[9], false);FlatSinglerealArray2M.AssertModel(models[7],_testData[10], false);FlatSinglerealArray2M.AssertModel(models[8],_testData[11], false);FlatSinglerealArray2M.AssertModel(models[9],_testData[12], false);FlatSinglerealArray2M.AssertModel(models[10],_testData[13], false);FlatSinglerealArray2M.AssertModel(models[11],_testData[14], false);FlatSinglerealArray2M.AssertModel(models[12],_testData[15], false);FlatSinglerealArray2M.AssertModel(models[13],_testData[16], false);FlatSinglerealArray2M.AssertModel(models[14],_testData[17], false);FlatSinglerealArray2M.AssertModel(models[15],_testData[18], false);FlatSinglerealArray2M.AssertModel(models[16],_testData[19], false);FlatSinglerealArray2M.AssertModel(models[17],_testData[20], false);FlatSinglerealArray2M.AssertModel(models[18],_testData[21], false);FlatSinglerealArray2M.AssertModel(models[19],_testData[22], false);FlatSinglerealArray2M.AssertModel(models[20],_testData[23], false);FlatSinglerealArray2M.AssertModel(models[21],_testData[24], false);FlatSinglerealArray2M.AssertModel(models[22],_testData[25], false);FlatSinglerealArray2M.AssertModel(models[23],_testData[26], false);FlatSinglerealArray2M.AssertModel(models[24],_testData[27], false);FlatSinglerealArray2M.AssertModel(models[25],_testData[28], false);FlatSinglerealArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
FlatSinglerealArray2M.AssertModel(models[0],_testData[13], false);FlatSinglerealArray2M.AssertModel(models[1],_testData[14], false);FlatSinglerealArray2M.AssertModel(models[2],_testData[15], false);FlatSinglerealArray2M.AssertModel(models[3],_testData[16], false);FlatSinglerealArray2M.AssertModel(models[4],_testData[17], false);FlatSinglerealArray2M.AssertModel(models[5],_testData[18], false);FlatSinglerealArray2M.AssertModel(models[6],_testData[19], false);FlatSinglerealArray2M.AssertModel(models[7],_testData[20], false);FlatSinglerealArray2M.AssertModel(models[8],_testData[21], false);FlatSinglerealArray2M.AssertModel(models[9],_testData[22], false);FlatSinglerealArray2M.AssertModel(models[10],_testData[23], false);FlatSinglerealArray2M.AssertModel(models[11],_testData[24], false);FlatSinglerealArray2M.AssertModel(models[12],_testData[25], false);FlatSinglerealArray2M.AssertModel(models[13],_testData[26], false);FlatSinglerealArray2M.AssertModel(models[14],_testData[27], false);FlatSinglerealArray2M.AssertModel(models[15],_testData[28], false);FlatSinglerealArray2M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlerealarray2m m
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
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
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatSinglerealArray2M.AssertModel(models[0],_testData[15], false);FlatSinglerealArray2M.AssertModel(models[1],_testData[16], false);FlatSinglerealArray2M.AssertModel(models[2],_testData[17], false);FlatSinglerealArray2M.AssertModel(models[3],_testData[18], false);FlatSinglerealArray2M.AssertModel(models[4],_testData[19], false);FlatSinglerealArray2M.AssertModel(models[5],_testData[20], false);FlatSinglerealArray2M.AssertModel(models[6],_testData[21], false);FlatSinglerealArray2M.AssertModel(models[7],_testData[22], false);FlatSinglerealArray2M.AssertModel(models[8],_testData[23], false);FlatSinglerealArray2M.AssertModel(models[9],_testData[24], false);FlatSinglerealArray2M.AssertModel(models[10],_testData[25], false);FlatSinglerealArray2M.AssertModel(models[11],_testData[26], false);FlatSinglerealArray2M.AssertModel(models[12],_testData[27], false);FlatSinglerealArray2M.AssertModel(models[13],_testData[28], false);FlatSinglerealArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatSinglerealArray2M.AssertModel(models[0],_testData[3], false);FlatSinglerealArray2M.AssertModel(models[1],_testData[4], false);FlatSinglerealArray2M.AssertModel(models[2],_testData[5], false);FlatSinglerealArray2M.AssertModel(models[3],_testData[6], false);FlatSinglerealArray2M.AssertModel(models[4],_testData[7], false);FlatSinglerealArray2M.AssertModel(models[5],_testData[8], false);FlatSinglerealArray2M.AssertModel(models[6],_testData[9], false);FlatSinglerealArray2M.AssertModel(models[7],_testData[10], false);FlatSinglerealArray2M.AssertModel(models[8],_testData[11], false);FlatSinglerealArray2M.AssertModel(models[9],_testData[12], false);FlatSinglerealArray2M.AssertModel(models[10],_testData[13], false);FlatSinglerealArray2M.AssertModel(models[11],_testData[14], false);FlatSinglerealArray2M.AssertModel(models[12],_testData[15], false);FlatSinglerealArray2M.AssertModel(models[13],_testData[16], false);FlatSinglerealArray2M.AssertModel(models[14],_testData[17], false);FlatSinglerealArray2M.AssertModel(models[15],_testData[18], false);FlatSinglerealArray2M.AssertModel(models[16],_testData[19], false);FlatSinglerealArray2M.AssertModel(models[17],_testData[20], false);FlatSinglerealArray2M.AssertModel(models[18],_testData[21], false);FlatSinglerealArray2M.AssertModel(models[19],_testData[22], false);FlatSinglerealArray2M.AssertModel(models[20],_testData[23], false);FlatSinglerealArray2M.AssertModel(models[21],_testData[24], false);FlatSinglerealArray2M.AssertModel(models[22],_testData[25], false);FlatSinglerealArray2M.AssertModel(models[23],_testData[26], false);FlatSinglerealArray2M.AssertModel(models[24],_testData[27], false);FlatSinglerealArray2M.AssertModel(models[25],_testData[28], false);FlatSinglerealArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
            batchName: "DbConnectionSelectModelDynParBatch",
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
        private void DbConnectionSelectModelDynParBatchConfig()
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

                var models = await ((ISingleListrealArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
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
                parametr2.Value = 35;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((ISingleListrealArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
SinglerealArray2M.AssertModel(models[0],_testData[12], false);SinglerealArray2M.AssertModel(models[1],_testData[13], false);SinglerealArray2M.AssertModel(models[2],_testData[14], false);SinglerealArray2M.AssertModel(models[3],_testData[15], false);SinglerealArray2M.AssertModel(models[4],_testData[16], false);SinglerealArray2M.AssertModel(models[5],_testData[17], false);SinglerealArray2M.AssertModel(models[6],_testData[18], false);SinglerealArray2M.AssertModel(models[7],_testData[19], false);SinglerealArray2M.AssertModel(models[8],_testData[20], false);SinglerealArray2M.AssertModel(models[9],_testData[21], false);SinglerealArray2M.AssertModel(models[10],_testData[22], false);SinglerealArray2M.AssertModel(models[11],_testData[23], false);SinglerealArray2M.AssertModel(models[12],_testData[24], false);SinglerealArray2M.AssertModel(models[13],_testData[25], false);SinglerealArray2M.AssertModel(models[14],_testData[26], false);SinglerealArray2M.AssertModel(models[15],_testData[27], false);SinglerealArray2M.AssertModel(models[16],_testData[28], false);SinglerealArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
SinglerealArray2M.AssertModel(models[0],_testData[7], false);SinglerealArray2M.AssertModel(models[1],_testData[8], false);SinglerealArray2M.AssertModel(models[2],_testData[9], false);SinglerealArray2M.AssertModel(models[3],_testData[10], false);SinglerealArray2M.AssertModel(models[4],_testData[11], false);SinglerealArray2M.AssertModel(models[5],_testData[12], false);SinglerealArray2M.AssertModel(models[6],_testData[13], false);SinglerealArray2M.AssertModel(models[7],_testData[14], false);SinglerealArray2M.AssertModel(models[8],_testData[15], false);SinglerealArray2M.AssertModel(models[9],_testData[16], false);SinglerealArray2M.AssertModel(models[10],_testData[17], false);SinglerealArray2M.AssertModel(models[11],_testData[18], false);SinglerealArray2M.AssertModel(models[12],_testData[19], false);SinglerealArray2M.AssertModel(models[13],_testData[20], false);SinglerealArray2M.AssertModel(models[14],_testData[21], false);SinglerealArray2M.AssertModel(models[15],_testData[22], false);SinglerealArray2M.AssertModel(models[16],_testData[23], false);SinglerealArray2M.AssertModel(models[17],_testData[24], false);SinglerealArray2M.AssertModel(models[18],_testData[25], false);SinglerealArray2M.AssertModel(models[19],_testData[26], false);SinglerealArray2M.AssertModel(models[20],_testData[27], false);SinglerealArray2M.AssertModel(models[21],_testData[28], false);SinglerealArray2M.AssertModel(models[22],_testData[29], false);
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

                var models =  ((ISingleListrealArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((ISingleListrealArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
SinglerealArray2M.AssertModel(models[0],_testData[7], false);SinglerealArray2M.AssertModel(models[1],_testData[8], false);SinglerealArray2M.AssertModel(models[2],_testData[9], false);SinglerealArray2M.AssertModel(models[3],_testData[10], false);SinglerealArray2M.AssertModel(models[4],_testData[11], false);SinglerealArray2M.AssertModel(models[5],_testData[12], false);SinglerealArray2M.AssertModel(models[6],_testData[13], false);SinglerealArray2M.AssertModel(models[7],_testData[14], false);SinglerealArray2M.AssertModel(models[8],_testData[15], false);SinglerealArray2M.AssertModel(models[9],_testData[16], false);SinglerealArray2M.AssertModel(models[10],_testData[17], false);SinglerealArray2M.AssertModel(models[11],_testData[18], false);SinglerealArray2M.AssertModel(models[12],_testData[19], false);SinglerealArray2M.AssertModel(models[13],_testData[20], false);SinglerealArray2M.AssertModel(models[14],_testData[21], false);SinglerealArray2M.AssertModel(models[15],_testData[22], false);SinglerealArray2M.AssertModel(models[16],_testData[23], false);SinglerealArray2M.AssertModel(models[17],_testData[24], false);SinglerealArray2M.AssertModel(models[18],_testData[25], false);SinglerealArray2M.AssertModel(models[19],_testData[26], false);SinglerealArray2M.AssertModel(models[20],_testData[27], false);SinglerealArray2M.AssertModel(models[21],_testData[28], false);SinglerealArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
SinglerealArray2M.AssertModel(models[0],_testData[6], false);SinglerealArray2M.AssertModel(models[1],_testData[7], false);SinglerealArray2M.AssertModel(models[2],_testData[8], false);SinglerealArray2M.AssertModel(models[3],_testData[9], false);SinglerealArray2M.AssertModel(models[4],_testData[10], false);SinglerealArray2M.AssertModel(models[5],_testData[11], false);SinglerealArray2M.AssertModel(models[6],_testData[12], false);SinglerealArray2M.AssertModel(models[7],_testData[13], false);SinglerealArray2M.AssertModel(models[8],_testData[14], false);SinglerealArray2M.AssertModel(models[9],_testData[15], false);SinglerealArray2M.AssertModel(models[10],_testData[16], false);SinglerealArray2M.AssertModel(models[11],_testData[17], false);SinglerealArray2M.AssertModel(models[12],_testData[18], false);SinglerealArray2M.AssertModel(models[13],_testData[19], false);SinglerealArray2M.AssertModel(models[14],_testData[20], false);SinglerealArray2M.AssertModel(models[15],_testData[21], false);SinglerealArray2M.AssertModel(models[16],_testData[22], false);SinglerealArray2M.AssertModel(models[17],_testData[23], false);SinglerealArray2M.AssertModel(models[18],_testData[24], false);SinglerealArray2M.AssertModel(models[19],_testData[25], false);SinglerealArray2M.AssertModel(models[20],_testData[26], false);SinglerealArray2M.AssertModel(models[21],_testData[27], false);SinglerealArray2M.AssertModel(models[22],_testData[28], false);SinglerealArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglerealArray2M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
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
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 68, query1, 35, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatSinglerealArray2M.AssertModel(models[0],_testData[15], false);FlatSinglerealArray2M.AssertModel(models[1],_testData[16], false);FlatSinglerealArray2M.AssertModel(models[2],_testData[17], false);FlatSinglerealArray2M.AssertModel(models[3],_testData[18], false);FlatSinglerealArray2M.AssertModel(models[4],_testData[19], false);FlatSinglerealArray2M.AssertModel(models[5],_testData[20], false);FlatSinglerealArray2M.AssertModel(models[6],_testData[21], false);FlatSinglerealArray2M.AssertModel(models[7],_testData[22], false);FlatSinglerealArray2M.AssertModel(models[8],_testData[23], false);FlatSinglerealArray2M.AssertModel(models[9],_testData[24], false);FlatSinglerealArray2M.AssertModel(models[10],_testData[25], false);FlatSinglerealArray2M.AssertModel(models[11],_testData[26], false);FlatSinglerealArray2M.AssertModel(models[12],_testData[27], false);FlatSinglerealArray2M.AssertModel(models[13],_testData[28], false);FlatSinglerealArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatSinglerealArray2M.AssertModel(models[0],_testData[7], false);FlatSinglerealArray2M.AssertModel(models[1],_testData[8], false);FlatSinglerealArray2M.AssertModel(models[2],_testData[9], false);FlatSinglerealArray2M.AssertModel(models[3],_testData[10], false);FlatSinglerealArray2M.AssertModel(models[4],_testData[11], false);FlatSinglerealArray2M.AssertModel(models[5],_testData[12], false);FlatSinglerealArray2M.AssertModel(models[6],_testData[13], false);FlatSinglerealArray2M.AssertModel(models[7],_testData[14], false);FlatSinglerealArray2M.AssertModel(models[8],_testData[15], false);FlatSinglerealArray2M.AssertModel(models[9],_testData[16], false);FlatSinglerealArray2M.AssertModel(models[10],_testData[17], false);FlatSinglerealArray2M.AssertModel(models[11],_testData[18], false);FlatSinglerealArray2M.AssertModel(models[12],_testData[19], false);FlatSinglerealArray2M.AssertModel(models[13],_testData[20], false);FlatSinglerealArray2M.AssertModel(models[14],_testData[21], false);FlatSinglerealArray2M.AssertModel(models[15],_testData[22], false);FlatSinglerealArray2M.AssertModel(models[16],_testData[23], false);FlatSinglerealArray2M.AssertModel(models[17],_testData[24], false);FlatSinglerealArray2M.AssertModel(models[18],_testData[25], false);FlatSinglerealArray2M.AssertModel(models[19],_testData[26], false);FlatSinglerealArray2M.AssertModel(models[20],_testData[27], false);FlatSinglerealArray2M.AssertModel(models[21],_testData[28], false);FlatSinglerealArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((ISingleListrealArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglerealArray2M.AssertModel(models[i],_testData[i], false);
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
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
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
LEFT JOIN public.singlerealarray2mi mi ON mi.id = m.singlerealarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((ISingleListrealArray)this).DbConnectionDynQuerySelectModelBatch(connection, 128, query1, 98, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatSinglerealArray2M.AssertModel(models[0],_testData[25], false);FlatSinglerealArray2M.AssertModel(models[1],_testData[26], false);FlatSinglerealArray2M.AssertModel(models[2],_testData[27], false);FlatSinglerealArray2M.AssertModel(models[3],_testData[28], false);FlatSinglerealArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatSinglerealArray2M.AssertModel(models[0],_testData[20], false);FlatSinglerealArray2M.AssertModel(models[1],_testData[21], false);FlatSinglerealArray2M.AssertModel(models[2],_testData[22], false);FlatSinglerealArray2M.AssertModel(models[3],_testData[23], false);FlatSinglerealArray2M.AssertModel(models[4],_testData[24], false);FlatSinglerealArray2M.AssertModel(models[5],_testData[25], false);FlatSinglerealArray2M.AssertModel(models[6],_testData[26], false);FlatSinglerealArray2M.AssertModel(models[7],_testData[27], false);FlatSinglerealArray2M.AssertModel(models[8],_testData[28], false);FlatSinglerealArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleListrealArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleListrealArray)this).DbConnectionSelectModelBatchAsync(connection, 76, 26))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
SinglerealArray2M.AssertModel(models[0],_testData[16], false);SinglerealArray2M.AssertModel(models[1],_testData[17], false);SinglerealArray2M.AssertModel(models[2],_testData[18], false);SinglerealArray2M.AssertModel(models[3],_testData[19], false);SinglerealArray2M.AssertModel(models[4],_testData[20], false);SinglerealArray2M.AssertModel(models[5],_testData[21], false);SinglerealArray2M.AssertModel(models[6],_testData[22], false);SinglerealArray2M.AssertModel(models[7],_testData[23], false);SinglerealArray2M.AssertModel(models[8],_testData[24], false);SinglerealArray2M.AssertModel(models[9],_testData[25], false);SinglerealArray2M.AssertModel(models[10],_testData[26], false);SinglerealArray2M.AssertModel(models[11],_testData[27], false);SinglerealArray2M.AssertModel(models[12],_testData[28], false);SinglerealArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
SinglerealArray2M.AssertModel(models[0],_testData[5], false);SinglerealArray2M.AssertModel(models[1],_testData[6], false);SinglerealArray2M.AssertModel(models[2],_testData[7], false);SinglerealArray2M.AssertModel(models[3],_testData[8], false);SinglerealArray2M.AssertModel(models[4],_testData[9], false);SinglerealArray2M.AssertModel(models[5],_testData[10], false);SinglerealArray2M.AssertModel(models[6],_testData[11], false);SinglerealArray2M.AssertModel(models[7],_testData[12], false);SinglerealArray2M.AssertModel(models[8],_testData[13], false);SinglerealArray2M.AssertModel(models[9],_testData[14], false);SinglerealArray2M.AssertModel(models[10],_testData[15], false);SinglerealArray2M.AssertModel(models[11],_testData[16], false);SinglerealArray2M.AssertModel(models[12],_testData[17], false);SinglerealArray2M.AssertModel(models[13],_testData[18], false);SinglerealArray2M.AssertModel(models[14],_testData[19], false);SinglerealArray2M.AssertModel(models[15],_testData[20], false);SinglerealArray2M.AssertModel(models[16],_testData[21], false);SinglerealArray2M.AssertModel(models[17],_testData[22], false);SinglerealArray2M.AssertModel(models[18],_testData[23], false);SinglerealArray2M.AssertModel(models[19],_testData[24], false);SinglerealArray2M.AssertModel(models[20],_testData[25], false);SinglerealArray2M.AssertModel(models[21],_testData[26], false);SinglerealArray2M.AssertModel(models[22],_testData[27], false);SinglerealArray2M.AssertModel(models[23],_testData[28], false);SinglerealArray2M.AssertModel(models[24],_testData[29], false);
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
                var models =  ((ISingleListrealArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    SinglerealArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleListrealArray)this).DbConnectionSelectModelBatch(connection, 68, 56))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
SinglerealArray2M.AssertModel(models[0],_testData[15], false);SinglerealArray2M.AssertModel(models[1],_testData[16], false);SinglerealArray2M.AssertModel(models[2],_testData[17], false);SinglerealArray2M.AssertModel(models[3],_testData[18], false);SinglerealArray2M.AssertModel(models[4],_testData[19], false);SinglerealArray2M.AssertModel(models[5],_testData[20], false);SinglerealArray2M.AssertModel(models[6],_testData[21], false);SinglerealArray2M.AssertModel(models[7],_testData[22], false);SinglerealArray2M.AssertModel(models[8],_testData[23], false);SinglerealArray2M.AssertModel(models[9],_testData[24], false);SinglerealArray2M.AssertModel(models[10],_testData[25], false);SinglerealArray2M.AssertModel(models[11],_testData[26], false);SinglerealArray2M.AssertModel(models[12],_testData[27], false);SinglerealArray2M.AssertModel(models[13],_testData[28], false);SinglerealArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
SinglerealArray2M.AssertModel(models[0],_testData[13], false);SinglerealArray2M.AssertModel(models[1],_testData[14], false);SinglerealArray2M.AssertModel(models[2],_testData[15], false);SinglerealArray2M.AssertModel(models[3],_testData[16], false);SinglerealArray2M.AssertModel(models[4],_testData[17], false);SinglerealArray2M.AssertModel(models[5],_testData[18], false);SinglerealArray2M.AssertModel(models[6],_testData[19], false);SinglerealArray2M.AssertModel(models[7],_testData[20], false);SinglerealArray2M.AssertModel(models[8],_testData[21], false);SinglerealArray2M.AssertModel(models[9],_testData[22], false);SinglerealArray2M.AssertModel(models[10],_testData[23], false);SinglerealArray2M.AssertModel(models[11],_testData[24], false);SinglerealArray2M.AssertModel(models[12],_testData[25], false);SinglerealArray2M.AssertModel(models[13],_testData[26], false);SinglerealArray2M.AssertModel(models[14],_testData[27], false);SinglerealArray2M.AssertModel(models[15],_testData[28], false);SinglerealArray2M.AssertModel(models[16],_testData[29], false);
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
                ((ISingleListrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 93);
                var models = await ((ISingleListrealArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));
SinglerealArray2M.AssertModel(models[0],_testData[19], false);SinglerealArray2M.AssertModel(models[1],_testData[20], false);SinglerealArray2M.AssertModel(models[2],_testData[21], false);SinglerealArray2M.AssertModel(models[3],_testData[22], false);SinglerealArray2M.AssertModel(models[4],_testData[23], false);SinglerealArray2M.AssertModel(models[5],_testData[24], false);SinglerealArray2M.AssertModel(models[6],_testData[25], false);SinglerealArray2M.AssertModel(models[7],_testData[26], false);SinglerealArray2M.AssertModel(models[8],_testData[27], false);SinglerealArray2M.AssertModel(models[9],_testData[28], false);SinglerealArray2M.AssertModel(models[10],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleListrealArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleListrealArray)this).SetDbConnectionSelectModelParametrs(cmd, 4);
                var models =  ((ISingleListrealArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
SinglerealArray2M.AssertModel(models[0],_testData[1], false);SinglerealArray2M.AssertModel(models[1],_testData[2], false);SinglerealArray2M.AssertModel(models[2],_testData[3], false);SinglerealArray2M.AssertModel(models[3],_testData[4], false);SinglerealArray2M.AssertModel(models[4],_testData[5], false);SinglerealArray2M.AssertModel(models[5],_testData[6], false);SinglerealArray2M.AssertModel(models[6],_testData[7], false);SinglerealArray2M.AssertModel(models[7],_testData[8], false);SinglerealArray2M.AssertModel(models[8],_testData[9], false);SinglerealArray2M.AssertModel(models[9],_testData[10], false);SinglerealArray2M.AssertModel(models[10],_testData[11], false);SinglerealArray2M.AssertModel(models[11],_testData[12], false);SinglerealArray2M.AssertModel(models[12],_testData[13], false);SinglerealArray2M.AssertModel(models[13],_testData[14], false);SinglerealArray2M.AssertModel(models[14],_testData[15], false);SinglerealArray2M.AssertModel(models[15],_testData[16], false);SinglerealArray2M.AssertModel(models[16],_testData[17], false);SinglerealArray2M.AssertModel(models[17],_testData[18], false);SinglerealArray2M.AssertModel(models[18],_testData[19], false);SinglerealArray2M.AssertModel(models[19],_testData[20], false);SinglerealArray2M.AssertModel(models[20],_testData[21], false);SinglerealArray2M.AssertModel(models[21],_testData[22], false);SinglerealArray2M.AssertModel(models[22],_testData[23], false);SinglerealArray2M.AssertModel(models[23],_testData[24], false);SinglerealArray2M.AssertModel(models[24],_testData[25], false);SinglerealArray2M.AssertModel(models[25],_testData[26], false);SinglerealArray2M.AssertModel(models[26],_testData[27], false);SinglerealArray2M.AssertModel(models[27],_testData[28], false);SinglerealArray2M.AssertModel(models[28],_testData[29], false);
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

