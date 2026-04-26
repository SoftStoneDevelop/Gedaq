

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
    internal partial interface INpgsqlLineSingleTypeline
    {
    }
    
    internal partial class NpgsqlLineSingleTypeline : INpgsqlLineSingleTypeline
    {


#region TestData

        private readonly NpgsqlLineline0M[] _testData = new NpgsqlLineline0M[]
        {
            new NpgsqlLineline0M
{
    Id = 1,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4842829485842717d, b: 0.8953693111464033d, c: 0.9433781515181855d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4127145492946579d, b: 0.032770180550661276d, c: 0.5137998504834331d),
},
            new NpgsqlLineline0M
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.49323929829604396d, b: 0.28074208391190103d, c: 0.29230691806168574d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9942723320858373d, b: 0.4521151631723588d, c: 0.7586244594601881d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.04994893028629943d, b: 0.9993938217741556d, c: 0.2427130433902448d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.18013280555760836d, b: 0.44547512992669247d, c: 0.6109493716011616d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8178323965612176d, b: 0.09190377916446757d, c: 0.9498290902361659d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8801752076307242d, b: 0.3694824406741163d, c: 0.3547478179169685d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6269163889406784d, b: 0.3894451072573375d, c: 0.09795518754229626d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6535721124419235d, b: 0.24009593748579972d, c: 0.21376980786163624d),
},
            new NpgsqlLineline0M
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7564473140254979d, b: 0.4406653662369203d, c: 0.616745468307715d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.20057667220015762d, b: 0.89889624369858d, c: 0.08795019319418251d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9401083641125438d, b: 0.4962825112452004d, c: 0.3683775648679233d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.08492438930020807d, b: 0.9588115341245153d, c: 0.43184376477255215d),
},
            new NpgsqlLineline0M
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.10180879832964651d, b: 0.07666586372927309d, c: 0.03269433485858697d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.660353835720775d, b: 0.40096451598364136d, c: 0.7260556037439192d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5672883669808558d, b: 0.656862677728309d, c: 0.01973716210054799d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.16848840587601255d, b: 0.6080698680286093d, c: 0.45477414746301104d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5714208295777417d, b: 0.6419576327798119d, c: 0.5406975028498009d),
},
            new NpgsqlLineline0M
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8338685208242546d, b: 0.6747714586263606d, c: 0.8156928999826497d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7095089058430214d, b: 0.8198150769912913d, c: 0.4746600500616598d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8557013119271912d, b: 0.1838381517137334d, c: 0.6133702089545645d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.45744933469761084d, b: 0.42800184942525765d, c: 0.9769512225623324d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.23501724129941748d, b: 0.5692003878851758d, c: 0.36962147792695843d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5019681922373376d, b: 0.8659113851642913d, c: 0.3481359400899112d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.1849943738479527d, b: 0.6241834611904108d, c: 0.2132551614504089d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7398210428206926d, b: 0.5658400708226998d, c: 0.831753672375453d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7808275441952826d, b: 0.2588805724131319d, c: 0.7311773231682511d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7163332089160006d, b: 0.173588013924443d, c: 0.24429214423545798d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5292504794276809d, b: 0.3052005847646444d, c: 0.5350875051212352d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.041765567298886475d, b: 0.1565758270148253d, c: 0.7667191935449603d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6524201356041581d, b: 0.16140644708765928d, c: 0.07392853761622908d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.24273621175410254d, b: 0.9380453017690553d, c: 0.49994975376998796d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4372123342704569d, b: 0.9321694402028533d, c: 0.5739414371967088d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.17503762984644933d, b: 0.08182070574215139d, c: 0.2611607545410968d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6490702365357535d, b: 0.6686859469945461d, c: 0.39243486659190063d),
},
            new NpgsqlLineline0M
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.027658274439426478d, b: 0.3233523045742418d, c: 0.8286327061286809d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6226077789282137d, b: 0.4636494975935955d, c: 0.1867071699080558d),
},
            new NpgsqlLineline0M
{
    Id = 86,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.12506340160623475d, b: 0.41433444116312745d, c: 0.9755667942640763d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6854815467783468d, b: 0.629919516799163d, c: 0.909534072256068d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5075870986604636d, b: 0.45988167742988106d, c: 0.6077782600819462d),
},
            new NpgsqlLineline0M
{
    Id = 91,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8090529930287873d, b: 0.21125491686904974d, c: 0.8007945150134169d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2842211771175438d, b: 0.03794618135860306d, c: 0.30165178416109095d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9691498608079462d, b: 0.6349845708504538d, c: 0.2562807054411532d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 101,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4444114549918974d, b: 0.6161011594080249d, c: 0.26127287400556687d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8287081002178998d, b: 0.8946071599737384d, c: 0.23730667084903723d),
},
            new NpgsqlLineline0M
{
    Id = 107,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8834008929053874d, b: 0.38076945394037376d, c: 0.634127291383532d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.36379963756799805d, b: 0.06322112066919827d, c: 0.4941806604926696d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.992177331946037d, b: 0.020411815915958753d, c: 0.7364959232280712d),
},
            new NpgsqlLineline0M
{
    Id = 113,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.45193885372146214d, b: 0.5597834394096748d, c: 0.08492256892741257d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9291485952790639d, b: 0.4293313729032947d, c: 0.6388444479503383d),
},
            new NpgsqlLineline0M
{
    Id = 115,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3339935712251979d, b: 0.3685408315395906d, c: 0.11062781664492305d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4512284334834892d, b: 0.3305260367473475d, c: 0.17979112545290432d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6545097327709687d, b: 0.38362595078817496d, c: 0.90246020665563d),
},
            new NpgsqlLineline0M
{
    Id = 123,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.00574945953581707d, b: 0.6036764161166833d, c: 0.5066164219035552d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4377512842588863d, b: 0.1859198166246091d, c: 0.4046671347459583d),
},
            new NpgsqlLineline0M
{
    Id = 126,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.19664318991774987d, b: 0.558992889948787d, c: 0.011242702712127683d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4434497759566308d, b: 0.8910371166121313d, c: 0.9819880797423862d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8809351730394094d, b: 0.623188013212462d, c: 0.5938540844590825d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 137,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8304804037840513d, b: 0.5430587678011547d, c: 0.06513242653765361d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7742932976419167d, b: 0.45726396131737035d, c: 0.42925783405927287d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.08184836291736308d, b: 0.4940279824560182d, c: 0.7806152293188438d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7516887676397712d, b: 0.4997265651192482d, c: 0.875903480093265d),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0mi(
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0mi(
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
            queryMapTypes: [typeof(NpgsqlLineline0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(10))]
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

                changedRows =  ((INpgsqlLineSingleTypeline)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineSingleTypeline)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineSingleTypeline)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineSingleTypeline)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineSingleTypeline)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineSingleTypeline)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineSingleTypeline)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0mi(
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
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

                changedRows =  ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0m(
	id,
    value,
    nullablevalue,
    npgsqllineline0mi_id
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllineline0mi_id", 
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
                changedRows =  ((INpgsqlLineSingleTypeline)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineSingleTypeline)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineSingleTypeline)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineSingleTypeline)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0m(
	id,
    value,
    nullablevalue,
    npgsqllineline0mi_id
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
    npgsqllineline0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
                NpgsqlTypes.NpgsqlLine? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
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

                    nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.6535721124419235d, b: 0.24009593748579972d, c: 0.21376980786163624d)));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
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

                    nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.08492438930020807d, b: 0.9588115341245153d, c: 0.43184376477255215d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
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

                    nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
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

                    nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.5714208295777417d, b: 0.6419576327798119d, c: 0.5406975028498009d)));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0m(
	id,
    value,
    nullablevalue,
    npgsqllineline0mi_id
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
    npgsqllineline0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllineline0mi_id", 
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
                NpgsqlTypes.NpgsqlLine? nullable = null;
                nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine? nullable = null;
                nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLineline0M> models = null;

                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLineline0M> models = null;

                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0m(
	id,
    value,
    nullablevalue,
    npgsqllineline0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqllineline0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlLine), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqllineline0mi_id", 
                methodParametrName: "npgsqllineline0mi_id", 
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

                changedRows =  ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((INpgsqlLineSingleTypeline)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlLineSingleTypeline)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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

                var models = await ((INpgsqlLineSingleTypeline)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((INpgsqlLineSingleTypeline)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineSingleTypeline)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlLineSingleTypeline)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
                var models = await ((INpgsqlLineSingleTypeline)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineSingleTypeline)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatNpgsqlLineline0M.AssertModel(models[0],_testData[4], false);FlatNpgsqlLineline0M.AssertModel(models[1],_testData[5], false);FlatNpgsqlLineline0M.AssertModel(models[2],_testData[6], false);FlatNpgsqlLineline0M.AssertModel(models[3],_testData[7], false);FlatNpgsqlLineline0M.AssertModel(models[4],_testData[8], false);FlatNpgsqlLineline0M.AssertModel(models[5],_testData[9], false);FlatNpgsqlLineline0M.AssertModel(models[6],_testData[10], false);FlatNpgsqlLineline0M.AssertModel(models[7],_testData[11], false);FlatNpgsqlLineline0M.AssertModel(models[8],_testData[12], false);FlatNpgsqlLineline0M.AssertModel(models[9],_testData[13], false);FlatNpgsqlLineline0M.AssertModel(models[10],_testData[14], false);FlatNpgsqlLineline0M.AssertModel(models[11],_testData[15], false);FlatNpgsqlLineline0M.AssertModel(models[12],_testData[16], false);FlatNpgsqlLineline0M.AssertModel(models[13],_testData[17], false);FlatNpgsqlLineline0M.AssertModel(models[14],_testData[18], false);FlatNpgsqlLineline0M.AssertModel(models[15],_testData[19], false);FlatNpgsqlLineline0M.AssertModel(models[16],_testData[20], false);FlatNpgsqlLineline0M.AssertModel(models[17],_testData[21], false);FlatNpgsqlLineline0M.AssertModel(models[18],_testData[22], false);FlatNpgsqlLineline0M.AssertModel(models[19],_testData[23], false);FlatNpgsqlLineline0M.AssertModel(models[20],_testData[24], false);FlatNpgsqlLineline0M.AssertModel(models[21],_testData[25], false);FlatNpgsqlLineline0M.AssertModel(models[22],_testData[26], false);FlatNpgsqlLineline0M.AssertModel(models[23],_testData[27], false);FlatNpgsqlLineline0M.AssertModel(models[24],_testData[28], false);FlatNpgsqlLineline0M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatNpgsqlLineline0M.AssertModel(models[0],_testData[9], false);FlatNpgsqlLineline0M.AssertModel(models[1],_testData[10], false);FlatNpgsqlLineline0M.AssertModel(models[2],_testData[11], false);FlatNpgsqlLineline0M.AssertModel(models[3],_testData[12], false);FlatNpgsqlLineline0M.AssertModel(models[4],_testData[13], false);FlatNpgsqlLineline0M.AssertModel(models[5],_testData[14], false);FlatNpgsqlLineline0M.AssertModel(models[6],_testData[15], false);FlatNpgsqlLineline0M.AssertModel(models[7],_testData[16], false);FlatNpgsqlLineline0M.AssertModel(models[8],_testData[17], false);FlatNpgsqlLineline0M.AssertModel(models[9],_testData[18], false);FlatNpgsqlLineline0M.AssertModel(models[10],_testData[19], false);FlatNpgsqlLineline0M.AssertModel(models[11],_testData[20], false);FlatNpgsqlLineline0M.AssertModel(models[12],_testData[21], false);FlatNpgsqlLineline0M.AssertModel(models[13],_testData[22], false);FlatNpgsqlLineline0M.AssertModel(models[14],_testData[23], false);FlatNpgsqlLineline0M.AssertModel(models[15],_testData[24], false);FlatNpgsqlLineline0M.AssertModel(models[16],_testData[25], false);FlatNpgsqlLineline0M.AssertModel(models[17],_testData[26], false);FlatNpgsqlLineline0M.AssertModel(models[18],_testData[27], false);FlatNpgsqlLineline0M.AssertModel(models[19],_testData[28], false);FlatNpgsqlLineline0M.AssertModel(models[20],_testData[29], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatNpgsqlLineline0M.AssertModel(models[0],_testData[12], false);FlatNpgsqlLineline0M.AssertModel(models[1],_testData[13], false);FlatNpgsqlLineline0M.AssertModel(models[2],_testData[14], false);FlatNpgsqlLineline0M.AssertModel(models[3],_testData[15], false);FlatNpgsqlLineline0M.AssertModel(models[4],_testData[16], false);FlatNpgsqlLineline0M.AssertModel(models[5],_testData[17], false);FlatNpgsqlLineline0M.AssertModel(models[6],_testData[18], false);FlatNpgsqlLineline0M.AssertModel(models[7],_testData[19], false);FlatNpgsqlLineline0M.AssertModel(models[8],_testData[20], false);FlatNpgsqlLineline0M.AssertModel(models[9],_testData[21], false);FlatNpgsqlLineline0M.AssertModel(models[10],_testData[22], false);FlatNpgsqlLineline0M.AssertModel(models[11],_testData[23], false);FlatNpgsqlLineline0M.AssertModel(models[12],_testData[24], false);FlatNpgsqlLineline0M.AssertModel(models[13],_testData[25], false);FlatNpgsqlLineline0M.AssertModel(models[14],_testData[26], false);FlatNpgsqlLineline0M.AssertModel(models[15],_testData[27], false);FlatNpgsqlLineline0M.AssertModel(models[16],_testData[28], false);FlatNpgsqlLineline0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatNpgsqlLineline0M.AssertModel(models[0],_testData[2], false);FlatNpgsqlLineline0M.AssertModel(models[1],_testData[3], false);FlatNpgsqlLineline0M.AssertModel(models[2],_testData[4], false);FlatNpgsqlLineline0M.AssertModel(models[3],_testData[5], false);FlatNpgsqlLineline0M.AssertModel(models[4],_testData[6], false);FlatNpgsqlLineline0M.AssertModel(models[5],_testData[7], false);FlatNpgsqlLineline0M.AssertModel(models[6],_testData[8], false);FlatNpgsqlLineline0M.AssertModel(models[7],_testData[9], false);FlatNpgsqlLineline0M.AssertModel(models[8],_testData[10], false);FlatNpgsqlLineline0M.AssertModel(models[9],_testData[11], false);FlatNpgsqlLineline0M.AssertModel(models[10],_testData[12], false);FlatNpgsqlLineline0M.AssertModel(models[11],_testData[13], false);FlatNpgsqlLineline0M.AssertModel(models[12],_testData[14], false);FlatNpgsqlLineline0M.AssertModel(models[13],_testData[15], false);FlatNpgsqlLineline0M.AssertModel(models[14],_testData[16], false);FlatNpgsqlLineline0M.AssertModel(models[15],_testData[17], false);FlatNpgsqlLineline0M.AssertModel(models[16],_testData[18], false);FlatNpgsqlLineline0M.AssertModel(models[17],_testData[19], false);FlatNpgsqlLineline0M.AssertModel(models[18],_testData[20], false);FlatNpgsqlLineline0M.AssertModel(models[19],_testData[21], false);FlatNpgsqlLineline0M.AssertModel(models[20],_testData[22], false);FlatNpgsqlLineline0M.AssertModel(models[21],_testData[23], false);FlatNpgsqlLineline0M.AssertModel(models[22],_testData[24], false);FlatNpgsqlLineline0M.AssertModel(models[23],_testData[25], false);FlatNpgsqlLineline0M.AssertModel(models[24],_testData[26], false);FlatNpgsqlLineline0M.AssertModel(models[25],_testData[27], false);FlatNpgsqlLineline0M.AssertModel(models[26],_testData[28], false);FlatNpgsqlLineline0M.AssertModel(models[27],_testData[29], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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

                var models = await ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
NpgsqlLineline0M.AssertModel(models[0],_testData[5], false);NpgsqlLineline0M.AssertModel(models[1],_testData[6], false);NpgsqlLineline0M.AssertModel(models[2],_testData[7], false);NpgsqlLineline0M.AssertModel(models[3],_testData[8], false);NpgsqlLineline0M.AssertModel(models[4],_testData[9], false);NpgsqlLineline0M.AssertModel(models[5],_testData[10], false);NpgsqlLineline0M.AssertModel(models[6],_testData[11], false);NpgsqlLineline0M.AssertModel(models[7],_testData[12], false);NpgsqlLineline0M.AssertModel(models[8],_testData[13], false);NpgsqlLineline0M.AssertModel(models[9],_testData[14], false);NpgsqlLineline0M.AssertModel(models[10],_testData[15], false);NpgsqlLineline0M.AssertModel(models[11],_testData[16], false);NpgsqlLineline0M.AssertModel(models[12],_testData[17], false);NpgsqlLineline0M.AssertModel(models[13],_testData[18], false);NpgsqlLineline0M.AssertModel(models[14],_testData[19], false);NpgsqlLineline0M.AssertModel(models[15],_testData[20], false);NpgsqlLineline0M.AssertModel(models[16],_testData[21], false);NpgsqlLineline0M.AssertModel(models[17],_testData[22], false);NpgsqlLineline0M.AssertModel(models[18],_testData[23], false);NpgsqlLineline0M.AssertModel(models[19],_testData[24], false);NpgsqlLineline0M.AssertModel(models[20],_testData[25], false);NpgsqlLineline0M.AssertModel(models[21],_testData[26], false);NpgsqlLineline0M.AssertModel(models[22],_testData[27], false);NpgsqlLineline0M.AssertModel(models[23],_testData[28], false);NpgsqlLineline0M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
NpgsqlLineline0M.AssertModel(models[0],_testData[12], false);NpgsqlLineline0M.AssertModel(models[1],_testData[13], false);NpgsqlLineline0M.AssertModel(models[2],_testData[14], false);NpgsqlLineline0M.AssertModel(models[3],_testData[15], false);NpgsqlLineline0M.AssertModel(models[4],_testData[16], false);NpgsqlLineline0M.AssertModel(models[5],_testData[17], false);NpgsqlLineline0M.AssertModel(models[6],_testData[18], false);NpgsqlLineline0M.AssertModel(models[7],_testData[19], false);NpgsqlLineline0M.AssertModel(models[8],_testData[20], false);NpgsqlLineline0M.AssertModel(models[9],_testData[21], false);NpgsqlLineline0M.AssertModel(models[10],_testData[22], false);NpgsqlLineline0M.AssertModel(models[11],_testData[23], false);NpgsqlLineline0M.AssertModel(models[12],_testData[24], false);NpgsqlLineline0M.AssertModel(models[13],_testData[25], false);NpgsqlLineline0M.AssertModel(models[14],_testData[26], false);NpgsqlLineline0M.AssertModel(models[15],_testData[27], false);NpgsqlLineline0M.AssertModel(models[16],_testData[28], false);NpgsqlLineline0M.AssertModel(models[17],_testData[29], false);
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

                var models =  ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
NpgsqlLineline0M.AssertModel(models[0],_testData[9], false);NpgsqlLineline0M.AssertModel(models[1],_testData[10], false);NpgsqlLineline0M.AssertModel(models[2],_testData[11], false);NpgsqlLineline0M.AssertModel(models[3],_testData[12], false);NpgsqlLineline0M.AssertModel(models[4],_testData[13], false);NpgsqlLineline0M.AssertModel(models[5],_testData[14], false);NpgsqlLineline0M.AssertModel(models[6],_testData[15], false);NpgsqlLineline0M.AssertModel(models[7],_testData[16], false);NpgsqlLineline0M.AssertModel(models[8],_testData[17], false);NpgsqlLineline0M.AssertModel(models[9],_testData[18], false);NpgsqlLineline0M.AssertModel(models[10],_testData[19], false);NpgsqlLineline0M.AssertModel(models[11],_testData[20], false);NpgsqlLineline0M.AssertModel(models[12],_testData[21], false);NpgsqlLineline0M.AssertModel(models[13],_testData[22], false);NpgsqlLineline0M.AssertModel(models[14],_testData[23], false);NpgsqlLineline0M.AssertModel(models[15],_testData[24], false);NpgsqlLineline0M.AssertModel(models[16],_testData[25], false);NpgsqlLineline0M.AssertModel(models[17],_testData[26], false);NpgsqlLineline0M.AssertModel(models[18],_testData[27], false);NpgsqlLineline0M.AssertModel(models[19],_testData[28], false);NpgsqlLineline0M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
NpgsqlLineline0M.AssertModel(models[0],_testData[9], false);NpgsqlLineline0M.AssertModel(models[1],_testData[10], false);NpgsqlLineline0M.AssertModel(models[2],_testData[11], false);NpgsqlLineline0M.AssertModel(models[3],_testData[12], false);NpgsqlLineline0M.AssertModel(models[4],_testData[13], false);NpgsqlLineline0M.AssertModel(models[5],_testData[14], false);NpgsqlLineline0M.AssertModel(models[6],_testData[15], false);NpgsqlLineline0M.AssertModel(models[7],_testData[16], false);NpgsqlLineline0M.AssertModel(models[8],_testData[17], false);NpgsqlLineline0M.AssertModel(models[9],_testData[18], false);NpgsqlLineline0M.AssertModel(models[10],_testData[19], false);NpgsqlLineline0M.AssertModel(models[11],_testData[20], false);NpgsqlLineline0M.AssertModel(models[12],_testData[21], false);NpgsqlLineline0M.AssertModel(models[13],_testData[22], false);NpgsqlLineline0M.AssertModel(models[14],_testData[23], false);NpgsqlLineline0M.AssertModel(models[15],_testData[24], false);NpgsqlLineline0M.AssertModel(models[16],_testData[25], false);NpgsqlLineline0M.AssertModel(models[17],_testData[26], false);NpgsqlLineline0M.AssertModel(models[18],_testData[27], false);NpgsqlLineline0M.AssertModel(models[19],_testData[28], false);NpgsqlLineline0M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 37, query1, 32, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatNpgsqlLineline0M.AssertModel(models[0],_testData[9], false);FlatNpgsqlLineline0M.AssertModel(models[1],_testData[10], false);FlatNpgsqlLineline0M.AssertModel(models[2],_testData[11], false);FlatNpgsqlLineline0M.AssertModel(models[3],_testData[12], false);FlatNpgsqlLineline0M.AssertModel(models[4],_testData[13], false);FlatNpgsqlLineline0M.AssertModel(models[5],_testData[14], false);FlatNpgsqlLineline0M.AssertModel(models[6],_testData[15], false);FlatNpgsqlLineline0M.AssertModel(models[7],_testData[16], false);FlatNpgsqlLineline0M.AssertModel(models[8],_testData[17], false);FlatNpgsqlLineline0M.AssertModel(models[9],_testData[18], false);FlatNpgsqlLineline0M.AssertModel(models[10],_testData[19], false);FlatNpgsqlLineline0M.AssertModel(models[11],_testData[20], false);FlatNpgsqlLineline0M.AssertModel(models[12],_testData[21], false);FlatNpgsqlLineline0M.AssertModel(models[13],_testData[22], false);FlatNpgsqlLineline0M.AssertModel(models[14],_testData[23], false);FlatNpgsqlLineline0M.AssertModel(models[15],_testData[24], false);FlatNpgsqlLineline0M.AssertModel(models[16],_testData[25], false);FlatNpgsqlLineline0M.AssertModel(models[17],_testData[26], false);FlatNpgsqlLineline0M.AssertModel(models[18],_testData[27], false);FlatNpgsqlLineline0M.AssertModel(models[19],_testData[28], false);FlatNpgsqlLineline0M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatNpgsqlLineline0M.AssertModel(models[0],_testData[7], false);FlatNpgsqlLineline0M.AssertModel(models[1],_testData[8], false);FlatNpgsqlLineline0M.AssertModel(models[2],_testData[9], false);FlatNpgsqlLineline0M.AssertModel(models[3],_testData[10], false);FlatNpgsqlLineline0M.AssertModel(models[4],_testData[11], false);FlatNpgsqlLineline0M.AssertModel(models[5],_testData[12], false);FlatNpgsqlLineline0M.AssertModel(models[6],_testData[13], false);FlatNpgsqlLineline0M.AssertModel(models[7],_testData[14], false);FlatNpgsqlLineline0M.AssertModel(models[8],_testData[15], false);FlatNpgsqlLineline0M.AssertModel(models[9],_testData[16], false);FlatNpgsqlLineline0M.AssertModel(models[10],_testData[17], false);FlatNpgsqlLineline0M.AssertModel(models[11],_testData[18], false);FlatNpgsqlLineline0M.AssertModel(models[12],_testData[19], false);FlatNpgsqlLineline0M.AssertModel(models[13],_testData[20], false);FlatNpgsqlLineline0M.AssertModel(models[14],_testData[21], false);FlatNpgsqlLineline0M.AssertModel(models[15],_testData[22], false);FlatNpgsqlLineline0M.AssertModel(models[16],_testData[23], false);FlatNpgsqlLineline0M.AssertModel(models[17],_testData[24], false);FlatNpgsqlLineline0M.AssertModel(models[18],_testData[25], false);FlatNpgsqlLineline0M.AssertModel(models[19],_testData[26], false);FlatNpgsqlLineline0M.AssertModel(models[20],_testData[27], false);FlatNpgsqlLineline0M.AssertModel(models[21],_testData[28], false);FlatNpgsqlLineline0M.AssertModel(models[22],_testData[29], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatch(connection, 62, query1, 62, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatNpgsqlLineline0M.AssertModel(models[0],_testData[15], false);FlatNpgsqlLineline0M.AssertModel(models[1],_testData[16], false);FlatNpgsqlLineline0M.AssertModel(models[2],_testData[17], false);FlatNpgsqlLineline0M.AssertModel(models[3],_testData[18], false);FlatNpgsqlLineline0M.AssertModel(models[4],_testData[19], false);FlatNpgsqlLineline0M.AssertModel(models[5],_testData[20], false);FlatNpgsqlLineline0M.AssertModel(models[6],_testData[21], false);FlatNpgsqlLineline0M.AssertModel(models[7],_testData[22], false);FlatNpgsqlLineline0M.AssertModel(models[8],_testData[23], false);FlatNpgsqlLineline0M.AssertModel(models[9],_testData[24], false);FlatNpgsqlLineline0M.AssertModel(models[10],_testData[25], false);FlatNpgsqlLineline0M.AssertModel(models[11],_testData[26], false);FlatNpgsqlLineline0M.AssertModel(models[12],_testData[27], false);FlatNpgsqlLineline0M.AssertModel(models[13],_testData[28], false);FlatNpgsqlLineline0M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatNpgsqlLineline0M.AssertModel(models[0],_testData[15], false);FlatNpgsqlLineline0M.AssertModel(models[1],_testData[16], false);FlatNpgsqlLineline0M.AssertModel(models[2],_testData[17], false);FlatNpgsqlLineline0M.AssertModel(models[3],_testData[18], false);FlatNpgsqlLineline0M.AssertModel(models[4],_testData[19], false);FlatNpgsqlLineline0M.AssertModel(models[5],_testData[20], false);FlatNpgsqlLineline0M.AssertModel(models[6],_testData[21], false);FlatNpgsqlLineline0M.AssertModel(models[7],_testData[22], false);FlatNpgsqlLineline0M.AssertModel(models[8],_testData[23], false);FlatNpgsqlLineline0M.AssertModel(models[9],_testData[24], false);FlatNpgsqlLineline0M.AssertModel(models[10],_testData[25], false);FlatNpgsqlLineline0M.AssertModel(models[11],_testData[26], false);FlatNpgsqlLineline0M.AssertModel(models[12],_testData[27], false);FlatNpgsqlLineline0M.AssertModel(models[13],_testData[28], false);FlatNpgsqlLineline0M.AssertModel(models[14],_testData[29], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
                var models = await ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelBatchAsync(connection, 113, 72))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
NpgsqlLineline0M.AssertModel(models[0],_testData[25], false);NpgsqlLineline0M.AssertModel(models[1],_testData[26], false);NpgsqlLineline0M.AssertModel(models[2],_testData[27], false);NpgsqlLineline0M.AssertModel(models[3],_testData[28], false);NpgsqlLineline0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
NpgsqlLineline0M.AssertModel(models[0],_testData[17], false);NpgsqlLineline0M.AssertModel(models[1],_testData[18], false);NpgsqlLineline0M.AssertModel(models[2],_testData[19], false);NpgsqlLineline0M.AssertModel(models[3],_testData[20], false);NpgsqlLineline0M.AssertModel(models[4],_testData[21], false);NpgsqlLineline0M.AssertModel(models[5],_testData[22], false);NpgsqlLineline0M.AssertModel(models[6],_testData[23], false);NpgsqlLineline0M.AssertModel(models[7],_testData[24], false);NpgsqlLineline0M.AssertModel(models[8],_testData[25], false);NpgsqlLineline0M.AssertModel(models[9],_testData[26], false);NpgsqlLineline0M.AssertModel(models[10],_testData[27], false);NpgsqlLineline0M.AssertModel(models[11],_testData[28], false);NpgsqlLineline0M.AssertModel(models[12],_testData[29], false);
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
                var models =  ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelBatch(connection, 47, 22))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
NpgsqlLineline0M.AssertModel(models[0],_testData[11], false);NpgsqlLineline0M.AssertModel(models[1],_testData[12], false);NpgsqlLineline0M.AssertModel(models[2],_testData[13], false);NpgsqlLineline0M.AssertModel(models[3],_testData[14], false);NpgsqlLineline0M.AssertModel(models[4],_testData[15], false);NpgsqlLineline0M.AssertModel(models[5],_testData[16], false);NpgsqlLineline0M.AssertModel(models[6],_testData[17], false);NpgsqlLineline0M.AssertModel(models[7],_testData[18], false);NpgsqlLineline0M.AssertModel(models[8],_testData[19], false);NpgsqlLineline0M.AssertModel(models[9],_testData[20], false);NpgsqlLineline0M.AssertModel(models[10],_testData[21], false);NpgsqlLineline0M.AssertModel(models[11],_testData[22], false);NpgsqlLineline0M.AssertModel(models[12],_testData[23], false);NpgsqlLineline0M.AssertModel(models[13],_testData[24], false);NpgsqlLineline0M.AssertModel(models[14],_testData[25], false);NpgsqlLineline0M.AssertModel(models[15],_testData[26], false);NpgsqlLineline0M.AssertModel(models[16],_testData[27], false);NpgsqlLineline0M.AssertModel(models[17],_testData[28], false);NpgsqlLineline0M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
NpgsqlLineline0M.AssertModel(models[0],_testData[4], false);NpgsqlLineline0M.AssertModel(models[1],_testData[5], false);NpgsqlLineline0M.AssertModel(models[2],_testData[6], false);NpgsqlLineline0M.AssertModel(models[3],_testData[7], false);NpgsqlLineline0M.AssertModel(models[4],_testData[8], false);NpgsqlLineline0M.AssertModel(models[5],_testData[9], false);NpgsqlLineline0M.AssertModel(models[6],_testData[10], false);NpgsqlLineline0M.AssertModel(models[7],_testData[11], false);NpgsqlLineline0M.AssertModel(models[8],_testData[12], false);NpgsqlLineline0M.AssertModel(models[9],_testData[13], false);NpgsqlLineline0M.AssertModel(models[10],_testData[14], false);NpgsqlLineline0M.AssertModel(models[11],_testData[15], false);NpgsqlLineline0M.AssertModel(models[12],_testData[16], false);NpgsqlLineline0M.AssertModel(models[13],_testData[17], false);NpgsqlLineline0M.AssertModel(models[14],_testData[18], false);NpgsqlLineline0M.AssertModel(models[15],_testData[19], false);NpgsqlLineline0M.AssertModel(models[16],_testData[20], false);NpgsqlLineline0M.AssertModel(models[17],_testData[21], false);NpgsqlLineline0M.AssertModel(models[18],_testData[22], false);NpgsqlLineline0M.AssertModel(models[19],_testData[23], false);NpgsqlLineline0M.AssertModel(models[20],_testData[24], false);NpgsqlLineline0M.AssertModel(models[21],_testData[25], false);NpgsqlLineline0M.AssertModel(models[22],_testData[26], false);NpgsqlLineline0M.AssertModel(models[23],_testData[27], false);NpgsqlLineline0M.AssertModel(models[24],_testData[28], false);NpgsqlLineline0M.AssertModel(models[25],_testData[29], false);
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
                await using var cmd = await ((INpgsqlLineSingleTypeline)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 48);
                var models = await ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
NpgsqlLineline0M.AssertModel(models[0],_testData[12], false);NpgsqlLineline0M.AssertModel(models[1],_testData[13], false);NpgsqlLineline0M.AssertModel(models[2],_testData[14], false);NpgsqlLineline0M.AssertModel(models[3],_testData[15], false);NpgsqlLineline0M.AssertModel(models[4],_testData[16], false);NpgsqlLineline0M.AssertModel(models[5],_testData[17], false);NpgsqlLineline0M.AssertModel(models[6],_testData[18], false);NpgsqlLineline0M.AssertModel(models[7],_testData[19], false);NpgsqlLineline0M.AssertModel(models[8],_testData[20], false);NpgsqlLineline0M.AssertModel(models[9],_testData[21], false);NpgsqlLineline0M.AssertModel(models[10],_testData[22], false);NpgsqlLineline0M.AssertModel(models[11],_testData[23], false);NpgsqlLineline0M.AssertModel(models[12],_testData[24], false);NpgsqlLineline0M.AssertModel(models[13],_testData[25], false);NpgsqlLineline0M.AssertModel(models[14],_testData[26], false);NpgsqlLineline0M.AssertModel(models[15],_testData[27], false);NpgsqlLineline0M.AssertModel(models[16],_testData[28], false);NpgsqlLineline0M.AssertModel(models[17],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineSingleTypeline)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 115);
                var models =  ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
NpgsqlLineline0M.AssertModel(models[0],_testData[26], false);NpgsqlLineline0M.AssertModel(models[1],_testData[27], false);NpgsqlLineline0M.AssertModel(models[2],_testData[28], false);NpgsqlLineline0M.AssertModel(models[3],_testData[29], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4842829485842717d, b: 0.8953693111464033d, c: 0.9433781515181855d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4127145492946579d, b: 0.032770180550661276d, c: 0.5137998504834331d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.49323929829604396d, b: 0.28074208391190103d, c: 0.29230691806168574d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9942723320858373d, b: 0.4521151631723588d, c: 0.7586244594601881d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.04994893028629943d, b: 0.9993938217741556d, c: 0.2427130433902448d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.18013280555760836d, b: 0.44547512992669247d, c: 0.6109493716011616d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8178323965612176d, b: 0.09190377916446757d, c: 0.9498290902361659d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8801752076307242d, b: 0.3694824406741163d, c: 0.3547478179169685d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6269163889406784d, b: 0.3894451072573375d, c: 0.09795518754229626d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6535721124419235d, b: 0.24009593748579972d, c: 0.21376980786163624d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7564473140254979d, b: 0.4406653662369203d, c: 0.616745468307715d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20057667220015762d, b: 0.89889624369858d, c: 0.08795019319418251d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9401083641125438d, b: 0.4962825112452004d, c: 0.3683775648679233d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.08492438930020807d, b: 0.9588115341245153d, c: 0.43184376477255215d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.10180879832964651d, b: 0.07666586372927309d, c: 0.03269433485858697d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.660353835720775d, b: 0.40096451598364136d, c: 0.7260556037439192d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5672883669808558d, b: 0.656862677728309d, c: 0.01973716210054799d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.16848840587601255d, b: 0.6080698680286093d, c: 0.45477414746301104d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5714208295777417d, b: 0.6419576327798119d, c: 0.5406975028498009d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8338685208242546d, b: 0.6747714586263606d, c: 0.8156928999826497d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7095089058430214d, b: 0.8198150769912913d, c: 0.4746600500616598d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8557013119271912d, b: 0.1838381517137334d, c: 0.6133702089545645d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.45744933469761084d, b: 0.42800184942525765d, c: 0.9769512225623324d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.23501724129941748d, b: 0.5692003878851758d, c: 0.36962147792695843d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5019681922373376d, b: 0.8659113851642913d, c: 0.3481359400899112d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1849943738479527d, b: 0.6241834611904108d, c: 0.2132551614504089d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7398210428206926d, b: 0.5658400708226998d, c: 0.831753672375453d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7808275441952826d, b: 0.2588805724131319d, c: 0.7311773231682511d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7163332089160006d, b: 0.173588013924443d, c: 0.24429214423545798d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5292504794276809d, b: 0.3052005847646444d, c: 0.5350875051212352d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.041765567298886475d, b: 0.1565758270148253d, c: 0.7667191935449603d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6524201356041581d, b: 0.16140644708765928d, c: 0.07392853761622908d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.24273621175410254d, b: 0.9380453017690553d, c: 0.49994975376998796d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4372123342704569d, b: 0.9321694402028533d, c: 0.5739414371967088d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.17503762984644933d, b: 0.08182070574215139d, c: 0.2611607545410968d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6490702365357535d, b: 0.6686859469945461d, c: 0.39243486659190063d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.027658274439426478d, b: 0.3233523045742418d, c: 0.8286327061286809d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6226077789282137d, b: 0.4636494975935955d, c: 0.1867071699080558d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12506340160623475d, b: 0.41433444116312745d, c: 0.9755667942640763d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6854815467783468d, b: 0.629919516799163d, c: 0.909534072256068d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5075870986604636d, b: 0.45988167742988106d, c: 0.6077782600819462d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8090529930287873d, b: 0.21125491686904974d, c: 0.8007945150134169d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2842211771175438d, b: 0.03794618135860306d, c: 0.30165178416109095d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9691498608079462d, b: 0.6349845708504538d, c: 0.2562807054411532d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4444114549918974d, b: 0.6161011594080249d, c: 0.26127287400556687d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8287081002178998d, b: 0.8946071599737384d, c: 0.23730667084903723d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8834008929053874d, b: 0.38076945394037376d, c: 0.634127291383532d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.36379963756799805d, b: 0.06322112066919827d, c: 0.4941806604926696d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.992177331946037d, b: 0.020411815915958753d, c: 0.7364959232280712d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.45193885372146214d, b: 0.5597834394096748d, c: 0.08492256892741257d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9291485952790639d, b: 0.4293313729032947d, c: 0.6388444479503383d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3339935712251979d, b: 0.3685408315395906d, c: 0.11062781664492305d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4512284334834892d, b: 0.3305260367473475d, c: 0.17979112545290432d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6545097327709687d, b: 0.38362595078817496d, c: 0.90246020665563d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.00574945953581707d, b: 0.6036764161166833d, c: 0.5066164219035552d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4377512842588863d, b: 0.1859198166246091d, c: 0.4046671347459583d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.19664318991774987d, b: 0.558992889948787d, c: 0.011242702712127683d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4434497759566308d, b: 0.8910371166121313d, c: 0.9819880797423862d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8809351730394094d, b: 0.623188013212462d, c: 0.5938540844590825d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8304804037840513d, b: 0.5430587678011547d, c: 0.06513242653765361d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7742932976419167d, b: 0.45726396131737035d, c: 0.42925783405927287d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.08184836291736308d, b: 0.4940279824560182d, c: 0.7806152293188438d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7516887676397712d, b: 0.4997265651192482d, c: 0.875903480093265d))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4842829485842717d, b: 0.8953693111464033d, c: 0.9433781515181855d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4127145492946579d, b: 0.032770180550661276d, c: 0.5137998504834331d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.49323929829604396d, b: 0.28074208391190103d, c: 0.29230691806168574d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9942723320858373d, b: 0.4521151631723588d, c: 0.7586244594601881d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.04994893028629943d, b: 0.9993938217741556d, c: 0.2427130433902448d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.18013280555760836d, b: 0.44547512992669247d, c: 0.6109493716011616d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8178323965612176d, b: 0.09190377916446757d, c: 0.9498290902361659d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8801752076307242d, b: 0.3694824406741163d, c: 0.3547478179169685d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6269163889406784d, b: 0.3894451072573375d, c: 0.09795518754229626d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6535721124419235d, b: 0.24009593748579972d, c: 0.21376980786163624d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7564473140254979d, b: 0.4406653662369203d, c: 0.616745468307715d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20057667220015762d, b: 0.89889624369858d, c: 0.08795019319418251d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9401083641125438d, b: 0.4962825112452004d, c: 0.3683775648679233d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.08492438930020807d, b: 0.9588115341245153d, c: 0.43184376477255215d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.10180879832964651d, b: 0.07666586372927309d, c: 0.03269433485858697d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.660353835720775d, b: 0.40096451598364136d, c: 0.7260556037439192d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5672883669808558d, b: 0.656862677728309d, c: 0.01973716210054799d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.16848840587601255d, b: 0.6080698680286093d, c: 0.45477414746301104d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5714208295777417d, b: 0.6419576327798119d, c: 0.5406975028498009d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8338685208242546d, b: 0.6747714586263606d, c: 0.8156928999826497d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7095089058430214d, b: 0.8198150769912913d, c: 0.4746600500616598d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8557013119271912d, b: 0.1838381517137334d, c: 0.6133702089545645d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.45744933469761084d, b: 0.42800184942525765d, c: 0.9769512225623324d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.23501724129941748d, b: 0.5692003878851758d, c: 0.36962147792695843d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5019681922373376d, b: 0.8659113851642913d, c: 0.3481359400899112d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1849943738479527d, b: 0.6241834611904108d, c: 0.2132551614504089d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7398210428206926d, b: 0.5658400708226998d, c: 0.831753672375453d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7808275441952826d, b: 0.2588805724131319d, c: 0.7311773231682511d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7163332089160006d, b: 0.173588013924443d, c: 0.24429214423545798d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5292504794276809d, b: 0.3052005847646444d, c: 0.5350875051212352d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.041765567298886475d, b: 0.1565758270148253d, c: 0.7667191935449603d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6524201356041581d, b: 0.16140644708765928d, c: 0.07392853761622908d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.24273621175410254d, b: 0.9380453017690553d, c: 0.49994975376998796d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4372123342704569d, b: 0.9321694402028533d, c: 0.5739414371967088d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.17503762984644933d, b: 0.08182070574215139d, c: 0.2611607545410968d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6490702365357535d, b: 0.6686859469945461d, c: 0.39243486659190063d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.027658274439426478d, b: 0.3233523045742418d, c: 0.8286327061286809d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6226077789282137d, b: 0.4636494975935955d, c: 0.1867071699080558d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12506340160623475d, b: 0.41433444116312745d, c: 0.9755667942640763d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6854815467783468d, b: 0.629919516799163d, c: 0.909534072256068d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5075870986604636d, b: 0.45988167742988106d, c: 0.6077782600819462d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8090529930287873d, b: 0.21125491686904974d, c: 0.8007945150134169d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2842211771175438d, b: 0.03794618135860306d, c: 0.30165178416109095d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9691498608079462d, b: 0.6349845708504538d, c: 0.2562807054411532d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4444114549918974d, b: 0.6161011594080249d, c: 0.26127287400556687d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8287081002178998d, b: 0.8946071599737384d, c: 0.23730667084903723d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8834008929053874d, b: 0.38076945394037376d, c: 0.634127291383532d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.36379963756799805d, b: 0.06322112066919827d, c: 0.4941806604926696d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.992177331946037d, b: 0.020411815915958753d, c: 0.7364959232280712d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.45193885372146214d, b: 0.5597834394096748d, c: 0.08492256892741257d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9291485952790639d, b: 0.4293313729032947d, c: 0.6388444479503383d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3339935712251979d, b: 0.3685408315395906d, c: 0.11062781664492305d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4512284334834892d, b: 0.3305260367473475d, c: 0.17979112545290432d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6545097327709687d, b: 0.38362595078817496d, c: 0.90246020665563d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.00574945953581707d, b: 0.6036764161166833d, c: 0.5066164219035552d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4377512842588863d, b: 0.1859198166246091d, c: 0.4046671347459583d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.19664318991774987d, b: 0.558992889948787d, c: 0.011242702712127683d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4434497759566308d, b: 0.8910371166121313d, c: 0.9819880797423862d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8809351730394094d, b: 0.623188013212462d, c: 0.5938540844590825d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8304804037840513d, b: 0.5430587678011547d, c: 0.06513242653765361d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7742932976419167d, b: 0.45726396131737035d, c: 0.42925783405927287d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.08184836291736308d, b: 0.4940279824560182d, c: 0.7806152293188438d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7516887676397712d, b: 0.4997265651192482d, c: 0.875903480093265d))));

            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllineline0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
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
FROM public.binary_npgsqllineline0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLineline0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlLineSingleTypeline)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineSingleTypeline)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlLineSingleTypeline)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlLineSingleTypeline)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllineline0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllineline0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
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
FROM public.binary_npgsqllineline0m m
LEFT JOIN public.binary_npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLineline0M>(15);

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
                ((INpgsqlLineSingleTypeline)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineSingleTypeline)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlLineline0M.AssertModel(models[0],_testData[0], false);
                NpgsqlLineline0M.AssertModel(models[1],_testData[1], false);
                NpgsqlLineline0M.AssertModel(models[2],_testData[2], false);
                NpgsqlLineline0M.AssertModel(models[3],_testData[3], false);
                NpgsqlLineline0M.AssertModel(models[4],_testData[4], false);
                NpgsqlLineline0M.AssertModel(models[5],_testData[5], false);
                NpgsqlLineline0M.AssertModel(models[6],_testData[6], false);
                NpgsqlLineline0M.AssertModel(models[7],_testData[7], false);
                NpgsqlLineline0M.AssertModel(models[8],_testData[8], false);
                NpgsqlLineline0M.AssertModel(models[9],_testData[9], false);
                NpgsqlLineline0M.AssertModel(models[10],_testData[10], false);
                NpgsqlLineline0M.AssertModel(models[11],_testData[11], false);
                NpgsqlLineline0M.AssertModel(models[12],_testData[12], false);
                NpgsqlLineline0M.AssertModel(models[13],_testData[13], false);
                NpgsqlLineline0M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlLineSingleTypeline)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlLineSingleTypeline)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlLineline0M.AssertModel(models[0],_testData[0], false);
                NpgsqlLineline0M.AssertModel(models[1],_testData[1], false);
                NpgsqlLineline0M.AssertModel(models[2],_testData[2], false);
                NpgsqlLineline0M.AssertModel(models[3],_testData[3], false);
                NpgsqlLineline0M.AssertModel(models[4],_testData[4], false);
                NpgsqlLineline0M.AssertModel(models[5],_testData[5], false);
                NpgsqlLineline0M.AssertModel(models[6],_testData[6], false);
                NpgsqlLineline0M.AssertModel(models[7],_testData[7], false);
                NpgsqlLineline0M.AssertModel(models[8],_testData[8], false);
                NpgsqlLineline0M.AssertModel(models[9],_testData[9], false);
                NpgsqlLineline0M.AssertModel(models[10],_testData[10], false);
                NpgsqlLineline0M.AssertModel(models[11],_testData[11], false);
                NpgsqlLineline0M.AssertModel(models[12],_testData[12], false);
                NpgsqlLineline0M.AssertModel(models[13],_testData[13], false);
                NpgsqlLineline0M.AssertModel(models[14],_testData[14], false);
                NpgsqlLineline0M.AssertModel(models[15],_testData[15], false);
                NpgsqlLineline0M.AssertModel(models[16],_testData[16], false);
                NpgsqlLineline0M.AssertModel(models[17],_testData[17], false);
                NpgsqlLineline0M.AssertModel(models[18],_testData[18], false);
                NpgsqlLineline0M.AssertModel(models[19],_testData[19], false);
                NpgsqlLineline0M.AssertModel(models[20],_testData[20], false);
                NpgsqlLineline0M.AssertModel(models[21],_testData[21], false);
                NpgsqlLineline0M.AssertModel(models[22],_testData[22], false);
                NpgsqlLineline0M.AssertModel(models[23],_testData[23], false);
                NpgsqlLineline0M.AssertModel(models[24],_testData[24], false);
                NpgsqlLineline0M.AssertModel(models[25],_testData[25], false);
                NpgsqlLineline0M.AssertModel(models[26],_testData[26], false);
                NpgsqlLineline0M.AssertModel(models[27],_testData[27], false);
                NpgsqlLineline0M.AssertModel(models[28],_testData[28], false);
                NpgsqlLineline0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllineline0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllineline0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineSingleTypeline)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLineline0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineSingleTypeline)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLineline0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllineline0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineSingleTypeline)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineSingleTypeline)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

