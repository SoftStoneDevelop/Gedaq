

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
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.68436396f,

0.33231562f,

0.8098292f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6227491f,

0.9505678f,

0.48616278f,

0.7300078f,

},
    ModelInner = new SinglerealListD12MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.52740294f,

0.72757816f,

0.7530031f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.39716333f,

0.29999614f,

0.98560154f,

},
},
            new SinglerealListD1E2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.10513455f,

0.94229734f,

0.1376251f,

0.3260051f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.43729758f,

0.21098638f,

0.0011894107f,

},
    ModelInner = new SinglerealListD12MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.61824816f,

0.8399793f,

0.5558063f,

0.6345372f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.93641454f,

0.050638676f,

0.7985618f,

0.07283062f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.34237546f,

0.86262447f,

0.31836933f,

},
},
            new SinglerealListD1E2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.51526386f,

0.8134329f,

0.061185896f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.066446364f,

0.7607242f,

0.52771956f,

0.96328884f,

},
},
            new SinglerealListD1E2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.91081595f,

0.53405356f,

0.70920885f,

0.72328246f,

},
    ModelInner = new SinglerealListD12MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.86591595f,

0.8510658f,

0.24684566f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.46286035f,

0.80578196f,

0.25065166f,

},
},
            new SinglerealListD1E2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.31084806f,

0.6222451f,

0.24606293f,

0.82445806f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7433145f,

0.80338824f,

0.048341095f,

},
},
            new SinglerealListD1E2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.83040303f,

0.9407072f,

0.8602908f,

0.8779074f,

},
    ModelInner = new SinglerealListD12MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5007405f,

0.37754464f,

0.27277458f,

0.1704694f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.85055673f,

0.27820832f,

0.7211504f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.4202382f,

0.5571781f,

0.37693846f,

},
},
            new SinglerealListD1E2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.36301398f,

0.6996306f,

0.648001f,

0.41483384f,

},
    ModelInner = new SinglerealListD12MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.69552577f,

0.7402743f,

0.06538278f,

0.68680334f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.67785054f,

0.16740072f,

0.27056944f,

0.44050878f,

},
},
            new SinglerealListD1E2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.66463846f,

0.7238109f,

0.26725602f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.15270627f,

0.3978026f,

0.5233711f,

0.67934394f,

},
    ModelInner = new SinglerealListD12MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.49135816f,

0.13342363f,

0.50515354f,

0.2596261f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.89716065f,

0.031093717f,

0.9076616f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.06132096f,

0.2989686f,

0.45259404f,

},
},
            new SinglerealListD1E2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.62302727f,

0.19517052f,

0.16663247f,

},
    ModelInner = new SinglerealListD12MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.64142114f,

0.0639776f,

0.5677311f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.43326384f,

0.43923485f,

0.40414846f,

},
},
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.3165928f,

0.7134777f,

0.21295631f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.5712575f,

0.60113794f,

0.799026f,

},
},
            new SinglerealListD1E2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8631214f,

0.34738737f,

0.31964374f,

0.1833427f,

},
    ModelInner = new SinglerealListD12MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.63089114f,

0.108421326f,

0.50652575f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.88949686f,

0.7873338f,

0.3281504f,

0.80053395f,

},
},
            new SinglerealListD1E2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.2802738f,

0.19514471f,

0.5950163f,

0.8050139f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.5704158f,

0.75427264f,

0.5131398f,

},
},
            new SinglerealListD1E2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.93743676f,

0.45120364f,

0.5286713f,

},
    ModelInner = new SinglerealListD12MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.29501313f,

0.23340064f,

0.091646254f,

0.92876834f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.37607127f,

0.92234224f,

0.9864001f,

},
},
            new SinglerealListD1E2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.609522f,

0.45679235f,

0.25452566f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.1585244f,

0.20564455f,

0.3464743f,

0.42339927f,

},
    ModelInner = new SinglerealListD12MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6089194f,

0.22161448f,

0.7961358f,

0.52521545f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.14592052f,

0.62418705f,

0.83972794f,

0.83988535f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6792746f,

0.5298747f,

0.64817876f,

0.36764288f,

},
},
            new SinglerealListD1E2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.6812995f,

0.58236706f,

0.7113901f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.032288253f,

0.25536686f,

0.6350959f,

0.23519742f,

},
},
            new SinglerealListD1E2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.1956535f,

0.9118508f,

0.706718f,

0.7100246f,

},
    ModelInner = new SinglerealListD12MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.31598496f,

0.09251559f,

0.5856554f,

0.13384175f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.1744886f,

0.86265016f,

0.76363987f,

},
},
            new SinglerealListD1E2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.028188348f,

0.23100096f,

0.7186247f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.037065446f,

0.008977771f,

0.17112005f,

0.24236363f,

},
    ModelInner = new SinglerealListD12MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.10097462f,

0.4315074f,

0.6186734f,

0.76963395f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.022069156f,

0.068858325f,

0.8470005f,

},
},
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9279888f,

0.69766843f,

0.21787435f,

0.91466075f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6803022f,

0.9980742f,

0.43141735f,

0.518868f,

},
},
            new SinglerealListD1E2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.7494682f,

0.5982844f,

0.17117834f,

0.04998511f,

},
    ModelInner = new SinglerealListD12MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.72606415f,

0.4244733f,

0.36389744f,

0.5559987f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.96440053f,

0.42461252f,

0.580568f,

},
},
            new SinglerealListD1E2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.09979725f,

0.7028274f,

0.88434887f,

0.63012147f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.56375515f,

0.4936303f,

0.18321836f,

},
    ModelInner = new SinglerealListD12MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.37037897f,

0.6019033f,

0.7808351f,

0.61225176f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.42064703f,

0.49946558f,

0.731705f,

0.91778356f,

},
},
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.37926203f,

0.5518244f,

0.08380598f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.6275317f,

0.8024685f,

0.61170113f,

},
},
            new SinglerealListD1E2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.22498816f,

0.270158f,

0.30717647f,

0.3407541f,

},
    ModelInner = new SinglerealListD12MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.66371554f,

0.2305265f,

0.3450876f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6484846f,

0.8478766f,

0.40780598f,

0.05049503f,

},
},
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.58968663f,

0.88483495f,

0.93122065f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.22551495f,

0.8447384f,

0.6741045f,

0.4676208f,

},
},
            new SinglerealListD1E2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.19404417f,

0.95684814f,

0.3792436f,

},
    ModelInner = new SinglerealListD12MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.78117263f,

0.40999055f,

0.6602576f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.004979253f,

0.21581191f,

0.7188967f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.793033f,

0.97789407f,

0.618079f,

0.36342382f,

},
    ModelInner = new SinglerealListD12MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.4113437f,

0.6972082f,

0.39127237f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.9339946f,

0.015193701f,

0.7310512f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.878662f,

0.9769338f,

0.95634f,

0.22113484f,

},
},
            new SinglerealListD1E2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.50745803f,

0.37800068f,

0.07498586f,

0.77786607f,

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlereallistd12mi(
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
INSERT INTO public.singlereallistd12mi(
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
            queryMapTypes: [typeof(SinglerealListD12MI)],
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
    singlereallistd12mi_id
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
                methodParametrName: "singlereallistd12mi_id", 
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
    singlereallistd12mi_id
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
    singlereallistd12mi_id,
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
    singlereallistd12mi_id
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
    singlereallistd12mi_id,
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
                methodParametrName: "singlereallistd12mi_id", 
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
LEFT JOIN public.singlereallistd12mi mi ON mi.id = m.singlereallistd12mi_id
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
LEFT JOIN public.singlereallistd12mi mi ON mi.id = m.singlereallistd12mi_id
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[21],_testData[34], false);
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[32],_testData[34], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 2;
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatSinglerealListD1E2M.AssertModel(models[0],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(models[1],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(models[2],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(models[3],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(models[4],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatSinglerealListD1E2M.AssertModel(models[0],_testData[1], false);
                        FlatSinglerealListD1E2M.AssertModel(models[1],_testData[2], false);
                        FlatSinglerealListD1E2M.AssertModel(models[2],_testData[3], false);
                        FlatSinglerealListD1E2M.AssertModel(models[3],_testData[4], false);
                        FlatSinglerealListD1E2M.AssertModel(models[4],_testData[5], false);
                        FlatSinglerealListD1E2M.AssertModel(models[5],_testData[6], false);
                        FlatSinglerealListD1E2M.AssertModel(models[6],_testData[7], false);
                        FlatSinglerealListD1E2M.AssertModel(models[7],_testData[8], false);
                        FlatSinglerealListD1E2M.AssertModel(models[8],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(models[9],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(models[10],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(models[11],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(models[12],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(models[13],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(models[14],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(models[15],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(models[16],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(models[17],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(models[18],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(models[19],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(models[20],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(models[21],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(models[22],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(models[23],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(models[24],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(models[25],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(models[26],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(models[27],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(models[28],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(models[29],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(models[30],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(models[31],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(models[32],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 41;
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[20],_testData[34], false);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatSinglerealListD1E2M.AssertModel(models[0],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(models[1],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(models[2],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatSinglerealListD1E2M.AssertModel(models[0],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(models[1],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(models[2],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(models[3],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(models[4],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(models[5],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(models[6],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(models[7],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(models[8],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(models[9],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(models[10],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(models[11],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(models[12],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(models[13],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(models[14],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(models[15],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(models[16],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(models[17],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(models[18],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(models[19],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(models[20],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 2;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[33],_testData[34], false);
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
LEFT JOIN public.singlereallistd12mi mi ON mi.id = m.singlereallistd12mi_id
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleListrealListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        SinglerealListD1E2M.AssertModel(models[0],_testData[8], false);
                        SinglerealListD1E2M.AssertModel(models[1],_testData[9], false);
                        SinglerealListD1E2M.AssertModel(models[2],_testData[10], false);
                        SinglerealListD1E2M.AssertModel(models[3],_testData[11], false);
                        SinglerealListD1E2M.AssertModel(models[4],_testData[12], false);
                        SinglerealListD1E2M.AssertModel(models[5],_testData[13], false);
                        SinglerealListD1E2M.AssertModel(models[6],_testData[14], false);
                        SinglerealListD1E2M.AssertModel(models[7],_testData[15], false);
                        SinglerealListD1E2M.AssertModel(models[8],_testData[16], false);
                        SinglerealListD1E2M.AssertModel(models[9],_testData[17], false);
                        SinglerealListD1E2M.AssertModel(models[10],_testData[18], false);
                        SinglerealListD1E2M.AssertModel(models[11],_testData[19], false);
                        SinglerealListD1E2M.AssertModel(models[12],_testData[20], false);
                        SinglerealListD1E2M.AssertModel(models[13],_testData[21], false);
                        SinglerealListD1E2M.AssertModel(models[14],_testData[22], false);
                        SinglerealListD1E2M.AssertModel(models[15],_testData[23], false);
                        SinglerealListD1E2M.AssertModel(models[16],_testData[24], false);
                        SinglerealListD1E2M.AssertModel(models[17],_testData[25], false);
                        SinglerealListD1E2M.AssertModel(models[18],_testData[26], false);
                        SinglerealListD1E2M.AssertModel(models[19],_testData[27], false);
                        SinglerealListD1E2M.AssertModel(models[20],_testData[28], false);
                        SinglerealListD1E2M.AssertModel(models[21],_testData[29], false);
                        SinglerealListD1E2M.AssertModel(models[22],_testData[30], false);
                        SinglerealListD1E2M.AssertModel(models[23],_testData[31], false);
                        SinglerealListD1E2M.AssertModel(models[24],_testData[32], false);
                        SinglerealListD1E2M.AssertModel(models[25],_testData[33], false);
                        SinglerealListD1E2M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleListrealListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        SinglerealListD1E2M.AssertModel(models[0],_testData[16], false);
                        SinglerealListD1E2M.AssertModel(models[1],_testData[17], false);
                        SinglerealListD1E2M.AssertModel(models[2],_testData[18], false);
                        SinglerealListD1E2M.AssertModel(models[3],_testData[19], false);
                        SinglerealListD1E2M.AssertModel(models[4],_testData[20], false);
                        SinglerealListD1E2M.AssertModel(models[5],_testData[21], false);
                        SinglerealListD1E2M.AssertModel(models[6],_testData[22], false);
                        SinglerealListD1E2M.AssertModel(models[7],_testData[23], false);
                        SinglerealListD1E2M.AssertModel(models[8],_testData[24], false);
                        SinglerealListD1E2M.AssertModel(models[9],_testData[25], false);
                        SinglerealListD1E2M.AssertModel(models[10],_testData[26], false);
                        SinglerealListD1E2M.AssertModel(models[11],_testData[27], false);
                        SinglerealListD1E2M.AssertModel(models[12],_testData[28], false);
                        SinglerealListD1E2M.AssertModel(models[13],_testData[29], false);
                        SinglerealListD1E2M.AssertModel(models[14],_testData[30], false);
                        SinglerealListD1E2M.AssertModel(models[15],_testData[31], false);
                        SinglerealListD1E2M.AssertModel(models[16],_testData[32], false);
                        SinglerealListD1E2M.AssertModel(models[17],_testData[33], false);
                        SinglerealListD1E2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        SinglerealListD1E2M.AssertModel(models[0],_testData[20], false);
                        SinglerealListD1E2M.AssertModel(models[1],_testData[21], false);
                        SinglerealListD1E2M.AssertModel(models[2],_testData[22], false);
                        SinglerealListD1E2M.AssertModel(models[3],_testData[23], false);
                        SinglerealListD1E2M.AssertModel(models[4],_testData[24], false);
                        SinglerealListD1E2M.AssertModel(models[5],_testData[25], false);
                        SinglerealListD1E2M.AssertModel(models[6],_testData[26], false);
                        SinglerealListD1E2M.AssertModel(models[7],_testData[27], false);
                        SinglerealListD1E2M.AssertModel(models[8],_testData[28], false);
                        SinglerealListD1E2M.AssertModel(models[9],_testData[29], false);
                        SinglerealListD1E2M.AssertModel(models[10],_testData[30], false);
                        SinglerealListD1E2M.AssertModel(models[11],_testData[31], false);
                        SinglerealListD1E2M.AssertModel(models[12],_testData[32], false);
                        SinglerealListD1E2M.AssertModel(models[13],_testData[33], false);
                        SinglerealListD1E2M.AssertModel(models[14],_testData[34], false);
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
                await ((ISingleListrealListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 151, query1, 2, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[33],_testData[34], false);
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
                await ((ISingleListrealListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 99, query1, 28, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[26],_testData[34], false);
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
                 ((ISingleListrealListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 52, query1, 112, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[6],_testData[34], false);
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
                 ((ISingleListrealListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 22, query1, 142, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
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
                foreach(var batchResult in await ((ISingleListrealListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 56, query1, 2, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatSinglerealListD1E2M.AssertModel(models[0],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(models[1],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(models[2],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(models[3],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(models[4],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(models[5],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(models[6],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(models[7],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(models[8],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(models[9],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(models[10],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(models[11],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(models[12],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(models[13],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(models[14],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(models[15],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(models[16],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(models[17],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(models[18],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(models[19],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatSinglerealListD1E2M.AssertModel(models[0],_testData[1], false);
                        FlatSinglerealListD1E2M.AssertModel(models[1],_testData[2], false);
                        FlatSinglerealListD1E2M.AssertModel(models[2],_testData[3], false);
                        FlatSinglerealListD1E2M.AssertModel(models[3],_testData[4], false);
                        FlatSinglerealListD1E2M.AssertModel(models[4],_testData[5], false);
                        FlatSinglerealListD1E2M.AssertModel(models[5],_testData[6], false);
                        FlatSinglerealListD1E2M.AssertModel(models[6],_testData[7], false);
                        FlatSinglerealListD1E2M.AssertModel(models[7],_testData[8], false);
                        FlatSinglerealListD1E2M.AssertModel(models[8],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(models[9],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(models[10],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(models[11],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(models[12],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(models[13],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(models[14],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(models[15],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(models[16],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(models[17],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(models[18],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(models[19],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(models[20],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(models[21],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(models[22],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(models[23],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(models[24],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(models[25],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(models[26],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(models[27],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(models[28],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(models[29],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(models[30],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(models[31],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(models[32],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(models[33],_testData[34], false);
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
                await ((ISingleListrealListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 99, query1, 7, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[32],_testData[34], false);
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
                foreach(var batchResult in  ((ISingleListrealListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 109, query1, 142, query2))
                {
                    if(++resultIndex == 1)
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
                 ((ISingleListrealListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 36, query1, 103, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[25],_testData[34], false);
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
LEFT JOIN public.singlereallistd12mi mi ON mi.id = m.singlereallistd12mi_id
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
                foreach(var batchResult in await ((ISingleListrealListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 28, 85))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        SinglerealListD1E2M.AssertModel(models[0],_testData[8], false);
                        SinglerealListD1E2M.AssertModel(models[1],_testData[9], false);
                        SinglerealListD1E2M.AssertModel(models[2],_testData[10], false);
                        SinglerealListD1E2M.AssertModel(models[3],_testData[11], false);
                        SinglerealListD1E2M.AssertModel(models[4],_testData[12], false);
                        SinglerealListD1E2M.AssertModel(models[5],_testData[13], false);
                        SinglerealListD1E2M.AssertModel(models[6],_testData[14], false);
                        SinglerealListD1E2M.AssertModel(models[7],_testData[15], false);
                        SinglerealListD1E2M.AssertModel(models[8],_testData[16], false);
                        SinglerealListD1E2M.AssertModel(models[9],_testData[17], false);
                        SinglerealListD1E2M.AssertModel(models[10],_testData[18], false);
                        SinglerealListD1E2M.AssertModel(models[11],_testData[19], false);
                        SinglerealListD1E2M.AssertModel(models[12],_testData[20], false);
                        SinglerealListD1E2M.AssertModel(models[13],_testData[21], false);
                        SinglerealListD1E2M.AssertModel(models[14],_testData[22], false);
                        SinglerealListD1E2M.AssertModel(models[15],_testData[23], false);
                        SinglerealListD1E2M.AssertModel(models[16],_testData[24], false);
                        SinglerealListD1E2M.AssertModel(models[17],_testData[25], false);
                        SinglerealListD1E2M.AssertModel(models[18],_testData[26], false);
                        SinglerealListD1E2M.AssertModel(models[19],_testData[27], false);
                        SinglerealListD1E2M.AssertModel(models[20],_testData[28], false);
                        SinglerealListD1E2M.AssertModel(models[21],_testData[29], false);
                        SinglerealListD1E2M.AssertModel(models[22],_testData[30], false);
                        SinglerealListD1E2M.AssertModel(models[23],_testData[31], false);
                        SinglerealListD1E2M.AssertModel(models[24],_testData[32], false);
                        SinglerealListD1E2M.AssertModel(models[25],_testData[33], false);
                        SinglerealListD1E2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        SinglerealListD1E2M.AssertModel(models[0],_testData[20], false);
                        SinglerealListD1E2M.AssertModel(models[1],_testData[21], false);
                        SinglerealListD1E2M.AssertModel(models[2],_testData[22], false);
                        SinglerealListD1E2M.AssertModel(models[3],_testData[23], false);
                        SinglerealListD1E2M.AssertModel(models[4],_testData[24], false);
                        SinglerealListD1E2M.AssertModel(models[5],_testData[25], false);
                        SinglerealListD1E2M.AssertModel(models[6],_testData[26], false);
                        SinglerealListD1E2M.AssertModel(models[7],_testData[27], false);
                        SinglerealListD1E2M.AssertModel(models[8],_testData[28], false);
                        SinglerealListD1E2M.AssertModel(models[9],_testData[29], false);
                        SinglerealListD1E2M.AssertModel(models[10],_testData[30], false);
                        SinglerealListD1E2M.AssertModel(models[11],_testData[31], false);
                        SinglerealListD1E2M.AssertModel(models[12],_testData[32], false);
                        SinglerealListD1E2M.AssertModel(models[13],_testData[33], false);
                        SinglerealListD1E2M.AssertModel(models[14],_testData[34], false);
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
                foreach(var batchResult in  ((ISingleListrealListD1)this).DbConnectionSTSelectModelBatch(connection, 36, 92))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        SinglerealListD1E2M.AssertModel(models[0],_testData[9], false);
                        SinglerealListD1E2M.AssertModel(models[1],_testData[10], false);
                        SinglerealListD1E2M.AssertModel(models[2],_testData[11], false);
                        SinglerealListD1E2M.AssertModel(models[3],_testData[12], false);
                        SinglerealListD1E2M.AssertModel(models[4],_testData[13], false);
                        SinglerealListD1E2M.AssertModel(models[5],_testData[14], false);
                        SinglerealListD1E2M.AssertModel(models[6],_testData[15], false);
                        SinglerealListD1E2M.AssertModel(models[7],_testData[16], false);
                        SinglerealListD1E2M.AssertModel(models[8],_testData[17], false);
                        SinglerealListD1E2M.AssertModel(models[9],_testData[18], false);
                        SinglerealListD1E2M.AssertModel(models[10],_testData[19], false);
                        SinglerealListD1E2M.AssertModel(models[11],_testData[20], false);
                        SinglerealListD1E2M.AssertModel(models[12],_testData[21], false);
                        SinglerealListD1E2M.AssertModel(models[13],_testData[22], false);
                        SinglerealListD1E2M.AssertModel(models[14],_testData[23], false);
                        SinglerealListD1E2M.AssertModel(models[15],_testData[24], false);
                        SinglerealListD1E2M.AssertModel(models[16],_testData[25], false);
                        SinglerealListD1E2M.AssertModel(models[17],_testData[26], false);
                        SinglerealListD1E2M.AssertModel(models[18],_testData[27], false);
                        SinglerealListD1E2M.AssertModel(models[19],_testData[28], false);
                        SinglerealListD1E2M.AssertModel(models[20],_testData[29], false);
                        SinglerealListD1E2M.AssertModel(models[21],_testData[30], false);
                        SinglerealListD1E2M.AssertModel(models[22],_testData[31], false);
                        SinglerealListD1E2M.AssertModel(models[23],_testData[32], false);
                        SinglerealListD1E2M.AssertModel(models[24],_testData[33], false);
                        SinglerealListD1E2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        SinglerealListD1E2M.AssertModel(models[0],_testData[22], false);
                        SinglerealListD1E2M.AssertModel(models[1],_testData[23], false);
                        SinglerealListD1E2M.AssertModel(models[2],_testData[24], false);
                        SinglerealListD1E2M.AssertModel(models[3],_testData[25], false);
                        SinglerealListD1E2M.AssertModel(models[4],_testData[26], false);
                        SinglerealListD1E2M.AssertModel(models[5],_testData[27], false);
                        SinglerealListD1E2M.AssertModel(models[6],_testData[28], false);
                        SinglerealListD1E2M.AssertModel(models[7],_testData[29], false);
                        SinglerealListD1E2M.AssertModel(models[8],_testData[30], false);
                        SinglerealListD1E2M.AssertModel(models[9],_testData[31], false);
                        SinglerealListD1E2M.AssertModel(models[10],_testData[32], false);
                        SinglerealListD1E2M.AssertModel(models[11],_testData[33], false);
                        SinglerealListD1E2M.AssertModel(models[12],_testData[34], false);
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
                ((ISingleListrealListD1)this).SetDbConnectionSelectModelParametrs(cmd, 121);
                var models = await ((ISingleListrealListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(6));

                SinglerealListD1E2M.AssertModel(models[0],_testData[29], false);
                SinglerealListD1E2M.AssertModel(models[1],_testData[30], false);
                SinglerealListD1E2M.AssertModel(models[2],_testData[31], false);
                SinglerealListD1E2M.AssertModel(models[3],_testData[32], false);
                SinglerealListD1E2M.AssertModel(models[4],_testData[33], false);
                SinglerealListD1E2M.AssertModel(models[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleListrealListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleListrealListD1)this).SetDbConnectionSelectModelParametrs(cmd, 52);
                var models =  ((ISingleListrealListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

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
FROM public.binary_singlereallistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(SinglerealListD12MIWA)],
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
            queryMapType: typeof(SinglerealListD12MIWA),
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
                var importCollection = new List<SinglerealListD12MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISingleListrealListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_singlereallistd12mi
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
                    SinglerealListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealListD12MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISingleListrealListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_singlereallistd12mi
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
                    SinglerealListD12MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_singlereallistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(SinglerealListD12MIWA)],
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
            queryMapType: typeof(SinglerealListD12MIWA),
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
                var importCollection = new List<SinglerealListD12MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ISingleListrealListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_singlereallistd12mi
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
                    SinglerealListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealListD12MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ISingleListrealListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_singlereallistd12mi
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
                    SinglerealListD12MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_singlereallistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(SinglerealListD12MI)],
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
COPY public.binary_singlereallistd12mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(SinglerealListD12MI),
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
                var importCollection = new List<SinglerealListD12MI>(2);
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
                    SinglerealListD12MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealListD12MI>(2);
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
                    SinglerealListD12MI.AssertModel(actual, expect, false);
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
FROM public.binary_singlereallistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(SinglerealListD12MIWA)],
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
COPY public.binary_singlereallistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(SinglerealListD12MIWA),
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
                var importCollection = new List<SinglerealListD12MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealListD12MIWA
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
                    SinglerealListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<SinglerealListD12MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new SinglerealListD12MIWA
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
                    SinglerealListD12MIWA.AssertModel(actual, expect, false);
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
singlereallistd12mi_id,
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
LEFT JOIN public.binary_singlereallistd12mi mi ON mi.id = m.singlereallistd12mi_id
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
    singlereallistd12mi_id,
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
            queryMapTypes: [typeof(SinglerealListD12MIWA), typeof(SinglerealListD12MIWA)],
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
                var models1 = new List<SinglerealListD12MIWA>();
                var models2 = new List<SinglerealListD12MIWA>();
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
    FROM public.binary_singlereallistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealListD12MIWA>();
                var models2 = new List<SinglerealListD12MIWA>();
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
    FROM public.binary_singlereallistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(SinglerealListD12MIWA)],
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
COPY public.binary_singlereallistd12mi
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
                    SinglerealListD12MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_singlereallistd12mi
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
                    SinglerealListD12MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(SinglerealListD12MIWA), typeof(SinglerealListD12MIWA)],
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
                var models1 = new List<SinglerealListD12MIWA>();
                var models2 = new List<SinglerealListD12MIWA>();
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
    FROM public.binary_singlereallistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealListD12MIWA>();
                var models2 = new List<SinglerealListD12MIWA>();
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
    FROM public.binary_singlereallistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(SinglerealListD12MIWA)],
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
COPY public.binary_singlereallistd12mi
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
                    SinglerealListD12MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_singlereallistd12mi
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
                    SinglerealListD12MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_singlereallistd12mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(SinglerealListD12MI), typeof(SinglerealListD12MI)],
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
                var models1 = new List<SinglerealListD12MI>();
                var models2 = new List<SinglerealListD12MI>();
                await ((ISingleListrealListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealListD12MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealListD12MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealListD12MI>();
                var models2 = new List<SinglerealListD12MI>();
                ((ISingleListrealListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealListD12MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealListD12MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlereallistd12mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(SinglerealListD12MI)],
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
                    SinglerealListD12MI.AssertModel(model, expectedModel, false);
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
                    SinglerealListD12MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_singlereallistd12mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(SinglerealListD12MIWA), typeof(SinglerealListD12MIWA)],
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
                var models1 = new List<SinglerealListD12MIWA>();
                var models2 = new List<SinglerealListD12MIWA>();
                await ((ISingleListrealListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<SinglerealListD12MIWA>();
                var models2 = new List<SinglerealListD12MIWA>();
                ((ISingleListrealListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    SinglerealListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    SinglerealListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlereallistd12mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(SinglerealListD12MIWA)],
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
                    SinglerealListD12MIWA.AssertModel(model, expectedModel, false);
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
                    SinglerealListD12MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

