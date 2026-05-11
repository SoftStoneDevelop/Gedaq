

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
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8523078f,

0.6008245f,

0.5607302f,

0.6333947f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.8145354f,

0.8644016f,

0.7346943f,

0.041579485f,

},
},
            new SinglerealListD1E2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.41732216f,

0.53489304f,

0.6200374f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.030322373f,

0.21478146f,

0.73305565f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.828827f,

0.79491127f,

0.11809969f,

},
},
            new SinglerealListD1E2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.12318373f,

0.09918833f,

0.86897594f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.5614287f,

0.12841016f,

0.88666195f,

0.68490136f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.41589373f,

0.7623651f,

0.88284814f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.53827703f,

0.6102859f,

0.37539142f,

0.18798703f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.41160327f,

0.8938788f,

0.29625142f,

0.44022703f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.49424917f,

0.21442163f,

0.23162585f,

0.7058034f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.15326965f,

0.12887537f,

0.3962348f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.113591254f,

0.20163667f,

0.5248978f,

},
},
            new SinglerealListD1E2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9823916f,

0.07500517f,

0.54600304f,

0.3218013f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.1783427f,

0.38615948f,

0.16392839f,

0.5189389f,

},
},
            new SinglerealListD1E2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.13322753f,

0.4217645f,

0.46073896f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7314708f,

0.008208692f,

0.2700746f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.124803185f,

0.4150172f,

0.451429f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.19146734f,

0.80458444f,

0.021989167f,

0.30600846f,

},
},
            new SinglerealListD1E2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.9732683f,

0.21729529f,

0.5016881f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.2498008f,

0.1862939f,

0.6043729f,

},
},
            new SinglerealListD1E2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.61061615f,

0.4411065f,

0.62100774f,

0.8337775f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.48056674f,

0.5936899f,

0.54377663f,

0.44744635f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7449155f,

0.9832867f,

0.1351062f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8613182f,

0.4861248f,

0.31625295f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9735082f,

0.09671897f,

0.41903389f,

0.09981382f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.16263986f,

0.07941753f,

0.3066643f,

0.20978284f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.36718756f,

0.3382669f,

0.8184388f,

},
},
            new SinglerealListD1E2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.99551827f,

0.8080924f,

0.36723918f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.7010906f,

0.93222374f,

0.41148335f,

},
},
            new SinglerealListD1E2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9368342f,

0.7115333f,

0.3243397f,

0.3675046f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.03612584f,

0.6211535f,

0.44349676f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.9027702f,

0.080191016f,

0.7860661f,

},
},
            new SinglerealListD1E2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.7856587f,

0.87358254f,

0.22811776f,

0.7131243f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.71078855f,

0.8627906f,

0.17235118f,

0.2827304f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.16851169f,

0.46569425f,

0.75205743f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.46761894f,

0.8968456f,

0.5155797f,

0.27547216f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9062414f,

0.32147706f,

0.16754395f,

0.26762843f,

},
},
            new SinglerealListD1E2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.9570619f,

0.61716366f,

0.10391319f,

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
0.37089688f,

0.9394904f,

0.49575776f,

0.25535727f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.64173317f,

0.45455217f,

0.12656796f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.22833198f,

0.09318948f,

0.24265951f,

},
},
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.33323115f,

0.44588512f,

0.17980206f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.93277556f,

0.5986743f,

0.3235607f,

0.73940015f,

},
},
            new SinglerealListD1E2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.91060215f,

0.37859517f,

0.01082617f,

0.5229876f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.69478256f,

0.7214732f,

0.03522861f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.9569175f,

0.5403069f,

0.3412509f,

0.8698452f,

},
},
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.0317744f,

0.9073924f,

0.98202217f,

0.8834438f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.77207905f,

0.26024818f,

0.5017163f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.07005614f,

0.33695388f,

0.9293954f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.82809854f,

0.93783915f,

0.19924778f,

0.34142298f,

},
},
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.036993742f,

0.9422355f,

0.36477315f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.24550861f,

0.33143395f,

0.8444134f,

0.069634974f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6328576f,

0.23295134f,

0.050394237f,

0.6873418f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.57276857f,

0.7803016f,

0.44306064f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.11387664f,

0.08843762f,

0.22598046f,

0.34943378f,

},
},
            new SinglerealListD1E2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.8131037f,

0.99644446f,

0.09398115f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.6989456f,

0.90155447f,

0.16623402f,

},
},
            new SinglerealListD1E2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.062657535f,

0.7453645f,

0.061573267f,

0.68538564f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.9097675f,

0.5628438f,

0.961928f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.7381334f,

0.37617266f,

0.75842625f,

0.54865044f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.40510142f,

0.37580317f,

0.5276386f,

0.36499614f,

},
},
            new SinglerealListD1E2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.49577862f,

0.016421676f,

0.8556148f,

0.9866927f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.22101492f,

0.08144134f,

0.7730199f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.16712064f,

0.2944787f,

0.18689221f,

0.42685318f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.6355554f,

0.4840188f,

0.54255056f,

},
},
            new SinglerealListD1E2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6916913f,

0.19405437f,

0.4086312f,

0.7656123f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.44615227f,

0.16809028f,

0.69142735f,

},
},
            new SinglerealListD1E2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.57316566f,

0.19383156f,

0.8677894f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.7707061f,

0.009606242f,

0.9402682f,

0.55728847f,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.85908204f,

0.7836909f,

0.0825544f,

},
    ModelInner = null,
    NullableValue = null,
},
            new SinglerealListD1E2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.017590702f,

0.5869763f,

0.35804105f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.6296468f,

0.43954092f,

0.035687804f,

0.3796283f,

},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.25215995f,

0.58925587f,

0.4227633f,

0.28078258f,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.38326252f,

0.86473894f,

0.5906963f,

0.6511475f,

},
},
            new SinglerealListD1E2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.49337417f,

0.40310913f,

0.074965894f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.042735636f,

0.53065753f,

0.48697305f,

},
},
            new SinglerealListD1E2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.033206165f,

0.21413076f,

0.47736418f,

0.15295815f,

},
    ModelInner = new SinglerealListD1E2MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Single>(4)
{
0.84040326f,

0.12575257f,

0.53033525f,

0.3230595f,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Single>(3)
{
0.18191719f,

0.19830537f,

0.79113847f,

},
},
            new SinglerealListD1E2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<System.Single>(3)
{
0.089300394f,

0.61056244f,

0.14809966f,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Single>(4)
{
0.24643505f,

0.8619112f,

0.25515658f,

0.29425144f,

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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
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
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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

                    if(resultIndex == 2)
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
                parametr1.Value = 156;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatSinglerealListD1E2M.AssertModel(models[0],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(models[1],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(models[2],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(models[3],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(models[4],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(models[5],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(models[6],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(models[7],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(models[8],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[5],_testData[34], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleListrealListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleListrealListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        SinglerealListD1E2M.AssertModel(models[0],_testData[27], false);
                        SinglerealListD1E2M.AssertModel(models[1],_testData[28], false);
                        SinglerealListD1E2M.AssertModel(models[2],_testData[29], false);
                        SinglerealListD1E2M.AssertModel(models[3],_testData[30], false);
                        SinglerealListD1E2M.AssertModel(models[4],_testData[31], false);
                        SinglerealListD1E2M.AssertModel(models[5],_testData[32], false);
                        SinglerealListD1E2M.AssertModel(models[6],_testData[33], false);
                        SinglerealListD1E2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        SinglerealListD1E2M.AssertModel(models[0],_testData[19], false);
                        SinglerealListD1E2M.AssertModel(models[1],_testData[20], false);
                        SinglerealListD1E2M.AssertModel(models[2],_testData[21], false);
                        SinglerealListD1E2M.AssertModel(models[3],_testData[22], false);
                        SinglerealListD1E2M.AssertModel(models[4],_testData[23], false);
                        SinglerealListD1E2M.AssertModel(models[5],_testData[24], false);
                        SinglerealListD1E2M.AssertModel(models[6],_testData[25], false);
                        SinglerealListD1E2M.AssertModel(models[7],_testData[26], false);
                        SinglerealListD1E2M.AssertModel(models[8],_testData[27], false);
                        SinglerealListD1E2M.AssertModel(models[9],_testData[28], false);
                        SinglerealListD1E2M.AssertModel(models[10],_testData[29], false);
                        SinglerealListD1E2M.AssertModel(models[11],_testData[30], false);
                        SinglerealListD1E2M.AssertModel(models[12],_testData[31], false);
                        SinglerealListD1E2M.AssertModel(models[13],_testData[32], false);
                        SinglerealListD1E2M.AssertModel(models[14],_testData[33], false);
                        SinglerealListD1E2M.AssertModel(models[15],_testData[34], false);
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
                await ((ISingleListrealListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 87, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[25],_testData[34], false);
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
                await ((ISingleListrealListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 53, query1, 138, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
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
                 ((ISingleListrealListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 158, query1, 53, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[24],_testData[34], false);
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
                 ((ISingleListrealListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 158, query1, 109, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems2[1],_testData[34], false);
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
                foreach(var batchResult in await ((ISingleListrealListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 125, query1, 21, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatSinglerealListD1E2M.AssertModel(models[0],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(models[1],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(models[2],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(models[3],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(models[4],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(models[5],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(models[6],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(models[7],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(models[8],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(models[9],_testData[34], false);
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
                await ((ISingleListrealListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 31, query1, 47, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[25],_testData[34], false);
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
                foreach(var batchResult in  ((ISingleListrealListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 46, query1, 121, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatSinglerealListD1E2M.AssertModel(models[0],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(models[1],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(models[2],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(models[3],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(models[4],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(models[5],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(models[6],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(models[7],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(models[8],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(models[9],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(models[10],_testData[34], false);
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
                 ((ISingleListrealListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 31, query1, 81, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatSinglerealListD1E2M.AssertModel(secondItems2[19],_testData[34], false);
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
                foreach(var batchResult in await ((ISingleListrealListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 138, 138))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        SinglerealListD1E2M.AssertModel(models[0],_testData[28], false);
                        SinglerealListD1E2M.AssertModel(models[1],_testData[29], false);
                        SinglerealListD1E2M.AssertModel(models[2],_testData[30], false);
                        SinglerealListD1E2M.AssertModel(models[3],_testData[31], false);
                        SinglerealListD1E2M.AssertModel(models[4],_testData[32], false);
                        SinglerealListD1E2M.AssertModel(models[5],_testData[33], false);
                        SinglerealListD1E2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        SinglerealListD1E2M.AssertModel(models[0],_testData[28], false);
                        SinglerealListD1E2M.AssertModel(models[1],_testData[29], false);
                        SinglerealListD1E2M.AssertModel(models[2],_testData[30], false);
                        SinglerealListD1E2M.AssertModel(models[3],_testData[31], false);
                        SinglerealListD1E2M.AssertModel(models[4],_testData[32], false);
                        SinglerealListD1E2M.AssertModel(models[5],_testData[33], false);
                        SinglerealListD1E2M.AssertModel(models[6],_testData[34], false);
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
                foreach(var batchResult in  ((ISingleListrealListD1)this).DbConnectionSTSelectModelBatch(connection, 108, 156))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        SinglerealListD1E2M.AssertModel(models[0],_testData[19], false);
                        SinglerealListD1E2M.AssertModel(models[1],_testData[20], false);
                        SinglerealListD1E2M.AssertModel(models[2],_testData[21], false);
                        SinglerealListD1E2M.AssertModel(models[3],_testData[22], false);
                        SinglerealListD1E2M.AssertModel(models[4],_testData[23], false);
                        SinglerealListD1E2M.AssertModel(models[5],_testData[24], false);
                        SinglerealListD1E2M.AssertModel(models[6],_testData[25], false);
                        SinglerealListD1E2M.AssertModel(models[7],_testData[26], false);
                        SinglerealListD1E2M.AssertModel(models[8],_testData[27], false);
                        SinglerealListD1E2M.AssertModel(models[9],_testData[28], false);
                        SinglerealListD1E2M.AssertModel(models[10],_testData[29], false);
                        SinglerealListD1E2M.AssertModel(models[11],_testData[30], false);
                        SinglerealListD1E2M.AssertModel(models[12],_testData[31], false);
                        SinglerealListD1E2M.AssertModel(models[13],_testData[32], false);
                        SinglerealListD1E2M.AssertModel(models[14],_testData[33], false);
                        SinglerealListD1E2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        SinglerealListD1E2M.AssertModel(models[0],_testData[32], false);
                        SinglerealListD1E2M.AssertModel(models[1],_testData[33], false);
                        SinglerealListD1E2M.AssertModel(models[2],_testData[34], false);
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
                ((ISingleListrealListD1)this).SetDbConnectionSelectModelParametrs(cmd, 133);
                var models = await ((ISingleListrealListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleListrealListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleListrealListD1)this).SetDbConnectionSelectModelParametrs(cmd, 96);
                var models =  ((ISingleListrealListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

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

