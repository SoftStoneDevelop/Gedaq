

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
    internal partial interface INpgsqlPointSingleTypepoint
    {
    }
    
    internal partial class NpgsqlPointSingleTypepoint : INpgsqlPointSingleTypepoint
    {


#region TestData

        private readonly NpgsqlPointpoint0M[] _testData = new NpgsqlPointpoint0M[]
        {
            new NpgsqlPointpoint0M
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.522333828679786d, y: 0.7891408717746823d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5680839390614815d, y: 0.45387747649287935d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5870916923777191d, y: 0.3399267337263453d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.4240617788256851d, y: 0.5679899992735339d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8486493794040415d, y: 0.4617957920928931d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.0839969782570783d, y: 0.2591493411919267d),
},
            new NpgsqlPointpoint0M
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.04767221052843762d, y: 0.21433639705043328d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.2938049051381503d, y: 0.9012175300674404d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6651025930117141d, y: 0.7052653357143285d),
},
            new NpgsqlPointpoint0M
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.39750814852945926d, y: 0.007359777145333868d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.579390540607864d, y: 0.13182348020405865d),
},
            new NpgsqlPointpoint0M
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9259641152463088d, y: 0.7347216553078851d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.17280342932970638d, y: 0.6388281113850816d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9508390506125151d, y: 0.7074336745088823d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3476402646627412d, y: 0.07106312848896312d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.2019304587186732d, y: 0.7954759440828046d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.30138685099024853d, y: 0.9604127165261807d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4064949349921765d, y: 0.059057509304311306d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4461422130920718d, y: 0.5246779333524296d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.772183896727397d, y: 0.6311974585113467d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.9326865072680839d, y: 0.5422102140977909d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.626348461478757d, y: 0.8150353926690947d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6061335610803851d, y: 0.15790090646190558d),
},
            new NpgsqlPointpoint0M
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8255650088854961d, y: 0.6654412981709237d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.45836235270229797d, y: 0.5208964702159143d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.29191345950665526d, y: 0.12558218613042427d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.5825851725672004d, y: 0.0762783602697169d),
},
            new NpgsqlPointpoint0M
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.26432582223276535d, y: 0.5733079382790428d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7907013086969136d, y: 0.3089568071994747d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7189120058623751d, y: 0.1445681335970992d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.06684206570193019d, y: 0.2748300862399172d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8505997916298377d, y: 0.5433934491438257d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5241170831732016d, y: 0.6141516689826978d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.29043944216024686d, y: 0.3797294328237285d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6960281365376063d, y: 0.2760739990858613d),
},
            new NpgsqlPointpoint0M
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8036381754082952d, y: 0.39476655676046046d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.16674265301791225d, y: 0.49878933676110027d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7458269231850446d, y: 0.6848903044115371d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.03506036230146936d, y: 0.4372660816384073d),
},
            new NpgsqlPointpoint0M
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.49806842254809325d, y: 0.24364059623024092d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5894286753980938d, y: 0.7679216477018196d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.1705166132944269d, y: 0.21347685107286318d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.9380556211437343d, y: 0.9395613621371512d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.00905869443203533d, y: 0.14359029995766304d),
},
            new NpgsqlPointpoint0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8363312369810805d, y: 0.3506368656115256d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 94,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.047450917794743086d, y: 0.499034044568187d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.085669355139123d, y: 0.19150564996289265d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.17479413825455548d, y: 0.1314043065961078d),
},
            new NpgsqlPointpoint0M
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.06381031200805465d, y: 0.5035557208435321d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.10819752117171899d, y: 0.7908361625975506d),
},
            new NpgsqlPointpoint0M
{
    Id = 101,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7510108031290874d, y: 0.8708307167391482d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4662818304886368d, y: 0.2800161380345014d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 109,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6785313978527966d, y: 0.3667694831034628d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.2140372193002802d, y: 0.5477988909298471d),
},
            new NpgsqlPointpoint0M
{
    Id = 117,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5025568316654039d, y: 0.21694824366880638d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.2066578282547732d, y: 0.8445388607008647d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.8505199438080783d, y: 0.11526367081167121d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6136878185270669d, y: 0.8120022625100334d),
},
            new NpgsqlPointpoint0M
{
    Id = 119,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.09907276267190868d, y: 0.3290397292669013d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7276508232953768d, y: 0.8191314293605343d),
},
            new NpgsqlPointpoint0M
{
    Id = 126,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.28216748839108263d, y: 0.39588551343418266d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3453500678582485d, y: 0.6099455165802395d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 130,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3194724353728765d, y: 0.40207139669823d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 135,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.937266706412382d, y: 0.16080682300799132d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 88,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7182977955454177d, y: 0.42632002521678924d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.18441986768674723d, y: 0.6722551386787134d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 139,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8947448335468836d, y: 0.15426691433480166d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 148,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.02838233412892599d, y: 0.914814322737449d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8130799733358798d, y: 0.42105469428357134d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.11721094669454657d, y: 0.42772637851061224d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.8173381889689378d, y: 0.4805527441890831d),
},
            new NpgsqlPointpoint0M
{
    Id = 150,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.457452201179251d, y: 0.7879025308998386d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 156,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7795303245093574d, y: 0.18246068856272202d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 103,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.721864688337097d, y: 0.13631656215505228d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.5386020258848861d, y: 0.6559279750071285d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 164,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.73105647485323d, y: 0.2631893900202028d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.4002095319413531d, y: 0.2628356987297983d),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0mi(
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(15)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(15))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0mi(
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
            queryMapTypes: [typeof(NpgsqlPointpoint0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(15)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(15))]
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

                changedRows =  ((INpgsqlPointSingleTypepoint)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointSingleTypepoint)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointSingleTypepoint)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointSingleTypepoint)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointSingleTypepoint)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointSingleTypepoint)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointSingleTypepoint)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id,
    @value, 
    @nullablevalue
)
",
            methodName:"DbConnectionInsertInnerModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13), 
                nullable: true)]
        public void DbConnectionInsertInnerModelConfig()
        {
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0m(
	id,
    value,
    nullablevalue,
    npgsqlpointpoint0mi_id
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(15)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(15)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpoint0mi_id", 
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
                changedRows =  ((INpgsqlPointSingleTypepoint)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointSingleTypepoint)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointSingleTypepoint)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointSingleTypepoint)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0m(
	id,
    value,
    nullablevalue,
    npgsqlpointpoint0mi_id
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
    npgsqlpointpoint0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpoint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
                NpgsqlTypes.NpgsqlPoint? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(15);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(15);
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

                    nullable =  ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.579390540607864d, y: 0.13182348020405865d)));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(15);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(15);
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

                    nullable =  ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPoint? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(15);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(15);
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

                    nullable = await ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(15);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(15);
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

                    nullable = await ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0m(
	id,
    value,
    nullablevalue,
    npgsqlpointpoint0mi_id
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
    npgsqlpointpoint0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpoint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(15)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(15)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpoint0mi_id", 
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
                NpgsqlTypes.NpgsqlPoint? nullable = null;
                nullable =  ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint? nullable = null;
                nullable = await ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6061335610803851d, y: 0.15790090646190558d)));
                nullable = await ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpoint0M> models = null;

                models =  ((INpgsqlPointSingleTypepoint)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpoint0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPointSingleTypepoint)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpoint0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPointSingleTypepoint)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpoint0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPointSingleTypepoint)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpoint0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpoint0M> models = null;

                models = await ((INpgsqlPointSingleTypepoint)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpoint0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointSingleTypepoint)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpoint0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointSingleTypepoint)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpoint0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointSingleTypepoint)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpoint0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpoint0m(
	id,
    value,
    nullablevalue,
    npgsqlpointpoint0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpointpoint0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlPoint), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlpointpoint0mi_id", 
                methodParametrName: "npgsqlpointpoint0mi_id", 
                dbType: (System.Data.DbType)(11),
                nullable: true)]
        public void DbConnectionInsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointSingleTypepoint)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M), typeof(FlatNpgsqlPointpoint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
FROM public.npgsqlpointpoint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpoint0M>();
                var models2 = new List<FlatNpgsqlPointpoint0M>();
                await ((INpgsqlPointSingleTypepoint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpoint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpoint0M>();
                var models2 = new List<FlatNpgsqlPointpoint0M>();
                ((INpgsqlPointSingleTypepoint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpoint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
FROM public.npgsqlpointpoint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointSingleTypepoint)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointSingleTypepoint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpoint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
                var models = await ((INpgsqlPointSingleTypepoint)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointSingleTypepoint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M), typeof(FlatNpgsqlPointpoint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
FROM public.npgsqlpointpoint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpoint0M>();
                var models2 = new List<FlatNpgsqlPointpoint0M>();
                await ((INpgsqlPointSingleTypepoint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpoint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpoint0M>();
                var models2 = new List<FlatNpgsqlPointpoint0M>();
                ((INpgsqlPointSingleTypepoint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpoint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
FROM public.npgsqlpointpoint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointSingleTypepoint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointSingleTypepoint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpoint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
                var models = await ((INpgsqlPointSingleTypepoint)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointSingleTypepoint)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M), typeof(FlatNpgsqlPointpoint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpoint0M>();
                var models2 = new List<FlatNpgsqlPointpoint0M>();
                await((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpoint0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var firstItems2 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems2 = new List<FlatNpgsqlPointpoint0M>();
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var firstItems2 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpoint0M>();
                var models2 = new List<FlatNpgsqlPointpoint0M>();
                ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpoint0M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 139;
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var firstItems2 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems2 = new List<FlatNpgsqlPointpoint0M>();
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var firstItems2 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[33],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems2 = new List<FlatNpgsqlPointpoint0M>();
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 29;
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems2 = new List<FlatNpgsqlPointpoint0M>();
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpoint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
                var models = await((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPointpoint0M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPointpoint0M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPointpoint0M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPointpoint0M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPointpoint0M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[25],_testData[34], false);
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
                var models = ((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 150;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPointpoint0M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPointpoint0M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPointpoint0M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M), typeof(FlatNpgsqlPointpoint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpoint0M>();
                var models2 = new List<FlatNpgsqlPointpoint0M>();
                await((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpoint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var firstItems2 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems2 = new List<FlatNpgsqlPointpoint0M>();
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 72, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var firstItems2 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 64, query1, 99, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpoint0M>();
                var models2 = new List<FlatNpgsqlPointpoint0M>();
                ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpoint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var firstItems2 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems2 = new List<FlatNpgsqlPointpoint0M>();
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 117, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var firstItems2 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 99, query1, 62, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpoint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 72, query1, 40, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[26],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems2 = new List<FlatNpgsqlPointpoint0M>();
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 43, query1, 43, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 56, query1, 87, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[14],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
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
FROM public.npgsqlpointpoint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems1 = new List<FlatNpgsqlPointpoint0M>();
                var secondItems2 = new List<FlatNpgsqlPointpoint0M>();
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelBatch(connection, 148, query1, 56, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpoint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
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
                var models = await((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelBatchAsync(connection, 50, 130))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPointpoint0M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPointpoint0M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPointpoint0M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[29], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[30], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[31], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[34], false);
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
                var models = ((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpoint0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelBatch(connection, 150, 40))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPointpoint0M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPointpoint0M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPointpoint0M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPointpoint0M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPointpoint0M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPointpoint0M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[26],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPointSingleTypepoint)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointSingleTypepoint)this).SetDbConnectionSelectModelParametrs(cmd, 6);
                var models = await ((INpgsqlPointSingleTypepoint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                NpgsqlPointpoint0M.AssertModel(models[0],_testData[1], false);
                NpgsqlPointpoint0M.AssertModel(models[1],_testData[2], false);
                NpgsqlPointpoint0M.AssertModel(models[2],_testData[3], false);
                NpgsqlPointpoint0M.AssertModel(models[3],_testData[4], false);
                NpgsqlPointpoint0M.AssertModel(models[4],_testData[5], false);
                NpgsqlPointpoint0M.AssertModel(models[5],_testData[6], false);
                NpgsqlPointpoint0M.AssertModel(models[6],_testData[7], false);
                NpgsqlPointpoint0M.AssertModel(models[7],_testData[8], false);
                NpgsqlPointpoint0M.AssertModel(models[8],_testData[9], false);
                NpgsqlPointpoint0M.AssertModel(models[9],_testData[10], false);
                NpgsqlPointpoint0M.AssertModel(models[10],_testData[11], false);
                NpgsqlPointpoint0M.AssertModel(models[11],_testData[12], false);
                NpgsqlPointpoint0M.AssertModel(models[12],_testData[13], false);
                NpgsqlPointpoint0M.AssertModel(models[13],_testData[14], false);
                NpgsqlPointpoint0M.AssertModel(models[14],_testData[15], false);
                NpgsqlPointpoint0M.AssertModel(models[15],_testData[16], false);
                NpgsqlPointpoint0M.AssertModel(models[16],_testData[17], false);
                NpgsqlPointpoint0M.AssertModel(models[17],_testData[18], false);
                NpgsqlPointpoint0M.AssertModel(models[18],_testData[19], false);
                NpgsqlPointpoint0M.AssertModel(models[19],_testData[20], false);
                NpgsqlPointpoint0M.AssertModel(models[20],_testData[21], false);
                NpgsqlPointpoint0M.AssertModel(models[21],_testData[22], false);
                NpgsqlPointpoint0M.AssertModel(models[22],_testData[23], false);
                NpgsqlPointpoint0M.AssertModel(models[23],_testData[24], false);
                NpgsqlPointpoint0M.AssertModel(models[24],_testData[25], false);
                NpgsqlPointpoint0M.AssertModel(models[25],_testData[26], false);
                NpgsqlPointpoint0M.AssertModel(models[26],_testData[27], false);
                NpgsqlPointpoint0M.AssertModel(models[27],_testData[28], false);
                NpgsqlPointpoint0M.AssertModel(models[28],_testData[29], false);
                NpgsqlPointpoint0M.AssertModel(models[29],_testData[30], false);
                NpgsqlPointpoint0M.AssertModel(models[30],_testData[31], false);
                NpgsqlPointpoint0M.AssertModel(models[31],_testData[32], false);
                NpgsqlPointpoint0M.AssertModel(models[32],_testData[33], false);
                NpgsqlPointpoint0M.AssertModel(models[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointSingleTypepoint)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointSingleTypepoint)this).SetDbConnectionSelectModelParametrs(cmd, 135);
                var models =  ((INpgsqlPointSingleTypepoint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                NpgsqlPointpoint0M.AssertModel(models[0],_testData[30], false);
                NpgsqlPointpoint0M.AssertModel(models[1],_testData[31], false);
                NpgsqlPointpoint0M.AssertModel(models[2],_testData[32], false);
                NpgsqlPointpoint0M.AssertModel(models[3],_testData[33], false);
                NpgsqlPointpoint0M.AssertModel(models[4],_testData[34], false);
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
FROM public.npgsqlpointpoint0m m
LEFT JOIN public.npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelToObjArr",
            queryMapTypes: [typeof(object[])],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.522333828679786d, y: 0.7891408717746823d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5680839390614815d, y: 0.45387747649287935d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5870916923777191d, y: 0.3399267337263453d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4240617788256851d, y: 0.5679899992735339d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8486493794040415d, y: 0.4617957920928931d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.0839969782570783d, y: 0.2591493411919267d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.04767221052843762d, y: 0.21433639705043328d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2938049051381503d, y: 0.9012175300674404d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6651025930117141d, y: 0.7052653357143285d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.39750814852945926d, y: 0.007359777145333868d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.579390540607864d, y: 0.13182348020405865d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9259641152463088d, y: 0.7347216553078851d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.17280342932970638d, y: 0.6388281113850816d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9508390506125151d, y: 0.7074336745088823d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3476402646627412d, y: 0.07106312848896312d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2019304587186732d, y: 0.7954759440828046d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.30138685099024853d, y: 0.9604127165261807d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4064949349921765d, y: 0.059057509304311306d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4461422130920718d, y: 0.5246779333524296d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.772183896727397d, y: 0.6311974585113467d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9326865072680839d, y: 0.5422102140977909d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.626348461478757d, y: 0.8150353926690947d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6061335610803851d, y: 0.15790090646190558d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8255650088854961d, y: 0.6654412981709237d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.45836235270229797d, y: 0.5208964702159143d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.29191345950665526d, y: 0.12558218613042427d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5825851725672004d, y: 0.0762783602697169d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.26432582223276535d, y: 0.5733079382790428d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7907013086969136d, y: 0.3089568071994747d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7189120058623751d, y: 0.1445681335970992d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.06684206570193019d, y: 0.2748300862399172d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8505997916298377d, y: 0.5433934491438257d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5241170831732016d, y: 0.6141516689826978d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.29043944216024686d, y: 0.3797294328237285d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6960281365376063d, y: 0.2760739990858613d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8036381754082952d, y: 0.39476655676046046d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.16674265301791225d, y: 0.49878933676110027d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7458269231850446d, y: 0.6848903044115371d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.03506036230146936d, y: 0.4372660816384073d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.49806842254809325d, y: 0.24364059623024092d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5894286753980938d, y: 0.7679216477018196d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1705166132944269d, y: 0.21347685107286318d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9380556211437343d, y: 0.9395613621371512d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.00905869443203533d, y: 0.14359029995766304d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8363312369810805d, y: 0.3506368656115256d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.047450917794743086d, y: 0.499034044568187d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.085669355139123d, y: 0.19150564996289265d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.17479413825455548d, y: 0.1314043065961078d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.06381031200805465d, y: 0.5035557208435321d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.10819752117171899d, y: 0.7908361625975506d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7510108031290874d, y: 0.8708307167391482d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4662818304886368d, y: 0.2800161380345014d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6785313978527966d, y: 0.3667694831034628d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2140372193002802d, y: 0.5477988909298471d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5025568316654039d, y: 0.21694824366880638d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2066578282547732d, y: 0.8445388607008647d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8505199438080783d, y: 0.11526367081167121d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6136878185270669d, y: 0.8120022625100334d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.09907276267190868d, y: 0.3290397292669013d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7276508232953768d, y: 0.8191314293605343d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.28216748839108263d, y: 0.39588551343418266d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3453500678582485d, y: 0.6099455165802395d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3194724353728765d, y: 0.40207139669823d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.937266706412382d, y: 0.16080682300799132d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7182977955454177d, y: 0.42632002521678924d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.18441986768674723d, y: 0.6722551386787134d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8947448335468836d, y: 0.15426691433480166d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.02838233412892599d, y: 0.914814322737449d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((95)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8130799733358798d, y: 0.42105469428357134d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.11721094669454657d, y: 0.42772637851061224d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8173381889689378d, y: 0.4805527441890831d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.457452201179251d, y: 0.7879025308998386d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7795303245093574d, y: 0.18246068856272202d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((103)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.721864688337097d, y: 0.13631656215505228d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5386020258848861d, y: 0.6559279750071285d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.73105647485323d, y: 0.2631893900202028d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4002095319413531d, y: 0.2628356987297983d))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointSingleTypepoint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.522333828679786d, y: 0.7891408717746823d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5680839390614815d, y: 0.45387747649287935d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5870916923777191d, y: 0.3399267337263453d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4240617788256851d, y: 0.5679899992735339d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8486493794040415d, y: 0.4617957920928931d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.0839969782570783d, y: 0.2591493411919267d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.04767221052843762d, y: 0.21433639705043328d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2938049051381503d, y: 0.9012175300674404d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6651025930117141d, y: 0.7052653357143285d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.39750814852945926d, y: 0.007359777145333868d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.579390540607864d, y: 0.13182348020405865d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9259641152463088d, y: 0.7347216553078851d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.17280342932970638d, y: 0.6388281113850816d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9508390506125151d, y: 0.7074336745088823d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3476402646627412d, y: 0.07106312848896312d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2019304587186732d, y: 0.7954759440828046d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.30138685099024853d, y: 0.9604127165261807d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4064949349921765d, y: 0.059057509304311306d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4461422130920718d, y: 0.5246779333524296d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.772183896727397d, y: 0.6311974585113467d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9326865072680839d, y: 0.5422102140977909d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.626348461478757d, y: 0.8150353926690947d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6061335610803851d, y: 0.15790090646190558d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8255650088854961d, y: 0.6654412981709237d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.45836235270229797d, y: 0.5208964702159143d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.29191345950665526d, y: 0.12558218613042427d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5825851725672004d, y: 0.0762783602697169d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.26432582223276535d, y: 0.5733079382790428d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7907013086969136d, y: 0.3089568071994747d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7189120058623751d, y: 0.1445681335970992d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.06684206570193019d, y: 0.2748300862399172d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8505997916298377d, y: 0.5433934491438257d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5241170831732016d, y: 0.6141516689826978d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.29043944216024686d, y: 0.3797294328237285d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6960281365376063d, y: 0.2760739990858613d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8036381754082952d, y: 0.39476655676046046d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.16674265301791225d, y: 0.49878933676110027d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7458269231850446d, y: 0.6848903044115371d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.03506036230146936d, y: 0.4372660816384073d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.49806842254809325d, y: 0.24364059623024092d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5894286753980938d, y: 0.7679216477018196d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1705166132944269d, y: 0.21347685107286318d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9380556211437343d, y: 0.9395613621371512d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.00905869443203533d, y: 0.14359029995766304d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8363312369810805d, y: 0.3506368656115256d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.047450917794743086d, y: 0.499034044568187d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.085669355139123d, y: 0.19150564996289265d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.17479413825455548d, y: 0.1314043065961078d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.06381031200805465d, y: 0.5035557208435321d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.10819752117171899d, y: 0.7908361625975506d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7510108031290874d, y: 0.8708307167391482d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4662818304886368d, y: 0.2800161380345014d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6785313978527966d, y: 0.3667694831034628d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2140372193002802d, y: 0.5477988909298471d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5025568316654039d, y: 0.21694824366880638d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2066578282547732d, y: 0.8445388607008647d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8505199438080783d, y: 0.11526367081167121d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6136878185270669d, y: 0.8120022625100334d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.09907276267190868d, y: 0.3290397292669013d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7276508232953768d, y: 0.8191314293605343d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.28216748839108263d, y: 0.39588551343418266d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3453500678582485d, y: 0.6099455165802395d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3194724353728765d, y: 0.40207139669823d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.937266706412382d, y: 0.16080682300799132d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7182977955454177d, y: 0.42632002521678924d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.18441986768674723d, y: 0.6722551386787134d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8947448335468836d, y: 0.15426691433480166d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.02838233412892599d, y: 0.914814322737449d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((95)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8130799733358798d, y: 0.42105469428357134d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.11721094669454657d, y: 0.42772637851061224d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8173381889689378d, y: 0.4805527441890831d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.457452201179251d, y: 0.7879025308998386d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7795303245093574d, y: 0.18246068856272202d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((103)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.721864688337097d, y: 0.13631656215505228d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5386020258848861d, y: 0.6559279750071285d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.73105647485323d, y: 0.2631893900202028d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4002095319413531d, y: 0.2628356987297983d))));

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
FROM public.binary_npgsqlpointpoint0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpoint0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpoint0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpoint0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointSingleTypepoint)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpoint0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointSingleTypepoint)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpoint0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpoint0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointSingleTypepoint)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpoint0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointSingleTypepoint)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpoint0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpoint0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpoint0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpoint0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointSingleTypepoint)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpoint0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointSingleTypepoint)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpoint0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpoint0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointSingleTypepoint)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpoint0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointSingleTypepoint)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpoint0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpoint0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpoint0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpoint0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointSingleTypepoint)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointSingleTypepoint)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpoint0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointSingleTypepoint)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointSingleTypepoint)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpoint0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpoint0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpoint0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpoint0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpoint0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointSingleTypepoint)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointSingleTypepoint)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpoint0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpoint0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointSingleTypepoint)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointSingleTypepoint)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpoint0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpoint0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpoint0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
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
FROM public.binary_npgsqlpointpoint0m m
LEFT JOIN public.binary_npgsqlpointpoint0mi mi ON mi.id = m.npgsqlpointpoint0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpoint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpoint0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointSingleTypepoint)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointSingleTypepoint)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpoint0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpoint0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointSingleTypepoint)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointSingleTypepoint)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpoint0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpoint0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpoint0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpoint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15)
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
                var models =  ((INpgsqlPointSingleTypepoint)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpoint0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointSingleTypepoint)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpoint0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA), typeof(NpgsqlPointpoint0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
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
                var models1 = new List<NpgsqlPointpoint0MIWA>();
                var models2 = new List<NpgsqlPointpoint0MIWA>();
                await ((INpgsqlPointSingleTypepoint)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpoint0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpoint0MIWA>();
                var models2 = new List<NpgsqlPointpoint0MIWA>();
                ((INpgsqlPointSingleTypepoint)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpoint0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
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
                var models = await ((INpgsqlPointSingleTypepoint)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpoint0mi
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
                    NpgsqlPointpoint0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointSingleTypepoint)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpoint0mi
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
                    NpgsqlPointpoint0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA), typeof(NpgsqlPointpoint0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
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
                var models1 = new List<NpgsqlPointpoint0MIWA>();
                var models2 = new List<NpgsqlPointpoint0MIWA>();
                await ((INpgsqlPointSingleTypepoint)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpoint0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpoint0MIWA>();
                var models2 = new List<NpgsqlPointpoint0MIWA>();
                ((INpgsqlPointSingleTypepoint)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpoint0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
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
                var models = await ((INpgsqlPointSingleTypepoint)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpoint0mi
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
                    NpgsqlPointpoint0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointSingleTypepoint)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpoint0mi
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
                    NpgsqlPointpoint0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpoint0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MI), typeof(NpgsqlPointpoint0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
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
                var models1 = new List<NpgsqlPointpoint0MI>();
                var models2 = new List<NpgsqlPointpoint0MI>();
                await ((INpgsqlPointSingleTypepoint)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpoint0MI>();
                var models2 = new List<NpgsqlPointpoint0MI>();
                ((INpgsqlPointSingleTypepoint)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpoint0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(15),
                (NpgsqlTypes.NpgsqlDbType)(15)
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
                var models = await ((INpgsqlPointSingleTypepoint)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointSingleTypepoint)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpoint0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA), typeof(NpgsqlPointpoint0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
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
                var models1 = new List<NpgsqlPointpoint0MIWA>();
                var models2 = new List<NpgsqlPointpoint0MIWA>();
                await ((INpgsqlPointSingleTypepoint)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpoint0MIWA>();
                var models2 = new List<NpgsqlPointpoint0MIWA>();
                ((INpgsqlPointSingleTypepoint)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpoint0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointSingleTypepoint))]
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
                var models = await ((INpgsqlPointSingleTypepoint)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointSingleTypepoint)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

