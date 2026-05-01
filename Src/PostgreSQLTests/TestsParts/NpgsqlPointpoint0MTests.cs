

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
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.04926671346654754d, y: 0.5839754021963733d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.12739151406333415d, y: 0.2408724614764246d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 1,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.38510336881208485d, y: 0.1992830182009352d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9189104075499793d, y: 0.6579976230078874d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.09722863277621907d, y: 0.46729716723648407d),
},
            new NpgsqlPointpoint0M
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6676993177128502d, y: 0.18436540412396274d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8511719748840161d, y: 0.732064633195678d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.22403566989682777d, y: 0.37207447350299305d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7804628850793897d, y: 0.7727211872890132d),
},
            new NpgsqlPointpoint0M
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3025691790780568d, y: 0.5218415003144514d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6078048644083263d, y: 0.6382223563345198d),
},
            new NpgsqlPointpoint0M
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4765505514654683d, y: 0.702430194453288d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9639165585405821d, y: 0.2521520633570212d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.3800517859561311d, y: 0.06838496577451914d),
},
            new NpgsqlPointpoint0M
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5032455157820579d, y: 0.6738017076302306d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.06287679098760102d, y: 0.8136222427482087d),
},
            new NpgsqlPointpoint0M
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7180136658257567d, y: 0.5198003324782703d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.19511581591421923d, y: 0.24170636155877245d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.22786653542705948d, y: 0.4701586785849031d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.215647155024851d, y: 0.23236426958816103d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4941736862985109d, y: 0.9874738117306264d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9209732116212933d, y: 0.40871976086539896d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.379097735594934d, y: 0.1474330895913908d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.8896003652673415d, y: 0.3153663188621565d),
},
            new NpgsqlPointpoint0M
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.50710970303185d, y: 0.06422415530186043d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.31455709211091654d, y: 0.3572297324815309d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6596300593130314d, y: 0.15535857332512215d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.2451054766129176d, y: 0.8891933162854978d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.44809492567883924d, y: 0.4121256268079525d),
},
            new NpgsqlPointpoint0M
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.10958954706071522d, y: 0.28639169368603024d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9976130769610142d, y: 0.678904111586956d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.08779872869410787d, y: 0.5822104014320462d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.08525799756791042d, y: 0.9212395638707338d),
},
            new NpgsqlPointpoint0M
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8996212190612668d, y: 0.3804032473122877d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.20180441921818637d, y: 0.9499409463538369d),
},
            new NpgsqlPointpoint0M
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7767754980498863d, y: 0.12558832330777947d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.41165849905127305d, y: 0.35702033200929606d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.29232499379888655d, y: 0.6974473545551659d),
},
            new NpgsqlPointpoint0M
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7421528233403589d, y: 0.2665316190587387d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.47557988980560895d, y: 0.7321536814499204d),
},
            new NpgsqlPointpoint0M
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.086180496467675d, y: 0.44639495378895844d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4977593005704781d, y: 0.9857003972860798d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 93,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6771860648998905d, y: 0.5317775167311285d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.9324245445275242d, y: 0.6924281903865999d),
},
            new NpgsqlPointpoint0M
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7121815295657576d, y: 0.33663075336709614d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.895233472474534d, y: 0.44552615990746414d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.14533024641045933d, y: 0.34456470674494266d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.5006656770010389d, y: 0.4569689608007804d),
},
            new NpgsqlPointpoint0M
{
    Id = 103,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.37134969926695083d, y: 0.21324795337228541d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.9048130872354537d, y: 0.281906563084544d),
},
            new NpgsqlPointpoint0M
{
    Id = 104,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.008766316046007527d, y: 0.2248439582806009d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5592223788304219d, y: 0.6943835178694399d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.4033484161817378d, y: 0.9581759415251159d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 105,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9887991244900121d, y: 0.4649695034228334d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 112,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5672563702629317d, y: 0.5209961070954745d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.787027580972452d, y: 0.3091565450502167d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.1632458788221356d, y: 0.47880238574863676d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7099826786940777d, y: 0.16990851891440772d),
},
            new NpgsqlPointpoint0M
{
    Id = 115,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.3851676129455883d, y: 0.06355139775148311d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 121,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.09201177789251425d, y: 0.8520027786837022d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8607640775282098d, y: 0.9522956650048224d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.2668669030294635d, y: 0.23910751100608263d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 122,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.00798958201942479d, y: 0.6151049399974083d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.34468254563302136d, y: 0.6345086117103818d),
},
            new NpgsqlPointpoint0M
{
    Id = 126,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7713506091446208d, y: 0.2792424585642237d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.07809514442925847d, y: 0.9888416696237194d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 133,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8732170305433307d, y: 0.8405561002599944d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.05558902060236348d, y: 0.5837334014525853d),
},
            new NpgsqlPointpoint0M
{
    Id = 134,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.45276480840306266d, y: 0.4798479078477015d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4177394005933819d, y: 0.14764206261014734d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6899708565962018d, y: 0.33338478270634386d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.9560924951162595d, y: 0.7047585283228444d),
},
            new NpgsqlPointpoint0M
{
    Id = 141,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8629642255345503d, y: 0.24785185345863914d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.2943911169089968d, y: 0.08672634460903228d),
},
            new NpgsqlPointpoint0M
{
    Id = 147,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5865674966229492d, y: 0.6363141194956032d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 92,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.43592586805934597d, y: 0.4020606162364785d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 151,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4251811922870643d, y: 0.2319737796143736d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.018188026662398715d, y: 0.6539333370484078d),
},
            new NpgsqlPointpoint0M
{
    Id = 158,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.05886262566428746d, y: 0.830218638991904d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 100,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8939212570501996d, y: 0.16082481495776946d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 160,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9268642555494908d, y: 0.4837597781516293d),
    ModelInner = null,
    NullableValue = null,
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.6078048644083263d, y: 0.6382223563345198d)));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.3800517859561311d, y: 0.06838496577451914d)));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.06287679098760102d, y: 0.8136222427482087d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8896003652673415d, y: 0.3153663188621565d)));
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
                parametr1.Value = 52;
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
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[30],_testData[34], false);
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 12;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[34], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
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
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[22],_testData[34], false);
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
                parametr2.Value = 95;
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
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[14],_testData[34], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[33],_testData[34], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[29], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[30], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[31], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPointpoint0M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPointpoint0M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPointpoint0M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[29], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[30], false);
                        NpgsqlPointpoint0M.AssertModel(models[12],_testData[31], false);
                        NpgsqlPointpoint0M.AssertModel(models[13],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[14],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[15],_testData[34], false);
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
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 10, query1, 147, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[34], false);
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
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 40, query1, 32, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[28],_testData[34], false);
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
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 134, query1, 134, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[34], false);
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
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 19, query1, 83, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 115, query1, 147, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[34], false);
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
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 49, query1, 134, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 32, query1, 84, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelBatch(connection, 10, query1, 93, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[15],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelBatchAsync(connection, 19, 104))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPointpoint0M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPointpoint0M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPointpoint0M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPointpoint0M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPointpoint0M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPointpoint0M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPointpoint0M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPointpoint0M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPointpoint0M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPointpoint0M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[29], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[30], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[31], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[32], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[33], false);
                        NpgsqlPointpoint0M.AssertModel(models[12],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelBatch(connection, 49, 5))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                ((INpgsqlPointSingleTypepoint)this).SetDbConnectionSelectModelParametrs(cmd, 105);
                var models = await ((INpgsqlPointSingleTypepoint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointSingleTypepoint)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointSingleTypepoint)this).SetDbConnectionSelectModelParametrs(cmd, 82);
                var models =  ((INpgsqlPointSingleTypepoint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                NpgsqlPointpoint0M.AssertModel(models[0],_testData[16], false);
                NpgsqlPointpoint0M.AssertModel(models[1],_testData[17], false);
                NpgsqlPointpoint0M.AssertModel(models[2],_testData[18], false);
                NpgsqlPointpoint0M.AssertModel(models[3],_testData[19], false);
                NpgsqlPointpoint0M.AssertModel(models[4],_testData[20], false);
                NpgsqlPointpoint0M.AssertModel(models[5],_testData[21], false);
                NpgsqlPointpoint0M.AssertModel(models[6],_testData[22], false);
                NpgsqlPointpoint0M.AssertModel(models[7],_testData[23], false);
                NpgsqlPointpoint0M.AssertModel(models[8],_testData[24], false);
                NpgsqlPointpoint0M.AssertModel(models[9],_testData[25], false);
                NpgsqlPointpoint0M.AssertModel(models[10],_testData[26], false);
                NpgsqlPointpoint0M.AssertModel(models[11],_testData[27], false);
                NpgsqlPointpoint0M.AssertModel(models[12],_testData[28], false);
                NpgsqlPointpoint0M.AssertModel(models[13],_testData[29], false);
                NpgsqlPointpoint0M.AssertModel(models[14],_testData[30], false);
                NpgsqlPointpoint0M.AssertModel(models[15],_testData[31], false);
                NpgsqlPointpoint0M.AssertModel(models[16],_testData[32], false);
                NpgsqlPointpoint0M.AssertModel(models[17],_testData[33], false);
                NpgsqlPointpoint0M.AssertModel(models[18],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.04926671346654754d, y: 0.5839754021963733d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.12739151406333415d, y: 0.2408724614764246d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.38510336881208485d, y: 0.1992830182009352d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9189104075499793d, y: 0.6579976230078874d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.09722863277621907d, y: 0.46729716723648407d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6676993177128502d, y: 0.18436540412396274d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8511719748840161d, y: 0.732064633195678d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.22403566989682777d, y: 0.37207447350299305d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7804628850793897d, y: 0.7727211872890132d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3025691790780568d, y: 0.5218415003144514d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6078048644083263d, y: 0.6382223563345198d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4765505514654683d, y: 0.702430194453288d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9639165585405821d, y: 0.2521520633570212d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3800517859561311d, y: 0.06838496577451914d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5032455157820579d, y: 0.6738017076302306d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.06287679098760102d, y: 0.8136222427482087d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7180136658257567d, y: 0.5198003324782703d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.19511581591421923d, y: 0.24170636155877245d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.22786653542705948d, y: 0.4701586785849031d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.215647155024851d, y: 0.23236426958816103d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4941736862985109d, y: 0.9874738117306264d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9209732116212933d, y: 0.40871976086539896d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.379097735594934d, y: 0.1474330895913908d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8896003652673415d, y: 0.3153663188621565d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.50710970303185d, y: 0.06422415530186043d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.31455709211091654d, y: 0.3572297324815309d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6596300593130314d, y: 0.15535857332512215d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2451054766129176d, y: 0.8891933162854978d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.44809492567883924d, y: 0.4121256268079525d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.10958954706071522d, y: 0.28639169368603024d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9976130769610142d, y: 0.678904111586956d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.08779872869410787d, y: 0.5822104014320462d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.08525799756791042d, y: 0.9212395638707338d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8996212190612668d, y: 0.3804032473122877d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.20180441921818637d, y: 0.9499409463538369d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7767754980498863d, y: 0.12558832330777947d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.41165849905127305d, y: 0.35702033200929606d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.29232499379888655d, y: 0.6974473545551659d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7421528233403589d, y: 0.2665316190587387d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.47557988980560895d, y: 0.7321536814499204d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.086180496467675d, y: 0.44639495378895844d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4977593005704781d, y: 0.9857003972860798d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6771860648998905d, y: 0.5317775167311285d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9324245445275242d, y: 0.6924281903865999d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7121815295657576d, y: 0.33663075336709614d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.895233472474534d, y: 0.44552615990746414d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.14533024641045933d, y: 0.34456470674494266d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5006656770010389d, y: 0.4569689608007804d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.37134969926695083d, y: 0.21324795337228541d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9048130872354537d, y: 0.281906563084544d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.008766316046007527d, y: 0.2248439582806009d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5592223788304219d, y: 0.6943835178694399d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4033484161817378d, y: 0.9581759415251159d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9887991244900121d, y: 0.4649695034228334d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5672563702629317d, y: 0.5209961070954745d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.787027580972452d, y: 0.3091565450502167d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1632458788221356d, y: 0.47880238574863676d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7099826786940777d, y: 0.16990851891440772d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3851676129455883d, y: 0.06355139775148311d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.09201177789251425d, y: 0.8520027786837022d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8607640775282098d, y: 0.9522956650048224d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2668669030294635d, y: 0.23910751100608263d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.00798958201942479d, y: 0.6151049399974083d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.34468254563302136d, y: 0.6345086117103818d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7713506091446208d, y: 0.2792424585642237d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.07809514442925847d, y: 0.9888416696237194d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8732170305433307d, y: 0.8405561002599944d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.05558902060236348d, y: 0.5837334014525853d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.45276480840306266d, y: 0.4798479078477015d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4177394005933819d, y: 0.14764206261014734d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6899708565962018d, y: 0.33338478270634386d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9560924951162595d, y: 0.7047585283228444d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8629642255345503d, y: 0.24785185345863914d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2943911169089968d, y: 0.08672634460903228d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5865674966229492d, y: 0.6363141194956032d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((92)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.43592586805934597d, y: 0.4020606162364785d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4251811922870643d, y: 0.2319737796143736d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.018188026662398715d, y: 0.6539333370484078d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.05886262566428746d, y: 0.830218638991904d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((100)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8939212570501996d, y: 0.16082481495776946d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9268642555494908d, y: 0.4837597781516293d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.04926671346654754d, y: 0.5839754021963733d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.12739151406333415d, y: 0.2408724614764246d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.38510336881208485d, y: 0.1992830182009352d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9189104075499793d, y: 0.6579976230078874d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.09722863277621907d, y: 0.46729716723648407d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6676993177128502d, y: 0.18436540412396274d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8511719748840161d, y: 0.732064633195678d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.22403566989682777d, y: 0.37207447350299305d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7804628850793897d, y: 0.7727211872890132d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3025691790780568d, y: 0.5218415003144514d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6078048644083263d, y: 0.6382223563345198d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4765505514654683d, y: 0.702430194453288d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9639165585405821d, y: 0.2521520633570212d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3800517859561311d, y: 0.06838496577451914d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5032455157820579d, y: 0.6738017076302306d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.06287679098760102d, y: 0.8136222427482087d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7180136658257567d, y: 0.5198003324782703d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.19511581591421923d, y: 0.24170636155877245d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.22786653542705948d, y: 0.4701586785849031d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.215647155024851d, y: 0.23236426958816103d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4941736862985109d, y: 0.9874738117306264d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9209732116212933d, y: 0.40871976086539896d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.379097735594934d, y: 0.1474330895913908d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8896003652673415d, y: 0.3153663188621565d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.50710970303185d, y: 0.06422415530186043d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.31455709211091654d, y: 0.3572297324815309d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6596300593130314d, y: 0.15535857332512215d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2451054766129176d, y: 0.8891933162854978d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.44809492567883924d, y: 0.4121256268079525d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.10958954706071522d, y: 0.28639169368603024d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9976130769610142d, y: 0.678904111586956d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.08779872869410787d, y: 0.5822104014320462d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.08525799756791042d, y: 0.9212395638707338d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8996212190612668d, y: 0.3804032473122877d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.20180441921818637d, y: 0.9499409463538369d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7767754980498863d, y: 0.12558832330777947d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.41165849905127305d, y: 0.35702033200929606d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.29232499379888655d, y: 0.6974473545551659d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7421528233403589d, y: 0.2665316190587387d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.47557988980560895d, y: 0.7321536814499204d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.086180496467675d, y: 0.44639495378895844d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4977593005704781d, y: 0.9857003972860798d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6771860648998905d, y: 0.5317775167311285d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9324245445275242d, y: 0.6924281903865999d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7121815295657576d, y: 0.33663075336709614d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.895233472474534d, y: 0.44552615990746414d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.14533024641045933d, y: 0.34456470674494266d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5006656770010389d, y: 0.4569689608007804d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.37134969926695083d, y: 0.21324795337228541d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9048130872354537d, y: 0.281906563084544d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.008766316046007527d, y: 0.2248439582806009d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5592223788304219d, y: 0.6943835178694399d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4033484161817378d, y: 0.9581759415251159d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9887991244900121d, y: 0.4649695034228334d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5672563702629317d, y: 0.5209961070954745d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.787027580972452d, y: 0.3091565450502167d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1632458788221356d, y: 0.47880238574863676d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7099826786940777d, y: 0.16990851891440772d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3851676129455883d, y: 0.06355139775148311d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.09201177789251425d, y: 0.8520027786837022d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8607640775282098d, y: 0.9522956650048224d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2668669030294635d, y: 0.23910751100608263d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.00798958201942479d, y: 0.6151049399974083d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.34468254563302136d, y: 0.6345086117103818d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7713506091446208d, y: 0.2792424585642237d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.07809514442925847d, y: 0.9888416696237194d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8732170305433307d, y: 0.8405561002599944d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.05558902060236348d, y: 0.5837334014525853d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.45276480840306266d, y: 0.4798479078477015d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4177394005933819d, y: 0.14764206261014734d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6899708565962018d, y: 0.33338478270634386d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9560924951162595d, y: 0.7047585283228444d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8629642255345503d, y: 0.24785185345863914d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2943911169089968d, y: 0.08672634460903228d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5865674966229492d, y: 0.6363141194956032d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((92)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.43592586805934597d, y: 0.4020606162364785d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4251811922870643d, y: 0.2319737796143736d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.018188026662398715d, y: 0.6539333370484078d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.05886262566428746d, y: 0.830218638991904d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((100)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8939212570501996d, y: 0.16082481495776946d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9268642555494908d, y: 0.4837597781516293d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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

