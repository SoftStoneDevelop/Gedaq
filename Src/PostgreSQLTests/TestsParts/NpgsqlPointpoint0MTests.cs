

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
    Id = 2,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4045434804886693d, y: 0.1497083347886078d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.3672116013149077d, y: 0.9086154728291018d),
},
            new NpgsqlPointpoint0M
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8809049756375295d, y: 0.21999715865887493d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.1950908360327267d, y: 0.5498732152208442d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.5335719234219122d, y: 0.42887530205402724d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.8108074907246747d, y: 0.06191008229906492d),
},
            new NpgsqlPointpoint0M
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6930220228824048d, y: 0.9630446330129909d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.38850789900505633d, y: 0.36081735656205427d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.959442671720039d, y: 0.21029903485601187d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.9023480237771616d, y: 0.6300888809340851d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.10342685233653448d, y: 0.513790959100771d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.5024841721373446d, y: 0.18855863478116786d),
},
            new NpgsqlPointpoint0M
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9516441216586393d, y: 0.3988107117570845d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7737913424757967d, y: 0.5519658822426468d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.05098082499382384d, y: 0.29116989204263977d),
},
            new NpgsqlPointpoint0M
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5606354803907104d, y: 0.40196978582107856d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7609857016435885d, y: 0.24372887710178026d),
},
            new NpgsqlPointpoint0M
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7616343479504653d, y: 0.730861607763137d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.12359440365235086d, y: 0.5421996194250187d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.6629905568738906d, y: 0.8920952269789387d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7976725778721124d, y: 0.009496457983135587d),
},
            new NpgsqlPointpoint0M
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.42144844415491123d, y: 0.34007051824653944d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7760689958410192d, y: 0.6018466031735158d),
},
            new NpgsqlPointpoint0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9279245327635218d, y: 0.16814489591861825d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.5197529066156092d, y: 0.3328255383915453d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7873653271200262d, y: 0.14318297903644828d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.8024150265781688d, y: 0.21665963296513036d),
},
            new NpgsqlPointpoint0M
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8707194015296223d, y: 0.7013027612766116d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.03163198864722305d, y: 0.9141413535998383d),
},
            new NpgsqlPointpoint0M
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.03930736073030494d, y: 0.14025321699917892d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.2387754642910398d, y: 0.2178589698380453d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.3306602805167089d, y: 0.5152260343819687d),
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.2811034216913193d, y: 0.20233692958988825d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.36469678582886433d, y: 0.17882308975336692d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.20998787286507015d, y: 0.19248937548842004d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.5577180346704839d, y: 0.9677433666235006d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7143092511070123d, y: 0.5652905624766328d),
},
            new NpgsqlPointpoint0M
{
    Id = 93,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8427915632945583d, y: 0.5811389199589326d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 101,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.47069348864160365d, y: 0.8409022090036623d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6176498810227115d, y: 0.22006158027809142d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.33805066341263157d, y: 0.6928743744721457d),
},
            new NpgsqlPointpoint0M
{
    Id = 102,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8064956695886221d, y: 0.35232520858202654d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 105,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.16272526186056901d, y: 0.20705883607208564d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.902765732522598d, y: 0.959523625584476d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.38809153142770825d, y: 0.7091169661724319d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.07386655490450655d, y: 0.24446594654588338d),
},
            new NpgsqlPointpoint0M
{
    Id = 107,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.9541979977811847d, y: 0.9322628631995864d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 108,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.4783918858401718d, y: 0.7441218182358394d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7550591382399451d, y: 0.2707708141691434d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.35566166004357747d, y: 0.8774410518865161d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.5535910415032856d, y: 0.9141752553616319d),
},
            new NpgsqlPointpoint0M
{
    Id = 117,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8075322890961057d, y: 0.6317527610074042d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7132455025788297d, y: 0.3353571489904874d),
},
            new NpgsqlPointpoint0M
{
    Id = 122,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.11750450139767876d, y: 0.14706954894907365d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.035535850663596436d, y: 0.9373003409382488d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.4302548518883774d, y: 0.14179211105305511d),
},
            new NpgsqlPointpoint0M
{
    Id = 127,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.45662609062911774d, y: 0.8940759169771001d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 135,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.6079434488104797d, y: 0.2242931406580012d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.17152569460634315d, y: 0.8337920100473579d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 140,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.2900555999792591d, y: 0.9519478326336336d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.7661910732760304d, y: 0.622008122496019d),
},
            new NpgsqlPointpoint0M
{
    Id = 142,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8193261526154367d, y: 0.0675928063324791d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8149843255791803d, y: 0.36898503175013964d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 143,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.01124755192335325d, y: 0.965206897195605d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.8769472849075376d, y: 0.19950718119665634d),
},
            new NpgsqlPointpoint0M
{
    Id = 144,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.0038164967217148016d, y: 0.9081012621487957d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.7935948668736325d, y: 0.3999234011068181d),
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.8718384990365584d, y: 0.6696029262241827d),
},
    NullableValue = new NpgsqlTypes.NpgsqlPoint(x: 0.4104686893142552d, y: 0.7900870839169728d),
},
            new NpgsqlPointpoint0M
{
    Id = 148,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.16396257370263456d, y: 0.6075753636723735d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpoint0M
{
    Id = 155,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.04099552115378158d, y: 0.7267881699729037d),
    ModelInner = new NpgsqlPointpoint0MI
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlPoint(x: 0.8378521115212322d, y: 0.5585013810078651d),
    NullableValue = null,
},
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.5024841721373446d, y: 0.18855863478116786d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.05098082499382384d, y: 0.29116989204263977d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7609857016435885d, y: 0.24372887710178026d)));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7976725778721124d, y: 0.009496457983135587d)));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.7760689958410192d, y: 0.6018466031735158d)));
                nullable =  ((INpgsqlPointSingleTypepoint)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.8024150265781688d, y: 0.21665963296513036d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPoint(x: 0.03163198864722305d, y: 0.9141413535998383d)));
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[22],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 73;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[29], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[21],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

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
                parametr1.Value = 122;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[18],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPointpoint0M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 14, query1, 102, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[12],_testData[29], false);
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
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 33, query1, 33, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpoint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 140, query1, 144, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[29], false);
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
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 73, query1, 144, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 66, query1, 142, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[29], false);
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
                await ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 82, query1, 122, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPointpoint0M.AssertModel(secondItems2[7],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 21, query1, 2, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPointpoint0M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(models[28],_testData[29], false);
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
                 ((INpgsqlPointSingleTypepoint)this).DbConnectionDynQuerySelectModelBatch(connection, 73, query1, 108, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPointpoint0M.AssertModel(firstItems1[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelBatchAsync(connection, 90, 127))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlPointSingleTypepoint)this).DbConnectionSTSelectModelBatch(connection, 105, 66))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPointpoint0M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPointpoint0M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPointpoint0M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPointpoint0M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPointpoint0M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPointpoint0M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPointpoint0M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPointpoint0M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPointpoint0M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPointpoint0M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPointpoint0M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPointpoint0M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPointpoint0M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPointpoint0M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPointpoint0M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPointpoint0M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPointpoint0M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPointpoint0M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPointpoint0M.AssertModel(models[18],_testData[29], false);
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
                ((INpgsqlPointSingleTypepoint)this).SetDbConnectionSelectModelParametrs(cmd, 135);
                var models = await ((INpgsqlPointSingleTypepoint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(6));
NpgsqlPointpoint0M.AssertModel(models[0],_testData[24], false);NpgsqlPointpoint0M.AssertModel(models[1],_testData[25], false);NpgsqlPointpoint0M.AssertModel(models[2],_testData[26], false);NpgsqlPointpoint0M.AssertModel(models[3],_testData[27], false);NpgsqlPointpoint0M.AssertModel(models[4],_testData[28], false);NpgsqlPointpoint0M.AssertModel(models[5],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointSingleTypepoint)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointSingleTypepoint)this).SetDbConnectionSelectModelParametrs(cmd, 127);
                var models =  ((INpgsqlPointSingleTypepoint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
NpgsqlPointpoint0M.AssertModel(models[0],_testData[23], false);NpgsqlPointpoint0M.AssertModel(models[1],_testData[24], false);NpgsqlPointpoint0M.AssertModel(models[2],_testData[25], false);NpgsqlPointpoint0M.AssertModel(models[3],_testData[26], false);NpgsqlPointpoint0M.AssertModel(models[4],_testData[27], false);NpgsqlPointpoint0M.AssertModel(models[5],_testData[28], false);NpgsqlPointpoint0M.AssertModel(models[6],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4045434804886693d, y: 0.1497083347886078d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3672116013149077d, y: 0.9086154728291018d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8809049756375295d, y: 0.21999715865887493d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1950908360327267d, y: 0.5498732152208442d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5335719234219122d, y: 0.42887530205402724d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8108074907246747d, y: 0.06191008229906492d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6930220228824048d, y: 0.9630446330129909d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.38850789900505633d, y: 0.36081735656205427d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.959442671720039d, y: 0.21029903485601187d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9023480237771616d, y: 0.6300888809340851d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.10342685233653448d, y: 0.513790959100771d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5024841721373446d, y: 0.18855863478116786d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9516441216586393d, y: 0.3988107117570845d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7737913424757967d, y: 0.5519658822426468d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.05098082499382384d, y: 0.29116989204263977d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5606354803907104d, y: 0.40196978582107856d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7609857016435885d, y: 0.24372887710178026d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7616343479504653d, y: 0.730861607763137d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.12359440365235086d, y: 0.5421996194250187d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6629905568738906d, y: 0.8920952269789387d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7976725778721124d, y: 0.009496457983135587d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.42144844415491123d, y: 0.34007051824653944d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7760689958410192d, y: 0.6018466031735158d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9279245327635218d, y: 0.16814489591861825d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5197529066156092d, y: 0.3328255383915453d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7873653271200262d, y: 0.14318297903644828d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8024150265781688d, y: 0.21665963296513036d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8707194015296223d, y: 0.7013027612766116d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.03163198864722305d, y: 0.9141413535998383d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.03930736073030494d, y: 0.14025321699917892d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2387754642910398d, y: 0.2178589698380453d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3306602805167089d, y: 0.5152260343819687d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2811034216913193d, y: 0.20233692958988825d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.36469678582886433d, y: 0.17882308975336692d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.20998787286507015d, y: 0.19248937548842004d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5577180346704839d, y: 0.9677433666235006d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7143092511070123d, y: 0.5652905624766328d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8427915632945583d, y: 0.5811389199589326d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.47069348864160365d, y: 0.8409022090036623d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6176498810227115d, y: 0.22006158027809142d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.33805066341263157d, y: 0.6928743744721457d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8064956695886221d, y: 0.35232520858202654d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.16272526186056901d, y: 0.20705883607208564d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.902765732522598d, y: 0.959523625584476d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.38809153142770825d, y: 0.7091169661724319d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.07386655490450655d, y: 0.24446594654588338d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9541979977811847d, y: 0.9322628631995864d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4783918858401718d, y: 0.7441218182358394d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7550591382399451d, y: 0.2707708141691434d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.35566166004357747d, y: 0.8774410518865161d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5535910415032856d, y: 0.9141752553616319d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8075322890961057d, y: 0.6317527610074042d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7132455025788297d, y: 0.3353571489904874d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.11750450139767876d, y: 0.14706954894907365d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.035535850663596436d, y: 0.9373003409382488d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4302548518883774d, y: 0.14179211105305511d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.45662609062911774d, y: 0.8940759169771001d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6079434488104797d, y: 0.2242931406580012d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.17152569460634315d, y: 0.8337920100473579d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2900555999792591d, y: 0.9519478326336336d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7661910732760304d, y: 0.622008122496019d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8193261526154367d, y: 0.0675928063324791d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8149843255791803d, y: 0.36898503175013964d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.01124755192335325d, y: 0.965206897195605d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8769472849075376d, y: 0.19950718119665634d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.0038164967217148016d, y: 0.9081012621487957d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7935948668736325d, y: 0.3999234011068181d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8718384990365584d, y: 0.6696029262241827d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4104686893142552d, y: 0.7900870839169728d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.16396257370263456d, y: 0.6075753636723735d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.04099552115378158d, y: 0.7267881699729037d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8378521115212322d, y: 0.5585013810078651d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4045434804886693d, y: 0.1497083347886078d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3672116013149077d, y: 0.9086154728291018d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8809049756375295d, y: 0.21999715865887493d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.1950908360327267d, y: 0.5498732152208442d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5335719234219122d, y: 0.42887530205402724d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8108074907246747d, y: 0.06191008229906492d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6930220228824048d, y: 0.9630446330129909d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.38850789900505633d, y: 0.36081735656205427d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.959442671720039d, y: 0.21029903485601187d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9023480237771616d, y: 0.6300888809340851d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.10342685233653448d, y: 0.513790959100771d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5024841721373446d, y: 0.18855863478116786d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9516441216586393d, y: 0.3988107117570845d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7737913424757967d, y: 0.5519658822426468d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.05098082499382384d, y: 0.29116989204263977d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5606354803907104d, y: 0.40196978582107856d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7609857016435885d, y: 0.24372887710178026d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7616343479504653d, y: 0.730861607763137d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.12359440365235086d, y: 0.5421996194250187d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6629905568738906d, y: 0.8920952269789387d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7976725778721124d, y: 0.009496457983135587d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.42144844415491123d, y: 0.34007051824653944d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7760689958410192d, y: 0.6018466031735158d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9279245327635218d, y: 0.16814489591861825d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5197529066156092d, y: 0.3328255383915453d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7873653271200262d, y: 0.14318297903644828d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8024150265781688d, y: 0.21665963296513036d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8707194015296223d, y: 0.7013027612766116d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.03163198864722305d, y: 0.9141413535998383d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.03930736073030494d, y: 0.14025321699917892d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2387754642910398d, y: 0.2178589698380453d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.3306602805167089d, y: 0.5152260343819687d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2811034216913193d, y: 0.20233692958988825d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.36469678582886433d, y: 0.17882308975336692d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.20998787286507015d, y: 0.19248937548842004d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5577180346704839d, y: 0.9677433666235006d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7143092511070123d, y: 0.5652905624766328d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8427915632945583d, y: 0.5811389199589326d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.47069348864160365d, y: 0.8409022090036623d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6176498810227115d, y: 0.22006158027809142d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.33805066341263157d, y: 0.6928743744721457d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8064956695886221d, y: 0.35232520858202654d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.16272526186056901d, y: 0.20705883607208564d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.902765732522598d, y: 0.959523625584476d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.38809153142770825d, y: 0.7091169661724319d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.07386655490450655d, y: 0.24446594654588338d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.9541979977811847d, y: 0.9322628631995864d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4783918858401718d, y: 0.7441218182358394d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7550591382399451d, y: 0.2707708141691434d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.35566166004357747d, y: 0.8774410518865161d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.5535910415032856d, y: 0.9141752553616319d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8075322890961057d, y: 0.6317527610074042d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7132455025788297d, y: 0.3353571489904874d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.11750450139767876d, y: 0.14706954894907365d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.035535850663596436d, y: 0.9373003409382488d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4302548518883774d, y: 0.14179211105305511d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.45662609062911774d, y: 0.8940759169771001d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.6079434488104797d, y: 0.2242931406580012d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.17152569460634315d, y: 0.8337920100473579d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.2900555999792591d, y: 0.9519478326336336d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7661910732760304d, y: 0.622008122496019d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8193261526154367d, y: 0.0675928063324791d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8149843255791803d, y: 0.36898503175013964d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.01124755192335325d, y: 0.965206897195605d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8769472849075376d, y: 0.19950718119665634d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.0038164967217148016d, y: 0.9081012621487957d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.7935948668736325d, y: 0.3999234011068181d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8718384990365584d, y: 0.6696029262241827d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPoint?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.4104686893142552d, y: 0.7900870839169728d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.16396257370263456d, y: 0.6075753636723735d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.04099552115378158d, y: 0.7267881699729037d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPoint)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPoint(x: 0.8378521115212322d, y: 0.5585013810078651d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
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
        public  void DynQueryImportModelInnerTest()
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
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MI)],
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
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
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
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpoint0MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointSingleTypepoint)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointSingleTypepoint)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPointpoint0MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointSingleTypepoint)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointSingleTypepoint)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
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

        [Test, Order(5)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpoint0M>(15);

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
                ((INpgsqlPointSingleTypepoint)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointSingleTypepoint)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPointpoint0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpoint0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpoint0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpoint0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpoint0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpoint0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpoint0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpoint0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpoint0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpoint0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpoint0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpoint0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpoint0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpoint0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpoint0M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPointSingleTypepoint)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPointSingleTypepoint)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPointpoint0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpoint0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpoint0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpoint0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpoint0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpoint0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpoint0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpoint0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpoint0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpoint0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpoint0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpoint0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpoint0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpoint0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpoint0M.AssertModel(models[14],_testData[14], false);
                NpgsqlPointpoint0M.AssertModel(models[15],_testData[15], false);
                NpgsqlPointpoint0M.AssertModel(models[16],_testData[16], false);
                NpgsqlPointpoint0M.AssertModel(models[17],_testData[17], false);
                NpgsqlPointpoint0M.AssertModel(models[18],_testData[18], false);
                NpgsqlPointpoint0M.AssertModel(models[19],_testData[19], false);
                NpgsqlPointpoint0M.AssertModel(models[20],_testData[20], false);
                NpgsqlPointpoint0M.AssertModel(models[21],_testData[21], false);
                NpgsqlPointpoint0M.AssertModel(models[22],_testData[22], false);
                NpgsqlPointpoint0M.AssertModel(models[23],_testData[23], false);
                NpgsqlPointpoint0M.AssertModel(models[24],_testData[24], false);
                NpgsqlPointpoint0M.AssertModel(models[25],_testData[25], false);
                NpgsqlPointpoint0M.AssertModel(models[26],_testData[26], false);
                NpgsqlPointpoint0M.AssertModel(models[27],_testData[27], false);
                NpgsqlPointpoint0M.AssertModel(models[28],_testData[28], false);
                NpgsqlPointpoint0M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(6)]
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

        [Test, Order(6)]
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
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MIWA)],
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
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointSingleTypepoint)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpoint0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpoint0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlPointSingleTypepoint)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpoint0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
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
COPY public.binary_npgsqlpointpoint0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpoint0MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointSingleTypepoint)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlPointSingleTypepoint)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpoint0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

